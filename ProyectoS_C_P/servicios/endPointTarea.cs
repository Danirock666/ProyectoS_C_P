using ProyectoS_C_P.http;
using ProyectoS_C_P.modelos; // Asegúrate de tener la clase Tarea en este namespace
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProyectoS_C_P.servicios
{
    internal class EndPointTarea : ConexionAApi
    {
        private readonly string taskKey = "/task";

        // Method to get a list of tasks (Index)
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

        // Method to get a specific task by ID (Show)
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

        // Method to create a new task (Create)
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

        // Method to update an existing task (Update)
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

        // Method to delete an existing task (Delete)
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
