using System;
using Cede_Dotnet_CSharp_Calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cede_Dotnet_CSharp_UnitTest_Demo
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Sumar_2_2()
        {
            //Arrange(Preparar)
            Calculadora calculadora = new Calculadora();

            //Act(Actuar)
            var suma = calculadora.Sumar(2,2);

            //Assert(Afirmar)
            Assert.IsNotNull(suma);
            Assert.IsTrue(suma==4);
            Assert.AreEqual(4, suma);
           
        }

        [TestMethod]
        public void Sumar_5_10()
        {
            //Arrange(Preparar)
            Calculadora calculadora = new Calculadora();

            //Act(Actuar)
            var suma = calculadora.Sumar(5, 10);

            //Assert(Afirmar)
            Assert.AreEqual(15, suma);
        }


        [TestMethod]
        public void Sumar_Aleatorio_2()
        {
            //Arrange(Preparar)
            Calculadora calculadora = new Calculadora();
            double aleatorio = new Random().NextDouble();

            //Act(Actuar)
            var suma = calculadora.Sumar(aleatorio, 2);

            //Assert(Afirmar)
            Assert.AreEqual((aleatorio+2), suma);
        }

        [TestMethod]
        public void Restar_2_2()
        {           
            //Arrange(Preparar)
            ICalculadora calculadora = new Calculadora();

            //Act(Actuar)
            var resta = calculadora.Restar(2, 2);

            //Assert(Afirmar)
            Assert.AreEqual(0, resta);
        }

        [TestMethod]
        public void Multiplicar_5_2()
        {
            //Arrange(Preparar)
            ICalculadora calculadora = new Calculadora();

            //Act(Actuar)
            var multiplicacion = calculadora.Multiplicar(5, 2);

            //Assert(Afirmar)
            Assert.AreEqual(10, multiplicacion);
        }

        [TestMethod]
        public void Dividir_6_2()
        {
            //Arrange(Preparar)
            ICalculadora calculadora = new Calculadora();

            //Act(Actuar)
            var division = calculadora.Dividir(6, 2);

            //Assert(Afirmar)
            Assert.AreEqual(3, division);
        }

    }
}
