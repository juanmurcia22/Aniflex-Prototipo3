package com.mycompany.aniflexproyecto2.config;

import com.mongodb.client.model.IndexOptions;
import org.bson.Document;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.boot.CommandLineRunner;
import org.springframework.core.annotation.Order;
import org.springframework.data.mongodb.core.MongoTemplate;
import org.springframework.stereotype.Component;
import java.util.Locale;
import static com.mongodb.client.model.Filters.eq;
import static com.mongodb.client.model.Filters.and;
import static com.mongodb.client.model.Indexes.ascending;
import static com.mongodb.client.model.Updates.set;

/** Completa solo los IDs manuales ausentes en documentos anteriores. Conserva sus ObjectId. */
@Component
@Order(-100)
public class PrepararIdentificadores implements CommandLineRunner {
    private final MongoTemplate mongo;
    private final boolean activo;
    public PrepararIdentificadores(MongoTemplate mongo,
            @Value("${aniflex.migrar-ids:true}") boolean activo) {
        this.mongo = mongo;
        this.activo = activo;
    }
    @Override
    public void run(String... args) {
        if (!activo) return;
        preparar("series", "SER-");
        preparar("episodios", "EPI-");
    }
    private void preparar(String coleccion, String prefijo) {
        var documentos = mongo.getCollection(coleccion);
        for (Document doc : documentos.find()) {
            if (doc.getString("id") == null || doc.getString("id").isBlank()) {
                String manual = prefijo + doc.get("_id").toString().toUpperCase(Locale.ROOT);
                documentos.updateOne(and(eq("_id", doc.get("_id")), eq("id", doc.get("id"))), set("id", manual));
            }
        }
        documentos.createIndex(ascending("id"), new IndexOptions().unique(true).name("id_manual_unico"));
    }
}
