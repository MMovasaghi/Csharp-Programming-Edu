using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];            
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Enter number{i} :");
                num[i] = int.Parse(Console.ReadLine());
            }
            int tmp = 0;
            for (int i = 0; i < num.Length; i++)
            {                
                for (int j = i; j < num.Length; j++)
                {
                    if(num[i] <= num[j])
                    {
                        tmp = num[i];
                        num[i] = num[j];
                        num[j] = tmp;
                    }
                }
                Console.Write($"{num[i]} ");
            }
            Console.Read();
        }
    }
}
