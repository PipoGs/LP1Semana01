﻿using System;

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

            //input conversion15
            string input1 = Console.ReadLine();
            int conversion1 = int.Parse(input1);

            //Ask for input2
            Console.WriteLine("Write a Real Number:");

            //input conversion2
            string input2 = Console.ReadLine();
            float conversion2 = float.Parse(input2);

            //Result
            Console.WriteLine($"{conversion1} + {conversion2} equals to {conversion1 + conversion2}");




            
            

        }
    }
}
