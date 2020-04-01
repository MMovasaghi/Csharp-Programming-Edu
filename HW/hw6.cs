using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int max = 0;
            int min = 0;
            Console.Write($"Enter number{1} : ");
            num = int.Parse(Console.ReadLine());
            max = min = num;
            for (int i = 1; i < 10; i++)
            {
                Console.Write($"Enter number{i + 1} : ");
                num = int.Parse(Console.ReadLine());
                if (num > max)
                    max = num;
                if (num < min)
                    min = num;
            }
            Console.WriteLine($"Largest is {max} and the smallest is {min}");
            Console.Read();
        }
    }
}
