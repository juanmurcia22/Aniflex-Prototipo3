package com.aniflex.rest.dto;

public record SerieReferencia(String id, String codigo, String titulo, int temporadas,
        double calificacion, String fechaEstreno, boolean enEmision, String estudioId) { }
