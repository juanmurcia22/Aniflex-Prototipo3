import type { Serie } from '../../models/Serie';
import type { FieldDef, Raw, ValorCampo } from '../../entities/EntityConfig';
import { SeriesEstudio } from './SeriesEstudio';
import { CampoInput } from './CampoInput';

interface Props {
  campos: FieldDef[];
  valores: Raw;
  onChange: (key: string, v: ValorCampo) => void;
  modoEdicion?: boolean;
  onBusyChange?: (busy: boolean) => void;
}

export function EntityForm({ campos, valores, onChange, modoEdicion = false, onBusyChange }: Props) {
  return (
    <>
      {campos.filter((c) => modoEdicion || !c.ocultoAlAdicionar).map((c) => (
        c.tipo === 'seriesRefs' ? <SeriesEstudio key={c.key} series={Array.isArray(valores[c.key]) ? valores[c.key] as Serie[] : []}
          estudioId={String(valores.id ?? '')} onChange={v=>onChange(c.key,v)} onBusyChange={onBusyChange} /> :
        <CampoInput key={c.key} campo={c} onBusyChange={onBusyChange} valor={valores[c.key] ?? ''}
                    onChange={(v) => onChange(c.key, v)}
                    soloLectura={c.soloLectura || (modoEdicion && c.soloLecturaAlEditar)} />
      ))}
    </>
  );
}
