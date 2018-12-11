using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_POO.inheritance
{
    public class Drama : Movie
    {
        public Drama(string title, int year) : base(title)
        {

        }

        public override void Play()
        {
            string PlayText = "Playing and Recording";
        }

        public void Play_Drama_Movie()
        {
            string PlayText = "Playing and Recording";
        }
    }
}
