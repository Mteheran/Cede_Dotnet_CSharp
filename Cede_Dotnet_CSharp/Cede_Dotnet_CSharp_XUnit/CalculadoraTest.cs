using Cede_Dotnet_CSharp_Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Cede_Dotnet_CSharp_XUnit
{
    public class CalculadoraTest
    {
        [Fact]
        public void Sumar_2_2()
        {
            //Arrange(Preparar)
            Calculadora calculadora = new Calculadora();

            //Act(Actuar)
            var suma = calculadora.Sumar(2, 2);

            //Assert(Afirmar)
            Assert.NotNull(suma);
            Assert.True(suma == 4);
            Assert.Equal(4, suma);
        }

        [Fact]
        public void Sumar_5_10()
        {
            //Arrange(Preparar)
            Calculadora calculadora = new Calculadora();

            //Act(Actuar)
            var suma = calculadora.Sumar(5, 10);

            //Assert(Afirmar)
            Assert.Equal(15, suma);
        }


        [Fact]
        public void Sumar_Aleatorio_2()
        {
            //Arrange(Preparar)
            Calculadora calculadora = new Calculadora();
            double aleatorio = new Random().NextDouble();

            //Act(Actuar)
            var suma = calculadora.Sumar(aleatorio, 2);

            //Assert(Afirmar)
            Assert.Equal((aleatorio + 2), suma);
        }

        [Fact]
        public void Restar_2_2()
        {
            //Arrange(Preparar)
            ICalculadora calculadora = new Calculadora();

            //Act(Actuar)
            var resta = calculadora.Restar(2, 2);

            //Assert(Afirmar)
            Assert.Equal(0, resta);
        }

        [Fact]
        public void Multiplicar_5_2()
        {
            //Arrange(Preparar)
            ICalculadora calculadora = new Calculadora();

            //Act(Actuar)
            var multiplicacion = calculadora.Multiplicar(5, 2);

            //Assert(Afirmar)
            Assert.Equal(10, multiplicacion);
        }

        [Fact]
        public void Dividir_6_2()
        {
            //Arrange(Preparar)
            ICalculadora calculadora = new Calculadora();

            //Act(Actuar)
            var division = calculadora.Dividir(6, 2);

            //Assert(Afirmar)
            Assert.Equal(3, division);
        }

        [Fact]
        public void Doble_7()
        {
            //Arrange(Preparar)
            ICalculadora calculadora = new Calculadora();

            //Act(Actuar)
            var resultado = calculadora.Doble(7);

            //Assert(Afirmar)
            Assert.Equal(14, resultado);
        }
    }
}
