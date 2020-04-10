using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    class person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public double grade { get; set; }
        public person(int id, string name, string phone, double grade)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.grade = grade;
        }
        public string showDetail()
        {
            string result = string.Format($"===============\n" +
                $"ID: {this.id}\nName: {this.name}\nPhone: {this.phone}\nGrade: {this.grade}\n" +
                $"===============");
            return result;
        }
    }
}
