using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_POO.abtract
{
    public abstract class School
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public bool InClasses { get; set; }

        public abstract void StartClasses();

        public abstract void EndingClasses();
    }
}
