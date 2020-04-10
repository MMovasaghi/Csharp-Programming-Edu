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
            List<person> persons = new List<person>();
            Random rand = new Random();
            string[] names = { "Ali", "Hasan", "Hosein", "Mohamad", "Fateme", "Zahra", "Razye" };
            string[] phones = { "09122284359", "09122384359", "09432184359", "09122344359", "09122833594", "09122164359", "09122184359" };
            for (int i = 0; i < 10; i++)
            {
                persons.Add(new person(i, names[rand.Next(0, names.Length - 1)], phones[rand.Next(0, phones.Length - 1)], rand.Next(0, 20)));
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            foreach (var item in persons)
            {
                Console.WriteLine($"Name: {item.name}\nPhone: {item.phone}");
                Console.WriteLine("----------------------------------");
            }

            Console.Write("Enter Name : ");
            string name = Console.ReadLine();

            foreach (var item in persons)
            {
                if (item.name.ToLower() == name.ToLower())
                {
                    Console.WriteLine(item.showDetail());
                    //break;
                }
            }

            Console.ReadLine();
        }
    }
}
