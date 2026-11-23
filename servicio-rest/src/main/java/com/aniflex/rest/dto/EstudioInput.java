package com.aniflex.rest.dto;

import java.time.LocalDate;
import java.util.List;

public record EstudioInput(String codigo, String nombre, String paisOrigen,
                           LocalDate fechaFundacion, List<String> seriesIds) { }
