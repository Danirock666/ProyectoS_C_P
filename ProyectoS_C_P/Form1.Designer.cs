namespace ProyectoS_C_P
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            tablaProyecto = new DataGridView();
            textBoxNombre = new TextBox();
            label3 = new Label();
            ButtonIngresarPro = new Button();
            textBoxDescripcion = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            ButtonIngresarTar = new Button();
            textBox3 = new TextBox();
            numericUpDown2 = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablaProyecto).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tablaProyecto);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ButtonIngresarPro);
            panel1.Controls.Add(textBoxDescripcion);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 501);
            panel1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(136, 155);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(45, 27);
            numericUpDown1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(44, 162);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 7;
            label4.Text = "Hora Total:";
            // 
            // tablaProyecto
            // 
            tablaProyecto.BackgroundColor = Color.Gray;
            tablaProyecto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProyecto.GridColor = Color.White;
            tablaProyecto.Location = new Point(36, 224);
            tablaProyecto.Name = "tablaProyecto";
            tablaProyecto.RowHeadersWidth = 51;
            tablaProyecto.RowTemplate.Height = 29;
            tablaProyecto.Size = new Size(943, 237);
            tablaProyecto.TabIndex = 6;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(134, 70);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(257, 27);
            textBoxNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(59, 77);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // ButtonIngresarPro
            // 
            ButtonIngresarPro.BackColor = Color.Black;
            ButtonIngresarPro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonIngresarPro.ForeColor = Color.White;
            ButtonIngresarPro.Location = new Point(470, 174);
            ButtonIngresarPro.Name = "ButtonIngresarPro";
            ButtonIngresarPro.Size = new Size(94, 29);
            ButtonIngresarPro.TabIndex = 3;
            ButtonIngresarPro.Text = "INGRESAR";
            ButtonIngresarPro.UseVisualStyleBackColor = false;
            ButtonIngresarPro.Click += ButtonIngresarPro_Click;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(134, 113);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(257, 27);
            textBoxDescripcion.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(36, 120);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripcion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(194, 18);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 0;
            label1.Text = "PROYECTOS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(ButtonIngresarTar);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(numericUpDown2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(12, 542);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 486);
            panel2.TabIndex = 1;
            // 
            // ButtonIngresarTar
            // 
            ButtonIngresarTar.BackColor = Color.Black;
            ButtonIngresarTar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonIngresarTar.ForeColor = Color.White;
            ButtonIngresarTar.Location = new Point(470, 166);
            ButtonIngresarTar.Name = "ButtonIngresarTar";
            ButtonIngresarTar.Size = new Size(94, 29);
            ButtonIngresarTar.TabIndex = 12;
            ButtonIngresarTar.Text = "INGRESAR";
            ButtonIngresarTar.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 81);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(257, 27);
            textBox3.TabIndex = 11;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(134, 133);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(45, 27);
            numericUpDown2.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(76, 133);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 9;
            label7.Text = "Horas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(36, 88);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 8;
            label6.Text = "Descripcion:";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Gray;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = Color.White;
            dataGridView2.Location = new Point(33, 218);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(943, 237);
            dataGridView2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(222, 27);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 0;
            label5.Text = "TAREAS";
            // 
            // Form1
            // 
            BackColor = Color.Black;
            ClientSize = new Size(1042, 1055);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablaProyecto).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Label label1;
        private Button ButtonIngresarPro;
        private TextBox textBoxDescripcion;
        private Label label2;
        private TextBox textBoxNombre;
        private Label label3;
        private DataGridView tablaProyecto;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private Panel panel2;
        private DataGridView dataGridView2;
        private Label label5;
        private Label label7;
        private Label label6;
        private Button ButtonIngresarTar;
        private TextBox textBox3;
        private NumericUpDown numericUpDown2;
    }
}
#endregion