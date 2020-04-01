using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(1, 1000);
            int input = 0;
            while (true)
            {
                Console.Write("Your guess : ");
                input = int.Parse(Console.ReadLine());
                if (input == number)
                {
                    Console.WriteLine($"## This is True, my number is {number}");
                    break;
                }
                else if (input < number)
                    Console.WriteLine(">> Your number is SMALL.");
                else
                    Console.WriteLine(">> Your number is LARGE.");
            }
            Console.ReadLine();
        }
    }
}
