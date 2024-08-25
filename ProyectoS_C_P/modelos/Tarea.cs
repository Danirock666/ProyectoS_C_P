using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProyectoS_C_P.modelos
{
    public class Tarea
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }
        
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("start_date")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("Hours")]
        public string Hours { get; set; }

        [JsonPropertyName("area")]
        public string Area { get; set; }

        [JsonPropertyName("proyect_id")]
        public int ProyectId { get; set; }

        [JsonPropertyName("user_id")]
        public int UserId { get; set; }


    }
    
}
