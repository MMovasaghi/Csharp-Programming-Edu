using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            Console.Write($"Enter number1: ");
            num[0] = int.Parse(Console.ReadLine());
            int max = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                Console.Write($"Enter number{i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
                if (max < num[i])
                    max = num[i];
            }
            Console.WriteLine($"Largest number is {max}");
            Console.Read();
        }
    }
}
