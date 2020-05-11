using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    class Program
    {
        static void Main()
        {
            #region First task
            string[] firstNames = { "Андрей", "Григорий", "Павел", "Владимир" };
            string[] lastNames = { "Петин", "Ревин", "Бугаев", "Парамонов" };
            string[] fullNames = new string[8];

            for(int i = 0, j = 0; j < firstNames.Count(); i+=2, j++)
            {
                fullNames[i] = firstNames[j];
                fullNames[i + 1] = lastNames[j];
            }
            #endregion

            #region Second task
            bool swapped;
            for (int i = 0; i < lastNames.Count(); i++)
            {
                swapped = false;
                for(int j = 0; j < lastNames.Count()-i-1; j++)
                {
                    if (lastNames[j].CompareTo(lastNames[j + 1]) > 0)
                    {
                        string temp = lastNames[j + 1];
                        lastNames[j + 1] = lastNames[j];
                        lastNames[j] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false) break;
            }
            #endregion

            #region Third task (see Student.cs)
            Queue<Student> queueToExpulsion = new Queue<Student>();
            for(int i= 0; i < 101; i++)
            {
                Student temp = Student.GenerateStudent();
                if (temp.GetDecision())
                    queueToExpulsion.Enqueue(temp);
            }
            foreach(Student student in queueToExpulsion)
                Console.WriteLine(student.GetStudentInfo());
            Console.WriteLine(queueToExpulsion.Count());
            Console.ReadKey();
            #endregion

            #region Fourth task
            Dictionary<string, string> ARDictionary = new Dictionary<string, string>
            {
                { "Hello", "Здравствуйте" },
                { "Responsibility", "Ответственность" },
                { "Peaceful", "Мирный" },
                { "Test", "Тест" },
                { "Point", "Точка" }
            };
            #endregion

            #region Fifth task (see QueueExpulse.cs)
            QueueExpulse queueToExpulse = new QueueExpulse(100);
            for(int i = 0; i < queueToExpulse.length; i++)
            {
                Student temp = Student.GenerateStudent();
                if (temp.GetDecision())
                    queueToExpulse[i] = temp;
            }
            Console.WriteLine(queueToExpulse.printQueue());
            Console.ReadKey();
            #endregion
        }
    }
}
