import { useState } from 'react';
import { SerieController } from '../../controllers/SerieController';
import type { Serie } from '../../models/Serie';
import { mensajeDe } from '../../utils/parseo';

export function SeriesEstudio({ series, estudioId, onChange, soloLectura, onBusyChange }: {
  series: Serie[]; estudioId?: string; onChange: (series: Serie[]) => void; soloLectura?: boolean; onBusyChange?: (busy: boolean) => void;
}) {
  const [codigo, setCodigo] = useState('');
  const [error, setError] = useState('');
  const [ocupado, setOcupado] = useState(false);
  async function agregar() {
    if (ocupado) return;
    setOcupado(true); onBusyChange?.(true); setError('');
    try {
      if (!codigo.trim()) throw new Error('Ingresa el ID manual de la serie.');
      const serie = await SerieController.getInstance().buscar({ codigo: codigo.trim() });
      if (!serie) throw new Error('No existe una serie con ese ID manual.');
      if (series.some(s => s.id === serie.id)) throw new Error('La serie ya está en la lista.');
      if (serie.estudioId && serie.estudioId !== estudioId) throw new Error('Esta serie ya pertenece a otro estudio.');
      onChange([...series, serie]); setCodigo('');
    } catch(err) { setError(mensajeDe(err)); }
    finally { setOcupado(false); onBusyChange?.(false); }
  }
  return <section className="series-estudio" aria-label="Series referenciadas">
    {!soloLectura && <div className="busqueda-referencia">
      <label className="campo"><span>ID manual de la serie</span>
        <input value={codigo} disabled={ocupado} onChange={e=>setCodigo(e.target.value)}
          onKeyDown={e=> { if(e.key === 'Enter') { e.preventDefault(); void agregar(); } }} /></label>
      <button type="button" className="secundario" disabled={ocupado} onClick={()=>void agregar()}>Añadir serie</button>
    </div>}
    {error && <p className="mensaje error" role="status">{error}</p>}
    {!series.length ? <p className="vacio">Sin series asociadas.</p> : <ul className="series-seleccionadas">
      {series.map(s=><li key={s.id}><span><strong>{s.codigo}</strong> — {s.titulo}<small>ObjectId: {s.id}</small></span>
        {!soloLectura && <button type="button" className="secundario" disabled={ocupado}
          onClick={()=>onChange(series.filter(item=>item.id!==s.id))}>Retirar {s.codigo}</button>}</li>)}
    </ul>}
  </section>;
}
