using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Singleton
{
    public class Singleton
    {
        private static Singleton instance = null;

        protected Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
            }
        }

        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
