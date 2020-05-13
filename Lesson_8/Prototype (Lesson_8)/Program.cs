using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_6;

namespace Prototype__Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer1 = new Computer();
            computer1.OverclockTheComputer();
            Computer computer2 = (Computer)computer1.Clone();
        }
    }
}
