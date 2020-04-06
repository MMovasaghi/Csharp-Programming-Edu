using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    throw new Exception("The Phone number must be 11 char.");
                }
                Console.Write("Enter age : ");
                age = int.Parse(Console.ReadLine());                
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
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
