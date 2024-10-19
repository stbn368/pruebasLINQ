using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebasLINQ
{
    public enum Departamento
    {
        RH = 201,
        Desarrollo = 520,
        Soporte = 402,
        Admin = 309
    }

    public class Empleado
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int IdExterno { get; set; }
        public double Salario { get; set; }
        public Departamento Departamento { get; set; }
    }
}
