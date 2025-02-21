using System;
using System.Text;

namespace Smiley
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Escreva um numero inteiro em formato hexadecimal: ");

            string input = Console.ReadLine();
            int conversion1 = int.Parse(input);
            char unicode = (char)conversion1;

            //char unicode = "$({\u} + {conversion});

           Console.WriteLine(unicode);

            
            
        }
    }
}
