using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] names = { "Ali", "Hosein", "Zahra", "Hasan", "Fateme", "Reza", "Narges" };
            Student[] students = new Student[10];
            for (int i = 0; i < 10; i++)
            {
                students[i] = new Student(names[rand.Next(0, names.Length - 1)], rand.Next(1000, 10000).ToString());
                students[i].PhoneNumber = rand.Next(1000, 10000).ToString() + rand.Next(1000, 10000).ToString();
            }
            while (true)
            {
                Console.Clear();
                Console.Write("Chose From Menu:\n1. Print all user details\n2. Show spesific user details by it's index\n0. Exit\nYour Choise: ");
                string input = Console.ReadLine();

                if(input == "1")
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine($"Student number [{i}]");
                        students[i].ShowDetails();                        
                    }
                    Console.WriteLine("----------------------------------------");
                }
                else if(input == "2")
                {
                    Console.Write("Enter Student number: ");
                    int i = int.Parse(Console.ReadLine());
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Student number [{i}]");
                    students[i].ShowDetails();
                    Console.WriteLine("----------------------------------------");
                }
                else if(input == "0")
                {
                    break;
                }
                else
                {
                    continue;
                }
                Console.WriteLine("Press any key to back to menu ...");
                Console.ReadKey();
            }
        }
    }
}
