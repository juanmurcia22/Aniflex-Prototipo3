using Newtonsoft.Json;

namespace Aniflex.Client.Modelo;

public sealed class Estudio
{
    [JsonProperty("id")] public string Id { get; set; } = "";
    [JsonProperty("codigo")] public string Codigo { get; set; } = "";
    [JsonProperty("nombre")] public string Nombre { get; set; } = "";
    [JsonProperty("paisOrigen")] public string PaisOrigen { get; set; } = "";
    [JsonProperty("fechaFundacion")] public DateTime FechaFundacion { get; set; } = DateTime.Today;
    [JsonProperty("series")] public List<Serie> Series { get; set; } = [];
    [JsonProperty("seriesIds")] public List<string> SeriesIds { get; set; } = [];
}
