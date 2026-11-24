import type { FieldDef } from '../../entities/EntityConfig';
import { SeriesEstudio } from './SeriesEstudio';
import type { Serie } from '../../models/Serie';
import { formatear } from './formato';

export function EntityDetail({ campos, entidad }: { campos: FieldDef[]; entidad: object }) {
  const e = entidad as Record<string, unknown>;
  return (
    <dl className="detalle">
      {campos.map((c) => (
        <div key={c.key}>
          <dt>{c.label}</dt>
          <dd>{c.tipo === 'seriesRefs' ? <SeriesEstudio series={(e[c.key] as Serie[]) ?? []} soloLectura onChange={() => {}} /> : formatear(c, e[c.key])}</dd>
        </div>
      ))}
    </dl>
  );
}
