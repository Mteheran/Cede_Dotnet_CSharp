using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Adapter
{
    public static class ExternalFileFactory
    {
        public static IExtenalFileAdapter GetFileAdapter(ExternalFileServiceType serviceType)
        {
            switch (serviceType)
            {
                case ExternalFileServiceType.SharePoint:
                    return new ExternalFileAdapter();
                case ExternalFileServiceType.SharePoint2013:
                    return new ExternalFile2013Adapter();
                default:
                    throw new Exception();
                    break;
            }
        }
    }
}
