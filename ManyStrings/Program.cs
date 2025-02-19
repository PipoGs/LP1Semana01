using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8;

            //Ints used for Strings
            int number2 = 9;
            uint number3 = 4U;

            //Strings
            string string1 = "Hello LP1!";
            
            string string2 = "Um tab\t e um copyright\u00a9";
            string string3 = "This is a star\t\u2727";

            //Concatenated Strings

		    string string4 = "Uma" + "string" + "concatenada";
            
            string string5 = "Outros tipos autom. convertidos " + number2 + "" 
            + number3;
            
            string string6 = $"{number2} and {number3} equals to {number2 + number3}";


            //Base
            Console.WriteLine("Hello LP1!");

            //Strings

            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine(string3);

            //Concatenated Strings
            Console.WriteLine(string4);
            Console.WriteLine(string5);
            Console.WriteLine(string6);
        }
    }
}
