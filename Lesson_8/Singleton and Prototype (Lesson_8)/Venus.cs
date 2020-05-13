using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lesson_8
{
    class Venus : CelestialBody, IPlanet
    {
        private static Venus instance;
        public bool DenseAtmosphere { get; set; }
        public int AtmosphericPressure { get; set; }
        public double SurfaceGravity { get; set; }

        protected Venus()
        {
            name = "Venus";
            orbitSemiMajorAxis = 108208930;
            orbitVelocity = 35020;
            diameter = 6051800;
            mass = (int)(4.8675 * (10 ^ 24));
            DenseAtmosphere = true;
            AtmosphericPressure = 9300000;
            SurfaceGravity = 8.87;
        }
        public static Venus Instance()
        {
            if (instance == null)
                instance = new Venus();
            return instance;
        }
    }
}
