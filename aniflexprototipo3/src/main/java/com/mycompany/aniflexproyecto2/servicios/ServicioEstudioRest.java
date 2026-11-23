package com.mycompany.aniflexproyecto2.servicios;

import com.mycompany.aniflexproyecto2.model.Estudio;
import com.mycompany.aniflexproyecto2.model.EstudioInput;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.core.ParameterizedTypeReference;
import org.springframework.http.client.JdkClientHttpRequestFactory;
import org.springframework.stereotype.Service;
import org.springframework.web.client.RestClient;
import org.springframework.web.client.RestClientException;
import org.springframework.web.client.RestClientResponseException;
import java.net.http.HttpClient;
import java.time.Duration;
import java.util.List;
import java.util.Map;
import java.util.function.Supplier;

/** GraphQL delega el CRUD de estudios al servicio REST Java. */
@Service
public class ServicioEstudioRest {
    private final RestClient cliente;

    public ServicioEstudioRest(@Value("${aniflex.rest.url:http://localhost:8081}") String url) {
        var http = HttpClient.newBuilder().connectTimeout(Duration.ofSeconds(3)).build();
        var factory = new JdkClientHttpRequestFactory(http);
        factory.setReadTimeout(Duration.ofSeconds(8));
        cliente = RestClient.builder().baseUrl(url).requestFactory(factory).build();
    }

    public List<Estudio> listar(String codigo, String paisOrigen, String serieId) {
        return ejecutar(() -> cliente.get().uri(builder -> {
            builder.path("/api/estudios/");
            if (codigo != null && !codigo.isBlank()) builder.queryParam("codigo", codigo);
            if (paisOrigen != null && !paisOrigen.isBlank()) builder.queryParam("paisOrigen", paisOrigen);
            if (serieId != null && !serieId.isBlank()) builder.queryParam("serieId", serieId);
            return builder.build();
        }).retrieve().body(new ParameterizedTypeReference<List<Estudio>>() { }));
    }

    public Estudio buscar(String codigo) {
        return listar(codigo, null, null).stream().findFirst().orElse(null);
    }

    public Estudio adicionar(EstudioInput input) {
        return ejecutar(() -> cliente.post().uri("/api/estudios/")
                .body(input).retrieve().body(Estudio.class));
    }

    public Estudio actualizar(EstudioInput input) {
        if (input.id() == null || input.id().isBlank())
            throw new IllegalArgumentException("El ID interno del estudio es obligatorio al actualizar.");
        return ejecutar(() -> cliente.put().uri("/api/estudios/{id}", input.id())
                .body(input).retrieve().body(Estudio.class));
    }

    public boolean eliminar(String id) {
        return Boolean.TRUE.equals(ejecutar(() -> cliente.delete().uri("/api/estudios/{id}", id)
                .retrieve().body(Boolean.class)));
    }

    public boolean eliminarSerie(String id) {
        return Boolean.TRUE.equals(ejecutar(() -> cliente.delete().uri("/api/series/{id}", id)
                .retrieve().body(Boolean.class)));
    }

    private <T> T ejecutar(Supplier<T> operacion) {
        try { return operacion.get(); }
        catch (RestClientResponseException ex) {
            var problema = ex.getResponseBodyAs(new ParameterizedTypeReference<Map<String, Object>>() { });
            String mensaje = problema == null ? "El servicio REST rechazó la operación."
                    : String.valueOf(problema.getOrDefault("detail", "Error del servicio REST."));
            if (ex.getStatusCode().is4xxClientError()) throw new IllegalArgumentException(mensaje);
            throw new IllegalStateException(mensaje, ex);
        } catch (RestClientException ex) {
            throw new IllegalStateException("No se pudo conectar con el servicio REST de estudios (puerto 8081).", ex);
        }
    }
}
