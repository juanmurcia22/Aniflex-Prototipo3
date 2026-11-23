package com.aniflex.rest.controller;

import com.aniflex.rest.service.ServicioEstudio;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/api/series")
public class SerieController {
    private final ServicioEstudio servicio;

    public SerieController(ServicioEstudio servicio) {
        this.servicio = servicio;
    }

    @DeleteMapping("/{id}")
    public boolean eliminar(@PathVariable String id) {
        return servicio.eliminarSerie(id);
    }
}
