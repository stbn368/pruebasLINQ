﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebasLINQ
{
    public class EjerciciosAvanzados
    {
        /*
        1. Consultas anidadas para encontrar empleados con salarios por encima del promedio:
        Descripción: Dada una lista de empleados (con Nombre y Salario), usa LINQ para obtener los empleados cuyo salario está por encima del salario promedio.
        class Empleado { public string Nombre; public decimal Salario; }
        Salida: Lista de empleados con salario superior al promedio.
        
        2. Agrupar y contar ocurrencias en una lista de palabras:
        Descripción: Dada una lista de palabras, usa LINQ para agruparlas por palabra y contar cuántas veces aparece cada una.
        Ejemplo: Entrada: {"apple", "banana", "apple", "orange", "banana"}, Salida: {"apple"=2, "banana"=2, "orange"=1}
        
        3. Obtener los 3 productos más caros usando LINQ:
        Descripción: Dada una lista de productos (con Nombre y Precio), usa LINQ para obtener los 3 productos más caros.
        class Producto { public string Nombre; public decimal Precio; }
        
        4. Realizar un Join Externo Izquierdo (Left Outer Join):
        Descripción: Dadas dos listas, una de clientes y otra de pedidos, realiza un Left Outer Join para obtener todos los clientes y sus pedidos (si existen). 
        Si no tienen pedidos, el cliente igualmente debe aparecer en el resultado con valor null para los pedidos.
        class Cliente { public int ClienteId; public string Nombre; }
        class Pedido { public int ClienteId; public string DetallesPedido; }
        
        5. Consulta LINQ sobre una base de datos simulada:
        Descripción: Crea una simulación de una base de datos en memoria usando listas de objetos que representan una tienda en línea (productos, clientes, pedidos, etc.). 
        Luego, usa LINQ para hacer consultas como:
        Obtener todos los clientes que hicieron pedidos en el último mes.
        Calcular el total de ventas por cliente.
        Obtener los 5 productos más vendidos.
        
        6. Consulta con múltiples niveles de agrupación:
        Descripción: Dada una lista de estudiantes con Nombre, Curso y Nota, usa LINQ para agrupar a los estudiantes por curso y luego por rango de notas 
        (por ejemplo, >90, 70-90, <70).
        class Estudiante { public string Nombre; public string Curso; public int Nota; }

        7. Consultas con Deferred Execution y optimización:
        Descripción: Dada una lista grande de números, filtra los números pares, ordénalos, y selecciona los primeros 10 números. 
        Optimiza el código utilizando deferred execution (ejecución diferida).
        Ejemplo: Muestra cómo se ejecuta la consulta solo cuando se itera sobre ella.
        
        8. Simulación de un sistema de recomendaciones:
        Descripción: Dada una lista de productos y otra de usuarios con sus compras, crea una consulta LINQ para recomendar productos a usuarios basados 
        en compras similares de otros usuarios.
        Ejemplo: Los usuarios que compraron el producto A tienden a comprar también el producto B.
        */

        public static DB db = new DB();

        public static void Ejercicio1()
        {
            var empleadoMayorSalarioMedio = db.empleados?.Select(e => e).Where(
                s => s.Salario > (db.empleados.Average(s => s.Salario)));

            Console.WriteLine($"Salario medio: {db.empleados.Average(s => s.Salario)}");
            foreach (var e in empleadoMayorSalarioMedio)
            {
                Console.WriteLine($"{e.Nombre} --> salario: {e.Salario}");
            }
        }

        public static void Ejercicio2()
        {
            var frutasRepetidas = DB.frutasConRepeticiones.GroupBy(f => f);

            foreach (var fruta in frutasRepetidas)
            {
                Console.Write($"{fruta.Key} --> ");
                Console.WriteLine(fruta.Count());
            }
        }
        public static void Ejercicio3()
        {
            var productosMasCaros = db.productos.OrderByDescending(p => p.Precio).Take(3);
            foreach (var p in productosMasCaros)
            {
                Console.WriteLine(p.Nombre);
            }
        }

        public static void Ejercicio4()
        {
            var clientesPedido = db.clientes?.Join(db.pedidos,
                                    cli => cli.ClienteId,
                                    ped => ped.ClienteId,
                                    (cli, ped) => new {
                                        cli.Nombre,
                                        ped.DetallesPedido
                                    });

            foreach (var cliPe in clientesPedido)
            {
                Console.WriteLine($"{cliPe.Nombre} --> {cliPe.DetallesPedido}");
            }
        }
        public static void Ejercicio5()
        {
            var pedidosClienteUltimoMes = db.pedidosNew.Where(d => d.FechaPedido.Month >= DateTime.Now.Month).Join(db.clientesNew,
                ped => ped.PedidoId,
                cli => cli.ClienteId,
                (ped, cli) => new
                {
                    cli.Nombre
                });

            foreach (var c in pedidosClienteUltimoMes)
            {
                Console.WriteLine(c.Nombre);
            }
        }
        public static void Ejercicio6()
        {
            var agrupacionPorCursoYRango = db.estudiantesNew
            .GroupBy(e => e.Curso)  // Agrupar por Curso
            .Select(grupoCurso => new
            {
                Curso = grupoCurso.Key,
                RangosDeNotas = grupoCurso
                    .GroupBy(e =>
                    {
                        // Clasificar a los estudiantes por rango de notas
                        if (e.Nota > 90)
                            return ">90";
                        else if (e.Nota >= 70 && e.Nota <= 90)
                            return "70-90";
                        else
                            return "<70";
                    })
                    .Select(grupoRango => new
                    {
                        Rango = grupoRango.Key,
                        Estudiantes = grupoRango
                    })
            });

            // Mostrar los resultados
            foreach (var curso in agrupacionPorCursoYRango)
            {
                Console.WriteLine($"Curso: {curso.Curso}");
                foreach (var rango in curso.RangosDeNotas)
                {
                    Console.WriteLine($"  Rango de Notas: {rango.Rango}");
                    foreach (var estudiante in rango.Estudiantes)
                    {
                        Console.WriteLine($"    Nombre: {estudiante.Nombre}, Nota: {estudiante.Nota}");
                    }
                }
            }
        }
    }
}
