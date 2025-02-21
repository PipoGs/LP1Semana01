using System;
using System.Text;
using System.Globalization;

namespace Smiley
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Escreva um numero inteiro em formato hexadecimal: ");

            //Conversâo
            string input = Console.ReadLine();
            int conversionuni = int.Parse(input, System.Globalization.NumberStyles.HexNumber);
            string unicodeconver = char.ConvertFromUtf32(conversionuni).ToString();

            Console.WriteLine(unicodeconver);

            
            
        }
    }
}
