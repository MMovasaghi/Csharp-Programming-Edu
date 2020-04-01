using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            string lastname;
            string age;
            string phone;

            Console.WriteLine("Hello,");
            Console.Write("Please Enter Your FirstName : ");
            firstname = Console.ReadLine();
            Console.Write("Please Enter Your Last Name : ");
            lastname = Console.ReadLine();
            Console.Write("Please Enter Your Age : ");
            age = Console.ReadLine();
            Console.Write("Please Enter Your Phone : ");
            phone = Console.ReadLine();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Hello {firstname} {lastname},\nYou sed me that you are {age} years old now.\nAnd Your phone number is {phone}");
        }
    }
}
