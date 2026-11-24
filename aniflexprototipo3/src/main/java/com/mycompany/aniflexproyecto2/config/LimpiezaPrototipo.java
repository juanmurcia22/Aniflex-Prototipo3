package com.mycompany.aniflexproyecto2.config;

import com.mongodb.client.MongoClient;
import com.mongodb.client.MongoClients;
import jakarta.annotation.PreDestroy;
import org.bson.Document;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Component;
import java.util.List;

/** Sesión desechable: borra únicamente las colecciones propias del servicio. */
@Component
public class LimpiezaPrototipo {
    private static final Logger log = LoggerFactory.getLogger(LimpiezaPrototipo.class);
    private final String uri;
    private final String base;
    private final boolean habilitada;
    private boolean iniciada;

    public LimpiezaPrototipo(@Value("${aniflex.mongodb.uri}") String uri,
                            @Value("${aniflex.mongodb.database}") String base,
                            @Value("${aniflex.prototipo.limpiar:true}") boolean habilitada) {
        this.uri = uri; this.base = base; this.habilitada = habilitada;
    }

    public void iniciar(MongoClient client) {
        if (habilitada) limpiar(client);
        iniciada = true;
    }

    private void limpiar(MongoClient client) {
        var db = client.getDatabase(base);
        for (String coleccion : List.of("series", "episodios"))
            db.getCollection(coleccion).deleteMany(new Document());
        log.info("Prototipo: datos de {} eliminados; índices y colecciones conservados.", base);
    }

    @PreDestroy
    public void cerrar() {
        if (!habilitada || !iniciada) return;
        // Conexión propia: no depende del orden de destrucción del pool de Spring.
        var settings = com.mongodb.MongoClientSettings.builder()
                .applyConnectionString(new com.mongodb.ConnectionString(uri))
                .applyToClusterSettings(c -> c.serverSelectionTimeout(3, java.util.concurrent.TimeUnit.SECONDS)).build();
        try (var client = MongoClients.create(settings)) { limpiar(client); }
        catch (RuntimeException ex) {
            log.error("No se pudo limpiar {} al cerrar. El próximo arranque volverá a limpiarla.", base, ex);
        }
    }
}
