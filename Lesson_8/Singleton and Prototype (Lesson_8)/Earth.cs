using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lesson_8
{
    class Earth : CelestialBody, IPlanet
    {
        private static Earth instance;
        public bool DenseAtmosphere { get; set; }
        public int AtmosphericPressure { get; set; }
        public double SurfaceGravity { get; set; }

        protected Earth()
        {
            name = "Earth";
            orbitSemiMajorAxis = 149598261;
            orbitVelocity = 29783;
            diameter = 6378100;
            mass = (int)(5.9726 * (10 ^ 24));
            DenseAtmosphere = true;
            AtmosphericPressure = 101325000;
            SurfaceGravity = 9.780327;
        }
        public static Earth Instance()
        {
            if (instance == null)
                instance = new Earth();
            return instance;
        }
    }
}
