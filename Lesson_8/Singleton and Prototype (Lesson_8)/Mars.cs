using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lesson_8
{
    class Mars : CelestialBody, IPlanet
    {
        private static Mars instance;
        public bool DenseAtmosphere { get; set; }
        public int AtmosphericPressure { get; set; }
        public double SurfaceGravity { get; set; }

        protected Mars()
        {
            name = "Mars";
            orbitSemiMajorAxis = (int)(2.2794382 * (10^8));
            orbitVelocity = 24130;
            diameter = 3396200;
            mass = (int)(6.4171 * (10 ^ 23));
            DenseAtmosphere = false;
            AtmosphericPressure = 636;
            SurfaceGravity = 3.7117;
        }
        public static Mars Instance()
        {
            if (instance == null)
                instance = new Mars();
            return instance;
        }
    }
}
