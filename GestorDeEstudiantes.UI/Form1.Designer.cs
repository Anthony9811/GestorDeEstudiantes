namespace GestorDeEstudiantes.UI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCarne = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNumeroDeCarne = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBuscarUnEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEstudianteConPromedioMásBajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEstudianteConPromedioMásAltoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarNotas = new System.Windows.Forms.Button();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtParaMostrarResultados = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCarne
            // 
            this.lblCarne.AutoSize = true;
            this.lblCarne.Location = new System.Drawing.Point(55, 43);
            this.lblCarne.Name = "lblCarne";
            this.lblCarne.Size = new System.Drawing.Size(38, 13);
            this.lblCarne.TabIndex = 0;
            this.lblCarne.Text = "Carné:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 115);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(41, 168);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtNumeroDeCarne
            // 
            this.txtNumeroDeCarne.Location = new System.Drawing.Point(99, 40);
            this.txtNumeroDeCarne.Name = "txtNumeroDeCarne";
            this.txtNumeroDeCarne.Size = new System.Drawing.Size(117, 20);
            this.txtNumeroDeCarne.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(99, 165);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(117, 20);
            this.txtApellidos.TabIndex = 5;
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(44, 199);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEstudiante.TabIndex = 6;
            this.btnAgregarEstudiante.Text = "Agregar";
            this.btnAgregarEstudiante.UseVisualStyleBackColor = true;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.btnAgregarEstudiante_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNotasToolStripMenuItem,
            this.mostrarEstudianteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarNotasToolStripMenuItem
            // 
            this.agregarNotasToolStripMenuItem.Name = "agregarNotasToolStripMenuItem";
            this.agregarNotasToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.agregarNotasToolStripMenuItem.Text = "Agregar Notas";
            // 
            // mostrarEstudianteToolStripMenuItem
            // 
            this.mostrarEstudianteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnBuscarUnEstudianteToolStripMenuItem,
            this.mnEstudianteConPromedioMásBajoToolStripMenuItem,
            this.mnEstudianteConPromedioMásAltoToolStripMenuItem});
            this.mostrarEstudianteToolStripMenuItem.Name = "mostrarEstudianteToolStripMenuItem";
            this.mostrarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.mostrarEstudianteToolStripMenuItem.Text = "Mostrar Estudiante";
            // 
            // mnBuscarUnEstudianteToolStripMenuItem
            // 
            this.mnBuscarUnEstudianteToolStripMenuItem.Name = "mnBuscarUnEstudianteToolStripMenuItem";
            this.mnBuscarUnEstudianteToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.mnBuscarUnEstudianteToolStripMenuItem.Text = "Buscar un estudiante";
            // 
            // mnEstudianteConPromedioMásBajoToolStripMenuItem
            // 
            this.mnEstudianteConPromedioMásBajoToolStripMenuItem.Name = "mnEstudianteConPromedioMásBajoToolStripMenuItem";
            this.mnEstudianteConPromedioMásBajoToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.mnEstudianteConPromedioMásBajoToolStripMenuItem.Text = "Estudiante con promedio más bajo";
            this.mnEstudianteConPromedioMásBajoToolStripMenuItem.Click += new System.EventHandler(this.mnEstudianteConPromedioMásBajoToolStripMenuItem_Click);
            // 
            // mnEstudianteConPromedioMásAltoToolStripMenuItem
            // 
            this.mnEstudianteConPromedioMásAltoToolStripMenuItem.Name = "mnEstudianteConPromedioMásAltoToolStripMenuItem";
            this.mnEstudianteConPromedioMásAltoToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.mnEstudianteConPromedioMásAltoToolStripMenuItem.Text = "Estudiante con promedio más alto";
            this.mnEstudianteConPromedioMásAltoToolStripMenuItem.Click += new System.EventHandler(this.mnEstudianteConPromedioMásAltoToolStripMenuItem_Click);
            // 
            // btnAgregarNotas
            // 
            this.btnAgregarNotas.Location = new System.Drawing.Point(265, 77);
            this.btnAgregarNotas.Name = "btnAgregarNotas";
            this.btnAgregarNotas.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarNotas.TabIndex = 8;
            this.btnAgregarNotas.Text = "Agregar";
            this.btnAgregarNotas.UseVisualStyleBackColor = true;
            this.btnAgregarNotas.Click += new System.EventHandler(this.btnAgregarNotas_Click);
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(239, 43);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(33, 13);
            this.lblNota.TabIndex = 9;
            this.lblNota.Text = "Nota:";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(278, 40);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(119, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtParaMostrarResultados
            // 
            this.txtParaMostrarResultados.Location = new System.Drawing.Point(397, 27);
            this.txtParaMostrarResultados.Name = "txtParaMostrarResultados";
            this.txtParaMostrarResultados.Size = new System.Drawing.Size(233, 166);
            this.txtParaMostrarResultados.TabIndex = 12;
            this.txtParaMostrarResultados.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 263);
            this.Controls.Add(this.txtParaMostrarResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.btnAgregarNotas);
            this.Controls.Add(this.btnAgregarEstudiante);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumeroDeCarne);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCarne);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarne;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNumeroDeCarne;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Button btnAgregarEstudiante;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnBuscarUnEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnEstudianteConPromedioMásBajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnEstudianteConPromedioMásAltoToolStripMenuItem;
        private System.Windows.Forms.Button btnAgregarNotas;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RichTextBox txtParaMostrarResultados;
    }
}

