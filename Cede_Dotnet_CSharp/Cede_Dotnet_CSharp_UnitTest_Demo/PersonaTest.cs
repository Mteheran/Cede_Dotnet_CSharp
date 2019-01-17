using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp_UnitTest_Demo
{
    [TestClass]
    public class PersonaTest
    {
        [TestMethod]
        public void PersonaCount()
        {
            var personas = Data.PersonaData.GetPersonas();

            Assert.AreEqual(5, personas.Count);
            Assert.IsTrue(personas[0].Edad > 0);
            Assert.AreEqual(1, personas[0].Edad);
            Assert.IsNull(personas[0].Apellido);
        }
    }
}
