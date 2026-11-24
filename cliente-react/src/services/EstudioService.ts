import type { Estudio } from '../models/Estudio';
import { texto, sinVacios } from '../utils/parseo';
import { GraphQLClient } from './GraphQLClient';
import type { ICrudService, Params } from './ICrudService';
import { SerieService, CAMPOS_SERIE } from './SerieService';

const CAMPOS = `id codigo nombre paisOrigen fechaFundacion seriesIds series { ${CAMPOS_SERIE} }`;

export class EstudioService implements ICrudService<Estudio> {
  constructor(private readonly gql: GraphQLClient = GraphQLClient.getInstance()) {}

  private async guardar(e: Omit<Estudio, 'id'> & { id?: string }, nuevo: boolean): Promise<Estudio> {
    // Las series completas son de consulta; la relación se escribe con sus ObjectId.
    const input = { ...(nuevo ? {} : { id: e.id }), codigo: e.codigo, nombre: e.nombre,
      paisOrigen: e.paisOrigen, fechaFundacion: e.fechaFundacion, seriesIds: e.seriesIds };
    const operacion = nuevo ? 'adicionarEstudio' : 'actualizarEstudio';
    const d = await this.gql.request<{ estudio: Estudio }>(
      `mutation($input: EstudioInput!) { estudio: ${operacion}(input: $input) { ${CAMPOS} } }`, { input });
    return d.estudio;
  }

  adicionar(e: Omit<Estudio, 'id'>): Promise<Estudio> { return this.guardar(e, true); }
  actualizar(e: Estudio): Promise<Estudio> { return this.guardar(e, false); }

  async buscar(p: Params): Promise<Estudio | null> {
    const codigo = texto(p.codigo ?? '', 'ID manual');
    const d = await this.gql.request<{ buscarEstudio: Estudio | null }>(
      `query($codigo: String!) { buscarEstudio(codigo: $codigo) { ${CAMPOS} } }`, { codigo });
    return d.buscarEstudio;
  }

  async listar(p: Params): Promise<Estudio[]> {
    const { codigo, paisOrigen, serieCodigo } = sinVacios(p);
    let serieId = sinVacios(p).serieId;
    if (serieCodigo) {
      const serie = await new SerieService(this.gql).buscar({ codigo: serieCodigo });
      if (!serie) throw new Error('No existe una serie con ese ID.');
      serieId = serie.id;
    }
    const d = await this.gql.request<{ listarEstudios: Estudio[] }>(
      `query($codigo: String, $paisOrigen: String, $serieId: ID) {
        listarEstudios(codigo: $codigo, paisOrigen: $paisOrigen, serieId: $serieId) { ${CAMPOS} } }`,
      { codigo, paisOrigen, serieId });
    return d.listarEstudios;
  }

  async eliminar(id: string): Promise<boolean> {
    const d = await this.gql.request<{ eliminarEstudio: boolean }>(
      'mutation($id: ID!) { eliminarEstudio(id: $id) }', { id });
    return d.eliminarEstudio;
  }
}
