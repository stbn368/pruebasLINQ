using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebasLINQ
{
    public class DB
    {
        public List<Empleado> empleados = new List<Empleado>()
            {
                new Empleado {
                    Nombre = "Daniela",
                    Apellido = "Pérez",
                    Departamento = Departamento.Desarrollo,
                    Edad = 29,
                    IdExterno = 1,
                    Salario = 1500
                },
                new Empleado {
                    Nombre = "José",
                    Apellido = "Lima Rico",
                    Departamento = Departamento.Admin,
                    Edad = 40,
                    IdExterno = 2,
                    Salario = 1780
                },
                 new Empleado {
                    Nombre = "Fernanda",
                    Apellido = "Vega Valle",
                    Departamento = Departamento.Desarrollo,
                    Edad = 35,
                    IdExterno = 3,
                    Salario = 1900
                },
                  new Empleado {
                    Nombre = "Fabiola",
                    Apellido = "Cortés Vázquez",
                    Departamento = Departamento.Desarrollo,
                    Edad = 25,
                    IdExterno = 4,
                    Salario = 2400

                },
                   new Empleado {
                    Nombre = "Mónica",
                    Apellido = "Correa",
                    Departamento = Departamento.Soporte,
                    Edad = 22,
                    IdExterno = 5,
                    Salario = 1350
                },
            };

        public List<Estudiante> estudiantes = new List<Estudiante>()
            {
                new Estudiante {
                    Id = "254",
                    Nombre = "Daniela",
                    Edad = 29
                },
                new Estudiante {
                    Id = "255",
                    Nombre = "Esteban",
                    Edad = 28
                },
                new Estudiante {
                    Id = "256",
                    Nombre = "Gloria",
                    Edad = 28
                },
                new Estudiante {
                    Id = "257",
                    Nombre = "Leporino",
                    Edad = 15
                },
                new Estudiante {
                    Id = "258",
                    Nombre = "Coquina",
                    Edad = 15
                }
            };

        public List<Calificacion> notas = new List<Calificacion>()
            {
                new Calificacion {
                    EstudianteId = "254",
                    Nota = 8.25
                },
                new Calificacion {
                    EstudianteId = "255",
                    Nota = 9
                },
                new Calificacion{
                    EstudianteId = "256",
                    Nota = 9.5
                },
                new Calificacion {
                    EstudianteId = "257",
                    Nota = 7.25
                },
                new Calificacion {
                    EstudianteId = "258",
                    Nota = 7.75
                }
            };


        public static List<string> frutas = new List<string>()
            {"plátano","naranja","melón","sandia","mandarina","kiwi","mango","melocotón",};

        //método para generar lista de enteros random
        public static List<int> lista()
        {
            Random random = new Random();
            List<int> listaEnteros = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                listaEnteros.Add(random.Next(1, 101)); // Genera un número entre 1 y 100
            }
            return listaEnteros;
        }

    }

}
