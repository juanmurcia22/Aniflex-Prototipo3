import { useCallback, useEffect, useRef, useState } from 'react';
import { type EntityConfig, type Raw, comoParams } from '../../entities/EntityConfig';
import type { Params } from '../../services/ICrudService';
import { mensajeDe } from '../../utils/parseo';
import { CampoInput } from '../components/CampoInput';
import { DataGrid } from '../components/DataGrid';
import { type Msg, Mensaje } from '../components/Mensaje';

export function ListarWindow<T extends { id: string }>({ config }: { config: EntityConfig<T> }) {
  const [valores, setValores] = useState<Raw>({});
  const [filas, setFilas] = useState<T[]>([]);
  const [msg, setMsg] = useState<Msg | null>(null);
  const [ocupado, setOcupado] = useState(false);
  const [cargado, setCargado] = useState(false);
  const aplicado = useRef<Params | null>(null);
  const solicitud = useRef(0);

  const cargar = useCallback(async (params: Params) => {
    const turno = ++solicitud.current;
    aplicado.current = params;
    setOcupado(true); setMsg(null);
    try {
      const resultado = await config.controller.listar(params);
      if (turno === solicitud.current) { setFilas(resultado); setCargado(true); }
    } catch (err) {
      if (turno === solicitud.current) setMsg({ tipo: 'error', texto: mensajeDe(err) });
    } finally { if (turno === solicitud.current) setOcupado(false); }
  }, [config]);

  useEffect(() => {
    // Abrir la ventana no consulta. Solo refresca listados solicitados previamente.
    const refrescar = () => { if (aplicado.current !== null) void cargar(aplicado.current); };
    const desuscribir = [config.controller, ...(config.cambiosRelacionados ?? [])].map(c=>c.subscribe(refrescar));
    return () => { ++solicitud.current; desuscribir.forEach(fn=>fn()); };
  }, [config, cargar]);

  function limpiar() {
    ++solicitud.current; aplicado.current = null;
    setValores({}); setFilas([]); setMsg(null); setCargado(false); setOcupado(false);
  }

  return <>
    <form className="filtros" onSubmit={e=> { e.preventDefault(); void cargar(comoParams(valores)); }}>
      <fieldset disabled={ocupado} className="filtros-campos">
        {config.camposFiltro.map(c=><CampoInput key={c.key} campo={c} valor={valores[c.key] ?? ''}
          onChange={v=>setValores(prev=>({...prev,[c.key]:v}))} />)}
        <button type="button" className="principal" onClick={()=> { setValores({}); void cargar({}); }}>Cargar</button>
        <button type="submit">Filtrar</button>
      </fieldset>
      <button type="button" className="secundario" onClick={limpiar}>Limpiar</button>
    </form>
    <Mensaje msg={msg} />
    <p className="estado-listado" role="status">{ocupado ? 'Cargando…' : cargado ? `${filas.length} registro(s).` : 'Pulsa Cargar para listar todo o Filtrar para consultar.'}</p>
    <DataGrid campos={config.campos} filas={filas} relacion={config.relacion} />
  </>;
}
