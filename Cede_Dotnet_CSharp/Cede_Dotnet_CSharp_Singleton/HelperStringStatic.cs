using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Singleton
{
    public static class HelperStringStatic
    {
        public static  string RemoveSpecialCharactersWindowsFolder(string texto)
        {
            texto = texto.Replace("/", "");

            return texto;
        }
    }
}
