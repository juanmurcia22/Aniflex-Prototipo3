package com.mycompany.aniflexproyecto2.model;
import java.util.List;

public record EstudioInput(String id, String codigo, String nombre, String paisOrigen,
                           String fechaFundacion, List<String> seriesIds) { }
