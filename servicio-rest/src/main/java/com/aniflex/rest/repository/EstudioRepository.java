package com.aniflex.rest.repository;

import com.aniflex.rest.model.Estudio;
import com.mongodb.client.MongoCollection;
import com.mongodb.client.MongoDatabase;
import com.mongodb.client.model.IndexOptions;
import org.bson.Document;
import org.bson.conversions.Bson;
import org.bson.types.ObjectId;
import org.springframework.stereotype.Repository;
import java.time.ZoneOffset;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Optional;
import java.util.regex.Pattern;
import static com.mongodb.client.model.Filters.and;
import static com.mongodb.client.model.Filters.eq;
import static com.mongodb.client.model.Filters.regex;
import static com.mongodb.client.model.Filters.exists;
import static com.mongodb.client.model.Filters.in;
import static com.mongodb.client.model.Filters.ne;
import static com.mongodb.client.model.Updates.set;
import static com.mongodb.client.model.Updates.unset;
import static com.mongodb.client.model.Updates.combine;
import static com.mongodb.client.model.Indexes.ascending;

@Repository
public class EstudioRepository {
    private final MongoCollection<Document> estudios;

    public EstudioRepository(MongoDatabase database) {
        estudios = database.getCollection("estudios");
        boolean indiceAnterior = estudios.listIndexes().into(new ArrayList<>()).stream()
                .anyMatch(indice -> "codigo_estudio_unico".equals(indice.getString("name")));
        if (indiceAnterior) estudios.dropIndex("codigo_estudio_unico");
        for (Document doc : estudios.find()) {
            String manual = doc.getString("id");
            if (manual == null || manual.isBlank()) manual = doc.getString("Codigo");
            if (manual == null || manual.isBlank()) manual = "EST-" + doc.getObjectId("_id").toHexString();
            estudios.updateOne(eq("_id", doc.get("_id")), combine(
                    set("id", manual.trim().toUpperCase(java.util.Locale.ROOT)), unset("Codigo")));
        }
        estudios.createIndex(ascending("id"), new IndexOptions().unique(true).name("id_estudio_unico"));
        try {
            estudios.createIndex(ascending("SeriesIds"), new IndexOptions().unique(true)
                    .partialFilterExpression(exists("SeriesIds.0", true)).name("serie_estudio_unico"));
        } catch (com.mongodb.MongoException ex) {
            throw new IllegalStateException("No se puede imponer la relación: revisa si una serie aparece en varios estudios.", ex);
        }
    }

    public List<Estudio> listar(String codigo, String paisOrigen, ObjectId serieId) {
        var filtros = new ArrayList<Bson>();
        if (codigo != null) filtros.add(eq("id", codigo));
        if (paisOrigen != null) filtros.add(regex("PaisOrigen", "^" + Pattern.quote(paisOrigen) + "$", "i"));
        if (serieId != null) filtros.add(eq("SeriesIds", serieId));
        Bson filtro = filtros.isEmpty() ? new Document() : and(filtros);
        return estudios.find(filtro).sort(ascending("id")).map(this::desdeDocumento).into(new ArrayList<>());
    }

    public Optional<Estudio> buscarPorCodigo(String codigo) {
        return Optional.ofNullable(estudios.find(eq("id", codigo)).first()).map(this::desdeDocumento);
    }

    public Optional<Estudio> buscarPorId(ObjectId id) {
        return Optional.ofNullable(estudios.find(eq("_id", id)).first()).map(this::desdeDocumento);
    }

    public boolean vinculadasAOtro(ObjectId estudioId, List<ObjectId> ids) {
        return estudios.countDocuments(and(ne("_id", estudioId), in("SeriesIds", ids))) > 0;
    }

    public void insertar(Estudio estudio) {
        estudios.insertOne(aDocumento(estudio));
    }

    public boolean actualizar(Estudio estudio) {
        return estudios.replaceOne(eq("_id", estudio.id()), aDocumento(estudio)).getMatchedCount() != 0;
    }

    public boolean eliminar(ObjectId id) {
        return estudios.deleteOne(eq("_id", id)).getDeletedCount() != 0;
    }

    public boolean contieneSerie(ObjectId serieId) {
        return estudios.countDocuments(eq("SeriesIds", serieId)) > 0;
    }

    // Mantiene los nombres BSON de los documentos guardados por la versión .NET.
    private Document aDocumento(Estudio estudio) {
        return new Document("_id", estudio.id()).append("id", estudio.codigo())
                .append("Nombre", estudio.nombre()).append("PaisOrigen", estudio.paisOrigen())
                .append("FechaFundacion", Date.from(estudio.fechaFundacion().atStartOfDay().toInstant(ZoneOffset.UTC)))
                .append("SeriesIds", estudio.seriesIds());
    }

    private Estudio desdeDocumento(Document document) {
        return new Estudio(document.getObjectId("_id"), document.getString("id"),
                document.getString("Nombre"), document.getString("PaisOrigen"),
                document.getDate("FechaFundacion").toInstant().atZone(ZoneOffset.UTC).toLocalDate(),
                document.getList("SeriesIds", ObjectId.class));
    }
}
