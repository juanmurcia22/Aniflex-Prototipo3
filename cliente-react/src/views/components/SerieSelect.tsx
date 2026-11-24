import { useState } from 'react';
import { SerieController } from '../../controllers/SerieController';
import { mensajeDe } from '../../utils/parseo';

interface Props { valor: string; onChange: (v: string) => void; disabled?: boolean; onBusyChange?: (busy: boolean) => void; }

// Resuelve un ID manual sin descargar el catálogo. El valor sigue siendo el ObjectId.
export function SerieSelect({ valor, onChange, disabled, onBusyChange }: Props) {
  const [codigo, setCodigo] = useState('');
  const [etiqueta, setEtiqueta] = useState('');
  const [error, setError] = useState('');
  const [ocupado, setOcupado] = useState(false);
  async function buscar() {
    if (ocupado) return;
    setOcupado(true); onBusyChange?.(true); setError('');
    try {
      if (!codigo.trim()) throw new Error('Ingresa el ID manual de la serie.');
      const serie = await SerieController.getInstance().buscar({ codigo: codigo.trim() });
      if (!serie) throw new Error('No existe una serie con ese ID manual.');
      setEtiqueta(`${serie.codigo} — ${serie.titulo}`);
      onChange(serie.id);
    } catch (err) { setError(mensajeDe(err)); onChange(''); setEtiqueta(''); }
    finally { setOcupado(false); onBusyChange?.(false); }
  }
  return <div className="referencia">
    {!disabled && <div className="busqueda-referencia">
      <input aria-label="ID manual de la serie" value={codigo} disabled={ocupado}
        onChange={e => { setCodigo(e.target.value); onChange(''); setEtiqueta(''); setError(''); }}
        onKeyDown={e => { if(e.key === 'Enter') { e.preventDefault(); void buscar(); } }} />
      <button type="button" className="secundario" disabled={ocupado} onClick={() => void buscar()}>Buscar serie</button>
      <button type="button" className="secundario" disabled={ocupado} onClick={() => { onChange(''); setCodigo(''); setEtiqueta(''); setError(''); }}>Quitar</button>
    </div>}
    {valor && <span className="referencia-elegida">{etiqueta || 'Serie vinculada'}<small>ObjectId: {valor}</small></span>}
    {error && <p className="mensaje error" role="status">{error}</p>}
  </div>;
}
