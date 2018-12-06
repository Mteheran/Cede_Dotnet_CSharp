using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_CSharp
{
    class Program
    {     
        static void Main(string[] args)
        {
            string emptyText;
            string texto = "";
            bool activo;

            string texto1, texto2, texto3;
            texto1 = texto2 = texto3 = "texto";

            string concactText1 = "Hola";
            string concactText2 = "Hola 2";
            string concactText3 = "otro texto";


            string concact = "Hola" + " Hola 2"  + " otro texto";
            string concact2 = string.Format("{0} {1} {2}", "Hola", "Hola 2", "otro texto");
            string concact3= $"{concactText1} {concactText2} {concactText3}";

            //Console.WriteLine(concact);
            //Console.WriteLine(concact2);
            //Console.WriteLine(concact3);

            // using var
            var newDAte = new DateTime();
                                    
            int numberInt = 0;

            //Incremento
            numberInt = numberInt + 2;
            numberInt += 2;

            //posIncremento                       
            //Console.WriteLine(numberInt++);
            //Console.WriteLine(numberInt);

            ////Preincremento
            //Console.WriteLine(++numberInt);

            for (int i = 1; i <= 10; i = i+2)
            {
                //Console.WriteLine(i);
            }
               
            for (var i = new DateTime(2018, 12, 1); i < new DateTime(2018, 12, 05); i = i.AddDays(1))
            {
                //Console.WriteLine(i.ToShortDateString());
            }

            int numberIntWhile = 0;

            while (numberIntWhile < 5)
            {
                //Console.WriteLine(numberIntWhile);
                numberIntWhile++;
            }

            List<DateTime> dateTimes = new List<DateTime>();
            dateTimes.Add(new DateTime(2018, 12, 01));
            dateTimes.Add(new DateTime(2018, 12, 02));
            dateTimes.Add(new DateTime(2018, 12, 04));

            foreach (var item in dateTimes)
            {
                //Console.WriteLine(item);
            }

            int number = 5;
            int number2 = 4;
            int number3 = 4;
            int numberResult;

            Console.WriteLine(SumValue(number, number2));
            Console.WriteLine(number);
            Console.WriteLine(number2);

            //variables de referencia
            Console.WriteLine(Incrimentar(ref number3));
            Console.WriteLine(number3);

            //Variables de salida
            SumValueOut(number, number2, out numberResult);
            Console.WriteLine(numberResult);

            Console.WriteLine(SumValue(number));

            Console.ReadLine();

        }

        public static int SumValue(int number, int number2 = 1)
        {
            number++;
            number2++;
            return number + number2;
        }

        public static void SumValueOut(int number, int number2, out int numberResult)
        {
            number++;
            number2++;
            numberResult =  number + number2;
        }

        public static int Incrimentar(ref int number)
        {
            return ++number;
        }


        /// <summary>
        /// This method valids if the date is on the current year
        /// </summary>
        /// <param name="date">date to validate</param>
        /// <returns>True = is valid, False = Invalid</returns>
        public static bool IsDateOnCurrentYear(DateTime date)
        {
            return true;
        }
    }
}
