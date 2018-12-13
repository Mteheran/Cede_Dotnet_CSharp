using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Interfaces.AbstractClasses
{
    public class SmallCar : Car
    {
        public SmallCar()
        {
            this.GetSpeed();
        }

        public override double GetSpeed()
        {
            this.Turn_On();

            return base.GetSpeed();
        }

        public override string Turn_On()
        {
            throw new NotImplementedException();
        }

    }
}
