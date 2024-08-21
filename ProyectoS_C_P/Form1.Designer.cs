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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Descripcion = new ListBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            dateTimePicker2 = new DateTimePicker();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 16);
            label1.Name = "label1";
            label1.Size = new Size(177, 23);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Proyectos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 16);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(Descripcion);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(37, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 485);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(731, 385);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(731, 429);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(731, 338);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Descripcion
            // 
            Descripcion.BackColor = Color.Gray;
            Descripcion.FormattingEnabled = true;
            Descripcion.ItemHeight = 20;
            Descripcion.Location = new Point(14, 58);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(811, 244);
            Descripcion.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 429);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 4;
            label3.Text = "Fecha Creacion:";
            label3.Click += label3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(137, 424);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(274, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 338);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 6;
            label4.Text = "Horas Trabajadas:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 385);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 7;
            label5.Text = "Horas Totales:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(493, 329);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 8;
            label6.Text = "Estado:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(493, 393);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Pendiente";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(493, 423);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(115, 24);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "En Progreso";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.Location = new Point(493, 363);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 24);
            checkBox3.TabIndex = 11;
            checkBox3.Text = "Finalizado";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 14);
            label7.Name = "label7";
            label7.Size = new Size(75, 23);
            label7.TabIndex = 12;
            label7.Text = "Usuario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(31, 72);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 13;
            label8.Text = "Nombre:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 27);
            textBox2.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(37, 575);
            panel2.Name = "panel2";
            panel2.Size = new Size(845, 138);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(checkBox8);
            panel3.Controls.Add(checkBox7);
            panel3.Controls.Add(checkBox6);
            panel3.Controls.Add(checkBox5);
            panel3.Controls.Add(checkBox4);
            panel3.Controls.Add(dateTimePicker2);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(37, 749);
            panel3.Name = "panel3";
            panel3.Size = new Size(845, 281);
            panel3.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(14, 16);
            label9.Name = "label9";
            label9.Size = new Size(150, 23);
            label9.TabIndex = 0;
            label9.Text = "Gestion de Tareas";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 56);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 1;
            label10.Text = "Fecha inicio:";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 87);
            label11.Name = "label11";
            label11.Size = new Size(57, 20);
            label11.TabIndex = 2;
            label11.Text = "Estado:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(137, 87);
            label12.Name = "label12";
            label12.Size = new Size(51, 20);
            label12.TabIndex = 3;
            label12.Text = "Horas:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(283, 87);
            label13.Name = "label13";
            label13.Size = new Size(43, 20);
            label13.TabIndex = 4;
            label13.Text = "Area:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(406, 87);
            label14.Name = "label14";
            label14.Size = new Size(70, 20);
            label14.TabIndex = 5;
            label14.Text = "Proyecto:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(406, 56);
            label15.Name = "label15";
            label15.Size = new Size(147, 20);
            label15.TabIndex = 6;
            label15.Text = "Empleado Asignado:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(110, 49);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(21, 121);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(96, 24);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "Pendiente";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(21, 151);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(99, 24);
            checkBox5.TabIndex = 9;
            checkBox5.Text = "Finalizado";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(21, 181);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(110, 24);
            checkBox6.TabIndex = 10;
            checkBox6.Text = "En Progreso";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(283, 121);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(101, 24);
            checkBox7.TabIndex = 11;
            checkBox7.Text = "checkBox7";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(283, 151);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(101, 24);
            checkBox8.TabIndex = 12;
            checkBox8.Text = "checkBox8";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(921, 1051);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private ListBox Descripcion;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private Panel panel2;
        private Panel panel3;
        private Label label9;
        private Label label12;
        private Label label11;
        private Label label10;
        private DateTimePicker dateTimePicker2;
        private Label label15;
        private Label label14;
        private Label label13;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
    }
}
