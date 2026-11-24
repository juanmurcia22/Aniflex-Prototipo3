import { useRef, useState } from 'react';
import type { EntityConfig } from '../../entities/EntityConfig';
import { mensajeDe } from '../../utils/parseo';
import { EntityDetail } from '../components/EntityDetail';
import { type Msg, Mensaje } from '../components/Mensaje';
import { SearchPanel } from '../components/SearchPanel';

export function EliminarWindow<T extends { id: string }>({ config }: { config: EntityConfig<T> }) {
  const [encontrado, setEncontrado] = useState<T | null>(null);
  const [msg, setMsg] = useState<Msg | null>(null);
  const [ocupado, setOcupado] = useState(false);
  const eliminando = useRef(false);

  async function eliminar() {
    if (!encontrado || eliminando.current) return;
    const aviso = config.nombre === 'Estudio' ? ' Sus series se conservarán y quedarán sin estudio.' : '';
    if (!window.confirm(`¿Eliminar ${config.nombre} con ObjectId ${encontrado.id}?${aviso}`)) return;
    eliminando.current = true; setOcupado(true); setMsg(null);
    try {
      const ok = await config.controller.eliminar(encontrado.id);
      setMsg(ok ? { tipo: 'ok', texto: `Se eliminó ${config.nombre}.` }
        : { tipo: 'error', texto: 'El servidor indicó que el registro ya no existía.' });
      setEncontrado(null);
    } catch(err) { setMsg({ tipo: 'error', texto: mensajeDe(err) }); }
    finally { eliminando.current = false; setOcupado(false); }
  }
  return <>
    <SearchPanel config={config} disabled={ocupado} onResultado={e=> { setEncontrado(e); setMsg(null); }} />
    {encontrado && <>
      <EntityDetail campos={config.campos} entidad={encontrado} />
      <div className="acciones"><button type="button" className="peligro" disabled={ocupado}
        onClick={()=>void eliminar()}>{ocupado ? 'Eliminando…' : 'Eliminar'}</button></div>
    </>}
    <Mensaje msg={msg} />
  </>;
}
