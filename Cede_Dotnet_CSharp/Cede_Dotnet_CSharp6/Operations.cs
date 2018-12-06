using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp6
{
    public class Operations
    {
        public int NumberRandom { get; set; } = new Random().Next();

        public int SumWithRandomNumber(int number) => (number + NumberRandom);

        //Old method
        public int SumWithRandomNumber2(int number)
        {
            return number + NumberRandom;
        }

        public int Sum(int number1, int number2) => number1 + number2;
        public int Rest(int number1, int number2) => number1 - number2;
        public int Mult(int number1, int number2) => number1 * number2;
        public int Div(int number1, int number2) => number1 / number2;

    }
}
