using System;

namespace SumGame
{
    class Program
    {
        static void Main(string[] args)
        {
            String dig1, dig2, dig3;          

            Console.WriteLine("Hello! We're going to start out by creating two different three-digit numbers. Please enter the first digit of the first number.");
            dig1 = Console.ReadLine();

            Console.WriteLine("Now Please enter the second digit of the first number.");
            dig2 = Console.ReadLine();

            Console.WriteLine("Please enter the last digit of the first number.");
            dig3 = Console.ReadLine();

            Console.WriteLine("Great! You have chosen the number {0}{2}{3}.", dig1, dig2, dig3);
            Console.Read();
        }
        
    }
}
