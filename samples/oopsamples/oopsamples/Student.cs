using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsamples
{
    class Student
    {
        public string name { get; }
        public string UniNumber { get; }
        public string PhoneNumber { get; set; }
        private string[] CourseName;
        private double[] Grade;
        private Random rand;
        public Student(string InputName, string InputUninumber)
        {
            rand = new Random();
            Grade = new double[5];
            CourseName = new string[]{ "MATH","COMPUTER","CHEMISTRY","FARSI","ENGLISH"};
            name = InputName;
            UniNumber = InputUninumber;
            InitialGrade();
        }
        private void InitialGrade()
        {           
            for (int i = 0; i < Grade.Length; i++)
            {
                Grade[i] = rand.Next(0, 20);
            }
        }
        public void ShowDetails()
        {
            Console.WriteLine("Student Detail:");
            Console.WriteLine($">> Name: {name}\n" +
                $">> Uni-Number: {UniNumber}\n" +
                $">> Phone-Number: {PhoneNumber}");
            Console.WriteLine(">> Grades:");
            for (int i = 0; i < Grade.Length; i++)
            {
                Console.WriteLine($" |- {CourseName[i]} : {Grade[i]}");
            }
            Console.WriteLine($">> Average : {CalAverage()}");
        }
        public void setGrade(string course,double g)
        {
            course = course.ToUpper();
            for (int i = 0; i < CourseName.Length; i++)
            {
                if (course == CourseName[i])
                {
                    Grade[i] = g;
                    break;
                }
            }
        }
        public double getGrade(string course)
        {
            course = course.ToUpper();
            for (int i = 0; i < CourseName.Length; i++)
            {
                if (course == CourseName[i])
                    return Grade[i];
            }
            return -1;
        }
        private double CalAverage()
        {
            double avg = 0;
            for (int i = 0; i < Grade.Length; i++)
            {
                avg += Grade[i];
            }
            avg /= Grade.Length; // avg = avg / Grade.Length; 
            return avg;
        }

    }
}
