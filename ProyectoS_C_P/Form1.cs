namespace ProyectoS_C_P
{
    public partial class Form1 : Form
    {
        private List<Proyecto> ProyectoList = new List<Proyecto>();
        private List<Usuario> UsuarioList = new List<Usuario>();
        private List<Tarea> TareaList = new List<Tarea>();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proyecto objetoproyecto = new();

            objetoproyecto.Nombre = TextBoxNamePro.Text;
            objetoproyecto.Descripcion = ListBoxProyect.Text;
            objetoproyecto.Estado = CheckBoxFin.Checked;
            objetoproyecto.HorasTrabajadas = (int)numericUpDown1.Value;
            objetoproyecto.HorasTotales = (int)numericUpDown2.Value;
            objetoproyecto.FechaCreacion = dateTime.Value;

            ProyectoList.Add(objetoproyecto);

            ActualizardataGridView2();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxProyect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
