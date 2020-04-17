using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionHandling.Exceptions;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ali";
            string phone = "010239424782";
            int age = 0;


            try
            {
                // try to do some tasks
                //Console.Write("Enter name : ");
                //name = Console.ReadLine();
                Console.Write("Enter phone : ");
                phone = Console.ReadLine();
                long.Parse(phone);
                if (phone.Length != 11)
                {
                    throw new PhoneException("\"The phone number must have 11 number.\"");
                }
                Console.Write("Enter age : ");
                age = int.Parse(Console.ReadLine());                
            }
            catch (PhoneException e)
            {
                Console.WriteLine($"PhoneException: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Finally");
            }

            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine($"Name : {name}\n" +
                              $"Phone : {phone}\n" +
                              $"Age : {age}");

            Console.ReadLine();
        }
    }
}
