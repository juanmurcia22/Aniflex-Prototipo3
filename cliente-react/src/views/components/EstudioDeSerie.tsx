import { useState } from 'react';
import { EstudioController } from '../../controllers/EstudioController';
import type { Estudio } from '../../models/Estudio';
import { mensajeDe } from '../../utils/parseo';
import { SeriesEstudio } from './SeriesEstudio';

export function EstudioDeSerie({ serieId }: { serieId: string }) {
  const [estudios, setEstudios] = useState<Estudio[] | null>(null);
  const [error, setError] = useState('');
  const [ocupado, setOcupado] = useState(false);
  async function consultar() {
    setOcupado(true); setError('');
    try { setEstudios(await EstudioController.getInstance().listar({ serieId })); }
    catch(err) { setError(mensajeDe(err)); }
    finally { setOcupado(false); }
  }
  return <div className="estudio-relacionado">
    <button type="button" className="secundario" disabled={ocupado} onClick={()=>void consultar()}>Ver estudio</button>
    {error && <p className="mensaje error" role="status">{error}</p>}
    {estudios?.length === 0 && <p>Esta serie no tiene estudio asociado.</p>}
    {estudios?.map(estudio=><div key={estudio.id}>
      <h4>{estudio.codigo} — {estudio.nombre}</h4>
      <p>{estudio.paisOrigen} · Fundación: {estudio.fechaFundacion.slice(0,10)}</p>
      <small>ObjectId: {estudio.id}</small>
      <SeriesEstudio series={estudio.series} soloLectura onChange={()=>{}} />
    </div>)}
  </div>;
}
