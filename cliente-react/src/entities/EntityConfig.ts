import type { ReactNode } from 'react';
import type { ICrudController } from '../controllers/ICrudController';
import type { Serie } from '../models/Serie';
import type { Params } from '../services/ICrudService';
import { paraInput } from '../utils/fecha';

export type TipoCampo = 'text' | 'int' | 'float' | 'datetime' | 'boolean' | 'serieRef' | 'seriesRefs' | 'date';

export interface FieldDef {
  key: string;
  label: string;
  tipo: TipoCampo;
  soloLecturaAlEditar?: boolean;
  soloLectura?: boolean;
  ocultoAlAdicionar?: boolean;   // p. ej. el id: lo genera MongoDB, no se pide al adicionar
}

export type ValorCampo = string | boolean | Serie[];
export type Raw = Record<string, ValorCampo>;

// Descriptor de entidad
export interface EntityConfig<T extends { id: string }> {
  nombre: string;
  campos: FieldDef[];
  camposBusqueda: FieldDef[];
  camposFiltro: FieldDef[];
  controller: ICrudController<T>;
  relacion?: (entidad: T) => ReactNode;
  cambiosRelacionados?: Pick<ICrudController<unknown>, 'subscribe'>[];
  desdeFormularioNuevo(raw: Raw): Omit<T, 'id'>;   // para adicionar (sin id)
  desdeFormulario(raw: Raw): T;                    // para actualizar (con id)
}

export type AnyConfig = EntityConfig<any>;

export function valoresIniciales(campos: FieldDef[]): Raw {
  return Object.fromEntries(campos.map((c) => [c.key, c.tipo === 'boolean' ? false : c.tipo === 'seriesRefs' ? [] : '']));
}

export function aFormulario(campos: FieldDef[], entidad: object): Raw {
  const e = entidad as Record<string, unknown>;
  return Object.fromEntries(
    campos.map((c) => {
      const v = e[c.key];
      if (c.tipo === 'seriesRefs') return [c.key, Array.isArray(v) ? v : []];
      if (c.tipo === 'date') return [c.key, String(v ?? '').slice(0, 10)];
      if (c.tipo === 'boolean') return [c.key, v === true];
      if (c.tipo === 'datetime') return [c.key, paraInput(String(v))];
      return [c.key, String(v ?? '')];
    }),
  );
}

export function comoParams(raw: Raw): Params {
  return Object.fromEntries(
    Object.entries(raw).filter((par): par is [string, string] => typeof par[1] === 'string'),
  );
}
