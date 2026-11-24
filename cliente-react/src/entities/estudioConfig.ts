import { EstudioController } from '../controllers/EstudioController';
import { SerieController } from '../controllers/SerieController';
import type { Estudio } from '../models/Estudio';
import { texto } from '../utils/parseo';
import type { EntityConfig, Raw } from './EntityConfig';

function datos(r: Raw): Omit<Estudio, 'id'> {
  const fecha = texto(String(r.fechaFundacion), 'Fecha de fundación');
  const hoy = new Date();
  const fechaHoy = `${hoy.getFullYear()}-${String(hoy.getMonth()+1).padStart(2,'0')}-${String(hoy.getDate()).padStart(2,'0')}`;
  if (!/^\d{4}-\d{2}-\d{2}$/.test(fecha) || fecha > fechaHoy)
    throw new Error('La fecha de fundación debe ser válida y no puede ser futura.');
  const series = Array.isArray(r.series) ? r.series : [];
  return { codigo: texto(String(r.codigo), 'ID'), nombre: texto(String(r.nombre), 'Nombre'),
    paisOrigen: texto(String(r.paisOrigen), 'País de origen'), fechaFundacion: fecha,
    series, seriesIds: series.map(s => s.id) };
}

export const estudioConfig: EntityConfig<Estudio> = {
  nombre: 'Estudio',
  campos: [
    { key: 'codigo', label: 'ID', tipo: 'text' },
    { key: 'id', label: 'ObjectId', tipo: 'text', soloLecturaAlEditar: true, ocultoAlAdicionar: true },
    { key: 'nombre', label: 'Nombre', tipo: 'text' },
    { key: 'paisOrigen', label: 'País de origen', tipo: 'text' },
    { key: 'fechaFundacion', label: 'Fecha de fundación', tipo: 'date' },
    { key: 'series', label: 'Series referenciadas', tipo: 'seriesRefs' },
  ],
  camposBusqueda: [{ key: 'codigo', label: 'ID', tipo: 'text' }],
  camposFiltro: [
    { key: 'codigo', label: 'ID del estudio', tipo: 'text' },
    { key: 'paisOrigen', label: 'País de origen', tipo: 'text' },
    { key: 'serieCodigo', label: 'ID de la serie', tipo: 'text' },
  ],
  controller: EstudioController.getInstance(),
  cambiosRelacionados: [SerieController.getInstance()],
  desdeFormularioNuevo: datos,
  desdeFormulario: r => ({ ...datos(r), id: texto(String(r.id), 'ObjectId') }),
};
