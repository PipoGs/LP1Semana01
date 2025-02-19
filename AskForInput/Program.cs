using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //BASE
            Console.WriteLine("Hello LP1!");

            //Ask for input1
            Console.WriteLine("Write a Integer Number:");

            //input conversion1
            string input1 = Console.ReadLine();
            int convers1 = int.Parse(input1);

            //Ask for input2
            Console.WriteLine("Write a Real Number:");

            //input conversion2
            string input2 = Console.ReadLine();
            float convers2 = float.Parse(input2);

            //Result
            Console.WriteLine($"{convers1} + {convers2} equals to {convers1 + convers2}");




            
            

        }
    }
}
