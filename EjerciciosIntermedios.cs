using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebasLINQ
{
    public static class EjerciciosIntermedios
    {
        /*
        1. Obtener los nombres de las personas mayores de 30 años:
        Descripción: Dada una lista de objetos Persona (con Nombre y Edad), usa LINQ para obtener los nombres de las personas mayores de 30 años.
        
        2. Contar cuántos números son mayores a un valor específico:
        Descripción: Dada una lista de enteros, usa LINQ para contar cuántos números son mayores que 10.
        Ejemplo: Entrada: {5, 12, 18, 7, 30}, Salida: 3
        
        3. Agrupar palabras por su longitud:
        Descripción: Dada una lista de palabras, agrúpalas por su longitud.
        Ejemplo: Entrada: {"apple", "banana", "kiwi"}, Salida: Grupo de longitud 5: {"apple", "kiwi"}, Grupo de longitud 6: {"banana"}
        
        4. Unir dos listas de objetos usando LINQ Join:
        Descripción: Tienes dos listas: una de estudiantes y otra de notas. Usa LINQ para unirlas basándote en el StudentId y obtener el nombre del estudiante junto con su nota.
        Ejemplo:
        class Estudiante { public int Id; public string Nombre; }
        class Nota { public int StudentId; public int Calificacion; }
        
        5. Obtener el segundo número más grande en una lista:
        Descripción: Dada una lista de números, usa LINQ para encontrar el segundo número más grande.
        Ejemplo: Entrada: {3, 5, 8, 2}, Salida: 5
         */

        public static DB db = new DB();

        public static void Ejercicio1()
        {
            var nombresPersonasMayores = db.empleados.Where(e => e.Edad >= 30)
                .Select(e => e.Nombre);
            foreach (var n in nombresPersonasMayores)
            {
                Console.WriteLine(n);
            }
        }

        public static void Ejercicio2()
        {
            var numerosMayores = DB.listaNumerosRandom().Where(n => n > 10);

            Console.WriteLine("En la lista:");
            foreach(var n in numerosMayores)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine($"Hay {numerosMayores.Count()} números mayores que 10.");
        }
        public static void Ejercicio3()
        {
            var frutasOrdenadas = DB.frutas.OrderBy(f => f.Length);

            foreach (var fruta in frutasOrdenadas)
            {
                Console.WriteLine(fruta);
            }
        }

        public static void Ejercicio4()
        {
            var estudianteNota = db.estudiantes.Join(db.notas,
                                                estudiante => estudiante.Id,
                                                nota => nota.EstudianteId,
                                                (estudiante, nota) => new
                                                {
                                                    estudiante.Nombre,
                                                    nota.Nota
                                                });

            foreach (var e in estudianteNota)
            {
                Console.WriteLine($"Nombre: {e.Nombre} --> {e.Nota}");
            }
        }

        public static void Ejercicio5()
        {
            var lista = DB.listaNumerosRandom().OrderByDescending(n => n);

            Console.WriteLine("Lista:");
            foreach (var v in lista)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Segundo valor más alto:");
            Console.WriteLine(lista.Skip(1).FirstOrDefault());
        }
    }
}
