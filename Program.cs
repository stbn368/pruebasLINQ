using pruebasLINQ;

//EjerciciosPrincipiantes.Ejercicio1();
//EjerciciosPrincipiantes.Ejercicio2();
//EjerciciosPrincipiantes.Ejercicio1y2();
//Console.WriteLine(EjerciciosPrincipiantes.Ejercicio3("esto es un prueba", 'e'));
//EjerciciosPrincipiantes.Ejercicio4();
//EjerciciosPrincipiantes.Ejercicio5();

//EjerciciosIntermedios.Ejercicio1();
//EjerciciosIntermedios.Ejercicio2();
//EjerciciosIntermedios.Ejercicio3();
//EjerciciosIntermedios.Ejercicio4();
//EjerciciosIntermedios.Ejercicio5();

EjerciciosAvanzados.Ejercicio1();
//EjerciciosAvanzados.Ejercicio2();
//EjerciciosAvanzados.Ejercicio3();
//EjerciciosAvanzados.Ejercicio4();
//EjerciciosAvanzados.Ejercicio5();


Console.WriteLine("************************************************************************************************");


//instanciamos un objeto DB para ponder acceder a las listas de datos
DB db = new DB();

//obtener empleados que comienzen por la letra 'f'
var em = db.empleados.Where(e => e.Nombre.ToLower().StartsWith('f'));

var ed = db.empleados.Where(e => e.Departamento == Departamento.Desarrollo && e.Nombre.ToLower().Contains("f")).OrderBy(e => e.Id);

//************************************************************************************************
//primera forma
var filtro = db.empleados.Where(e => (e.Departamento == Departamento.Desarrollo
                                                || e.Departamento == Departamento.Soporte)
                                                && e.Apellido.ToLower().StartsWith("c"))
                .OrderByDescending(e => e.Nombre)
                .Select(e => new
                {
                    e.Id,
                    e.Nombre,
                    InicialApellido = e.Apellido.Substring(0, 1),
                    Depto = e.Departamento
                });

//segunda forma (formato consulta)
var qfiltro = from e in db.empleados
              where (e.Departamento == Departamento.Desarrollo
                     || e.Departamento == Departamento.Soporte)
                     && e.Apellido.ToLower().StartsWith("c")
                orderby e.Nombre descending
                select new
                {
                    e.Id,
                    e.Nombre,
                    InicialApellido = e.Apellido.Substring(0, 1),
                    Depto = e.Departamento
                };
//************************************************************************************************

//************************************************************************************************
//busca el nombre cuya longitud es igual o menor que la longitud del apellido más corto
var filtroSub = db.empleados.Where(e => e.Nombre.Length <= db.empleados
                                   .OrderBy(eb => eb.Apellido.Length)
                                   .Select(eb => eb.Apellido.Length)
                                   .First());

//en formato consulta
var qfiltroSub = from e in db.empleados
                 where e.Nombre.Length <=
                 (from eb in db.empleados
                  orderby eb.Apellido.Length
                  select eb.Apellido.Length
                 ).First()
                 select e;
//************************************************************************************************

var encabezado = string.Format("{0,-40} {1,-10} {2,-10} {3}",
                "Id", "Nombre", "Inicial Apellido", "Codigo Depto");
Console.WriteLine(encabezado);

foreach (var f in filtro)
{
    string fila = string.Format("{0,-40} {1,-10} {2,-10} {3}",
        f.Id, f.Nombre, f.InicialApellido, f.Depto);
    Console.WriteLine(fila);
}

foreach (var f in filtroSub)
{
    string fila = string.Format("{0,-10} {1,-10}",
        f.Nombre, f.Apellido);
    Console.WriteLine(fila);
}

/* LINQ se ejecuta de forma diferida por lo que la consulta no se ejecuta
 * hasta que se utiliza, en el ejemplo hasta llegar el foreach.
 * 
 * Tiene ventajas en el rendimiento de la aplicación
 * Otra ventaja es que los valores pueden cambiar durante la ejecución del programa
 * y afectar al resultado de la consulta
 */

/* Ejecución inmediata
 * Hay operadores de LINQ que fuerzan la ejecución inmediata
 * Un ejemplo sería el método ToArray()
 */






