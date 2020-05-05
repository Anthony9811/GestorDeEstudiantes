using System;
using System.Collections.Generic;

namespace GestorDeEstudiantes.LogicaDeNegocios
{
    public class Estudiante
    {
        

        public string Nombre { get; set; }

        public string Carne { get; set; }

        public string Apellidos { get; set; }

        public List<int> Notas { get; set; }

        public Estudiante()
        {
            Carne = " ";
            Nombre = " ";
            Apellidos = " ";
            Notas = new List<int>();
        }

    }
}
