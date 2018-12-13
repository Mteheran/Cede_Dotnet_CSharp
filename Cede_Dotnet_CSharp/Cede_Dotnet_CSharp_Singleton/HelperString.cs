using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Singleton
{
    public class HelperString
    {
        private static HelperString instance = null;

        protected HelperString() { }

        public static HelperString Instance
        {
            get
            {
                if (instance == null)
                    instance = new HelperString();

                return instance;
            }
        }

        public string RemoveSpecialCharactersWindowsFolder(string texto)
        {
            texto = texto.Replace("/", "");

            return texto;
        }
    }
}
