using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Interfaces.AbstractClasses
{
    public class SmallCar : Car
    {
        public override string Turn_On()
        {
            throw new NotImplementedException();
        }

        public override string GetSpeed() 
        {
            return 0;
        }
    }
}
