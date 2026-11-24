package com.aniflex.rest.service;

import com.aniflex.rest.dto.EstudioInput;
import com.aniflex.rest.dto.EstudioRespuesta;
import com.aniflex.rest.model.Estudio;
import com.aniflex.rest.integracion.CatalogoGraphQL;
import com.aniflex.rest.repository.EstudioRepository;
import org.bson.types.ObjectId;
import org.springframework.stereotype.Service;
import java.time.LocalDate;
import java.time.ZoneOffset;
import java.util.List;
import java.util.Locale;
import java.util.NoSuchElementException;
import java.util.Optional;

@Service
public class ServicioEstudio {
    private final EstudioRepository estudios;
    private final CatalogoGraphQL catalogo;

    public ServicioEstudio(EstudioRepository estudios, CatalogoGraphQL catalogo) {
        this.estudios = estudios;
        this.catalogo = catalogo;
    }

    public synchronized List<Estudio> listar(String codigo, String paisOrigen, String serieId) {
        String filtroCodigo = vacio(codigo) ? null : normalizarCodigo(codigo);
        String filtroPais = vacio(paisOrigen) ? null : paisOrigen.trim();
        ObjectId filtroSerie = vacio(serieId) ? null : leerId(serieId);
        var resultados = estudios.listar(filtroCodigo, filtroPais, filtroSerie);
        return resultados;
    }

    public synchronized Optional<Estudio> buscar(String codigo) {
        var resultado = estudios.buscarPorCodigo(normalizarCodigo(codigo));
        return resultado;
    }

    // Un único monitor coordina las escrituras de vínculos y las bajas en esta instancia local.
    public synchronized Estudio guardar(String id, EstudioInput input) {
        if (input == null) throw new IllegalArgumentException("Los datos del estudio son obligatorios.");
        if (vacio(input.nombre()) || vacio(input.paisOrigen()))
            throw new IllegalArgumentException("El nombre y el país de origen son obligatorios.");
        String codigo = normalizarCodigo(input.codigo());
        if (input.fechaFundacion() == null || input.fechaFundacion().isAfter(LocalDate.now(ZoneOffset.UTC)))
            throw new IllegalArgumentException("La fecha de fundación debe ser válida y no puede ser futura.");
        if (input.seriesIds() == null)
            throw new IllegalArgumentException("La lista de series es obligatoria y puede estar vacía.");
        List<ObjectId> ids = input.seriesIds().stream().map(ServicioEstudio::leerId).distinct().toList();
        if (catalogo.consultarSeries(ids).size() != ids.size())
            throw new IllegalArgumentException("Una de las series seleccionadas ya no existe. Actualiza la lista.");
        var estudio = new Estudio(id == null ? new ObjectId() : leerId(id), codigo,
                input.nombre().trim(), input.paisOrigen().trim(), input.fechaFundacion(), ids);
        if (estudios.vinculadasAOtro(estudio.id(), ids))
            throw new IllegalArgumentException("Una de las series ya pertenece a otro estudio.");
        var anterior = estudios.buscarPorId(estudio.id());
        if (id != null && anterior.isEmpty()) throw new NoSuchElementException("El estudio ya no existe.");
        if (id == null) estudios.insertar(estudio);
        else estudios.actualizar(estudio);
        return estudio;
    }

    public synchronized boolean eliminar(String id) {
        ObjectId objectId = leerId(id);
        return estudios.eliminar(objectId);
    }

    public EstudioRespuesta respuesta(Estudio estudio) {
        var referencias = catalogo.consultarSeries(estudio.seriesIds()).stream()
                .map(s -> new com.aniflex.rest.dto.SerieReferencia(s.id(), s.codigo(), s.titulo(),
                        s.temporadas(), s.calificacion(), s.fechaEstreno(), s.enEmision(), estudio.id().toHexString()))
                .toList();
        return EstudioRespuesta.desde(estudio, referencias);
    }

    public synchronized boolean eliminarSerie(String id) {
        ObjectId objectId = leerId(id);
        if (estudios.contieneSerie(objectId))
            throw new IllegalArgumentException("La serie pertenece a un estudio. Retira su asociación antes de eliminarla.");
        return catalogo.eliminarSerie(objectId);
    }

    private static ObjectId leerId(String id) {
        if (id == null || !ObjectId.isValid(id))
            throw new IllegalArgumentException("El identificador interno debe ser un ObjectId válido.");
        return new ObjectId(id);
    }

    private static boolean vacio(String texto) {
        return texto == null || texto.isBlank();
    }

    private static String normalizarCodigo(String codigo) {
        if (vacio(codigo)) throw new IllegalArgumentException("El código del estudio es obligatorio.");
        return codigo.trim().toUpperCase(Locale.ROOT);
    }
}
