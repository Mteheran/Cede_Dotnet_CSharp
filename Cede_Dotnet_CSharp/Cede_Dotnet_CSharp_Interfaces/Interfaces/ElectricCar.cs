using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Interfaces.Interfaces
{
    public class ElectricCar: Car, IElectricCar, ISUV
    {
        public bool Is4_4 { get; set; }

        public int BatteryCount { get; set; }

        public ElectricCar()
        {
            

        }
       
    }
}
