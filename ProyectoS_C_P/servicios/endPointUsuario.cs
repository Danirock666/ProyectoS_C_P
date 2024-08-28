using ProyectoS_C_P.http;
using ProyectoS_C_P.modelos;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProyectoS_C_P.servicios
{
    internal class endPointUsuario : ConexionAApi
    {
        private readonly string e5F6g9H8 = "/e5F6g9H8";

        // Método para obtener un usuario específico por ID
        public async Task<Usuario> Get(int userId)
        {
            Usuario usuario = null;
            string path = $"/users/{userId}{e5F6g9H8}";
            string body = "";

            try
            {
                var jsonRespuestaApi = await SendTransaction(path, body, "GET");
                RespuestaUsuario RespuestaApi = JsonSerializer.Deserialize<RespuestaUsuario>(jsonRespuestaApi.Data.ToString());
                usuario = RespuestaApi.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return usuario;
        }
    }
}
