using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Interfaces.DependecyInjection
{
    public class Computer
    {
        private IRam Ram { get; set; }

        private IBoard Board { get; set; }

        //property
        public IDisk Disk { get; set; }
        
        //contructor
        public Computer(IRam ram)
        {
            Ram = ram;
        }

        //parameter
        public void Turn_On(IBoard board)
        {
            this.Board = board;
        }
    }
}
