import type { Serie } from './Serie';

export interface Estudio {
  id: string;
  codigo: string;
  nombre: string;
  paisOrigen: string;
  fechaFundacion: string;
  seriesIds: string[];
  series: Serie[];
}
