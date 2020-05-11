using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    class QueueExpulse
    {
        private Student[] queueToExpulse;
        public int length;
        public string printQueue()
        {
            string queueString ="";
            foreach (Student student in queueToExpulse)
                queueString += student?.GetStudentInfo() + "\n";
            return queueString;
        }
        public QueueExpulse(int capacity)
        {
            queueToExpulse = new Student[capacity];
            length = queueToExpulse.Length;
        }
        public Student this[int index] { get => queueToExpulse[index]; set => queueToExpulse[index] = value; }
    }
}
