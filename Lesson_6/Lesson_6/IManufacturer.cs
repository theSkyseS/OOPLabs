using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    interface IManufacturer
    {
        ComputerManufacturer Name { get; set; }
        Country Country { get; set; }
        int NumberOfEmployees { get; set; }
    }
}
