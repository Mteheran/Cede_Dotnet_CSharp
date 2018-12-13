using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_Adapter
{
    public class ExternalFileAdapter : IExtenalFileAdapter
    {
        public SharePoint sharePoint { get; set; } = new SharePoint();

        public File SaveFile(byte[] fileinfo)
        {
            File file = new File();

            sharePoint.Url = "http//www.sharepoint";
            sharePoint.Library = "Documents";
            file.Name = "File" + DateTime.Now.ToLongDateString();
            file.ID = sharePoint.SaveFile(file.Name, fileinfo);

            return file;
        }
    }
}
