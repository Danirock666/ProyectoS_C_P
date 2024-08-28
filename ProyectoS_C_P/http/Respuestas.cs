using ProyectoS_C_P.modelos;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ProyectoS_C_P.http
{
    public class RespuestaBase<T>
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("data")]
        public T Data { get; set; }
    }

    public class RespuestaApi : RespuestaBase<object>
    {
    }

    public class RespuestaListaDeProyectos : RespuestaBase<List<Proyecto>>
    {
    }

    public class RespuestaProyecto : RespuestaBase<Proyecto>
    {
    }

    public class RespuestaCreacionProyecto : RespuestaBase<Proyecto>
    {
    }

    // Clase para manejar la respuesta de una lista de usuarios
    public class RespuestaListaDeUsuarios : RespuestaBase<List<Usuario>>
    {
    }

    // Clase para manejar la respuesta de un solo usuario
    public class RespuestaUsuario : RespuestaBase<Usuario>
    {
    }
    public class RespuestaListaDeTareas : RespuestaBase<List<Tarea>>
    {
    }

    // Clase para manejar la respuesta de una sola tarea
    public class RespuestaTarea : RespuestaBase<Tarea>
    {
    }

    // Clase para manejar la respuesta de la creación de una tarea
    public class RespuestaCreacionTarea : RespuestaBase<Tarea>
    {
    }
}