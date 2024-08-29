using ProyectoS_C_P.http;
using ProyectoS_C_P.modelos;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ProyectoS_C_P.servicios
{
    internal class endPointUsuario : ConexionAApi
    {
        private readonly string e5F6g9H8 = "/e5F6g9H8";

        // Método para obtener la lista de usuarios
        public async Task<List<Usuario>> Index()
        {
            List<Usuario> usuarios = null;
            string path = $"/users{e5F6g9H8}";
            string body = "";

            try
            {
                var jsonRespuestaApi = await SendTransaction(path, body, "GET");
                RespuestaListaDeUsuarios RespuestaApi = JsonSerializer.Deserialize<RespuestaListaDeUsuarios>(jsonRespuestaApi.Data.ToString());
                usuarios = RespuestaApi.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return usuarios;
        }
    }
}
