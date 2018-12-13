using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {            
            IExtenalFileAdapter extenalFileAdapter = ExternalFileFactory.GetFileAdapter(ExternalFileServiceType.SharePoint2013);

            extenalFileAdapter.SaveFile(new byte[] { });
        }
    }
}
