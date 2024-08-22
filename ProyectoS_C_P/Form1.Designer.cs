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
            TextBoxNamePro = new TextBox();
            PanelGestionProyect = new Panel();
            AgregarProButton = new Button();
            ActualizarButton = new Button();
            dataGridView2 = new DataGridView();
            ListBoxProyect = new ListBox();
            GroupBoxEstado = new GroupBox();
            CheckBoxFin = new CheckBox();
            CheckBoxPend = new CheckBox();
            CheckBoxProgre = new CheckBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            EliminarButton = new Button();
            EditarButton = new Button();
            GuardarButton = new Button();
            label4 = new Label();
            label5 = new Label();
            dateTime = new DateTimePicker();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            TextBoxUsu = new TextBox();
            PanelUsuario = new Panel();
            AgregarUsuButton = new Button();
            PanelTareas = new Panel();
            IngresarTareaButton = new Button();
            GroupBoxArea = new GroupBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            numericUpDown3 = new NumericUpDown();
            GroupBoxEstado2 = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            TextBoxProyect = new TextBox();
            TextBoxEmpAsig = new TextBox();
            dataGridView1 = new DataGridView();
            dateTimePicker2 = new DateTimePicker();
            label15 = new Label();
            label14 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            PanelGestionProyect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            GroupBoxEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            PanelUsuario.SuspendLayout();
            PanelTareas.SuspendLayout();
            GroupBoxArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            GroupBoxEstado2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(177, 23);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Proyectos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 43);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            label2.Click += label2_Click;
            // 
            // TextBoxNamePro
            // 
            TextBoxNamePro.BackColor = Color.Gray;
            TextBoxNamePro.ForeColor = SystemColors.Window;
            TextBoxNamePro.Location = new Point(91, 40);
            TextBoxNamePro.Name = "TextBoxNamePro";
            TextBoxNamePro.Size = new Size(181, 27);
            TextBoxNamePro.TabIndex = 2;
            TextBoxNamePro.TextChanged += textBox1_TextChanged;
            // 
            // PanelGestionProyect
            // 
            PanelGestionProyect.BackColor = Color.FromArgb(64, 64, 64);
            PanelGestionProyect.BorderStyle = BorderStyle.Fixed3D;
            PanelGestionProyect.Controls.Add(AgregarProButton);
            PanelGestionProyect.Controls.Add(ActualizarButton);
            PanelGestionProyect.Controls.Add(dataGridView2);
            PanelGestionProyect.Controls.Add(ListBoxProyect);
            PanelGestionProyect.Controls.Add(GroupBoxEstado);
            PanelGestionProyect.Controls.Add(numericUpDown2);
            PanelGestionProyect.Controls.Add(numericUpDown1);
            PanelGestionProyect.Controls.Add(label1);
            PanelGestionProyect.Controls.Add(EliminarButton);
            PanelGestionProyect.Controls.Add(EditarButton);
            PanelGestionProyect.Controls.Add(TextBoxNamePro);
            PanelGestionProyect.Controls.Add(GuardarButton);
            PanelGestionProyect.Controls.Add(label2);
            PanelGestionProyect.Controls.Add(label4);
            PanelGestionProyect.Controls.Add(label5);
            PanelGestionProyect.Controls.Add(dateTime);
            PanelGestionProyect.Controls.Add(label3);
            PanelGestionProyect.Location = new Point(37, 12);
            PanelGestionProyect.Name = "PanelGestionProyect";
            PanelGestionProyect.Size = new Size(845, 515);
            PanelGestionProyect.TabIndex = 3;
            PanelGestionProyect.Paint += panel1_Paint;
            // 
            // AgregarProButton
            // 
            AgregarProButton.BackColor = Color.FromArgb(64, 64, 64);
            AgregarProButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AgregarProButton.Location = new Point(289, 38);
            AgregarProButton.Name = "AgregarProButton";
            AgregarProButton.Size = new Size(94, 29);
            AgregarProButton.TabIndex = 18;
            AgregarProButton.Text = "Agregar ";
            AgregarProButton.UseVisualStyleBackColor = false;
            // 
            // ActualizarButton
            // 
            ActualizarButton.BackColor = Color.FromArgb(64, 64, 64);
            ActualizarButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ActualizarButton.ForeColor = Color.White;
            ActualizarButton.Location = new Point(731, 244);
            ActualizarButton.Name = "ActualizarButton";
            ActualizarButton.Size = new Size(94, 29);
            ActualizarButton.TabIndex = 17;
            ActualizarButton.Text = "Actualizar";
            ActualizarButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.DimGray;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(18, 366);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(807, 130);
            dataGridView2.TabIndex = 16;
            // 
            // ListBoxProyect
            // 
            ListBoxProyect.BackColor = Color.DimGray;
            ListBoxProyect.ForeColor = SystemColors.Window;
            ListBoxProyect.FormattingEnabled = true;
            ListBoxProyect.ItemHeight = 20;
            ListBoxProyect.Location = new Point(18, 75);
            ListBoxProyect.Name = "ListBoxProyect";
            ListBoxProyect.Size = new Size(807, 124);
            ListBoxProyect.TabIndex = 15;
            ListBoxProyect.SelectedIndexChanged += ListBoxProyect_SelectedIndexChanged;
            // 
            // GroupBoxEstado
            // 
            GroupBoxEstado.Controls.Add(CheckBoxFin);
            GroupBoxEstado.Controls.Add(CheckBoxPend);
            GroupBoxEstado.Controls.Add(CheckBoxProgre);
            GroupBoxEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GroupBoxEstado.ForeColor = SystemColors.ButtonFace;
            GroupBoxEstado.Location = new Point(441, 213);
            GroupBoxEstado.Name = "GroupBoxEstado";
            GroupBoxEstado.Size = new Size(250, 125);
            GroupBoxEstado.TabIndex = 14;
            GroupBoxEstado.TabStop = false;
            GroupBoxEstado.Text = "Estado";
            // 
            // CheckBoxFin
            // 
            CheckBoxFin.AutoSize = true;
            CheckBoxFin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CheckBoxFin.Location = new Point(8, 31);
            CheckBoxFin.Name = "CheckBoxFin";
            CheckBoxFin.Size = new Size(101, 24);
            CheckBoxFin.TabIndex = 11;
            CheckBoxFin.Text = "Finalizado";
            CheckBoxFin.UseVisualStyleBackColor = true;
            CheckBoxFin.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // CheckBoxPend
            // 
            CheckBoxPend.AutoSize = true;
            CheckBoxPend.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CheckBoxPend.Location = new Point(8, 61);
            CheckBoxPend.Name = "CheckBoxPend";
            CheckBoxPend.Size = new Size(101, 24);
            CheckBoxPend.TabIndex = 9;
            CheckBoxPend.Text = "Pendiente";
            CheckBoxPend.UseVisualStyleBackColor = true;
            // 
            // CheckBoxProgre
            // 
            CheckBoxProgre.AutoSize = true;
            CheckBoxProgre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CheckBoxProgre.Location = new Point(8, 91);
            CheckBoxProgre.Name = "CheckBoxProgre";
            CheckBoxProgre.Size = new Size(115, 24);
            CheckBoxProgre.TabIndex = 10;
            CheckBoxProgre.Text = "En Progreso";
            CheckBoxProgre.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.BackColor = Color.Gray;
            numericUpDown2.ForeColor = SystemColors.Window;
            numericUpDown2.Location = new Point(157, 262);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(54, 27);
            numericUpDown2.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.Gray;
            numericUpDown1.ForeColor = SystemColors.Window;
            numericUpDown1.Location = new Point(157, 225);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(54, 27);
            numericUpDown1.TabIndex = 12;
            // 
            // EliminarButton
            // 
            EliminarButton.BackColor = Color.FromArgb(64, 64, 64);
            EliminarButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EliminarButton.ForeColor = Color.White;
            EliminarButton.Location = new Point(731, 281);
            EliminarButton.Name = "EliminarButton";
            EliminarButton.Size = new Size(94, 29);
            EliminarButton.TabIndex = 3;
            EliminarButton.Text = "Eliminar";
            EliminarButton.UseVisualStyleBackColor = false;
            // 
            // EditarButton
            // 
            EditarButton.BackColor = Color.FromArgb(64, 64, 64);
            EditarButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditarButton.Location = new Point(731, 316);
            EditarButton.Name = "EditarButton";
            EditarButton.Size = new Size(94, 29);
            EditarButton.TabIndex = 2;
            EditarButton.Text = "Editar";
            EditarButton.UseVisualStyleBackColor = false;
            // 
            // GuardarButton
            // 
            GuardarButton.BackColor = Color.FromArgb(64, 64, 64);
            GuardarButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GuardarButton.Location = new Point(731, 209);
            GuardarButton.Name = "GuardarButton";
            GuardarButton.Size = new Size(94, 29);
            GuardarButton.TabIndex = 1;
            GuardarButton.Text = "Guardar";
            GuardarButton.UseVisualStyleBackColor = false;
            GuardarButton.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 227);
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
            label5.Location = new Point(18, 264);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 7;
            label5.Text = "Horas Totales:";
            // 
            // dateTime
            // 
            dateTime.CalendarMonthBackground = Color.Gray;
            dateTime.Location = new Point(141, 311);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(274, 27);
            dateTime.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 316);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 4;
            label3.Text = "Fecha Creacion:";
            label3.Click += label3_Click;
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
            label8.Location = new Point(18, 46);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 13;
            label8.Text = "Nombre:";
            // 
            // TextBoxUsu
            // 
            TextBoxUsu.BackColor = Color.Gray;
            TextBoxUsu.ForeColor = SystemColors.Window;
            TextBoxUsu.Location = new Point(108, 43);
            TextBoxUsu.Name = "TextBoxUsu";
            TextBoxUsu.Size = new Size(202, 27);
            TextBoxUsu.TabIndex = 14;
            // 
            // PanelUsuario
            // 
            PanelUsuario.BackColor = Color.FromArgb(64, 64, 64);
            PanelUsuario.BorderStyle = BorderStyle.Fixed3D;
            PanelUsuario.Controls.Add(AgregarUsuButton);
            PanelUsuario.Controls.Add(label7);
            PanelUsuario.Controls.Add(TextBoxUsu);
            PanelUsuario.Controls.Add(label8);
            PanelUsuario.Location = new Point(37, 553);
            PanelUsuario.Name = "PanelUsuario";
            PanelUsuario.Size = new Size(845, 104);
            PanelUsuario.TabIndex = 15;
            // 
            // AgregarUsuButton
            // 
            AgregarUsuButton.BackColor = Color.FromArgb(64, 64, 64);
            AgregarUsuButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AgregarUsuButton.Location = new Point(321, 41);
            AgregarUsuButton.Name = "AgregarUsuButton";
            AgregarUsuButton.Size = new Size(94, 29);
            AgregarUsuButton.TabIndex = 15;
            AgregarUsuButton.Text = "Agregar Usuario";
            AgregarUsuButton.UseVisualStyleBackColor = false;
            // 
            // PanelTareas
            // 
            PanelTareas.BackColor = Color.FromArgb(64, 64, 64);
            PanelTareas.BorderStyle = BorderStyle.Fixed3D;
            PanelTareas.Controls.Add(IngresarTareaButton);
            PanelTareas.Controls.Add(GroupBoxArea);
            PanelTareas.Controls.Add(numericUpDown3);
            PanelTareas.Controls.Add(GroupBoxEstado2);
            PanelTareas.Controls.Add(TextBoxProyect);
            PanelTareas.Controls.Add(TextBoxEmpAsig);
            PanelTareas.Controls.Add(dataGridView1);
            PanelTareas.Controls.Add(dateTimePicker2);
            PanelTareas.Controls.Add(label15);
            PanelTareas.Controls.Add(label14);
            PanelTareas.Controls.Add(label12);
            PanelTareas.Controls.Add(label10);
            PanelTareas.Controls.Add(label9);
            PanelTareas.Location = new Point(37, 681);
            PanelTareas.Name = "PanelTareas";
            PanelTareas.Size = new Size(845, 358);
            PanelTareas.TabIndex = 16;
            // 
            // IngresarTareaButton
            // 
            IngresarTareaButton.BackColor = Color.FromArgb(64, 64, 64);
            IngresarTareaButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            IngresarTareaButton.Location = new Point(626, 163);
            IngresarTareaButton.Name = "IngresarTareaButton";
            IngresarTareaButton.Size = new Size(94, 29);
            IngresarTareaButton.TabIndex = 17;
            IngresarTareaButton.Text = "Ingresar";
            IngresarTareaButton.UseVisualStyleBackColor = false;
            // 
            // GroupBoxArea
            // 
            GroupBoxArea.BackColor = Color.FromArgb(64, 64, 64);
            GroupBoxArea.Controls.Add(checkBox7);
            GroupBoxArea.Controls.Add(checkBox8);
            GroupBoxArea.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GroupBoxArea.ForeColor = SystemColors.ButtonFace;
            GroupBoxArea.Location = new Point(209, 82);
            GroupBoxArea.Name = "GroupBoxArea";
            GroupBoxArea.Size = new Size(115, 93);
            GroupBoxArea.TabIndex = 16;
            GroupBoxArea.TabStop = false;
            GroupBoxArea.Text = "Area";
            GroupBoxArea.Enter += groupBox3_Enter;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox7.Location = new Point(6, 26);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(99, 24);
            checkBox7.TabIndex = 11;
            checkBox7.Text = "Hardware";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox8.Location = new Point(6, 56);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(73, 24);
            checkBox8.TabIndex = 12;
            checkBox8.Text = "Redes";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            numericUpDown3.BackColor = Color.Gray;
            numericUpDown3.ForeColor = SystemColors.Window;
            numericUpDown3.Location = new Point(626, 108);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(58, 27);
            numericUpDown3.TabIndex = 16;
            // 
            // GroupBoxEstado2
            // 
            GroupBoxEstado2.Controls.Add(checkBox4);
            GroupBoxEstado2.Controls.Add(checkBox5);
            GroupBoxEstado2.Controls.Add(checkBox6);
            GroupBoxEstado2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GroupBoxEstado2.ForeColor = SystemColors.ButtonFace;
            GroupBoxEstado2.Location = new Point(12, 82);
            GroupBoxEstado2.Name = "GroupBoxEstado2";
            GroupBoxEstado2.Size = new Size(163, 114);
            GroupBoxEstado2.TabIndex = 15;
            GroupBoxEstado2.TabStop = false;
            GroupBoxEstado2.Text = "Estado";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox4.Location = new Point(6, 56);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(101, 24);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "Pendiente";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox5.Location = new Point(6, 26);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(101, 24);
            checkBox5.TabIndex = 9;
            checkBox5.Text = "Finalizado";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox6.Location = new Point(6, 86);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(115, 24);
            checkBox6.TabIndex = 10;
            checkBox6.Text = "En Progreso";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // TextBoxProyect
            // 
            TextBoxProyect.BackColor = Color.Gray;
            TextBoxProyect.ForeColor = SystemColors.Window;
            TextBoxProyect.Location = new Point(626, 75);
            TextBoxProyect.Name = "TextBoxProyect";
            TextBoxProyect.Size = new Size(135, 27);
            TextBoxProyect.TabIndex = 15;
            // 
            // TextBoxEmpAsig
            // 
            TextBoxEmpAsig.BackColor = Color.Gray;
            TextBoxEmpAsig.ForeColor = SystemColors.Window;
            TextBoxEmpAsig.Location = new Point(626, 42);
            TextBoxEmpAsig.Name = "TextBoxEmpAsig";
            TextBoxEmpAsig.Size = new Size(135, 27);
            TextBoxEmpAsig.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DimGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(813, 127);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(108, 44);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(459, 45);
            label15.Name = "label15";
            label15.Size = new Size(152, 20);
            label15.TabIndex = 6;
            label15.Text = "Empleado Asignado:";
            label15.Click += label15_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(536, 75);
            label14.Name = "label14";
            label14.Size = new Size(75, 20);
            label14.TabIndex = 5;
            label14.Text = "Proyecto:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(557, 112);
            label12.Name = "label12";
            label12.Size = new Size(54, 20);
            label12.TabIndex = 3;
            label12.Text = "Horas:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(14, 49);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 1;
            label10.Text = "Fecha inicio:";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(150, 23);
            label9.TabIndex = 0;
            label9.Text = "Gestion de Tareas";
            label9.Click += label9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(921, 1051);
            Controls.Add(PanelTareas);
            Controls.Add(PanelUsuario);
            Controls.Add(PanelGestionProyect);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            PanelGestionProyect.ResumeLayout(false);
            PanelGestionProyect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            GroupBoxEstado.ResumeLayout(false);
            GroupBoxEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            PanelUsuario.ResumeLayout(false);
            PanelUsuario.PerformLayout();
            PanelTareas.ResumeLayout(false);
            PanelTareas.PerformLayout();
            GroupBoxArea.ResumeLayout(false);
            GroupBoxArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            GroupBoxEstado2.ResumeLayout(false);
            GroupBoxEstado2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TextBoxNamePro;
        private Panel PanelGestionProyect;
        private Button EliminarButton;
        private Button EditarButton;
        private Button GuardarButton;
        private Label label3;
        private DateTimePicker dateTime;
        private Label label4;
        private Label label5;
        private CheckBox CheckBoxPend;
        private CheckBox CheckBoxProgre;
        private CheckBox CheckBoxFin;
        private Label label7;
        private Label label8;
        private TextBox TextBoxUsu;
        private Panel PanelUsuario;
        private Panel PanelTareas;
        private Label label9;
        private Label label12;
        private Label label10;
        private DateTimePicker dateTimePicker2;
        private Label label15;
        private Label label14;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private DataGridView dataGridView1;
        private TextBox TextBoxEmpAsig;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown3;
        private TextBox TextBoxProyect;
        private GroupBox GroupBoxEstado;
        private GroupBox GroupBoxArea;
        private GroupBox GroupBoxEstado2;
        private ListBox ListBoxProyect;
        private DataGridView dataGridView2;
        private Button ActualizarButton;
        private Button AgregarProButton;
        private Button AgregarUsuButton;
        private Button IngresarTareaButton;
    }
}
