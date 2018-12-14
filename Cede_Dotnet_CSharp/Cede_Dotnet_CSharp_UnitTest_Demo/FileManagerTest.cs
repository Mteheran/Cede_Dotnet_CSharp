using System;
using Cede_Dotnet_CSharp_FileManager;
using Cede_Dotnet_CSharp_UnitTest_Demo.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cede_Dotnet_CSharp_UnitTest_Demo
{
    [TestClass]
    public class FileManagerTest
    {
        [TestMethod]
        public void CountLetters_2()
        {
            IFileManager fileManager = new FakeFileManager();
            ITextManager textManager = new TextManager(fileManager);

            var countletter = textManager.CountLetters();

            Assert.AreEqual(12, countletter);
        }
    }
}
