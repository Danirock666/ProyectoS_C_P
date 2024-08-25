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

        public Form1()
        {
            InitializeComponent();
            dataGridView2 = new DataGridView();

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

        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
