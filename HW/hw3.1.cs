using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;

            Console.Write("Enter Number1 : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter Number2 : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter Number3 : ");
            c = int.Parse(Console.ReadLine());

            if (a >= b) // a >= b
            {
                if (a >= c) // a >= b && a >= c => a >= b,c
                {
                    Console.WriteLine($"Number {a} is the largest.");
                }
                else // a >= b && a < c => c > a,b
                {
                    Console.WriteLine($"Number {c} is the largest.");
                }
            }
            else // a < b
            {
                if (b >= c) // a < b && b >= c => b >= a,c
                {
                    Console.WriteLine($"Number {b} is the largest.");
                }
                else // a < b && b < c => c > a,b
                {
                    Console.WriteLine($"Number {c} is the largest.");
                }
            }
            

            Console.Read();
        }
    }
}
