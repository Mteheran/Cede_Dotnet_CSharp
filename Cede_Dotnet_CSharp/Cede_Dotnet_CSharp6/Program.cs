using System;
using static System.Console;

namespace Cede_Dotnet_CSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            DefaultValue defaultValue = new DefaultValue();
            //Console.WriteLine(defaultValue.Value1);

            //null operator - operador null
            DateTime? dateTime = null;
            //Console.WriteLine(dateTime?.ToShortDateString());

            string texto1 = "Hola a todos";
            string texto2 = "Un saludo cordial";
            string texto3 = "Que tengan un buen día";

            Console.WriteLine($@"
                                {texto1} 
                                {texto2} 
                                {texto3}.");

            Console.WriteLine($"{texto1}{Environment.NewLine}{texto2}{Environment.NewLine}{texto3}.");

            Console.WriteLine($"{GetText()}.");

            WriteLine("using static class");

            Console.ReadLine();

            try
            {
                WriteLine("using static class");
            }
            catch (Exception ex) when (ex.Message.Contains("101"))
            {
                WriteLine("Error 101" + ex.StackTrace);
            }
        }
        public static string GetText()
        {
            return "Texto desde función";
        }
    }

    
}
