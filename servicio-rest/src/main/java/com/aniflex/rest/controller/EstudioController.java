package com.aniflex.rest.controller;

import com.aniflex.rest.dto.EstudioInput;
import com.aniflex.rest.dto.EstudioRespuesta;
import com.aniflex.rest.service.ServicioEstudio;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.util.UriComponentsBuilder;
import java.util.List;

@RestController
@RequestMapping("/api/estudios")
public class EstudioController {
    private final ServicioEstudio servicio;

    public EstudioController(ServicioEstudio servicio) {
        this.servicio = servicio;
    }

    @GetMapping({"", "/"})
    public List<EstudioRespuesta> listar(@RequestParam(required = false) String codigo,
                                        @RequestParam(required = false) String paisOrigen,
                                        @RequestParam(required = false) String serieId) {
        return servicio.listar(codigo, paisOrigen, serieId).stream().map(servicio::respuesta).toList();
    }

    @GetMapping("/por-codigo/{codigo}")
    public ResponseEntity<EstudioRespuesta> buscar(@PathVariable String codigo) {
        return ResponseEntity.of(servicio.buscar(codigo).map(servicio::respuesta));
    }

    @PostMapping({"", "/"})
    public ResponseEntity<EstudioRespuesta> adicionar(@RequestBody EstudioInput input) {
        var respuesta = servicio.respuesta(servicio.guardar(null, input));
        var location = UriComponentsBuilder.fromPath("/api/estudios/por-codigo/{codigo}")
                .buildAndExpand(respuesta.codigo()).encode().toUri();
        return ResponseEntity.created(location).body(respuesta);
    }

    @PutMapping("/{id}")
    public EstudioRespuesta actualizar(@PathVariable String id, @RequestBody EstudioInput input) {
        return servicio.respuesta(servicio.guardar(id, input));
    }

    @DeleteMapping("/{id}")
    public boolean eliminar(@PathVariable String id) {
        return servicio.eliminar(id);
    }
}
