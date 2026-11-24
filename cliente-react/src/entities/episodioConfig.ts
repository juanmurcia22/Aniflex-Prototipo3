import { SerieController } from '../controllers/SerieController';
import { EpisodioController } from '../controllers/EpisodioController';
import { type Episodio, EpisodioBuilder } from '../models/Episodio';
import { decimal, entero, fechaHora, texto } from '../utils/parseo';
import type { EntityConfig, Raw } from './EntityConfig';

// Atributos comunes a adicionar y actualizar (el id se agrega solo al actualizar)
const datosEpisodio = (r: Raw) =>
  new EpisodioBuilder()
    .codigo(texto(String(r.codigo), 'ID'))
    .serieId(texto(String(r.serieId), 'Serie'))
    .noEpisodio(entero(String(r.noEpisodio), 'Nº de episodio', 1))
    .titulo(texto(String(r.titulo), 'Título'))
    .calificacion(decimal(String(r.calificacion), 'Calificación', 0, 10))
    .fechaEmision(fechaHora(String(r.fechaEmision), 'Fecha de emisión'))
    .esEspecial(r.esEspecial === true);

export const episodioConfig: EntityConfig<Episodio> = {
  nombre: 'Episodio',
  campos: [
    { key: 'codigo', label: 'ID', tipo: 'text' },
    { key: 'id', label: 'ObjectId', tipo: 'text', soloLecturaAlEditar: true, ocultoAlAdicionar: true },
    { key: 'serieId', label: 'Serie', tipo: 'serieRef', soloLecturaAlEditar: true },
    { key: 'serieTitulo', label: 'Título de la serie', tipo: 'text', soloLectura: true, ocultoAlAdicionar: true },
    { key: 'serieCalificacion', label: 'Calificación de la serie', tipo: 'text', soloLectura: true, ocultoAlAdicionar: true },
    { key: 'noEpisodio', label: 'Nº de episodio', tipo: 'int' },
    { key: 'titulo', label: 'Título', tipo: 'text' },
    { key: 'calificacion', label: 'Calificación (0-10)', tipo: 'float' },
    { key: 'fechaEmision', label: 'Fecha de emisión', tipo: 'datetime' },
    { key: 'esEspecial', label: 'Es especial', tipo: 'boolean' },
  ],
  camposBusqueda: [
    { key: 'codigo', label: 'ID', tipo: 'text' },
  ],
  camposFiltro: [
    { key: 'serieCodigo', label: 'ID de la serie', tipo: 'text' },
    { key: 'titulo', label: 'Título contiene', tipo: 'text' },
  ],
  controller: EpisodioController.getInstance(),
  cambiosRelacionados: [SerieController.getInstance()],
  desdeFormularioNuevo: (r) => datosEpisodio(r).buildNuevo(),
  desdeFormulario: (r) => datosEpisodio(r).id(texto(String(r.id), 'ID')).build(),
};
