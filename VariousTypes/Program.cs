using System;
using System.Text;

namespace VariousTypes
{

    public class Program
    {
       
        private static void Main(string[] args)

        {
            Console.OutputEncoding = Encoding.UTF8;

            //Ints

            int number;
            number = 8;

            int number2 = 9;

            uint number3 = 4U;

            long number4 = 2L;

            ulong number5 = 7UL;

            //Unicode Symbols

            char copyrightSymbol ='\u00a9';

            char StarSymbol ='\u2727';

            //Real Numbers

            double pi1 = 3.1415;

            float pi2 = 3.1415f;

            decimal pi3 = 3.1415m;

            

            //Booleans
            bool condition1 = false;
            bool condition2 = true;


            //Int
            Console.WriteLine("Hello LP1!");
            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine(number5);
            //Char
            Console.WriteLine(copyrightSymbol);
            Console.WriteLine(StarSymbol);
            //REAL
            Console.WriteLine(pi1);
            Console.WriteLine(pi2);
            Console.WriteLine(pi3);
            //Booleans
            Console.WriteLine(condition1);
            Console.WriteLine(condition2);
        }
    }
}
