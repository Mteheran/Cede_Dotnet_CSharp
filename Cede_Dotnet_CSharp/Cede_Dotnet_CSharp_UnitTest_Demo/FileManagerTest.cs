using System;
using Cede_Dotnet_CSharp_FileManager;
using Cede_Dotnet_CSharp_UnitTest_Demo.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

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

        [TestMethod]
        public void CountLetters_2_moq()
        {
            var mockFileManager = new Mock<IFileManager>();

            mockFileManager.Setup(m => m.GetTextFile()).Returns("Hola a todos");

            ITextManager textManager = new TextManager(mockFileManager.Object);

            var countletter = textManager.CountLetters();

            Assert.AreEqual(12, countletter);
        }

        [TestMethod]
        public void IsANumber_moq()
        {
            var mockFileManager = new Mock<IFileManager>();

            mockFileManager.Setup(m => m.GetTextFile()).Returns("123");

            ITextManager textManager = new TextManager(mockFileManager.Object);
            
            Assert.IsTrue(textManager.IsANumber());
        }

        [TestMethod]
        public void IsANumber_Negative_moq()
        {
            var mockFileManager = new Mock<IFileManager>();

            mockFileManager.Setup(m => m.GetTextFile()).Returns("ABC");

            ITextManager textManager = new TextManager(mockFileManager.Object);

            Assert.IsTrue(!textManager.IsANumber());
        }
    }
}
