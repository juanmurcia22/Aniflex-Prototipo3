import type { FieldDef } from '../../entities/EntityConfig';
import { paraMostrar } from '../../utils/fecha';

export function formatear(campo: FieldDef, valor: unknown): string {
  if (campo.tipo === 'seriesRefs') return Array.isArray(valor) && valor.length ? valor.map(s => `${s.codigo} — ${s.titulo}`).join('; ') : 'Sin series';
  if (campo.tipo === 'date') return String(valor ?? '').slice(0,10);
  if (campo.tipo === 'boolean') return valor === true ? 'Sí' : 'No';
  if (campo.tipo === 'datetime') return paraMostrar(String(valor));
  return String(valor ?? '');
}
