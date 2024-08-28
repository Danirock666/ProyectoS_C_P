using ProyectoS_C_P.http;
using ProyectoS_C_P.modelos;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProyectoS_C_P.services
{
    public class ProyectoServicio : ConexionAApi
    {
        private readonly string e5F6g9H8 = "/e5F6g9H8";

        // Método para obtener la lista de proyectos 
        public async Task<List<Proyecto>> Index()
        {
            //declarar una variable para almacenar la respuesta de la API
            //la variable debe ser del tipo de la respuesta esperada
            //en este caso, la respuesta es una lista de proyectos
            RespuestaListaDeProyectos respuestaApi;
            try
            {
                string path = $"/projects{e5F6g9H8}";
                string body = "";
                var response = await SendTransaction(path, body, "GET");

                // Convertir Data a cadena JSON
                string jsonRespuestaApi = response.Data.ToString();

                // Deserializar la respuesta de la API a un objeto de tipo RespuestaListaDeProyectos          
                respuestaApi = JsonSerializer.Deserialize<RespuestaListaDeProyectos>(jsonRespuestaApi);

                /* Aquí podrías validar si hay algun error con la respuesta según su código*/
                if (respuestaApi.Code != 200)
                {
                    /* cualquier cosa que quieras hacer pa mostrar el error*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi.Data;
        }

        // Método para obtener un proyecto específico por ID (Read)
        public async Task<Proyecto> Show(int projectId)
        {
            Proyecto proyecto = null;
            string path = $"/projects/{projectId}{e5F6g9H8}";
            string body = "";

            try
            {
                var jsonRespuestaApi = await SendTransaction(path, body, "GET");
                RespuestaProyecto RespuestaApi = JsonSerializer.Deserialize<RespuestaProyecto>(jsonRespuestaApi.Data.ToString());
                proyecto = RespuestaApi.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return proyecto;
        }

        public async Task<string> Create(object nuevoProyecto)
        {
            string respuestaApi = null;
            string path = $"/projects{e5F6g9H8}";

            try
            {
                string proyectoJson = JsonSerializer.Serialize(nuevoProyecto);
                var jsonRespuestaApi = await SendTransaction(path, proyectoJson, "POST");

                if (jsonRespuestaApi.Code == 201)
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return respuestaApi;
        }

        public async Task<string> Update(int projectId, object proyectoActualizado)
        {
            string respuestaApi = null;
            string path = $"/projects/{projectId}{e5F6g9H8}";

            try
            {
                string proyectoJson = JsonSerializer.Serialize(proyectoActualizado);
                var jsonRespuestaApi = await SendTransaction(path, proyectoJson, "PUT");

                if (jsonRespuestaApi.Code == 200)
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return respuestaApi;
        }

        public async Task<string> Delete(int projectId)
        {
            string respuestaApi = null;
            string path = $"/projects/{projectId}{e5F6g9H8}";

            try
            {
                var jsonRespuestaApi = await SendTransaction(path, string.Empty, "DELETE");

                if (jsonRespuestaApi.Code == 200)
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return respuestaApi;
        }
    }
}

