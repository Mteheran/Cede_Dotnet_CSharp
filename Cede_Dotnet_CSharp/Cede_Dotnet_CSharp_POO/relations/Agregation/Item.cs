using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_POO.relations.Agregation
{
    public class Item
    {
        public Guid ID { get; set; }

        public string Description { get; set; }

        public bool IsDone { get; set; }
    }
}
