using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello,\nIam Movasaghinia.\nThis is my c# class.\nThis class is good for who want to learn c#.";
            Console.WriteLine($"The main string:\n{a}");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            if (a.Contains("class"))
            {
                Console.WriteLine("It has \"class\"");
            }
            else
            {
                Console.WriteLine("There is no \"class\" in the string.");
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            string b = a.Replace("Hello", "Hi");
            Console.WriteLine($"The b string:\n{b}");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            int index = a.IndexOf("class");
            string c = a.Remove(index, ("class").Length);
            Console.WriteLine($"The c string:\n{c}");

            Console.ReadLine();
        }
    }
}
