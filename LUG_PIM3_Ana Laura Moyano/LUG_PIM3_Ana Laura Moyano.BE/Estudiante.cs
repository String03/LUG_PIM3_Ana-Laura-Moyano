using System;
using System.Collections.Generic;

namespace LUG_PIM3_Ana_Laura_Moyano.BE
{
    public class Estudiante
    {
        public Estudiante()
        {
            Materias = new List<MateriaPorEstudiante>();
        }

        public int Id { get; set; }
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaReg { get; set; }

        public List<MateriaPorEstudiante> Materias { get; set; }
    }
}
