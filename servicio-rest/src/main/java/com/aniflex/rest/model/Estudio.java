package com.aniflex.rest.model;

import org.bson.types.ObjectId;
import java.time.LocalDate;
import java.util.List;

public record Estudio(ObjectId id, String codigo, String nombre, String paisOrigen,
                      LocalDate fechaFundacion, List<ObjectId> seriesIds) {
    public Estudio {
        seriesIds = List.copyOf(seriesIds);
    }
}
