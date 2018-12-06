using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringNumber = "2";

            if(int.TryParse(stringNumber, out int intNumber))
            {
                //Console.WriteLine(intNumber);
            }

            void PrintText(int number)
            {
                //Console.WriteLine(number);
            }

            for (int i = 0; i < 5; i++)
            {
                PrintText(i);
            }

            ref int SumNumber(ref int Number)
            {
                Number++;
                return ref Number;
            }



            // ref variables
            int numberRef = 1;

            Console.WriteLine(numberRef);
            ref int numberRef2 = ref SumNumber(ref numberRef);
            Console.WriteLine(numberRef2);
            numberRef2++;
            Console.WriteLine(numberRef);

            double bigNumber = 10000000000000000000;
            double phoneNumber = 300_569_87_22;
            double decimalNumber = 1045.25_36_45;

            Console.WriteLine(decimalNumber);


            object dateRandom = new DateTime(2018,01,01);

            dateRandom = new DateTime(2017, 01, 01);

            switch (dateRandom)
            {
                case DateTime dateTime when dateTime.Year == 2018:
                    Console.WriteLine("Es una fecha de este año");
                    break;
                case DateTime dateTime when dateTime.Year == 2017:
                    Console.WriteLine("Es una fecha del año pasado");
                    break;
                case LocalFunctions local when local.Property1 == "":
                    Console.WriteLine("Es local");
                    break;
            }

            Console.ReadLine();

        }
    }
}
