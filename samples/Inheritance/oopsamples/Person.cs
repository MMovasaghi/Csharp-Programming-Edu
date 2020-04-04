using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsamples
{
    class Person
    {
        public string name { get; set; }
        public string PhoneNumber { get; set; }
        public string Major { get; set; }
        public Person(string name, string phone, string Major)
        {
            this.name = name;
            this.PhoneNumber = phone;
            this.Major = Major;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name : {name}\n" +
                $"Phone : {PhoneNumber}\n" +
                $"Major : {Major}");
        }
    }
}
