using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Adapter
{
    public class SharePoint
    {
        public string FileName { get; set; }

        public string Url { get; set; }

        public string Library { get; set; }

        public string SaveFile(string FileName, byte[] fileinfo)
        {
            return new Guid().ToString();
        }
    }
}
