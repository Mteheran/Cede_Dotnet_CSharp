using System;
using AutoFixture;
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

        [TestMethod]
        public void Doble_7()
        {
            //Arrange(Preparar)
            ICalculadora calculadora = new Calculadora();

            //Act(Actuar)
            var resultado = calculadora.Doble(7);

            //Assert(Afirmar)
            Assert.AreEqual(14, resultado);
        }

        [TestMethod]
        public void Triple_2_2()
        {
            //Arrange(Preparar)
            ICalculadora calculadora = new Calculadora();

            //Act(Actuar)
            var resultado = calculadora.Triple(2.2);

            //Assert(Afirmar)
            Assert.AreEqual("6.6", resultado.ToString("f1"));
        }


        [TestMethod]
        public void Triple_3_5()
        {
            //Arrange(Preparar)
            ICalculadora calculadora = new Calculadora();

            //Act(Actuar)
            var resultado = calculadora.Triple(3.5);

            //Assert(Afirmar)
            Assert.AreEqual(10.5, resultado);
        }

        [TestMethod]
        public void RaizCuadrada_2()
        {
            //Arrange(Preparar)
            ICalculadora calculadora = new Calculadora();

            //Act(Actuar)
            var resultado = calculadora.RaizCuadrada(4);

            //Assert(Afirmar)
            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        public void Sumar_Autofixture()
        {
            //Arrange(Preparar)
            Calculadora calculadora = new Calculadora();
            Fixture autoFixture = new Fixture();
            int number1 = autoFixture.Create<int>();
            int number2 = autoFixture.Create<int>();

            //Act(Actuar)
            var suma = calculadora.Sumar(number1, number2);

            //Assert(Afirmar)
            Assert.IsNotNull(suma);
            Assert.AreEqual(number1 + number2, suma);
        }

    }
}
