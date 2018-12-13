using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Interfaces.Interfaces
{
    public class Auto : ICar
    {
        public string Mark { get; set; }
        public string Color { get; set; }
        public string Version { get; set; }

        public void Turn_On()
        {
            throw new NotImplementedException();
        }
    }
}
