import { type FormEvent, useRef, useState } from 'react';
import { type EntityConfig, type Raw, valoresIniciales } from '../../entities/EntityConfig';
import { mensajeDe } from '../../utils/parseo';
import { EntityForm } from '../components/EntityForm';
import { type Msg, Mensaje } from '../components/Mensaje';

export function AdicionarWindow<T extends { id: string }>({ config }: { config: EntityConfig<T> }) {
  const [valores, setValores] = useState<Raw>(() => valoresIniciales(config.campos));
  const [msg, setMsg] = useState<Msg | null>(null);
  const [ocupado, setOcupado] = useState(false);
  const [resolviendo, setResolviendo] = useState(false);
  const [version, setVersion] = useState(0);
  const guardando = useRef(false);

  async function guardar(e: FormEvent) {
    e.preventDefault();
    if (guardando.current || resolviendo) return;
    guardando.current = true; setOcupado(true); setMsg(null);
    try {
      const creado = await config.controller.adicionar(config.desdeFormularioNuevo(valores));
      setMsg({ tipo: 'ok', texto: `Se agregó ${config.nombre}. ObjectId: ${creado.id}.` });
      setValores(valoresIniciales(config.campos)); setVersion(v=>v+1);
    } catch (err) { setMsg({ tipo: 'error', texto: mensajeDe(err) }); }
    finally { guardando.current = false; setOcupado(false); }
  }

  return <form className="formulario" onSubmit={guardar}>
    <fieldset disabled={ocupado}>
      <EntityForm key={version} campos={config.campos} valores={valores} onBusyChange={setResolviendo}
        onChange={(k,v)=>setValores(prev=>({...prev,[k]:v}))} />
      <div className="acciones"><button type="submit" disabled={resolviendo}>{ocupado ? 'Guardando…' : 'Guardar'}</button></div>
    </fieldset>
    <Mensaje msg={msg} />
  </form>;
}
