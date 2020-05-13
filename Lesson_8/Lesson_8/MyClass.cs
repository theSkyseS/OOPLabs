using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    class MyClass
    {
        public int amount;
        public string name;

        static protected bool flag = true;
        private double gap;

        public string Name { get => name; set => name = value; }
        protected bool Flag { set => flag = value; }
        private double doubleProperty { set; get; }

        public bool getFlag()
        {
            return flag;
        }
        protected void SetGap(double value)
        {
            gap = value;
        }
        private void AddToName(string value)
        {
            name += value;
        }

        public MyClass()
        {
            amount = 1;
            name = "default";
            flag = false;
            gap = 0.5;
        }

        private MyClass(int Amount, string Name, bool Flag, double Gap)
        {
            amount = Amount;
            name = Name;
            flag = Flag;
            gap = Gap;
        }
    }
}
