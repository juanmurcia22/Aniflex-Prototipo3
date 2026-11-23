package com.aniflex.rest.exception;

import com.mongodb.MongoException;
import com.mongodb.MongoWriteException;
import com.mongodb.ErrorCategory;
import org.springframework.http.HttpStatus;
import org.springframework.http.ProblemDetail;
import org.springframework.http.converter.HttpMessageNotReadableException;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.bind.annotation.RestControllerAdvice;
import java.util.NoSuchElementException;

@RestControllerAdvice
public class ManejadorErroresRest {
    @ExceptionHandler(IllegalArgumentException.class)
    public ProblemDetail datosInvalidos(IllegalArgumentException ex) {
        return ProblemDetail.forStatusAndDetail(HttpStatus.BAD_REQUEST, ex.getMessage());
    }

    @ExceptionHandler(HttpMessageNotReadableException.class)
    public ProblemDetail formatoInvalido() {
        return ProblemDetail.forStatusAndDetail(HttpStatus.BAD_REQUEST,
                "El cuerpo JSON o la fecha de fundación no tienen un formato válido (yyyy-MM-dd).");
    }

    @ExceptionHandler(NoSuchElementException.class)
    public ProblemDetail noEncontrado(NoSuchElementException ex) {
        return ProblemDetail.forStatusAndDetail(HttpStatus.NOT_FOUND, ex.getMessage());
    }

    @ExceptionHandler(MongoWriteException.class)
    public ProblemDetail errorEscritura(MongoWriteException ex) {
        if (ex.getError().getCategory() == ErrorCategory.DUPLICATE_KEY && ex.getMessage().contains("serie_estudio_unico"))
            return ProblemDetail.forStatusAndDetail(HttpStatus.CONFLICT, "Una de las series ya pertenece a otro estudio.");
        if (ex.getError().getCategory() == ErrorCategory.DUPLICATE_KEY)
            return ProblemDetail.forStatusAndDetail(HttpStatus.CONFLICT, "Ya existe un estudio con ese código.");
        return errorMongo();
    }

    @ExceptionHandler(MongoException.class)
    public ProblemDetail errorMongo() {
        return ProblemDetail.forStatusAndDetail(HttpStatus.SERVICE_UNAVAILABLE,
                "No se pudo acceder a MongoDB local.");
    }
}
