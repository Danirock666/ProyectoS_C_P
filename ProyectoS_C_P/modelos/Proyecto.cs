using System;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace ProyectoS_C_P.modelos
{
    public class Proyecto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("totalHours")]
        public int TotalHours { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

       
    }
}
