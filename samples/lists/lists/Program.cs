using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            Random rand = new Random();

            int length = 20;

            for (int i = 0; i < length; i++)
            {
                a.Add(rand.Next(1,10));
                Console.WriteLine($"[{i}] : {a[i]}");
            }
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine($"IndexOf({1}) : {a.IndexOf(1)}");
            Console.WriteLine($"Count : {a.Count}");
            Console.WriteLine($"Contains({1}) : {a.Contains(1)}");
            Console.WriteLine($"Contains({100}) : {a.Contains(100)}");
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine($"a.Insert(1, 100)");
            a.Insert(3, 100);
            int j = 0;
            foreach (var item in a)
            {
                Console.WriteLine($"[{j}] : {item}");
                j++;
            }
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine($"IndexOf({1}) : {a.IndexOf(1)}");
            Console.WriteLine($"Count : {a.Count}");
            Console.WriteLine($"Contains({1}) : {a.Contains(1)}");
            Console.WriteLine($"Contains({100}) : {a.Contains(100)}");

            Console.ReadLine();
        }
    }
}
