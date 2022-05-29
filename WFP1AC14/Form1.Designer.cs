namespace WFP1AC14
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.buttonObtenerDatos = new System.Windows.Forms.Button();
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.comboBoxClase = new System.Windows.Forms.ComboBox();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.comboBoxSeccion = new System.Windows.Forms.ComboBox();
            this.buttonCrearAlumno = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonImportar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1Parcial1 = new System.Windows.Forms.TextBox();
            this.textBox1Parcial2 = new System.Windows.Forms.TextBox();
            this.textBox1Parcial3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1Eliminar = new System.Windows.Forms.Button();
            this.button1eli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonObtenerDatos
            // 
            this.buttonObtenerDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonObtenerDatos.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonObtenerDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonObtenerDatos.Location = new System.Drawing.Point(181, 503);
            this.buttonObtenerDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonObtenerDatos.Name = "buttonObtenerDatos";
            this.buttonObtenerDatos.Size = new System.Drawing.Size(156, 22);
            this.buttonObtenerDatos.TabIndex = 0;
            this.buttonObtenerDatos.Text = "Obtener Datos";
            this.buttonObtenerDatos.UseVisualStyleBackColor = false;
            this.buttonObtenerDatos.Click += new System.EventHandler(this.buttonObtenerDatos_Click);
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(717, 0);
            this.dataGridViewAlumnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.RowHeadersWidth = 51;
            this.dataGridViewAlumnos.RowTemplate.Height = 29;
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(482, 540);
            this.dataGridViewAlumnos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Peru;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(73, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Peru;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(73, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Peru;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(73, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Clase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Peru;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(73, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Seccion";
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxCarnet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCarnet.Location = new System.Drawing.Point(171, 75);
            this.textBoxCarnet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(152, 22);
            this.textBoxCarnet.TabIndex = 7;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxNombre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNombre.Location = new System.Drawing.Point(171, 120);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(409, 22);
            this.textBoxNombre.TabIndex = 8;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxCorreo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCorreo.Location = new System.Drawing.Point(171, 167);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(409, 22);
            this.textBoxCorreo.TabIndex = 9;
            // 
            // comboBoxClase
            // 
            this.comboBoxClase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.comboBoxClase.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxClase.FormattingEnabled = true;
            this.comboBoxClase.Items.AddRange(new object[] {
            "PROGRAMACIÓN I",
            "PROGRAMACIÓN 2",
            "PROGRAMACIÓN 3",
            "MATEMATICA"});
            this.comboBoxClase.Location = new System.Drawing.Point(171, 215);
            this.comboBoxClase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxClase.Name = "comboBoxClase";
            this.comboBoxClase.Size = new System.Drawing.Size(288, 23);
            this.comboBoxClase.TabIndex = 10;
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonConsulta.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonConsulta.Location = new System.Drawing.Point(394, 75);
            this.buttonConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(186, 22);
            this.buttonConsulta.TabIndex = 11;
            this.buttonConsulta.Text = "Consulta Carnet";
            this.buttonConsulta.UseVisualStyleBackColor = false;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
            // 
            // comboBoxSeccion
            // 
            this.comboBoxSeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.comboBoxSeccion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSeccion.FormattingEnabled = true;
            this.comboBoxSeccion.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBoxSeccion.Location = new System.Drawing.Point(171, 258);
            this.comboBoxSeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSeccion.Name = "comboBoxSeccion";
            this.comboBoxSeccion.Size = new System.Drawing.Size(72, 23);
            this.comboBoxSeccion.TabIndex = 12;
            // 
            // buttonCrearAlumno
            // 
            this.buttonCrearAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCrearAlumno.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCrearAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonCrearAlumno.Location = new System.Drawing.Point(54, 417);
            this.buttonCrearAlumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCrearAlumno.Name = "buttonCrearAlumno";
            this.buttonCrearAlumno.Size = new System.Drawing.Size(189, 22);
            this.buttonCrearAlumno.TabIndex = 13;
            this.buttonCrearAlumno.Text = "Crear Alumno";
            this.buttonCrearAlumno.UseVisualStyleBackColor = false;
            this.buttonCrearAlumno.Click += new System.EventHandler(this.buttonCrearAlumno_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonActualizar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonActualizar.Location = new System.Drawing.Point(290, 417);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(184, 22);
            this.buttonActualizar.TabIndex = 14;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonImportar
            // 
            this.buttonImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonImportar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonImportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonImportar.Location = new System.Drawing.Point(54, 459);
            this.buttonImportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonImportar.Name = "buttonImportar";
            this.buttonImportar.Size = new System.Drawing.Size(189, 22);
            this.buttonImportar.TabIndex = 15;
            this.buttonImportar.Text = "Importar";
            this.buttonImportar.UseVisualStyleBackColor = false;
            this.buttonImportar.Click += new System.EventHandler(this.buttonImportar_Click);
            // 
            // buttonExportar
            // 
            this.buttonExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonExportar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonExportar.Location = new System.Drawing.Point(290, 459);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(184, 22);
            this.buttonExportar.TabIndex = 16;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = false;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Peru;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(73, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Parcial1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Peru;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(73, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Parcial2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Peru;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(73, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Parcial3";
            // 
            // textBox1Parcial1
            // 
            this.textBox1Parcial1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox1Parcial1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1Parcial1.Location = new System.Drawing.Point(171, 297);
            this.textBox1Parcial1.Name = "textBox1Parcial1";
            this.textBox1Parcial1.Size = new System.Drawing.Size(100, 22);
            this.textBox1Parcial1.TabIndex = 20;
            // 
            // textBox1Parcial2
            // 
            this.textBox1Parcial2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox1Parcial2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1Parcial2.Location = new System.Drawing.Point(171, 332);
            this.textBox1Parcial2.Name = "textBox1Parcial2";
            this.textBox1Parcial2.Size = new System.Drawing.Size(100, 22);
            this.textBox1Parcial2.TabIndex = 21;
            // 
            // textBox1Parcial3
            // 
            this.textBox1Parcial3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox1Parcial3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1Parcial3.Location = new System.Drawing.Point(171, 363);
            this.textBox1Parcial3.Name = "textBox1Parcial3";
            this.textBox1Parcial3.Size = new System.Drawing.Size(100, 22);
            this.textBox1Parcial3.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(210, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 22);
            this.label9.TabIndex = 24;
            this.label9.Text = "Universidad Mariano Gálvez";
            // 
            // button1Eliminar
            // 
            this.button1Eliminar.Location = new System.Drawing.Point(0, 0);
            this.button1Eliminar.Name = "button1Eliminar";
            this.button1Eliminar.Size = new System.Drawing.Size(75, 23);
            this.button1Eliminar.TabIndex = 0;
            // 
            // button1eli
            // 
            this.button1eli.Location = new System.Drawing.Point(505, 433);
            this.button1eli.Name = "button1eli";
            this.button1eli.Size = new System.Drawing.Size(106, 24);
            this.button1eli.TabIndex = 25;
            this.button1eli.Text = "ELIMINAR";
            this.button1eli.UseVisualStyleBackColor = true;
            this.button1eli.Click += new System.EventHandler(this.bottun1eli_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1199, 540);
            this.Controls.Add(this.button1eli);
            this.Controls.Add(this.button1Eliminar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1Parcial3);
            this.Controls.Add(this.textBox1Parcial2);
            this.Controls.Add(this.textBox1Parcial1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.buttonImportar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonCrearAlumno);
            this.Controls.Add(this.comboBoxSeccion);
            this.Controls.Add(this.buttonConsulta);
            this.Controls.Add(this.comboBoxClase);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAlumnos);
            this.Controls.Add(this.buttonObtenerDatos);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form1";
            this.Text = "Progra1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonObtenerDatos;
        private DataGridView dataGridViewAlumnos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxCarnet;
        private TextBox textBoxNombre;
        private TextBox textBoxCorreo;
        private ComboBox comboBoxClase;
        private Button buttonConsulta;
        private ComboBox comboBoxSeccion;
        private Button buttonCrearAlumno;
        private Button buttonActualizar;
        private Button buttonImportar;
        private Button buttonExportar;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1Parcial1;
        private TextBox textBox1Parcial2;
        private TextBox textBox1Parcial3;
        private PictureBox pictureBox1;
        private Label label9;
        private Button button1Eliminar;
        private Button button1eli;
    }
}