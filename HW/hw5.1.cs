using System;

namespace ConsoleApp2
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
                if (a >= c) // a >= b && a >= c 
                {
                    if (b >= c) 
                    {
                        Console.WriteLine($"{a} >= {b} >= {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{a} >= {c} >= {b}");
                    }
                }
                else // a >= b && a < c => {c > a >= b}
                {
                    Console.WriteLine($"{c} >= {a} >= {b}");
                }
            }
            else // a < b
            {
                if (b >= c) // b > a && b >= c
                {
                    if (a >= c)
                    {
                        Console.WriteLine($"{b} >= {a} >= {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{b} >= {c} >= {a}");
                    }
                }
                else // b > a && c > b
                {
                    Console.WriteLine($"{c} >= {b} >= {a}");
                }
            }
            Console.Read();
        }
    }
}
