import { type FormEvent, useRef, useState } from 'react';
import { type EntityConfig, type Raw, aFormulario } from '../../entities/EntityConfig';
import { mensajeDe } from '../../utils/parseo';
import { EntityForm } from '../components/EntityForm';
import { type Msg, Mensaje } from '../components/Mensaje';
import { SearchPanel } from '../components/SearchPanel';

export function ActualizarWindow<T extends { id: string }>({ config }: { config: EntityConfig<T> }) {
  const [encontrado, setEncontrado] = useState<T | null>(null);
  const [valores, setValores] = useState<Raw>({});
  const [msg, setMsg] = useState<Msg | null>(null);
  const [ocupado, setOcupado] = useState(false);
  const [resolviendo, setResolviendo] = useState(false);
  const guardando = useRef(false);

  function alBuscar(e: T | null) {
    setEncontrado(e); setMsg(null); setResolviendo(false);
    setValores(e ? aFormulario(config.campos,e) : {});
  }

  async function guardar(e: FormEvent) {
    e.preventDefault();
    if (guardando.current || resolviendo) return;
    guardando.current = true; setOcupado(true); setMsg(null);
    try {
      const actualizado = await config.controller.actualizar(config.desdeFormulario(valores));
      setEncontrado(actualizado); setValores(aFormulario(config.campos,actualizado));
      setMsg({ tipo: 'ok', texto: `Se actualizó ${config.nombre}. ObjectId: ${actualizado.id}.` });
    } catch (err) { setMsg({ tipo: 'error', texto: mensajeDe(err) }); }
    finally { guardando.current = false; setOcupado(false); }
  }

  return <>
    <SearchPanel config={config} onResultado={alBuscar} disabled={ocupado || resolviendo} />
    {encontrado && <form className="formulario" onSubmit={guardar}>
      <fieldset disabled={ocupado}>
        <EntityForm key={encontrado.id} campos={config.campos} valores={valores} modoEdicion onBusyChange={setResolviendo}
          onChange={(k,v)=>setValores(prev=>({...prev,[k]:v}))} />
        <div className="acciones"><button type="submit" disabled={resolviendo}>{ocupado ? 'Guardando…' : 'Guardar cambios'}</button></div>
      </fieldset>
      <Mensaje msg={msg} />
    </form>}
  </>;
}
