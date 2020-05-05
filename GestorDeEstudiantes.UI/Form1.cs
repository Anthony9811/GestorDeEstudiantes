using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudiantes.UI
{
    public partial class Form1 : Form
    {
        GestorDeEstudiantes.LogicaDeNegocios.Curso ElCurso;
        
        public Form1()
        {
            InitializeComponent();
            ElCurso = new GestorDeEstudiantes.LogicaDeNegocios.Curso();
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            GestorDeEstudiantes.LogicaDeNegocios.Estudiante estudianteNuevo = new LogicaDeNegocios.Estudiante();
            
            if(txtNumeroDeCarne.Text == "" || txtNombre.Text == "" || txtApellidos.Text == "")
            {
                MessageBox.Show("No pueden haber campos vacíos", "Error");
            }
            else if(ElCurso.ListaDeEstudiantes.Any(estudianteIngresado => estudianteIngresado.Carne == txtNumeroDeCarne.Text))
            {
                MessageBox.Show("El numero de carné ingresado ya existe", "Error");
            }
            else
            {
            estudianteNuevo.Carne = txtNumeroDeCarne.Text;
            estudianteNuevo.Nombre = txtNombre.Text;
            estudianteNuevo.Apellidos = txtApellidos.Text;

                ElCurso.AgregarEstudiante(estudianteNuevo);
                MessageBox.Show("Estudiante ingresado", "Éxito");

                txtNombre.Clear();
                txtApellidos.Clear();
                txtNumeroDeCarne.Clear();
            }

        }

        private void mnEstudianteConPromedioMásBajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtParaMostrarResultados.Text = (ElCurso.ObtenerEstudianteConPromedioMasBajo());

            lblApellidos.Enabled = false;
            lblNombre.Enabled = false;
            btnAgregarEstudiante.Enabled = false;
            txtApellidos.Enabled = false;
            txtNombre.Enabled = false;
            lblCarne.Enabled = false;
            txtNumeroDeCarne.Enabled = false;
            btnLimpiarCajaDeTexto.Visible = true;
        }

        private void mnEstudianteConPromedioMásAltoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtParaMostrarResultados.Text = (ElCurso.ObtenerEstudianteConPromedioMasAlto());

            lblApellidos.Enabled = false;
            lblNombre.Enabled = false;
            btnAgregarEstudiante.Enabled = false;
            txtApellidos.Enabled = false;
            txtNombre.Enabled = false;
            lblCarne.Enabled = false;
            txtNumeroDeCarne.Enabled = false;
            btnLimpiarCajaDeTexto.Visible = true;
        }

        private void mnBuscarUnEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBuscar.Visible = true;

            lblApellidos.Enabled = false;
            lblNombre.Enabled = false;
            btnAgregarEstudiante.Enabled = false;
            txtApellidos.Enabled = false;
            txtNombre.Enabled = false;
            
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNumeroDeCarne.Text == "")
            {
                MessageBox.Show("Debe ingresar el número de carné", "ADVERTENCIA");
            }
            else
            {
            txtParaMostrarResultados.Text = ElCurso.MostrarDatosDeEstudiante(txtNumeroDeCarne.Text);
                txtNumeroDeCarne.Clear();
                btnBuscar.Visible = false;

                lblApellidos.Enabled = false;
                lblNombre.Enabled = false;
                btnAgregarEstudiante.Enabled = false;
                txtApellidos.Enabled = false;
                txtNombre.Enabled = false;
                lblCarne.Enabled = false;
                txtNumeroDeCarne.Enabled = false;
                btnLimpiarCajaDeTexto.Visible = true;
            }
        }

        private void agregarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAgregarNotas.Visible = true;
            lblNota.Visible = true;
            txtNota.Visible = true;

            lblApellidos.Enabled = false;
            lblNombre.Enabled = false;
            btnAgregarEstudiante.Enabled = false;
            txtApellidos.Enabled = false;
            txtNombre.Enabled = false;
        }

        private void btnAgregarNotas_Click(object sender, EventArgs e)
        {
            if (!ElCurso.ListaDeEstudiantes.Any(estudianteIngresado => estudianteIngresado.Carne == txtNumeroDeCarne.Text) || txtNumeroDeCarne.Text == " ")
            {
                MessageBox.Show("El numero de carné está incorrecto o no existe");
            }
            else
            {
                ElCurso.IngresarNotaAlEstudiante(txtNumeroDeCarne.Text, Convert.ToInt32(txtNota.Text));
                MessageBox.Show("Nota ingresada correctamente", "Éxito");
                txtNota.Clear();
                txtNumeroDeCarne.Clear();

                btnAgregarNotas.Visible = false;
                lblNota.Visible = false;
                txtNota.Visible = false;

                lblApellidos.Enabled = true;
                lblNombre.Enabled = true;
                btnAgregarEstudiante.Enabled = true;
                txtApellidos.Enabled = true;
                txtNombre.Enabled = true;
            }
        }

        private void btnLimpiarCajaDeTexto_Click(object sender, EventArgs e)
        {
            lblApellidos.Enabled = true;
            lblNombre.Enabled = true;
            btnAgregarEstudiante.Enabled = true;
            txtApellidos.Enabled = true;
            txtNombre.Enabled = true;
            lblCarne.Enabled = true;
            txtNumeroDeCarne.Enabled = true;
            txtParaMostrarResultados.Clear();
            btnAgregarNotas.Visible = false;
        }
    }
}
