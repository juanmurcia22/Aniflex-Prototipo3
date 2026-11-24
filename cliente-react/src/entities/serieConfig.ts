import { createElement } from 'react';
import { EstudioDeSerie } from '../views/components/EstudioDeSerie';
import { EstudioController } from '../controllers/EstudioController';
import { SerieController } from '../controllers/SerieController';
import { type Serie, SerieBuilder } from '../models/Serie';
import { decimal, entero, fechaHora, texto } from '../utils/parseo';
import type { EntityConfig, Raw } from './EntityConfig';

// Atributos comunes a adicionar y actualizar (el id se agrega solo al actualizar)
const datosSerie = (r: Raw) =>
  new SerieBuilder()
    .codigo(texto(String(r.codigo), 'ID'))
    .titulo(texto(String(r.titulo), 'Título'))
    .temporadas(entero(String(r.temporadas), 'Temporadas', 1))
    .calificacion(decimal(String(r.calificacion), 'Calificación', 0, 10))
    .fechaEstreno(fechaHora(String(r.fechaEstreno), 'Fecha de estreno'))
    .enEmision(r.enEmision === true);

export const serieConfig: EntityConfig<Serie> = {
  nombre: 'Serie',
  campos: [
    { key: 'codigo', label: 'ID', tipo: 'text' },
    { key: 'id', label: 'ObjectId', tipo: 'text', soloLecturaAlEditar: true, ocultoAlAdicionar: true },
    { key: 'estudioId', label: 'ObjectId del estudio', tipo: 'text', soloLectura: true, ocultoAlAdicionar: true },
    { key: 'titulo', label: 'Título', tipo: 'text' },
    { key: 'temporadas', label: 'Temporadas', tipo: 'int' },
    { key: 'calificacion', label: 'Calificación (0-10)', tipo: 'float' },
    { key: 'fechaEstreno', label: 'Fecha de estreno', tipo: 'datetime' },
    { key: 'enEmision', label: 'En emisión', tipo: 'boolean' },
  ],
  camposBusqueda: [
    { key: 'codigo', label: 'ID', tipo: 'text' },
  ],
  camposFiltro: [
    { key: 'titulo', label: 'Título contiene', tipo: 'text' },
    { key: 'calificacionMinima', label: 'Calificación mínima', tipo: 'float' },
  ],
  controller: SerieController.getInstance(),
  relacion: serie => createElement(EstudioDeSerie, { serieId: serie.id }),
  cambiosRelacionados: [EstudioController.getInstance()],
  desdeFormularioNuevo: (r) => datosSerie(r).buildNueva(),
  desdeFormulario: (r) => datosSerie(r).id(texto(String(r.id), 'ID')).build(),
};
