using ProyectoS_C_P.http;
using ProyectoS_C_P.modelos;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProyectoS_C_P.services
{
    public class ProyectoServicio : ConexionAApi
    {
        private readonly string groupKey = "/ejemplo";

        public async Task<List<Proyecto>> Index()
        {
            RespuestaListaDeProyectos respuestaApi;
            try
            {
                string path = $"/projects{groupKey}";
                string body = "";
                var response = await SendTransaction(path, body, "GET");
                string jsonRespuestaApi = response.Data.ToString();
                respuestaApi = JsonSerializer.Deserialize<RespuestaListaDeProyectos>(jsonRespuestaApi);

                if (respuestaApi.Code != 200)
                {
                    // Manejo de error si es necesario
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi.Data;
        }

        public async Task<Proyecto> Show(int projectId)
        {
            string path = $"/projects/{projectId}{groupKey}";
            string body = "";
            var jsonRespuestaApi = await SendTransaction(path, body, "GET");
            RespuestaProyecto RespuestaApi = JsonSerializer.Deserialize<RespuestaProyecto>(jsonRespuestaApi.Data.ToString());

            return RespuestaApi.Data;
        }

        public async Task<string> Create(object nuevoProyecto)
        {
            string respuestaApi = null;
            string path = $"/projects{groupKey}";

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
            string path = $"/projects/{projectId}{groupKey}";

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
            string path = $"/projects/{projectId}{groupKey}";

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
