using ProyectoS_C_P.modelos;
using ProyectoS_C_P.services;
using ProyectoS_C_P.servicios;
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

        public Form1()
        {
            InitializeComponent();
            InicializarDataGridView();
            tablaProyecto.CellValueChanged += tablaProyecto_CellClick;
            tablaProyecto.CurrentCellDirtyStateChanged += (s, e) =>
            {
                // Asegúrate de que el valor cambie cuando el estado cambie en la columna del ComboBox
                if (tablaProyecto.CurrentCell is DataGridViewComboBoxCell)
                {
                    tablaProyecto.CommitEdit(DataGridViewDataErrorContexts.Commit);
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
        // Aquí se inicia el DataGridView (tablaProyecto)
        private void InicializarDataGridView()
        {
            //aqui empieza la iniciacion del DataGridView de Proyectos
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

            // Crear y agregar la columna de botón de editar en Proyecto
            DataGridViewButtonColumn EditarColumnaPro = new DataGridViewButtonColumn();
            EditarColumnaPro.Name = "Editar";
            EditarColumnaPro.HeaderText = "Editar";
            EditarColumnaPro.Text = "Editar";
            EditarColumnaPro.UseColumnTextForButtonValue = true;
            tablaProyecto.Columns.Add(EditarColumnaPro);

            // añadir columnas de botones eliminar en Proyecto
            DataGridViewButtonColumn EliminarColumnaPro = new DataGridViewButtonColumn();
            EliminarColumnaPro.Name = "Eliminar";
            EliminarColumnaPro.HeaderText = "Eliminar";
            EliminarColumnaPro.Text = "Eliminar";
            EliminarColumnaPro.UseColumnTextForButtonValue = true;
            tablaProyecto.Columns.Add(EliminarColumnaPro);

            // boton actualizar en Proyecto
            DataGridViewButtonColumn ActualizarColumnaPro = new DataGridViewButtonColumn();
            ActualizarColumnaPro.Name = "Actualizar";
            ActualizarColumnaPro.HeaderText = "Actualizar";
            ActualizarColumnaPro.Text = "Actualizar";
            ActualizarColumnaPro.UseColumnTextForButtonValue = true;
            tablaProyecto.Columns.Add(ActualizarColumnaPro);

            tablaProyecto.CellClick += tablaProyecto_CellClick;

            // aqui inicia el datagridview de tareas
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

            // Crear y agregar la columna de botón de editar en Tareas
            DataGridViewButtonColumn EditarColumnaTar = new DataGridViewButtonColumn();
            EditarColumnaTar.Name = "Editar";
            EditarColumnaTar.HeaderText = "Editar";
            EditarColumnaTar.Text = "Editar";
            EditarColumnaTar.UseColumnTextForButtonValue = true;
            tablaTarea.Columns.Add(EditarColumnaTar);

            // añadir columnas de botones eliminar en Tareas
            DataGridViewButtonColumn EliminarColumnaTar = new DataGridViewButtonColumn();
            EliminarColumnaTar.Name = "Eliminar";
            EliminarColumnaTar.HeaderText = "Eliminar";
            EliminarColumnaTar.Text = "Eliminar";
            EliminarColumnaTar.UseColumnTextForButtonValue = true;
            tablaTarea.Columns.Add(EliminarColumnaTar);

            // boton actualizar en Tareas
            DataGridViewButtonColumn ActualizarColumnaTar = new DataGridViewButtonColumn();
            ActualizarColumnaTar.Name = "Actualizar";
            ActualizarColumnaTar.HeaderText = "Actualizar";
            ActualizarColumnaTar.Text = "Actualizar";
            ActualizarColumnaTar.UseColumnTextForButtonValue = true;
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
        //tabla del datagridview configuraciones de botones 
        private void tablaTarea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tablaTarea.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    var confirmResult = MessageBox.Show("¿Está seguro que desea eliminar el proyecto?",
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

                    tareas.RemoveAt(e.RowIndex);
                    ActualizarDataGridView();
                }
                else if (tablaTarea.Columns[e.ColumnIndex].Name == "Actualizar")
                {
                    Tarea tarea = tareas[e.RowIndex];

                    tarea.Description = textBoxDescriptionTarea.Text;
                    tarea.Hours = (int)numericUpDown2.Value;
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
                tablaProyecto.Rows.Add(
                    proyecto.Id,
                    proyecto.Name,
                    proyecto.Description,
                    proyecto.Status,
                    proyecto.TotalHours,
                    proyecto.CreatedAt.ToShortDateString());
            }
                foreach (var tarea in tareas)
                {
                    tablaTarea.Rows.Add(
                        tarea.Id,
                        tarea.Description,
                        tarea.StartDate.ToShortDateString(),
                        tarea.Status,
                        tarea.Hours,
                        tarea.Area,
                        tarea.ProyectId,
                        tarea.UserId);
                }
            }

            private void tablaProyecto_CellValueChanged(object sender, DataGridViewCellEventArgs e)
            {
                if (e.ColumnIndex == tablaProyecto.Columns["comboBoxStatusColumn"].Index && e.RowIndex >= 0)
                {
                    Proyecto proyecto = proyectos[e.RowIndex];
                    proyecto.Status = tablaProyecto.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    ActualizarDataGridView();
                }
            }

            private void tablaTarea_CellValueChanged(object sender, DataGridViewCellEventArgs e)
            {
            if (e.ColumnIndex == tablaTarea.Columns["comboBoxStatusColumn"].Index && e.RowIndex >= 0)
            {
                Tarea tarea = tareas[e.RowIndex];
                tarea.Status = tablaTarea.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                ActualizarDataGridView();
         }
       }
     }
  }


