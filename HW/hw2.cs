using System;

namespace ConsoleApp3
{
    class Program
    {
        // get name and birthdate and present year then print the name of the user and his age
        static void Main(string[] args)
        {
            string name;
            int NowYear;
            int BirthYear;
            int age;
            
            

            // salam
            /*
            salam
            halet khobe ?

            */


            Console.WriteLine("Hello,");
            Console.Write("Please Enter Your Name : ");
            name = Console.ReadLine();
            Console.Write("Please Enter Your Present Year : ");
            NowYear = int.Parse(Console.ReadLine());
            Console.Write("Please Enter Your Bith Year : ");
            BirthYear = int.Parse(Console.ReadLine());

            age = NowYear - BirthYear;

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Hi {name},\nYou sed me that you are {age} years old now.");
        }
    }
}
