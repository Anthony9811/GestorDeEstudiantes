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
            
            if(txtNumeroDeCarne.Text == " " || txtNombre.Text == " " || txtApellidos.Text == " ")
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
            }

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
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtParaMostrarResultados.Text = ElCurso.MostrarDatosDeEstudiante(txtNumeroDeCarne.Text);
        }

        private void mnEstudianteConPromedioMásBajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtParaMostrarResultados.Text = (ElCurso.ObtenerEstudianteConPromedioMasBajo());
        }

        private void mnEstudianteConPromedioMásAltoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtParaMostrarResultados.Text = (ElCurso.ObtenerEstudianteConPromedioMasAlto());
        }
    }
}
