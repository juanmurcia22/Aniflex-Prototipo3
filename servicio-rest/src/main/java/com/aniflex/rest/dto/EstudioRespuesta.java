package com.aniflex.rest.dto;

import com.aniflex.rest.model.Estudio;
import java.time.LocalDate;
import java.util.List;

public record EstudioRespuesta(String id, String codigo, String nombre, String paisOrigen,
                               LocalDate fechaFundacion, List<String> seriesIds, List<SerieReferencia> series) {
    public static EstudioRespuesta desde(Estudio estudio, List<SerieReferencia> series) {
        return new EstudioRespuesta(estudio.id().toHexString(), estudio.codigo(), estudio.nombre(),
                estudio.paisOrigen(), estudio.fechaFundacion(),
                estudio.seriesIds().stream().map(id -> id.toHexString()).toList(), series);
    }
}
