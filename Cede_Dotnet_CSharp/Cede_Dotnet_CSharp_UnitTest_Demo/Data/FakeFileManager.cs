using Cede_Dotnet_CSharp_FileManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_UnitTest_Demo.Data
{
    public class FakeFileManager : IFileManager
    {
        public void GetInfoFile()
        {
        }

        public string GetTextFile()
        {
            return "Hola a todos";
        }
    }
}
