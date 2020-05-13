using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lesson_8
{
    interface IStar
    {
        SpectralClass SpectralClass { get; set; }
        LuminosityClass LuminosityClass { get; set; }

        List<CelestialBody> Planets { get; set; }
    }
}
