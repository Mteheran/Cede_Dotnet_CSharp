using System;

namespace Cede_Dotnet_CSharp_Calculadora
{
    public class Calculadora :ICalculadora
    {
        public double Dividir(double numero1, double numero2)
        {
            return numero1 / numero2;
        }

        public double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        public double Restar(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public double Sumar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public double Doble(double numero)
        {
            return numero * 2;
        }

        public double Triple(double numero)
        {
            return numero * 3;
        }

        public double RaizCuadrada(double numero)
        {
            return Math.Sqrt(numero);
        }
    }
}
