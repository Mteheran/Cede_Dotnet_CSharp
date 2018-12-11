using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Interfaces.AbstractClasses
{
    public abstract class Car
    {
        public abstract string Turn_On();

        public virtual double GetSpeed()
        {
            return new Random().NextDouble();
        }
    }
}
