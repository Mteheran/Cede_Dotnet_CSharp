using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Interfaces.DependecyInjection
{
    public class User
    {

        public void UsePC()
        {
            IRam ram = new MemoryRam();

            //contructor
            Computer computer = new Computer(ram);

            //property
            computer.Disk = new HardDrive();

            //Parameter
            computer.Turn_On(new MotherBoard());
        }
    }
}
