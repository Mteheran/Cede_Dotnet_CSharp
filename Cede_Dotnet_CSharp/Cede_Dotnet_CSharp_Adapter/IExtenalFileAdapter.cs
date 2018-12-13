using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Adapter
{
    public interface IExtenalFileAdapter
    {
        File SaveFile(byte[] fileinfo);
    }
}
