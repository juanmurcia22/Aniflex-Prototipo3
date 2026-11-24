import type { FieldDef, ValorCampo } from '../../entities/EntityConfig';
import { SerieSelect } from './SerieSelect';

interface Props {
  campo: FieldDef;
  valor: ValorCampo;
  onChange: (v: ValorCampo) => void;
  soloLectura?: boolean;
  onBusyChange?: (busy: boolean) => void;
}

export function CampoInput({ campo, valor, onChange, soloLectura, onBusyChange }: Props) {
  if (campo.tipo === 'boolean') {
    return (
      <label className="campo check">
        <input type="checkbox" checked={valor === true} disabled={soloLectura}
               onChange={(e) => onChange(e.target.checked)} />
        {campo.label}
      </label>
    );
  }
  if (campo.tipo === 'serieRef') {
    return (
      <div className="campo">
        <span>{campo.label}</span>
        <SerieSelect valor={String(valor)} onChange={onChange} disabled={soloLectura} onBusyChange={onBusyChange} />
      </div>
    );
  }
  const type = campo.tipo === 'date' ? 'date' : campo.tipo === 'datetime' ? 'datetime-local' : campo.tipo === 'text' ? 'text' : 'number';
  return (
    <label className="campo">
      <span>{campo.label}</span>
      <input type={type} step={campo.tipo === 'float' ? 'any' : campo.tipo === 'int' ? 1 : undefined}
             value={String(valor)} readOnly={soloLectura}
             onChange={(e) => onChange(e.target.value)} />
    </label>
  );
}
