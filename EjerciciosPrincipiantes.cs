using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pruebasLINQ
{
    public static class EjerciciosPrincipiantes
    {
        /*
        1. Filtrar números pares de una lista:
        Descripción: Dada una lista de enteros, usa LINQ para filtrar los números pares.
        Ejemplo: Entrada: {1, 2, 3, 4, 5}, Salida: {2, 4}

        2. Transformar una lista de números al cuadrado:
        Descripción: Usa LINQ para transformar una lista de enteros en otra lista donde cada número esté elevado al cuadrado.
        Ejemplo: Entrada: {1, 2, 3}, Salida: {1, 4, 9}

        3. Filtrar palabras que empiezan con una letra específica:
        Descripción: Dada una lista de cadenas, selecciona solo las que comienzan con una letra específica (p. ej., letra 'a').
        Ejemplo: Entrada: {"apple", "banana", "apricot"}, Letra: 'a', Salida: {"apple", "apricot"}

        4. Ordenar una lista de enteros:
        Descripción: Usa LINQ para ordenar una lista de números de menor a mayor.
        Ejemplo: Entrada: {5, 2, 8, 3}, Salida: {2, 3, 5, 8}

        5. Obtener los primeros 3 números de una lista:
        Descripción: Dada una lista de enteros, usa LINQ para seleccionar los primeros 3 números.
        Ejemplo: Entrada: {1, 2, 3, 4, 5}, Salida: {1, 2, 3}
         */

        //Ejercicio 1
        public static void Ejercicio1()
        {
            //consulta LINQ para números pares
            var enterosPares = DB.listaNumerosRandom().Where(p => p%2 == 0);

            Console.WriteLine("Números pares:");
            foreach (int i in enterosPares)
            {
                Console.WriteLine(i);
            }
        }

        public static void Ejercicio2()
        {
            //lista que almacena números cuadrados con LINQ
            var enterosCuadrado = DB.listaNumerosRandom().Select(num => num * num).ToList();
            Console.WriteLine("Números cuadrados:");
            foreach (int i in enterosCuadrado)
            {
                Console.WriteLine(i);
            }
        }

        public static void Ejercicio1y2()
        {
            var listaEjercicio = DB.listaNumerosRandom();

            //lista que almacena números pares elevados al cuadrado con LINQ
            var enterosParesCuadrados = listaEjercicio.Where(p => p % 2 == 0)
                                            .Select(num => num * num)
                                            .ToList();

            foreach (var l in listaEjercicio)
            {
                Console.WriteLine(l);
            }

            if (enterosParesCuadrados.Any())
            {
                Console.WriteLine("Números pares elevados al cuadrado:");
                foreach (int i in enterosParesCuadrados)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("No hay números pares en la lista.");
            }
        }

        public static int Ejercicio3(string texto, char letra) => texto.ToLower().Where(l => l == letra).Count();
        
        public static void Ejercicio4()
        {
            var listaOrdenada = DB.listaNumerosRandom().OrderBy(e => e);
            foreach (var e in listaOrdenada)
            {
                Console.WriteLine(e);
            }
        }

        public static void Ejercicio5()
        {
            var elementos = DB.listaNumerosRandom().Take(3);
            foreach (var e in elementos)
            {
                Console.WriteLine(e);
            }
        }

    }
}
