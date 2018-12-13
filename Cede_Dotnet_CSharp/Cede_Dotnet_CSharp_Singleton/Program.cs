using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(Singleton.Instance.HelloWorld());

            Console.WriteLine(HelperString.Instance.RemoveSpecialCharactersWindowsFolder("Lacteos /"));

            Console.WriteLine(HelperStringStatic.RemoveSpecialCharactersWindowsFolder("Lacteos /"));

            Console.ReadLine();
        }
    }
}
