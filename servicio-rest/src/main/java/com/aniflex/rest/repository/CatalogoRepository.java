package com.aniflex.rest.repository;

import com.mongodb.client.MongoCollection;
import com.mongodb.client.MongoDatabase;
import org.bson.Document;
import org.bson.types.ObjectId;
import org.springframework.stereotype.Repository;
import java.util.List;
import java.util.ArrayList;
import com.aniflex.rest.model.Estudio;
import com.aniflex.rest.dto.SerieReferencia;
import java.time.ZoneId;
import java.time.format.DateTimeFormatter;
import static com.mongodb.client.model.Filters.and;
import static com.mongodb.client.model.Filters.nin;
import static com.mongodb.client.model.Updates.set;
import static com.mongodb.client.model.Updates.unset;
import static com.mongodb.client.model.Filters.eq;
import static com.mongodb.client.model.Filters.in;

/** Acceso mínimo al catálogo para validar vínculos y completar bajas en cascada. */
@Repository
public class CatalogoRepository {
    private final MongoCollection<Document> series;
    private final MongoCollection<Document> episodios;

    public CatalogoRepository(MongoDatabase database) {
        series = database.getCollection("series");
        episodios = database.getCollection("episodios");
    }

    public boolean existenSeries(List<ObjectId> ids) {
        return series.countDocuments(in("_id", ids)) == ids.size();
    }

    public void actualizarEstudio(ObjectId estudioId, List<ObjectId> ids) {
        series.updateMany(and(eq("estudioId", estudioId), nin("_id", ids)), unset("estudioId"));
        if (!ids.isEmpty()) series.updateMany(in("_id", ids), set("estudioId", estudioId));
    }

    public void reconstruirReferencias(List<Estudio> estudios) {
        // Repara proyecciones de una ejecución interrumpida usando las asociaciones únicas del estudio.
        List<ObjectId> propietarios = estudios.stream().map(Estudio::id).toList();
        series.updateMany(nin("estudioId", propietarios), unset("estudioId"));
        for (Estudio estudio : estudios) actualizarEstudio(estudio.id(), estudio.seriesIds());
    }

    public List<SerieReferencia> consultarSeries(List<ObjectId> ids) {
        return series.find(in("_id", ids)).map(doc -> new SerieReferencia(
                doc.getObjectId("_id").toHexString(), doc.getString("id"), doc.getString("titulo"),
                ((Number) doc.get("temporadas")).intValue(), ((Number) doc.get("calificacion")).doubleValue(),
                doc.getDate("fechaEstreno").toInstant().atZone(ZoneId.systemDefault()).toLocalDateTime()
                        .format(DateTimeFormatter.ISO_LOCAL_DATE_TIME), doc.getBoolean("enEmision", false),
                doc.getObjectId("estudioId") == null ? null : doc.getObjectId("estudioId").toHexString()))
                .into(new ArrayList<>());
    }

    public boolean eliminarSerie(ObjectId id) {
        // También limpia referencias antiguas almacenadas como texto.
        episodios.deleteMany(in("serieId", id, id.toHexString()));
        return series.deleteOne(eq("_id", id)).getDeletedCount() != 0;
    }
}
