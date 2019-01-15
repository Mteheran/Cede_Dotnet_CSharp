using System;
using System.Collections.Generic;
using System.Text;

namespace Cede_Dotnet_CSharp_Calculadora
{
    public interface ICalculadora
    {
        double Sumar(double numero1, double numero2);
        double Restar(double numero1, double numero2);
        double Multiplicar(double numero1, double numero2);
        double Dividir(double numero1, double numero2);
        double Doble(double numero);
        double Triple(double numero);
        double RaizCuadrada(double numero);
    }
}
