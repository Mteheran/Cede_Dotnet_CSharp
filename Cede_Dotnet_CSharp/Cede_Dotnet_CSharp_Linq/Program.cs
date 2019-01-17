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
                if ((item%2) == 0)
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
                                            where n > 2 && n <7
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

            estudiantes.Add(new Estudiante() { Nombre= "Denys", Apellido = "Cuervo", Codigo = "E001", Edad= 19});
            estudiantes.Add(new Estudiante() { Nombre = "Hernan", Apellido = "Rojas", Codigo = "E002", Edad = 20 });
            estudiantes.Add(new Estudiante() { Nombre = "Julian", Apellido = "Caicedo", Codigo = "E003", Edad = 18 });
            estudiantes.Add(new Estudiante() { Nombre = "Ricardo", Apellido = "Zaldua", Codigo = "E004", Edad = 21 });
            estudiantes.Add(new Estudiante() { Nombre = "Santiago", Apellido = "Balcero", Codigo = "E005", Edad = 20 });
            estudiantes.Add(new Estudiante() { Nombre = "William", Apellido = "Garcia", Codigo = "E006", Edad = 19 });
            estudiantes.Add(new Estudiante() { Nombre = "Miguel", Apellido = "Teheran", Codigo = "E007", Edad = 21 });

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
                Console.WriteLine($"{item.Codigo} - {item.Nombre} {item.Apellido} - {item.Edad} ");
            }


            Console.ReadKey();
        }
    }
}
