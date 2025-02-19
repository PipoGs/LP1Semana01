using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8;
            //Strings
            string string1 = "Hello LP1!";
            
            string string2 = "Um tab\t e um copyright\u00a9";
            string string3 = "This is a star\t\u2727";

            

            Console.WriteLine("Hello LP1!");

            //Strings

            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine(string3);
        }
    }
}
