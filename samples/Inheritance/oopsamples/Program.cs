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
            Student student = new Student("Mohammad", "091289463847", "CS", "293849");

            student.ShowInfo();

            Console.WriteLine("-----------------------------------");

            student.ShowDetails();

            Console.WriteLine("++++++++++++++++++++++++++++++++++++");

            Teacher teacher = new Teacher(210, "Dr. A", "239847239", "Math");

            teacher.ShowInfo();

            Console.WriteLine("++++++++++++++++++++++++++++++++++++");

            AvalStudent avalStudent = new AvalStudent();

            avalStudent.ShowInfo();
            Console.WriteLine("-----------------------------------");
            avalStudent.ShowDetails();


            Console.ReadLine();
        }
    }
}
