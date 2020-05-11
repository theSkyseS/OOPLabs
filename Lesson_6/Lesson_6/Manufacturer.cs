using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Lesson_6.ComputerManufacturer;

namespace Lesson_6
{
    class Manufacturer : IManufacturer
    {
        private static Random random = new Random();
        
        public ComputerManufacturer Name { get; set; }
        public Country Country { get; set; }
        public int NumberOfEmployees { get; set; }

        public Manufacturer()
        {
            Name = HP;
            Country = Country.China;
            NumberOfEmployees = 1;
        }
        public Manufacturer(ComputerManufacturer name, Country country, int numberOFEmployees)
        {
            Name = name;
            Country = country;
            NumberOfEmployees = numberOFEmployees;
        }

        static public Manufacturer Generate()
        {
            ComputerManufacturer name = (ComputerManufacturer)random.Next(7);
            Country country = (Country)random.Next(7);
            int numberOFEmployees = 100 * random.Next(1, 1000);
            return new Manufacturer(name, country, numberOFEmployees);
        }
        public static List<Manufacturer> Generate100()
        {
            List<Manufacturer> manufacturers = new List<Manufacturer>();
            for (int i = 0; i < 101; i++)
                manufacturers.Add(Generate());
            return manufacturers;
        }
    }
}
