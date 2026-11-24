package com.mycompany.aniflexproyecto2.integracion;

import com.mycompany.aniflexproyecto2.servicios.ServicioSerie;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;
import java.nio.charset.StandardCharsets;
import java.security.MessageDigest;

/** Endpoint de cooperación: REST valida la pertenencia antes de pedir esta baja local. */
@RestController
@RequestMapping("/interno/catalogo/series")
public class CatalogoInternoController {
    private final ServicioSerie series;
    private final String clave;
    public CatalogoInternoController(ServicioSerie series, @Value("${aniflex.integracion.clave}") String clave) {
        this.series = series;
        this.clave = clave;
    }
    @DeleteMapping("/{id}")
    public boolean eliminar(@PathVariable String id,
                           @RequestHeader(value = "X-Aniflex-Interno", defaultValue = "") String recibida) {
        if (!MessageDigest.isEqual(clave.getBytes(StandardCharsets.UTF_8), recibida.getBytes(StandardCharsets.UTF_8)))
            throw new ResponseStatusException(HttpStatus.FORBIDDEN);
        return series.eliminarDelCatalogo(id);
    }
}
