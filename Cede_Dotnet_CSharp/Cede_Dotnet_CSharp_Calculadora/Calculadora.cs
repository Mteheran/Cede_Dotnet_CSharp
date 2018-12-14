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
    }
}
