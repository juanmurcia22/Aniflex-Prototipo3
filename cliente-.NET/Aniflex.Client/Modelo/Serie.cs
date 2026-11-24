using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Aniflex.Client.Modelo
{
    public class Serie
    {
        [JsonProperty("codigo")] public string Codigo { get; set; } = "";
        [JsonProperty("estudioId")] public string? EstudioId { get; set; }
        [Newtonsoft.Json.JsonIgnore, System.ComponentModel.Browsable(false)]
        public string Etiqueta => $"{Codigo} — {Titulo}";
        public override string ToString() => Etiqueta;
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("titulo")] public string Titulo { get; set; }
        [JsonProperty("temporadas")] public int Temporadas { get; set; }
        [JsonProperty("calificacion")] public double Calificacion { get; set; }
        [JsonProperty("fechaEstreno")] public string FechaEstreno { get; set; }
        [JsonProperty("enEmision")] public bool EnEmision { get; set; }
    }

}
