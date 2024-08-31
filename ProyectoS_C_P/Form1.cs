using ProyectoS_C_P.modelos;
using ProyectoS_C_P.services;
using ProyectoS_C_P.servicios;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoS_C_P
{
    public partial class Form1 : Form
    {
        ProyectoServicio projectService = new ProyectoServicio();
        List<Proyecto> proyectos = new List<Proyecto>(); //se llena al recibir la respuesta de la API
        Proyecto proyecto = new Proyecto(); //se llena al recibir la respuesta de la API

        List<Usuario> usuarios = new List<Usuario>();
        Usuario usuario = new Usuario();

        TareaServicio tareaService = new TareaServicio();
        List<Tarea> tareas = new List<Tarea>();
        Tarea tarea = new Tarea();
        
        DataGridViewComboBoxColumn comboBoxColumnPro;
        public Form1()
        {
            InitializeComponent();
            InicializarDataGridView();
            tablaProyecto.CellValueChanged += tablaProyecto_CellClick;
            tablaTarea.CellValueChanged += tablaTarea_CellClick;
            tablaProyecto.DataError += tablaProyecto_DataError;
            tablaProyecto.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (tablaProyecto.CurrentCell is DataGridViewComboBoxCell)
                {
                    tablaProyecto.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            };
            tablaTarea.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (tablaTarea.CurrentCell is DataGridViewComboBoxCell)
                {
                    tablaTarea.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                // Obtener todos los proyectos
                proyectos = await projectService.Index();

                // Obtener un proyecto por su ID
                proyecto = await projectService.Show(1);

                // Crear un nuevo proyecto
                var nuevoProyecto = new
                {
                    name = "Este es el nombre del nuevo proyecto",
                    description = "Esta es la descripción del nuevo proyecto",
                    status = "pendiente",
                    totalHours = 100,
                    created_at = "2024-10-01"
                };

                // Se debe serializar el objeto anónimo a JSON para enviarlo a la API
                var proyectoCreado = await projectService.Create(nuevoProyecto);

                MessageBox.Show(proyectoCreado);
            });

            Task.Run(async () =>
            {
                tareas = await tareaService.Index();
                tarea = await tareaService.Show(1);

                var nuevaTarea = new
                {
                    description = "Descripción de la tarea",
                    start_date = "2023-10-01",
                    status = "Pendiente",
                    hours = 5,
                    area = "Redes",
                    project_id = 1,
                    user_id = 1
                };

                var tareaCreada = await tareaService.Create(nuevaTarea);

                MessageBox.Show(tareaCreada);
                ActualizarDataGridView(); // Actualizar la vista con las tareas cargadas
            });
        }

        private void ButtonIngresarPro_Click(object sender, EventArgs e)
        {
            Proyecto objetoProyecto = new Proyecto
            {
                Id = 1,
                Name = textBoxNombre.Text,
                Description = textBoxDescripcion.Text,
                Status = "Pending", // Estado predeterminado si no se selecciona desde el DataGridView
                TotalHours = (int)numericUpDown1.Value,
                CreatedAt = DateTime.Now
            };
            proyectos.Add(objetoProyecto);
            ActualizarDataGridView();
        }

        private void ButtonIngresarTar_Click(object sender, EventArgs e)
        {
            Tarea objetoTarea = new Tarea
            {
                Id = 1,
                Description = textBoxDescriptionTarea.Text,
                StartDate = DateTime.Now,
                Status = "Pending",
                Hours = (int)numericUpDown2.Value,
                Area = comboBoxArea.Text,
                ProyectId = 1,
                UserId = 1
            };
            tareas.Add(objetoTarea);
            ActualizarDataGridView();
        }

        private void InicializarDataGridView()
        {
            // Inicialización del DataGridView de Proyectos
            tablaProyecto.Columns.Add("Id", "Id");
            tablaProyecto.Columns.Add("Name", "Name");
            tablaProyecto.Columns.Add("Description", "Description");

            DataGridViewComboBoxColumn comboBoxColumnPro = new DataGridViewComboBoxColumn
            {
                HeaderText = "Status",
                Name = "comboBoxStatusColumn"
            };
            comboBoxColumnPro.Items.AddRange(new string[] { "Pendiente", "En Progreso", "Completado" });
            tablaProyecto.Columns.Add(comboBoxColumnPro);

            tablaProyecto.Columns.Add("TotalHours", "Total Hours");
            tablaProyecto.Columns.Add("CreatedAT", "Created AT");

            // Columna de botón de editar en Proyecto
            DataGridViewButtonColumn EditarColumnaPro = new DataGridViewButtonColumn
            {
                Name = "Editar",
                HeaderText = "Editar",
                Text = "Editar",
                UseColumnTextForButtonValue = true
            };
            tablaProyecto.Columns.Add(EditarColumnaPro);

            // Columna de botón de eliminar en Proyecto
            DataGridViewButtonColumn EliminarColumnaPro = new DataGridViewButtonColumn
            {
                Name = "Eliminar",
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };
            tablaProyecto.Columns.Add(EliminarColumnaPro);

            // Columna de botón de actualizar en Proyecto
            DataGridViewButtonColumn ActualizarColumnaPro = new DataGridViewButtonColumn
            {
                Name = "Actualizar",
                HeaderText = "Actualizar",
                Text = "Actualizar",
                UseColumnTextForButtonValue = true
            };
            tablaProyecto.Columns.Add(ActualizarColumnaPro);

            tablaProyecto.CellClick += tablaProyecto_CellClick;

            // Inicialización del DataGridView de Tareas
            tablaTarea.Columns.Add("Id", "Id");
            tablaTarea.Columns.Add("Description", "Description");
            tablaTarea.Columns.Add("StarDate", "Star Date");

            DataGridViewComboBoxColumn comboBoxColumnTar = new DataGridViewComboBoxColumn
            {
                HeaderText = "Status",
                Name = "comboBoxStatusColumn"
            };
            comboBoxColumnTar.Items.AddRange(new string[] { "Pendiente", "En Progreso", "Completado" });
            tablaTarea.Columns.Add(comboBoxColumnTar);

            tablaTarea.Columns.Add("Hours", "Hours");
            tablaTarea.Columns.Add("Area", "Area");
            tablaTarea.Columns.Add("ProyectId", "Proyect Id");
            tablaTarea.Columns.Add("UserId", "User Id");

            // Columna de botón de editar en Tareas
            DataGridViewButtonColumn EditarColumnaTar = new DataGridViewButtonColumn
            {
                Name = "Editar",
                HeaderText = "Editar",
                Text = "Editar",
                UseColumnTextForButtonValue = true
            };
            tablaTarea.Columns.Add(EditarColumnaTar);

            // Columna de botón de eliminar en Tareas
            DataGridViewButtonColumn EliminarColumnaTar = new DataGridViewButtonColumn
            {
                Name = "Eliminar",
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };
            tablaTarea.Columns.Add(EliminarColumnaTar);

            // Columna de botón de actualizar en Tareas
            DataGridViewButtonColumn ActualizarColumnaTar = new DataGridViewButtonColumn
            {
                Name = "Actualizar",
                HeaderText = "Actualizar",
                Text = "Actualizar",
                UseColumnTextForButtonValue = true
            };
            tablaTarea.Columns.Add(ActualizarColumnaTar);

            tablaTarea.CellClick += tablaTarea_CellClick;
        }

        private void tablaProyecto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tablaProyecto.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    var confirmResult = MessageBox.Show("¿Está seguro que desea eliminar el proyecto?",
                                                         "Confirmar Eliminación",
                                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        proyectos.RemoveAt(e.RowIndex);
                        ActualizarDataGridView();
                    }
                }
                else if (tablaProyecto.Columns[e.ColumnIndex].Name == "Editar")
                {
                    Proyecto proyecto = proyectos[e.RowIndex];

                    textBoxNombre.Text = proyecto.Name;
                    textBoxDescripcion.Text = proyecto.Description;
                    numericUpDown1.Value = proyecto.TotalHours;

                    proyectos.RemoveAt(e.RowIndex);
                    ActualizarDataGridView();
                }
                else if (tablaProyecto.Columns[e.ColumnIndex].Name == "Actualizar")
                {
                    Proyecto proyecto = proyectos[e.RowIndex];

                    proyecto.Name = textBoxNombre.Text;
                    proyecto.Description = textBoxDescripcion.Text;
                    proyecto.TotalHours = (int)numericUpDown1.Value;
                    // Actualizar cualquier otro campo relevante aquí...

                    ActualizarDataGridView();
                }
            }
        }

        private void tablaTarea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tablaTarea.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    var confirmResult = MessageBox.Show("¿Está seguro que desea eliminar la tarea?",
                                                         "Confirmar Eliminación",
                                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        tareas.RemoveAt(e.RowIndex);
                        ActualizarDataGridView();
                    }
                }
                else if (tablaTarea.Columns[e.ColumnIndex].Name == "Editar")
                {
                    Tarea tarea = tareas[e.RowIndex];

                    textBoxDescriptionTarea.Text = tarea.Description;
                    numericUpDown2.Value = tarea.Hours;
                    comboBoxArea.Text = tarea.Area;

                    tareas.RemoveAt(e.RowIndex);
                    ActualizarDataGridView();
                }
                else if (tablaTarea.Columns[e.ColumnIndex].Name == "Actualizar")
                {
                    Tarea tarea = tareas[e.RowIndex];

                    tarea.Description = textBoxDescriptionTarea.Text;
                    tarea.Hours = (int)numericUpDown2.Value;
                    tarea.Area = comboBoxArea.Text;
                    // Actualizar cualquier otro campo relevante aquí...

                    ActualizarDataGridView();
                }
            }
        }

        private void ActualizarDataGridView()
        {
            tablaProyecto.Rows.Clear();
            tablaTarea.Rows.Clear();

            foreach (var proyecto in proyectos)
            {
                // Asegúrate de que el estado es válido antes de añadirlo al DataGridViewA
                var status = (proyecto.Status == "Pendiente" || proyecto.Status == "En Progreso" || proyecto.Status == "Completado")
              ? proyecto.Status
              : "Pendiente";


                tablaProyecto.Rows.Add(proyecto.Id, proyecto.Name, proyecto.Description, status, proyecto.TotalHours, proyecto.CreatedAt.ToShortDateString());
            }

            foreach (var tarea in tareas)
            {
                tablaTarea.Rows.Add(tarea.Id, tarea.Description, tarea.StartDate.ToShortDateString(), tarea.Status, tarea.Hours, tarea.Area, tarea.ProyectId, tarea.UserId);
            }
        }

        private void tablaProyecto_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is ArgumentException && tablaProyecto.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                MessageBox.Show($"El valor de la celda no es válido. Se usará 'Pendiente' como valor predeterminado.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tablaProyecto.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Pendiente"; // Valor predeterminado
            }
            else
            {
                MessageBox.Show($"Error al procesar los datos: {e.Exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            e.ThrowException = false;
        }

        private void tablaTarea_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is ArgumentException && tablaTarea.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                MessageBox.Show($"El valor de la celda no es válido. Se usará 'Pendiente' como valor predeterminado.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tablaTarea.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Pendiente"; // Valor predeterminado
            }
            else
            {
                MessageBox.Show($"Error al procesar los datos: {e.Exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            e.ThrowException = false;
        }
    }
}
