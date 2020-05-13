using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    interface IComputer
    {
        ProcessorType ProcessorType { get; set; }
        ComputerManufacturer ComputerManufacturer { get; set; }
        OSType OperationSystemType { get; set; }
        int ProcessorCoreClock { get; set; }
        int RAMVolume { get; set; }
        List<string> InstalledPrograms { get; set; }
        List<string> UserList { get; set; }
    }
}
