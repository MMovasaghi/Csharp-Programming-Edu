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

            Console.Write("Number : ");

            int length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                a.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("+++++++++++++++++++++++++");
            a.Add(10);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
