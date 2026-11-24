package com.aniflex.rest.integracion;

import com.aniflex.rest.dto.SerieReferencia;
import org.bson.types.ObjectId;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.http.client.JdkClientHttpRequestFactory;
import org.springframework.stereotype.Component;
import org.springframework.web.client.RestClient;
import org.springframework.web.client.RestClientException;
import java.net.http.HttpClient;
import java.time.Duration;
import java.util.List;
import java.util.Map;

/** REST conoce el catálogo exclusivamente por HTTP; nunca abre Aniflex_AB. */
@Component
public class CatalogoGraphQL {
    private final RestClient cliente;
    private final String clave;

    public CatalogoGraphQL(@Value("${aniflex.graphql.url:http://localhost:8080}") String url,
                          @Value("${aniflex.integracion.clave}") String clave) {
        var http = HttpClient.newBuilder().connectTimeout(Duration.ofSeconds(3)).build();
        var factory = new JdkClientHttpRequestFactory(http);
        factory.setReadTimeout(Duration.ofSeconds(8));
        cliente = RestClient.builder().baseUrl(url).requestFactory(factory).build();
        this.clave = clave;
    }

    public List<SerieReferencia> consultarSeries(List<ObjectId> ids) {
        if (ids.isEmpty()) return List.of();
        String query = "query($ids: [ID!]!) { seriesPorIds(ids: $ids) { id codigo titulo temporadas calificacion fechaEstreno enEmision } }";
        try {
            var respuesta = cliente.post().uri("/graphql").body(Map.of("query", query,
                    "variables", Map.of("ids", ids.stream().map(ObjectId::toHexString).toList())))
                    .retrieve().body(Respuesta.class);
            if (respuesta == null || respuesta.data() == null ||
                    (respuesta.errors() != null && !respuesta.errors().isEmpty()))
                throw new IllegalStateException("GraphQL no pudo consultar las series referenciadas.");
            return respuesta.data().seriesPorIds();
        } catch (RestClientException ex) {
            throw new IllegalStateException("No se pudo consultar el catálogo de GraphQL por HTTP.", ex);
        }
    }

    // La llamada ocurre dentro del monitor de ServicioEstudio: asociación y baja no se intercalan.
    public boolean eliminarSerie(ObjectId id) {
        try {
            return Boolean.TRUE.equals(cliente.delete().uri("/interno/catalogo/series/{id}", id.toHexString())
                    .header("X-Aniflex-Interno", clave).retrieve().body(Boolean.class));
        } catch (RestClientException ex) {
            throw new IllegalStateException("GraphQL no pudo completar la baja de la serie y sus episodios.", ex);
        }
    }

    private record Datos(List<SerieReferencia> seriesPorIds) { }
    private record ErrorGraphQL(String message) { }
    private record Respuesta(Datos data, List<ErrorGraphQL> errors) { }
}
