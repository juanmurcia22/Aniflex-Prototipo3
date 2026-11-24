import type { Serie, SerieNueva } from '../models/Serie';
import { sinVacios } from '../utils/parseo';
import { GraphQLClient } from './GraphQLClient';
import type { ICrudService, Params } from './ICrudService';

export const CAMPOS_SERIE = 'id codigo titulo temporadas calificacion fechaEstreno enEmision estudioId';
const CAMPOS = CAMPOS_SERIE;

export class SerieService implements ICrudService<Serie> {
  constructor(private readonly gql: GraphQLClient = GraphQLClient.getInstance()) {}

  private input(serie: SerieNueva & { id?: string }) {
    const { id, codigo, titulo, temporadas, calificacion, fechaEstreno, enEmision } = serie;
    return { ...(id ? { id } : {}), codigo, titulo, temporadas, calificacion, fechaEstreno, enEmision };
  }

  async adicionar(serie: SerieNueva): Promise<Serie> {
    const d = await this.gql.request<{ adicionarSerie: Serie }>(
      `mutation($input: SerieInput!) { adicionarSerie(input: $input) { ${CAMPOS} } }`, { input: this.input(serie) });
    return d.adicionarSerie;
  }

  async buscar(p: Params): Promise<Serie | null> {
    const { codigo } = sinVacios(p);
    if (codigo) {
      const resultado = await this.gql.request<{ buscarSerie: Serie | null }>(
        `query($codigo: String!) { buscarSerie: buscarSeriePorCodigo(codigo: $codigo) { ${CAMPOS} } }`, { codigo });
      return resultado.buscarSerie;
    }
    const { id, titulo } = sinVacios(p);
    if (!id && !titulo) throw new Error('Ingrese al menos el ID o el título de la serie.');
    const d = await this.gql.request<{ buscarSerie: Serie | null }>(
      `query($id: ID, $titulo: String) { buscarSerie(id: $id, titulo: $titulo) { ${CAMPOS} } }`, { id, titulo });
    return d.buscarSerie;
  }

  async actualizar(serie: Serie): Promise<Serie> {
    const d = await this.gql.request<{ actualizarSerie: Serie }>(
      `mutation($input: SerieInput!) { actualizarSerie(input: $input) { ${CAMPOS} } }`, { input: this.input(serie) });
    return d.actualizarSerie;
  }

  async eliminar(id: string): Promise<boolean> {
    const d = await this.gql.request<{ eliminarSerie: boolean }>(
      `mutation($id: ID!) { eliminarSerie(id: $id) }`, { id });
    return d.eliminarSerie;
  }

  async listar(filtro: Params): Promise<Serie[]> {
    const { titulo, calificacionMinima } = sinVacios(filtro);
    const d = await this.gql.request<{ listarSeries: Serie[] }>(
      `query($titulo: String, $calificacionMinima: Float) {
         listarSeries(titulo: $titulo, calificacionMinima: $calificacionMinima) { ${CAMPOS} } }`,
      { titulo, calificacionMinima: calificacionMinima === undefined ? undefined : Number(calificacionMinima) });
    return d.listarSeries;
  }
}
