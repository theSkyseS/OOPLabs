using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lesson_8
{
    class Mercury : CelestialBody, IPlanet
    {
        private static Mercury instance;
        public bool DenseAtmosphere { get; set; }
        public int AtmosphericPressure { get; set; }
        public double SurfaceGravity { get; set; }

        protected Mercury()
        {
            name = "Mercury";
            orbitSemiMajorAxis = 57909227;
            orbitVelocity = 47360;
            diameter = 2439700;
            mass = (int)(3.33022 * (10 ^ 23));
            DenseAtmosphere = false;
            AtmosphericPressure = 0;
            SurfaceGravity = 3.7;
        }
        public static Mercury Instance()
        {
            if (instance == null)
                instance = new Mercury();
            return instance;
        }
    }

}
