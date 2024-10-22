using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebasLINQ
{
    public class Estudiante
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Curso { get; set; }
        public int Nota { get; set; }
    }

    public class Calificacion
    {
        public string EstudianteId { get; set; }
        public double Nota { get; set; }
    }
}
