import type { ReactNode } from 'react';
import type { FieldDef } from '../../entities/EntityConfig';
import { formatear } from './formato';

export function DataGrid<T extends { id: string }>({ campos, filas, relacion }: { campos: FieldDef[]; filas: T[]; relacion?: (fila: T) => ReactNode }) {
  return (
    <div className="grilla">
      <table>
        <thead>
          <tr>{campos.map((c) => <th key={c.key}>{c.label}</th>)}{relacion && <th>Estudio</th>}</tr>
        </thead>
        <tbody>
          {filas.length === 0 && (
            <tr><td colSpan={campos.length + (relacion ? 1 : 0)} className="vacio">No hay registros para mostrar.</td></tr>
          )}
          {filas.map((f) => (
            <tr key={f.id}>
              {campos.map((c) => (
                <td key={c.key}>{formatear(c, (f as unknown as Record<string, unknown>)[c.key])}</td>
              ))}
              {relacion && <td>{relacion(f)}</td>}
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
