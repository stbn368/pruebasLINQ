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
                    Edad = 29,
                    Curso = "2B"
                },
                new Estudiante {
                    Id = "255",
                    Nombre = "Esteban",
                    Edad = 28,
                    Curso = "2B"
                },
                new Estudiante {
                    Id = "256",
                    Nombre = "Gloria",
                    Edad = 28,
                    Curso = "2B"
                },
                new Estudiante {
                    Id = "257",
                    Nombre = "Leporino",
                    Edad = 15,
                    Curso = "1A"
                },
                new Estudiante {
                    Id = "258",
                    Nombre = "Coquina",
                    Edad = 15,
                    Curso = "1C"
                }
            };

        public List<Calificacion> notas = new List<Calificacion>()
            {
                new Calificacion {
                    EstudianteId = "254",
                    Nota = 7.25
                },
                new Calificacion {
                    EstudianteId = "255",
                    Nota = 9.35
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

        public List<Producto> productos = new List<Producto>()
        {
            new Producto
            {
                Nombre = "Leche",
                Precio = 1.05,
                ProductoId = 12
            },
            new Producto
            {
                Nombre = "Café",
                Precio = 5.55,
                ProductoId = 14
            },
            new Producto
            {
                Nombre = "Yogur griego",
                Precio = 1.50,
                ProductoId = 15
            },
            new Producto
            {
                Nombre = "Plátano",
                Precio = 2.04,
                ProductoId = 18
            },
            new Producto
            {
                Nombre = "Nachos",
                Precio = 3.65,
                ProductoId = 19
            },
            new Producto
            {
                Nombre = "Pollo",
                Precio = 5.48,
                ProductoId = 20
            },
            new Producto
            {
                Nombre = "Cerveza",
                Precio = 6.99,
                ProductoId = 21
            },
            new Producto
            {
                Nombre = "Desodorante",
                Precio = 2.05,
                ProductoId = 22
            }
        };

        // Lista de clientes
        public List<Cliente> clientes = new List<Cliente>
        {
            new Cliente { ClienteId = 1, Nombre = "Juan" },
            new Cliente { ClienteId = 2, Nombre = "Ana" },
            new Cliente { ClienteId = 3, Nombre = "Luis" },
            new Cliente { ClienteId = 4, Nombre = "Marta" },
            new Cliente { ClienteId = 5, Nombre = "Pedro" }
        };

        // Lista de pedidos
        public List<Pedido> pedidos = new List<Pedido>
        {
            new Pedido { ClienteId = 1, DetallesPedido = "Pedido de laptop" },
            new Pedido { ClienteId = 1, DetallesPedido = "Pedido de teléfono" },
            new Pedido { ClienteId = 3, DetallesPedido = "Pedido de libros" },
            new Pedido { ClienteId = 5, DetallesPedido = "Pedido de ropa" }
        };

        //***********************************************************************************************

        // Lista de clientes
        public List<Cliente> clientesNew = new List<Cliente>
        {
            new Cliente { ClienteId = 1, Nombre = "Juan Pérez", Email = "juan@gmail.com" },
            new Cliente { ClienteId = 2, Nombre = "Ana García", Email = "ana@gmail.com" },
            new Cliente { ClienteId = 3, Nombre = "Luis Martínez", Email = "luis@gmail.com" },
            new Cliente { ClienteId = 4, Nombre = "Marta López", Email = "marta@gmail.com" }
        };

        // Lista de productos
        public List<Producto> productosNew = new List<Producto>
        {
            new Producto { ProductoId = 1, Nombre = "Laptop", Precio = 1200 },
            new Producto { ProductoId = 2, Nombre = "Smartphone", Precio = 800 },
            new Producto { ProductoId = 3, Nombre = "Tablet", Precio = 400 },
            new Producto { ProductoId = 4, Nombre = "Auriculares", Precio = 150 },
            new Producto { ProductoId = 5, Nombre = "Monitor", Precio = 300 }
        };

        // Lista de pedidos
        public List<Pedido> pedidosNew = new List<Pedido>
        {
            new Pedido { PedidoId = 1, ClienteId = 1, FechaPedido = DateTime.Now.AddDays(-10) },
            new Pedido { PedidoId = 2, ClienteId = 2, FechaPedido = DateTime.Now.AddDays(-20) },
            new Pedido { PedidoId = 3, ClienteId = 3, FechaPedido = DateTime.Now.AddDays(-5) },
            new Pedido { PedidoId = 4, ClienteId = 4, FechaPedido = DateTime.Now.AddDays(-30) },
            new Pedido { PedidoId = 5, ClienteId = 1, FechaPedido = DateTime.Now.AddDays(-40) }
        };

        // Lista de detalles de pedidos
        public List<DetallePedido> detallesPedidos = new List<DetallePedido>
        {
            new DetallePedido { PedidoId = 1, ProductoId = 1, Cantidad = 1 }, // Laptop para Juan
            new DetallePedido { PedidoId = 1, ProductoId = 4, Cantidad = 2 }, // 2 Auriculares para Juan
            new DetallePedido { PedidoId = 2, ProductoId = 2, Cantidad = 1 }, // Smartphone para Ana
            new DetallePedido { PedidoId = 3, ProductoId = 3, Cantidad = 1 }, // Tablet para Luis
            new DetallePedido { PedidoId = 4, ProductoId = 5, Cantidad = 1 }, // Monitor para Marta
            new DetallePedido { PedidoId = 5, ProductoId = 1, Cantidad = 1 }, // Laptop para Juan
        };

        //***********************************************************************************************

        public List<Estudiante> estudiantesNew = new List<Estudiante>
        {
            new Estudiante { Nombre = "Juan", Curso = "Matemáticas", Nota = 95 },
            new Estudiante { Nombre = "Ana", Curso = "Matemáticas", Nota = 85 },
            new Estudiante { Nombre = "Pedro", Curso = "Matemáticas", Nota = 65 },
            new Estudiante { Nombre = "María", Curso = "Ciencias", Nota = 92 },
            new Estudiante { Nombre = "Sofía", Curso = "Ciencias", Nota = 78 },
            new Estudiante { Nombre = "Carlos", Curso = "Ciencias", Nota = 60 },
            new Estudiante { Nombre = "Luis", Curso = "Historia", Nota = 88 },
            new Estudiante { Nombre = "Marta", Curso = "Historia", Nota = 73 },
            new Estudiante { Nombre = "Jorge", Curso = "Historia", Nota = 50 }
        };

        public static List<string> frutas = new List<string>()
            {"plátano","naranja","melón","sandia","mandarina","kiwi","mango","melocotón",};

        public static List<string> frutasConRepeticiones = new List<string>()
            {"plátano","naranja","melón","sandia","mandarina", "melón", "plátano", "kiwi", "kiwi","mango","melocotón", "melón"};

        //método para generar lista de enteros random
        public static List<int> listaNumerosRandom()
        {
            Random random = new Random();
            List<int> listaRandomEnteros = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                listaRandomEnteros.Add(random.Next(1, 101)); // Genera un número entre 1 y 100
            }
            return listaRandomEnteros;
        }

    }

}
