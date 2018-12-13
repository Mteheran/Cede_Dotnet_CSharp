using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Adapter
{
    public class SharePoint2013
    {
        public string FileName { get; set; }

        public string Url { get; set; }

        public string Library { get; set; }

        public string SaveFile(string fileName,string extension, byte[] fileinfo)
        {
            return new Guid().ToString();
        }
    }
}
