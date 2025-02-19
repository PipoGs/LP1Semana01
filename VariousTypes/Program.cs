﻿using System;
using System.Text;

namespace VariousTypes
{

    public class Program
    {
       
        private static void Main(string[] args)

        {
            Console.OutputEncoding = Encoding.UTF8;

            int number;
            number = 8;

            int number2 = 9;

            uint number3 = 4U;

            long number4 = 2L;

            ulong number5 = 7UL;

            //Unicode Symbols

            char copyrightSymbol ='\u00a9';

            char StarSymbol ='\u2727';

            //Strings

            string message = "Hello World!";
            
            message = "Bye World";

            string StringTest = "One tab\t and one copyright\u03a9";


            Console.WriteLine("Hello LP1!");
            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine(number5);

            Console.WriteLine(copyrightSymbol);
            Console.WriteLine(StarSymbol);

            Console.WriteLine(message);
            Console.WriteLine(StringTest);
        }
    }
}
