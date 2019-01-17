using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numerosPares = from n in numeros
                               where (n % 2) == 0
                               select n;

            //Console.WriteLine(string.Join(",", numerosPares));

            // otra manera de hacerlo sin usar Linq
            foreach (var item in numeros)
            {
                if ((item % 2) == 0)
                {
                    //Console.Write($"{item},");
                }
            }

            Console.WriteLine("");

            var numerosMayoresA5 = from n in numeros
                                   where n > 5
                                   select n;

            //Console.WriteLine(string.Join(",", numerosMayoresA5));


            var numerosmayoresa2Menoresa7 = from n in numeros
                                            where n > 2 && n < 7
                                            select n;

            //Console.WriteLine(string.Join(",", numerosmayoresa2Menoresa7));


            string[] cadenas = { "Uno", "Dos", "Tres", "Cuatro", "Cinco" };

            var ContieneI = from c in cadenas
                            where c.Contains("i")
                            select c;

            //Console.WriteLine(string.Join(",", ContieneI));

            var ContieneC = from c in cadenas
                            where c.ToLower().Contains("c")
                            select c;

            //Console.WriteLine(string.Join(",", ContieneC));


            var esCuatro = from c in cadenas
                           where c == "Cuatro"
                           select c;

            //Console.WriteLine(string.Join(",", esCuatro));

            List<Estudiante> estudiantes = new List<Estudiante>();

            estudiantes.Add(new Estudiante() { Nombre = "Denys", Apellido = "Cuervo", Codigo = "E001", Edad = 19, Codigo_Curso = "C001" });
            estudiantes.Add(new Estudiante() { Nombre = "Hernan", Apellido = "Rojas", Codigo = "E002", Edad = 20, Codigo_Curso = "C002" });
            estudiantes.Add(new Estudiante() { Nombre = "Julian", Apellido = "Caicedo", Codigo = "E003", Edad = 18, Codigo_Curso = "C001" });
            estudiantes.Add(new Estudiante() { Nombre = "Ricardo", Apellido = "Zaldua", Codigo = "E004", Edad = 21, Codigo_Curso = "C002" });
            estudiantes.Add(new Estudiante() { Nombre = "Santiago", Apellido = "Balcero", Codigo = "E005", Edad = 20, Codigo_Curso = "C003" });
            estudiantes.Add(new Estudiante() { Nombre = "William", Apellido = "Garcia", Codigo = "E006", Edad = 19, Codigo_Curso = "C004" });
            estudiantes.Add(new Estudiante() { Nombre = "Miguel", Apellido = "Teheran", Codigo = "E007", Edad = 21, Codigo_Curso = "C005" });

            var estudiantesMayoresA20 = from e in estudiantes
                                        where e.Edad > 20
                                        select e;

            //foreach (var item in estudiantesMayoresA20)
            //{
            //    Console.WriteLine($"{item.Codigo} - {item.Nombre} {item.Apellido} - {item.Edad} ");
            //}

            var estudiantesApellidoconCMayorA18 = from e in estudiantes
                                                  where e.Edad > 18 && e.Apellido.ToLower().StartsWith("c")
                                                  select e;

            foreach (var item in estudiantesApellidoconCMayorA18)
            {
                //Console.WriteLine($"{item.Codigo} - {item.Nombre} {item.Apellido} - {item.Edad} ");
            }

            var estudiantesNombreFinalizaconOMayorA19 = from e in estudiantes
                                                        where e.Edad >= 20 || e.Nombre.ToLower().EndsWith("o")
                                                        select e;

            foreach (var item in estudiantesNombreFinalizaconOMayorA19)
            {
                //Console.WriteLine($"{item.Codigo} - {item.Nombre} {item.Apellido} - {item.Edad} ");
            }

            var estudiantesDiferentesFiltros = from e in estudiantes
                                               where ((e.Codigo == "E001" || e.Codigo == "E002") && e.Edad <= 19) || e.Edad >= 21
                                               select e;

            foreach (var item in estudiantesDiferentesFiltros)
            {
                //Console.WriteLine($"{item.Codigo} - {item.Nombre} {item.Apellido} - {item.Edad} ");
            }

            //Ordenamiento en Linq
            var estudiantesOrdenadosPorEdad = from e in estudiantes
                                              where e.Nombre.ToLower().Contains("m")
                                              orderby e.Edad ascending
                                              select e;

            var estudiantesOrdenadosPorEdadDescending = from e in estudiantes
                                                        where e.Nombre.ToLower().Contains("m")
                                                        orderby e.Edad descending
                                                        select e;

            IOrderedEnumerable<Estudiante> estudiantesOrdenadosPorNombreDescending = from e in estudiantes
                                                                                     orderby e.Nombre descending
                                                                                     select e;



            foreach (var item in estudiantesOrdenadosPorNombreDescending)
            {
                //Console.WriteLine($"{item.Codigo} - {item.Nombre} {item.Apellido} - {item.Edad} ");
            }

            //Agrupamiento
            var estudiantesAgrupadosPorEdad = from e in estudiantes
                                              orderby e.Edad
                                              group e by e.Edad;

            foreach (var group in estudiantesAgrupadosPorEdad)
            {
                //Console.WriteLine($"{group.Key} - {group.Count()}");

                foreach (var item in group)
                {
                    //Console.WriteLine($"{item.Codigo} - {item.Nombre} {item.Apellido} - {item.Edad} ");
                }
            }

            List<Curso> cursos = new List<Curso>();
            cursos.Add(new Curso() { Codigo = "C001", Nombre = "Curso Azure", Descripcion = "Curso de azure" });
            cursos.Add(new Curso() { Codigo = "C002", Nombre = "Curso HTML", Descripcion = "Curso basico y fundamentos de HTML" });
            cursos.Add(new Curso() { Codigo = "C003", Nombre = "Curso netCore", Descripcion = "Curso avanzado de .net core y microservicios" });
            cursos.Add(new Curso() { Codigo = "C004", Nombre = "Curso React.js", Descripcion = "Curso fron-end en React.js" });
            cursos.Add(new Curso() { Codigo = "C005", Nombre = "Curso Base de datos", Descripcion = "Curso basico de sentencias SQL, base de datos relacionales" });

            var EstudiantePorCurso = from e in estudiantes
                                     join c in cursos on e.Codigo_Curso equals c.Codigo
                                     orderby e.Edad
                                     select new { NombreEstudiante = e.Nombre, NombreCurso = c.Nombre };

            //foreach (var item in EstudiantePorCurso)
            //{
            //    Console.WriteLine($"{item.NombreEstudiante} - {item.NombreCurso}");
            //}

            foreach (var estudiante in estudiantes)
            {
                foreach (var curso in cursos)
                {
                    if (estudiante.Codigo_Curso == curso.Codigo)
                    {
                        //Console.WriteLine($"{estudiante.Nombre} - {curso.Nombre}");
                    }
                }
            }

            // Metodos de extension en las listas
            foreach (var item in estudiantes.OrderBy(p=> p.Edad))
            {
                //Console.WriteLine($"{item.Codigo} - {item.Nombre} {item.Apellido} - {item.Edad} ");
            }

            foreach (var item in estudiantes.OrderByDescending(p => p.Edad))
            {
                //Console.WriteLine($"{item.Codigo} - {item.Nombre} {item.Apellido} - {item.Edad} ");
            }

            foreach (var item in estudiantes.Where(p=> (p.Codigo_Curso == "C001" && p.Edad> 19) || p.Edad == 18).OrderBy(p=> p.Edad))
            {
                //Console.WriteLine($"{item.Codigo} - {item.Nombre} {item.Apellido} - {item.Edad} ");
            }

            var estudiante19 = estudiantes.First(p => p.Edad == 19);

            Console.WriteLine($"{estudiante19.Codigo} - {estudiante19.Nombre} {estudiante19.Apellido} - {estudiante19.Edad} ");            

            Console.WriteLine($"{estudiantes.Min(p => p.Edad)} - {estudiantes.Max(p => p.Edad)} - {estudiantes.Sum(p => p.Edad)/estudiantes.Count} ");

            Console.ReadKey();    
            
       }        
    }
}
