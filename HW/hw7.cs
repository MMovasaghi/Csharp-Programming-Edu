using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.Write("Enter your name : ");
            name = Console.ReadLine();
            name = name.ToUpper();
            for (int i = 0; i < name.Length - 1; i++)
            {
                Console.Write($"{name[i]}-");
            }
            Console.Write($"{name[name.Length - 1]}");
            Console.Read();
        }
    }
}
