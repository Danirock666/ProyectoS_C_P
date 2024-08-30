using ProyectoS_C_P.modelos;
using ProyectoS_C_P.services;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProyectoS_C_P
{
    public partial class Form1 : Form
    {
        ProyectoServicio projectService = new ProyectoServicio();
        List<Proyecto> proyectos = new List<Proyecto>(); //se llena al recibir la respuesta de la API
        Proyecto proyecto = new Proyecto(); //se llena al recibir la respuesta de la API

        List<Usuario> usuarios = new List<Usuario>();
        Usuario usuario = new Usuario();

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
        }

        private void ButtonIngresarPro_Click(object sender, EventArgs e)
        {
            Proyecto objetoProyecto = new Proyecto
            {
                Name = textBoxNombre.Text,
                Description = textBoxDescripcion.Text,
                Status = "Pending", // Estado predeterminado si no se selecciona desde el DataGridView
                TotalHours = (int)numericUpDown1.Value,
                CreatedAt = DateTime.Now
            };

            proyectos.Add(objetoProyecto);
            ActualizarDataGridView();
        }

        // Aquí se inicia el DataGridView (tablaProyecto)
        private void InicializarDataGridView()
        {
            tablaProyecto.Columns.Add("Id", "Id");
            tablaProyecto.Columns.Add("Name", "Name");
            tablaProyecto.Columns.Add("Description", "Description");

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Status",
                Name = "comboBoxStatusColumn"
            };
            comboBoxColumn.Items.AddRange(new string[] { "Pendiente", "En Progreso", "Completado" });
            tablaProyecto.Columns.Add(comboBoxColumn);

            tablaProyecto.Columns.Add("TotalHours", "Total Hours");
            tablaProyecto.Columns.Add("CreatedAT", "Created AT");

            // Crear y agregar la columna de botón de editar
            DataGridViewButtonColumn EditarColumna = new DataGridViewButtonColumn();
            EditarColumna.Name = "Editar";
            EditarColumna.HeaderText = "Editar";
            EditarColumna.Text = "Editar";
            EditarColumna.UseColumnTextForButtonValue = true;
            tablaProyecto.Columns.Add(EditarColumna);

            // añadir columnas de botones eliminar
            DataGridViewButtonColumn EliminarColumna = new DataGridViewButtonColumn();
            EliminarColumna.Name = "Eliminar";
            EliminarColumna.HeaderText = "Eliminar";
            EliminarColumna.Text = "Eliminar";
            EliminarColumna.UseColumnTextForButtonValue = true;
            tablaProyecto.Columns.Add(EliminarColumna);

            DataGridViewButtonColumn ActualizarColumna = new DataGridViewButtonColumn();
            ActualizarColumna.Name = "Actualizar";
            ActualizarColumna.HeaderText = "Actualizar";
            ActualizarColumna.Text = "Actualizar";
            ActualizarColumna.UseColumnTextForButtonValue = true;
            tablaProyecto.Columns.Add(ActualizarColumna);


            tablaProyecto.CellClick += tablaProyecto_CellClick;
        }

        private void tablaProyecto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tablaProyecto.Columns[e.ColumnIndex].Name == "Eliminar")
                {

                    // Muestra un mensaje de confirmación antes de eliminar
                    var confirmResult = MessageBox.Show("¿Está seguro que desea eliminar el Nombre?",
                                                         "Confirmar Eliminación",
                                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)

                        //rescata el row index de la fila seleccionada y elimina el proyecto que corresponde a esa fila
                        proyectos.RemoveAt(e.RowIndex);
                    //actualiza el grid
                    ActualizarDataGridView();
                }
                else if (tablaProyecto.Columns[e.ColumnIndex].Name == "Editar")
                {
                    var confirmResult = MessageBox.Show("¿Estás seguro que deseas editar este Proyecto?",
                                                        "Confirmar Edición",
                                                        MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        var proyecto = proyectos[e.RowIndex];

                        textBoxNombre.Text = proyecto.Name;
                        textBoxDescripcion.Text = proyectos[e.RowIndex].Description;
                        int totalHours = proyectos[e.RowIndex].TotalHours;
                        numericUpDown1.Value = totalHours;

                        // Eliminar el PROYECTO de la lista
                        proyectos.RemoveAt(e.RowIndex);

                        // Actualizar el DataGridView
                        ActualizarDataGridView();
                    }
                }
            }
            // Actualización de tablaProyecto

        }
        private void ActualizarDataGridView()
            {
                tablaProyecto.Rows.Clear();

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


        
    }
}

