using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cede_Dotnet_CSharp_FileManager
{
    public class FileManager : IFileManager
    {
        public string InfoFile { get; set; }

        public void GetInfoFile()
        {
            StreamReader sr = new StreamReader(@"‪C:\eula.1028.txt");

            InfoFile = sr.ReadToEnd();

            sr.Close();
        }

        public string GetTextFile()
        {
            return InfoFile;
        }
    }
}
