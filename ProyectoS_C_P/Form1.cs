using ProyectoS_C_P.modelos;
using ProyectoS_C_P.services;
using System.Text.Json;
using System.Threading.Tasks;


namespace ProyectoS_C_P
{
    public partial class Form1 : Form
    {
        ProyectoServicio projectService = new ProyectoServicio();
        List<Proyecto> proyectos = new List<Proyecto>(); //se llena  al recibir la respuesta de la API
        Proyecto proyecto = new Proyecto();//se llena al recibir la respuesta de la API


        List<Usuario> usuarios = new List<Usuario>();
        Usuario usuario = new Usuario();


        List<Tarea> tareas = new List<Tarea>();
        Tarea tarea = new Tarea();


        public Form1()
        {
            InitializeComponent();
            InicializarDataGridView();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                //Obtener todos los proyectos
                proyectos = await projectService.Index();
                //MessageBox.Show(proyectos.Count.ToString());

                // Obtener un proyecto por su ID
                proyecto = await projectService.Show(1);
                //MessageBox.Show(proyecto.Name);

                // Crear un nuevo proyecto.
                // primero se debe crear un objeto anónimo con los datos del nuevo proyecto
                var nuevoProyecto = new
                {
                    name = "Este es el nombre del nuevo proyecto",
                    description = "Esta es la descripción del nuevo proyecto",
                    status = "pendiente",
                    totalHours = 100,
                    //no es necesario enviar el id ni las horas de trabajo, ya que se asignan automáticamente en la API
                    created_at = "2024-10-01"
                };

                //se debe serializar el objeto anónimo a JSON para enviarlo a la API
                var proyectoCreado = await projectService.Create(nuevoProyecto);
                
               // MessageBox.Show()
                 //debería mostrar el mensaje de la API

            });
        }
        private void AgregarProButton_Click(object sender, EventArgs e)
        {
            Proyecto proyecto = new();

            proyecto.Id = 1;
            proyecto.Name = TextBoxNamePro.Text;
            proyecto.Description = TextBoxDescription.Text;
            proyecto.Status = ComboBoxStatus.SelectedItem.ToString();

            proyecto.TotalHours = (int)NumericUpDownHorasTotales.Value;

            proyecto.TotalHours = (string)NumericUpDownHorasTotales.ProductVersion;


            proyecto.TotalHours = (string)NumericUpDownHorasTotales.ProductVersion;

            DateTime @new = System.DateTime.Now;
            proyecto.CreatedAt = @new;

            proyectos.Add(proyecto);
            ActualizarDataCridView();
        }
        private void AgregarUsuButton_Click(object sender, EventArgs e)
        {
            Usuario usuario = new();

            usuario.Name = TextBoxUsu.Text;

            usuarios.Add(usuario);
            ActualizarDataCridView();
        }
        private void IngresarTareaButton_Click(object sender, EventArgs e)
        {
            Tarea tarea = new();

            tarea.Description = TextBoxDescription2.Text;
            DateTime @new = System.DateTime.Now;
            tarea.StartDate = @new;
            tarea.Status = ComboBoxStatus2.SelectedItem.ToString();
            tarea.Hours = (int)numericUpDown3.Value;
            tarea.Area = ComboBoxArea.SelectedItem.ToString();

            tareas.Add(tarea);

            ActualizarDataCridView();


        }

        private void InicializarDataGridView()
        {

            dataGridViewProyecto.Columns.Add("Name", "Name");
            dataGridViewProyecto.Columns.Add("Description", "Description");

            // Crear un DataGridViewComboBoxColumn para la columna Status
            var statusColumn = new DataGridViewComboBoxColumn();
            statusColumn.Name = "Status";
            statusColumn.HeaderText = "Status";
            statusColumn.Items.AddRange("Not Started", "In Progress", "Completed"); // Agrega los estados posibles
            dataGridViewProyecto.Columns.Add(statusColumn);

            dataGridViewProyecto.Columns.Add("TotalHours", "Total Hours");
            dataGridViewProyecto.Columns.Add("CreatedAt", "Created At");

            dataGridView2.Columns.Add("Name", "Name");
            dataGridView2.Columns.Add("Description", "Description");
            dataGridView2.Columns.Add("StarDate", "Star Date");
            dataGridView2.Columns.Add("Status", "Status");
            dataGridView2.Columns.Add("Hours", "Hours");
            dataGridView2.Columns.Add("Area", "Area");
        }
        private void ActualizarDataCridView()
        {

            dataGridViewProyecto.Rows.Clear();

            foreach (var Proyecto in proyectos)
            {

                dataGridViewProyecto.Rows.Add(Proyecto.Name, Proyecto.Description,
                Proyecto.Status, Proyecto.TotalHours, Proyecto.CreatedAt.ToShortDateString());
            }

            dataGridView2.Rows.Clear();

            foreach (var Usuario in usuarios) 
            {

                dataGridView2.Rows.Add(Usuario.Name);
            }

            dataGridView2.Rows.Clear();

            foreach(var Tarea in tareas) 
            {
                
                dataGridView2.Rows.Add(Tarea.Description, Tarea.StartDate.ToShortDateString(),
                    Tarea.Status, Tarea.Hours, Tarea.Area);
            
            }

            
        }
        //Codigo que no se borra si se borra afecta al diseño
        private void NumericUpDownHorasTotal_ValueChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label15_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void checkBox3_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox4_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox6_CheckedChanged(object sender, EventArgs e) { }
        private void groupBox3_Enter(object sender, EventArgs e) { }
        private void checkBox7_CheckedChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void ListBoxProyect_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        
    }
}
