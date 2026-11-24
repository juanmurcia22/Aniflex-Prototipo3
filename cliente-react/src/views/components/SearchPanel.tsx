import { type FormEvent, useRef, useState } from 'react';
import { type EntityConfig, type Raw, comoParams } from '../../entities/EntityConfig';
import { mensajeDe } from '../../utils/parseo';
import { CampoInput } from './CampoInput';
import { type Msg, Mensaje } from './Mensaje';

interface Props<T extends { id: string }> {
  config: EntityConfig<T>;
  onResultado: (encontrado: T | null) => void;
  disabled?: boolean;
}

export function SearchPanel<T extends { id: string }>({ config, onResultado, disabled }: Props<T>) {
  const [params, setParams] = useState<Raw>({});
  const [msg, setMsg] = useState<Msg | null>(null);
  const [ocupado, setOcupado] = useState(false);
  const buscando = useRef(false);

  async function buscar(e: FormEvent) {
    e.preventDefault();
    if (buscando.current || disabled) return;
    buscando.current=true; setOcupado(true); setMsg(null); onResultado(null);
    try {
      const p = comoParams(params);
      if (!p.codigo?.trim()) throw new Error('Ingresa el ID manual.');
      const r = await config.controller.buscar(p);
      onResultado(r);
      setMsg(r ? null : { tipo: 'error', texto: `No se encontró ${config.nombre} con ese ID manual.` });
    } catch (err) { setMsg({ tipo: 'error', texto: mensajeDe(err) }); }
    finally { buscando.current=false; setOcupado(false); }
  }

  return <form className="formulario" onSubmit={buscar}>
    <fieldset disabled={disabled || ocupado}>
      {config.camposBusqueda.map(c=><CampoInput key={c.key} campo={c} valor={params[c.key] ?? ''}
        onChange={v=>setParams(prev=>({...prev,[c.key]:v}))} />)}
      <div className="acciones"><button type="submit">{ocupado ? 'Buscando…' : 'Buscar'}</button></div>
    </fieldset>
    <Mensaje msg={msg} />
  </form>;
}
