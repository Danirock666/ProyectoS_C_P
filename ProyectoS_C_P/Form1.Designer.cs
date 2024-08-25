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
            LabelGestionDeProyectos = new Label();
            LabelNombre = new Label();
            TextBoxNamePro = new TextBox();
            PanelGestionProyect = new Panel();
            LabelEstado = new Label();
            ComboBoxStatus = new ComboBox();
            TextBoxDescription = new TextBox();
            LabelDescripction = new Label();
            AgregarProButton = new Button();
            ActualizarButton = new Button();
            dataGridViewProyecto = new DataGridView();
            NumericUpDownHorasTotales = new NumericUpDown();
            GuardarButton = new Button();
            LabelHorasTotales = new Label();
            DateTime = new DateTimePicker();
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
            dataGridView2 = new DataGridView();
            dateTimePicker2 = new DateTimePicker();
            label15 = new Label();
            label14 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            PanelGestionProyect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProyecto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownHorasTotales).BeginInit();
            PanelUsuario.SuspendLayout();
            PanelTareas.SuspendLayout();
            GroupBoxArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            GroupBoxEstado2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // LabelGestionDeProyectos
            // 
            LabelGestionDeProyectos.AutoSize = true;
            LabelGestionDeProyectos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LabelGestionDeProyectos.Location = new Point(12, 10);
            LabelGestionDeProyectos.Name = "LabelGestionDeProyectos";
            LabelGestionDeProyectos.Size = new Size(177, 23);
            LabelGestionDeProyectos.TabIndex = 0;
            LabelGestionDeProyectos.Text = "Gestion de Proyectos";
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelNombre.Location = new Point(43, 46);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(71, 20);
            LabelNombre.TabIndex = 1;
            LabelNombre.Text = "Nombre:";
            LabelNombre.Click += label2_Click;
            // 
            // TextBoxNamePro
            // 
            TextBoxNamePro.BackColor = Color.Gray;
            TextBoxNamePro.ForeColor = SystemColors.Window;
            TextBoxNamePro.Location = new Point(120, 43);
            TextBoxNamePro.Name = "TextBoxNamePro";
            TextBoxNamePro.Size = new Size(181, 27);
            TextBoxNamePro.TabIndex = 2;
            TextBoxNamePro.TextChanged += textBox1_TextChanged;
            // 
            // PanelGestionProyect
            // 
            PanelGestionProyect.BackColor = Color.FromArgb(64, 64, 64);
            PanelGestionProyect.BorderStyle = BorderStyle.Fixed3D;
            PanelGestionProyect.Controls.Add(LabelEstado);
            PanelGestionProyect.Controls.Add(ComboBoxStatus);
            PanelGestionProyect.Controls.Add(TextBoxDescription);
            PanelGestionProyect.Controls.Add(LabelDescripction);
            PanelGestionProyect.Controls.Add(AgregarProButton);
            PanelGestionProyect.Controls.Add(ActualizarButton);
            PanelGestionProyect.Controls.Add(dataGridViewProyecto);
            PanelGestionProyect.Controls.Add(NumericUpDownHorasTotales);
            PanelGestionProyect.Controls.Add(LabelGestionDeProyectos);
            PanelGestionProyect.Controls.Add(TextBoxNamePro);
            PanelGestionProyect.Controls.Add(GuardarButton);
            PanelGestionProyect.Controls.Add(LabelNombre);
            PanelGestionProyect.Controls.Add(LabelHorasTotales);
            PanelGestionProyect.Controls.Add(DateTime);
            PanelGestionProyect.Controls.Add(label3);
            PanelGestionProyect.Location = new Point(37, 12);
            PanelGestionProyect.Name = "PanelGestionProyect";
            PanelGestionProyect.Size = new Size(845, 479);
            PanelGestionProyect.TabIndex = 3;
            PanelGestionProyect.Paint += panel1_Paint;
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelEstado.Location = new Point(54, 161);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(60, 20);
            LabelEstado.TabIndex = 22;
            LabelEstado.Text = "Estado:";
            // 
            // ComboBoxStatus
            // 
            ComboBoxStatus.BackColor = Color.Gray;
            ComboBoxStatus.FormattingEnabled = true;
            ComboBoxStatus.Items.AddRange(new object[] { "Pendiente", "Finalizado", "En Progreso" });
            ComboBoxStatus.Location = new Point(120, 153);
            ComboBoxStatus.Name = "ComboBoxStatus";
            ComboBoxStatus.Size = new Size(151, 28);
            ComboBoxStatus.TabIndex = 21;
            // 
            // TextBoxDescription
            // 
            TextBoxDescription.BackColor = Color.Gray;
            TextBoxDescription.Location = new Point(120, 101);
            TextBoxDescription.Name = "TextBoxDescription";
            TextBoxDescription.Size = new Size(263, 27);
            TextBoxDescription.TabIndex = 20;
            // 
            // LabelDescripction
            // 
            LabelDescripction.AutoSize = true;
            LabelDescripction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelDescripction.Location = new Point(20, 108);
            LabelDescripction.Name = "LabelDescripction";
            LabelDescripction.Size = new Size(94, 20);
            LabelDescripction.TabIndex = 19;
            LabelDescripction.Text = "Descripcion:";
            LabelDescripction.Click += label6_Click;
            // 
            // AgregarProButton
            // 
            AgregarProButton.BackColor = Color.FromArgb(64, 64, 64);
            AgregarProButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AgregarProButton.Location = new Point(230, 219);
            AgregarProButton.Name = "AgregarProButton";
            AgregarProButton.Size = new Size(94, 29);
            AgregarProButton.TabIndex = 18;
            AgregarProButton.Text = "Agregar ";
            AgregarProButton.UseVisualStyleBackColor = false;
            AgregarProButton.Click += AgregarProButton_Click;
            // 
            // ActualizarButton
            // 
            ActualizarButton.BackColor = Color.FromArgb(64, 64, 64);
            ActualizarButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ActualizarButton.ForeColor = Color.White;
            ActualizarButton.Location = new Point(357, 219);
            ActualizarButton.Name = "ActualizarButton";
            ActualizarButton.Size = new Size(94, 29);
            ActualizarButton.TabIndex = 17;
            ActualizarButton.Text = "Actualizar";
            ActualizarButton.UseVisualStyleBackColor = false;
            // 
            // dataGridViewProyecto
            // 
            dataGridViewProyecto.BackgroundColor = Color.DimGray;
            dataGridViewProyecto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProyecto.Location = new Point(18, 269);
            dataGridViewProyecto.Name = "dataGridViewProyecto";
            dataGridViewProyecto.RowHeadersWidth = 51;
            dataGridViewProyecto.RowTemplate.Height = 29;
            dataGridViewProyecto.Size = new Size(807, 184);
            dataGridViewProyecto.TabIndex = 16;
            dataGridViewProyecto.CellContentClick += dataGridView2_CellContentClick;
            // 
            // NumericUpDownHorasTotales
            // 
            NumericUpDownHorasTotales.BackColor = Color.Gray;
            NumericUpDownHorasTotales.ForeColor = SystemColors.Window;
            NumericUpDownHorasTotales.Location = new Point(544, 39);
            NumericUpDownHorasTotales.Name = "NumericUpDownHorasTotales";
            NumericUpDownHorasTotales.Size = new Size(54, 27);
            NumericUpDownHorasTotales.TabIndex = 13;
            NumericUpDownHorasTotales.ValueChanged += NumericUpDownHorasTotal_ValueChanged;
            // 
            // GuardarButton
            // 
            GuardarButton.BackColor = Color.FromArgb(64, 64, 64);
            GuardarButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GuardarButton.Location = new Point(491, 219);
            GuardarButton.Name = "GuardarButton";
            GuardarButton.Size = new Size(94, 29);
            GuardarButton.TabIndex = 1;
            GuardarButton.Text = "Guardar";
            GuardarButton.UseVisualStyleBackColor = false;
            GuardarButton.Click += button1_Click;
            // 
            // LabelHorasTotales
            // 
            LabelHorasTotales.AutoSize = true;
            LabelHorasTotales.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHorasTotales.Location = new Point(430, 43);
            LabelHorasTotales.Name = "LabelHorasTotales";
            LabelHorasTotales.Size = new Size(108, 20);
            LabelHorasTotales.TabIndex = 7;
            LabelHorasTotales.Text = "Horas Totales:";
            // 
            // DateTime
            // 
            DateTime.CalendarMonthBackground = Color.Gray;
            DateTime.Location = new Point(544, 103);
            DateTime.Name = "DateTime";
            DateTime.Size = new Size(274, 27);
            DateTime.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(421, 108);
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
            PanelUsuario.Location = new Point(37, 514);
            PanelUsuario.Name = "PanelUsuario";
            PanelUsuario.Size = new Size(845, 143);
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
            PanelTareas.Controls.Add(dataGridView2);
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
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.DimGray;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 211);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(813, 127);
            dataGridView2.TabIndex = 13;
            dataGridView2.CellContentClick += dataGridView1_CellContentClick;
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
            ClientSize = new Size(919, 1051);
            Controls.Add(PanelTareas);
            Controls.Add(PanelUsuario);
            Controls.Add(PanelGestionProyect);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Gestor Proyect";
            Load += Form1_Load;
            PanelGestionProyect.ResumeLayout(false);
            PanelGestionProyect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProyecto).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownHorasTotales).EndInit();
            PanelUsuario.ResumeLayout(false);
            PanelUsuario.PerformLayout();
            PanelTareas.ResumeLayout(false);
            PanelTareas.PerformLayout();
            GroupBoxArea.ResumeLayout(false);
            GroupBoxArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            GroupBoxEstado2.ResumeLayout(false);
            GroupBoxEstado2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LabelGestionDeProyectos;
        private Label LabelNombre;
        private TextBox TextBoxNamePro;
        private Panel PanelGestionProyect;
        private Button GuardarButton;
        private Label label3;
        private DateTimePicker DateTime;
        private Label LabelHorasTotales;
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
        private DataGridView dataGridView2;
        private TextBox TextBoxEmpAsig;
        private NumericUpDown NumericUpDownHorasTotales;
        private NumericUpDown numericUpDown3;
        private TextBox TextBoxProyect;
        private GroupBox GroupBoxArea;
        private GroupBox GroupBoxEstado2;
        private DataGridView dataGridViewProyecto;
        private Button ActualizarButton;
        private Button AgregarProButton;
        private Button AgregarUsuButton;
        private Button IngresarTareaButton;
        private Label LabelDescripction;
        private TextBox TextBoxDescription;
        private ComboBox ComboBoxStatus;
        private Label LabelEstado;
    }
}
