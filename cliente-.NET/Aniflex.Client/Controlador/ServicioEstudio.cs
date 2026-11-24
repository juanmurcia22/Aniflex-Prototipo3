using Aniflex.Client.Controlador;
using Aniflex.Client.Modelo;
using GraphQL;
using System.Globalization;

namespace Aniflex.Client.Servicios;

public sealed class ServicioEstudio
{
    private static readonly ServicioEstudio instancia = new();
    private ServicioEstudio() { }
    public static ServicioEstudio GetInstance() => instancia;
    private const string Campos = "id codigo nombre paisOrigen fechaFundacion seriesIds series { id codigo titulo temporadas calificacion fechaEstreno enEmision estudioId }";

    public async Task<List<Estudio>> ListarAsync(string? codigo = null, string? paisOrigen = null, string? serieId = null)
    {
        var respuesta = await GraphQLConexion.Cliente.SendQueryAsync<ListarRespuesta>(new GraphQLRequest
        {
            Query = "query($codigo: String, $paisOrigen: String, $serieId: ID) { listarEstudios(codigo: $codigo, paisOrigen: $paisOrigen, serieId: $serieId) { " + Campos + " } }",
            Variables = new { codigo, paisOrigen, serieId }
        });
        GraphQLConexion.VerificarErrores(respuesta);
        return respuesta.Data?.ListarEstudios ?? [];
    }

    public async Task<Estudio?> BuscarAsync(string codigo)
    {
        var respuesta = await GraphQLConexion.Cliente.SendQueryAsync<BuscarRespuesta>(new GraphQLRequest
        {
            Query = "query($codigo: String!) { buscarEstudio(codigo: $codigo) { " + Campos + " } }",
            Variables = new { codigo }
        });
        GraphQLConexion.VerificarErrores(respuesta);
        return respuesta.Data?.BuscarEstudio;
    }

    public async Task<Estudio> GuardarAsync(Estudio estudio, bool nuevo)
    {
        var operacion = nuevo ? "adicionarEstudio" : "actualizarEstudio";
        var respuesta = await GraphQLConexion.Cliente.SendMutationAsync<GuardarRespuesta>(new GraphQLRequest
        {
            Query = "mutation($input: EstudioInput!) { estudio: " + operacion + "(input: $input) { " + Campos + " } }",
            Variables = new { input = new {
                id = nuevo ? null : estudio.Id, codigo = estudio.Codigo,
                nombre = estudio.Nombre, paisOrigen = estudio.PaisOrigen,
                fechaFundacion = estudio.FechaFundacion.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                seriesIds = estudio.SeriesIds
            } }
        });
        GraphQLConexion.VerificarErrores(respuesta);
        return respuesta.Data?.Estudio ?? throw new InvalidOperationException("El servidor no devolvió el estudio guardado.");
    }

    public async Task<bool> EliminarAsync(string id)
    {
        var respuesta = await GraphQLConexion.Cliente.SendMutationAsync<EliminarRespuesta>(new GraphQLRequest
        {
            Query = "mutation($id: ID!) { eliminarEstudio(id: $id) }", Variables = new { id }
        });
        GraphQLConexion.VerificarErrores(respuesta);
        return respuesta.Data?.EliminarEstudio ?? false;
    }

    private sealed class ListarRespuesta { public List<Estudio> ListarEstudios { get; set; } = []; }
    private sealed class BuscarRespuesta { public Estudio? BuscarEstudio { get; set; } }
    private sealed class GuardarRespuesta { public Estudio? Estudio { get; set; } }
    private sealed class EliminarRespuesta { public bool EliminarEstudio { get; set; } }
}
