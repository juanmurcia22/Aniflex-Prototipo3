package com.mycompany.aniflexproyecto2.controller;

import com.mycompany.aniflexproyecto2.model.Estudio;
import com.mycompany.aniflexproyecto2.model.EstudioInput;
import com.mycompany.aniflexproyecto2.model.Serie;
import com.mycompany.aniflexproyecto2.servicios.ServicioEstudioRest;
import com.mycompany.aniflexproyecto2.servicios.ServicioSerie;
import org.springframework.graphql.data.method.annotation.*;
import org.springframework.stereotype.Controller;
import java.util.List;

@Controller
public class EstudioController {
    private final ServicioEstudioRest estudios;
    private final ServicioSerie series;

    public EstudioController(ServicioEstudioRest estudios, ServicioSerie series) {
        this.estudios = estudios;
        this.series = series;
    }

    @QueryMapping
    public List<Estudio> listarEstudios(@Argument String codigo, @Argument String paisOrigen,
                                       @Argument String serieId) {
        return estudios.listar(codigo, paisOrigen, serieId);
    }

    @QueryMapping
    public Estudio buscarEstudio(@Argument String codigo) {
        if (codigo == null || codigo.isBlank()) throw new IllegalArgumentException("Indica el código del estudio.");
        return estudios.buscar(codigo);
    }

    @MutationMapping
    public Estudio adicionarEstudio(@Argument EstudioInput input) { return estudios.adicionar(input); }
    @MutationMapping
    public Estudio actualizarEstudio(@Argument EstudioInput input) { return estudios.actualizar(input); }
    @MutationMapping
    public boolean eliminarEstudio(@Argument String id) { return estudios.eliminar(id); }

    @SchemaMapping(typeName = "Estudio", field = "series")
    public List<Serie> series(Estudio estudio) {
        return estudio.seriesIds().stream().flatMap(id -> series.buscarPorId(id).stream()).toList();
    }

    @SchemaMapping(typeName = "Serie", field = "estudioId")
    public String estudioId(Serie serie) {
        return estudios.listar(null, null, serie.getId()).stream().map(Estudio::id).findFirst().orElse(null);
    }

    @SchemaMapping(typeName = "Serie", field = "estudios")
    public List<Estudio> estudios(Serie serie) { return estudios.listar(null, null, serie.getId()); }
}
