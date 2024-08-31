using ProyectoS_C_P.http;
using ProyectoS_C_P.modelos; // Asegúrate de tener la clase Tarea en este namespace
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProyectoS_C_P.servicios
{
    internal class TareaServicio : ConexionAApi
    {
        private readonly string taskKey = "/task";

        // Método para obtener la lista de tareas (Index)
        public async Task<List<Tarea>> Index()
        {
            List<Tarea> taskList = null;
            string path = $"/tasks{taskKey}";
            string body = "";

            try
            {
                var response = await SendTransaction(path, body, "GET");
                RespuestaListaDeTareas respuestaApi = JsonSerializer.Deserialize<RespuestaListaDeTareas>(response.Data.ToString());
                taskList = respuestaApi.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return taskList;
        }

        // Método para obtener una tarea específica por ID (Show)
        public async Task<Tarea> Show(int taskId)
        {
            Tarea task = null;
            string path = $"/tasks/{taskId}{taskKey}";
            string body = "";

            try
            {
                var jsonRespuestaApi = await SendTransaction(path, body, "GET");
                RespuestaTarea respuestaApi = JsonSerializer.Deserialize<RespuestaTarea>(jsonRespuestaApi.Data.ToString());
                task = respuestaApi.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return task;
        }

        // Método para crear una nueva tarea (Create)
        public async Task<string> Create(object newTask)
        {
            string respuestaApi = null;
            string path = $"/tasks{taskKey}";

            try
            {
                string taskJson = JsonSerializer.Serialize(newTask);
                var jsonRespuestaApi = await SendTransaction(path, taskJson, "POST");

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

        // Método para actualizar una tarea existente (Update)
        public async Task<string> Update(int taskId, object updatedTask)
        {
            string respuestaApi = null;
            string path = $"/tasks/{taskId}{taskKey}";

            try
            {
                string taskJson = JsonSerializer.Serialize(updatedTask);
                var jsonRespuestaApi = await SendTransaction(path, taskJson, "PUT");

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

        // Método para eliminar una tarea existente (Delete)
        public async Task<string> Delete(int taskId)
        {
            string respuestaApi = null;
            string path = $"/tasks/{taskId}{taskKey}";

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
