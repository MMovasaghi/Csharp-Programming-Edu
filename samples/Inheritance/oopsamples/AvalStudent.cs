using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsamples
{
    class AvalStudent : Student
    {
        public AvalStudent() : base("Hasan","2983742934","CE","2983462")
        {
        }
        public int MyProperty { get; set; }
    }
}
