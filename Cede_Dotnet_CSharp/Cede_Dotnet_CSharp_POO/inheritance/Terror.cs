using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_POO.inheritance
{
    public class Terror: Movie
    {
        public Terror(string title) : base(title)
        {
            this.Title = title;
            this.Play();
        }
    }
}
