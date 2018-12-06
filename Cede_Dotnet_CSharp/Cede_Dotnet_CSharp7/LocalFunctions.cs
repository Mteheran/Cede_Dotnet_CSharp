using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp7
{
    public class LocalFunctions
    {
        public string Property1 { get; set; }

        public double CalculationUsingLocalFunction(double initialValue)
        {
            #region local functions

            double SumRandomLocal(double initialValueLocal)
            {
                return initialValueLocal + new Random().NextDouble();
            }

            #endregion

            double value = SumRandomLocal(initialValue);

            value = SumRandomLocal(initialValue);

            value++;

            ++value;

            return value;
        }

        public double Calculation(double initialValue)
        {
            double value = SumRandom(initialValue);

            value++;

            ++value;

            return value;
        }

        public double Calculation2(double initialValue)
        {
            double value = SumRandom(initialValue);

            value--;

            --value;

            return value;
        }

        private double SumRandom(double initialValue)
        {
            return initialValue + new Random().NextDouble();
        }
    }
}
