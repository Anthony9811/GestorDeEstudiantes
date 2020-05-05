using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace GestorDeEstudiantes.LogicaDeNegocios
{
    public class Curso
    {
        public List<Estudiante> ListaDeEstudiantes { get; set; }

        public Curso()
        {
            ListaDeEstudiantes = new List<Estudiante>();
        }

        public void AgregarEstudiante(Estudiante estudianteAIngresar)
        {
            ListaDeEstudiantes.Add(estudianteAIngresar);
        }

        public int ObtenerLaCantidadDeEstudiantes()
        {
            return ListaDeEstudiantes.Count;
        }

        public void IngresarNotaAlEstudiante(string carneDelEstudiante, int laNota)
        {
            Estudiante estudianteEnEspecifico = ListaDeEstudiantes.Find(estudianteBuscado => estudianteBuscado.Carne == carneDelEstudiante);
            if(estudianteEnEspecifico != null)
            {
                estudianteEnEspecifico.Notas.Add(laNota);
            }
        }

        public string MostrarDatosDeEstudiante(string carneDelEstudiante)
        {
            Estudiante elEstudianteAMostrar = ListaDeEstudiantes.Find(estudianteBuscado => estudianteBuscado.Carne == carneDelEstudiante);
            string datosAMostrar;
            string unMensaje = "Este estudiante no existe";

            if (elEstudianteAMostrar != null)
            {
                datosAMostrar = "Carné: " + elEstudianteAMostrar.Carne +
                                "\n" + "Nombre: " + elEstudianteAMostrar.Nombre +
                                " " + elEstudianteAMostrar.Apellidos +
                                "\n" + "Nota más alta: " + elEstudianteAMostrar.Notas.Max() +
                                "\n" + "Nota más baja: " + elEstudianteAMostrar.Notas.Min() +
                                "\n" + "Promedio de notas: " + elEstudianteAMostrar.Notas.Average();

                return datosAMostrar;
            }
            else
            {
                return unMensaje;
            }
        }

        public string ObtenerEstudianteConPromedioMasAlto()
        {
            Estudiante elEstudiante = ListaDeEstudiantes.Find(elPromedioAlto => elPromedioAlto.Notas.Average() == ListaDeEstudiantes.Max(promedio => promedio.Notas.Average()));
            String datosAMostrar;
         
          if(elEstudiante != null)
            {
               datosAMostrar =  "Carné: " + elEstudiante.Carne +
                       "\nNombre: " + elEstudiante.Nombre +
                       "\nApellidos " + elEstudiante.Apellidos +
                       "\nNota más alta: " + elEstudiante.Notas.Max() +
                       "\nNota más baja: " + elEstudiante.Notas.Min() +
                       "\nPromedio: " + elEstudiante.Notas.Average();
            return datosAMostrar;
            }
            else
            {
                return "Datos no encontrados";
            }
        }

        public string ObtenerEstudianteConPromedioMasBajo()
        {
            Estudiante elEstudiante = ListaDeEstudiantes.Find(promedioBajo => promedioBajo.Notas.Average() == ListaDeEstudiantes.Min(promedio => promedio.Notas.Average()));
            String datosAMostrar;

            if (elEstudiante != null)
            {
                datosAMostrar = "Carné: " + elEstudiante.Carne +
                        "\nNombre: " + elEstudiante.Nombre +
                        "\nApellidos " + elEstudiante.Apellidos +
                        "\nNota más alta: " + elEstudiante.Notas.Max() +
                        "\nNota más baja: " + elEstudiante.Notas.Min() +
                        "\nPromedio: " + elEstudiante.Notas.Average();
                return datosAMostrar;
            }
            else
            {
                return "Datos no encontrados";
            }
        }
    }
}
