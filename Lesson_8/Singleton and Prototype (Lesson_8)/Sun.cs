using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lesson_8
{
    class Sun : CelestialBody, IStar
    {
        private static Sun instance;
        public SpectralClass SpectralClass { get; set; }
        public LuminosityClass LuminosityClass { get; set; }
        public List<CelestialBody> Planets { get; set; }

        protected Sun()
        {
            name = "Sun";
            orbitSemiMajorAxis = (int)(2.5 * (10 ^ 20));
            orbitVelocity = (int)(2.2 * (10 ^ 5));
            diameter = (int)(1.392 * (10 ^ 9));
            mass = (int)(1.9885 * (10 ^ 30));
            SpectralClass = SpectralClass.G;
            LuminosityClass = LuminosityClass.V;
            Planets = new List<CelestialBody>()
            {
                Mercury.Instance(),
                Venus.Instance(),
                Earth.Instance(),
                Mars.Instance()
                //думаю хватит, пусть это будет модель внутренней области Солнечной системы =D
            };
        }

        public static Sun Instance()
        {
            if (instance == null)
                instance = new Sun();
            return instance;
        }
    }
}
