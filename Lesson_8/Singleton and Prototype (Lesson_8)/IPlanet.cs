using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lesson_8
{
    interface IPlanet
    {
        bool DenseAtmosphere { get; set; }
        int AtmosphericPressure { get; set; }
        double SurfaceGravity { get; set; }
    }
}
