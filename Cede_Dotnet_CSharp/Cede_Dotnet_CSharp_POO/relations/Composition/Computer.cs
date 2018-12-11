using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_POO.relations.Composition
{
    public class Computer
    {
        public Keyboard Keyboard { get; set; }

        public Monitor Monitor { get; set; }

        public Mouse Mouse { get; set; }
    }
}
