namespace BibliotecaEquipo
    {
    partial class AltaUsuario
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
            {
            if (disposing&&(components!=null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.LabNombreUsuario = new System.Windows.Forms.Label();
            this.GrbRolUsuario = new System.Windows.Forms.GroupBox();
            this.RbtAlumno = new System.Windows.Forms.RadioButton();
            this.RbtProfesor = new System.Windows.Forms.RadioButton();
            this.RbtPas = new System.Windows.Forms.RadioButton();
            this.LabApellidos = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LtbDepartamentos = new System.Windows.Forms.ListBox();
            this.LabDepartamento = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.GrbRolUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Location = new System.Drawing.Point(381, 40);
            this.TxtNombreUsuario.Multiline = true;
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(327, 30);
            this.TxtNombreUsuario.TabIndex = 0;
            // 
            // LabNombreUsuario
            // 
            this.LabNombreUsuario.AutoSize = true;
            this.LabNombreUsuario.Location = new System.Drawing.Point(269, 43);
            this.LabNombreUsuario.Name = "LabNombreUsuario";
            this.LabNombreUsuario.Size = new System.Drawing.Size(70, 17);
            this.LabNombreUsuario.TabIndex = 1;
            this.LabNombreUsuario.Text = "Nombre : ";
            // 
            // GrbRolUsuario
            // 
            this.GrbRolUsuario.Controls.Add(this.RbtPas);
            this.GrbRolUsuario.Controls.Add(this.RbtProfesor);
            this.GrbRolUsuario.Controls.Add(this.RbtAlumno);
            this.GrbRolUsuario.Location = new System.Drawing.Point(73, 33);
            this.GrbRolUsuario.Name = "GrbRolUsuario";
            this.GrbRolUsuario.Size = new System.Drawing.Size(149, 185);
            this.GrbRolUsuario.TabIndex = 3;
            this.GrbRolUsuario.TabStop = false;
            this.GrbRolUsuario.Text = "RolUsuario";
            // 
            // RbtAlumno
            // 
            this.RbtAlumno.AutoSize = true;
            this.RbtAlumno.Location = new System.Drawing.Point(18, 45);
            this.RbtAlumno.Name = "RbtAlumno";
            this.RbtAlumno.Size = new System.Drawing.Size(76, 21);
            this.RbtAlumno.TabIndex = 0;
            this.RbtAlumno.TabStop = true;
            this.RbtAlumno.Text = "Alumno";
            this.RbtAlumno.UseVisualStyleBackColor = true;
            // 
            // RbtProfesor
            // 
            this.RbtProfesor.AutoSize = true;
            this.RbtProfesor.Location = new System.Drawing.Point(18, 95);
            this.RbtProfesor.Name = "RbtProfesor";
            this.RbtProfesor.Size = new System.Drawing.Size(83, 21);
            this.RbtProfesor.TabIndex = 1;
            this.RbtProfesor.TabStop = true;
            this.RbtProfesor.Text = "Profesor";
            this.RbtProfesor.UseVisualStyleBackColor = true;
            // 
            // RbtPas
            // 
            this.RbtPas.AutoSize = true;
            this.RbtPas.Location = new System.Drawing.Point(18, 140);
            this.RbtPas.Name = "RbtPas";
            this.RbtPas.Size = new System.Drawing.Size(56, 21);
            this.RbtPas.TabIndex = 2;
            this.RbtPas.TabStop = true;
            this.RbtPas.Text = "PAS";
            this.RbtPas.UseVisualStyleBackColor = true;
            // 
            // LabApellidos
            // 
            this.LabApellidos.AutoSize = true;
            this.LabApellidos.Location = new System.Drawing.Point(269, 132);
            this.LabApellidos.Name = "LabApellidos";
            this.LabApellidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabApellidos.Size = new System.Drawing.Size(73, 17);
            this.LabApellidos.TabIndex = 5;
            this.LabApellidos.Text = "Apellidos :";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(381, 129);
            this.TxtApellido.Multiline = true;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtApellido.Size = new System.Drawing.Size(327, 30);
            this.TxtApellido.TabIndex = 4;
            // 
            // LtbDepartamentos
            // 
            this.LtbDepartamentos.FormattingEnabled = true;
            this.LtbDepartamentos.ItemHeight = 16;
            this.LtbDepartamentos.Items.AddRange(new object[] {
            "Administrativo",
            "Electricidad",
            "Informatica",
            "Limpieza",
            "Secretaria"});
            this.LtbDepartamentos.Location = new System.Drawing.Point(381, 209);
            this.LtbDepartamentos.Name = "LtbDepartamentos";
            this.LtbDepartamentos.Size = new System.Drawing.Size(327, 116);
            this.LtbDepartamentos.Sorted = true;
            this.LtbDepartamentos.TabIndex = 6;
            // 
            // LabDepartamento
            // 
            this.LabDepartamento.AutoSize = true;
            this.LabDepartamento.Location = new System.Drawing.Point(269, 209);
            this.LabDepartamento.Name = "LabDepartamento";
            this.LabDepartamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabDepartamento.Size = new System.Drawing.Size(106, 17);
            this.LabDepartamento.TabIndex = 7;
            this.LabDepartamento.Text = "Departamento :";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(577, 388);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(131, 65);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(381, 388);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(131, 65);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 542);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LabDepartamento);
            this.Controls.Add(this.LtbDepartamentos);
            this.Controls.Add(this.LabApellidos);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.GrbRolUsuario);
            this.Controls.Add(this.LabNombreUsuario);
            this.Controls.Add(this.TxtNombreUsuario);
            this.Name = "AltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaUsuario";
            this.GrbRolUsuario.ResumeLayout(false);
            this.GrbRolUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.Label LabNombreUsuario;
        private System.Windows.Forms.GroupBox GrbRolUsuario;
        private System.Windows.Forms.RadioButton RbtPas;
        private System.Windows.Forms.RadioButton RbtProfesor;
        private System.Windows.Forms.RadioButton RbtAlumno;
        private System.Windows.Forms.Label LabApellidos;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.ListBox LtbDepartamentos;
        private System.Windows.Forms.Label LabDepartamento;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnLimpiar;
        }
    }