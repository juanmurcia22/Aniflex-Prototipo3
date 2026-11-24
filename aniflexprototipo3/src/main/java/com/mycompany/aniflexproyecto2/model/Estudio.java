package com.mycompany.aniflexproyecto2.model;
import java.util.List;

public record Estudio(String id, String codigo, String nombre, String paisOrigen,
                      String fechaFundacion, List<String> seriesIds) { }
