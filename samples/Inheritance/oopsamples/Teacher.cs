using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsamples
{
    class Teacher : Person
    {
        public int RoomNumber { get; set; }
        public Teacher(int room, string name, string phone, string Major) 
            : base(name, phone, Major)
        {
            RoomNumber = room;
        }
    }
}
