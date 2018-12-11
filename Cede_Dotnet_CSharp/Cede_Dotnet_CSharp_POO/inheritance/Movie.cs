using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_POO.inheritance
{
    public class Movie
    {
        public string Title { get; set; }

        public Movie(string title)
        {
            Title = title;
        }

        public virtual void Play()
        {
            string PlayText = "Playing";
        }
    }
}
