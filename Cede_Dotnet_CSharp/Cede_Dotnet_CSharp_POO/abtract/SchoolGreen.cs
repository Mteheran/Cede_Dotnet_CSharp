using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_POO.abtract
{
    public class SchoolGreen : School
    {
        public override void EndingClasses()
        {
            this.InClasses = false;
        }

        public override void StartClasses()
        {
            this.InClasses = true;
        }
    }
}
