using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lesson_6;

namespace Lesson_7
{
    public class Program
    {
        #region Task 1
        public delegate double MyDel1(int[] a);

        public static MyDel1 myDelegate1 = delegate (int[] a)
        {
            int sum = 0;
            double result = 0;
            foreach (int i in a)
                sum += i;
            result = (sum * 1.0) / a.Length;
            return result;
        };
        #endregion

        #region Task 2
        public delegate int MyDel2(int x, int y, string oper);

        public static MyDel2 myDelegate2 = delegate (int x, int y, string oper)//oper передаётся для тестов
        {
            //string oper = Console.ReadLine();
            switch (oper)
            {
                case "+": return x + y;
                case "-": return x - y;
                default: Console.WriteLine("Введён неверный оператор"); return int.MinValue+1;
            }
            
        };
        #endregion

        //сами события из задания 3 находятся в шестом уроке в computer.cs
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.UserAdded += delegate
            {
                if (computer.UserList.Contains("admin"))
                    computer.UserList.Remove("admin");
            };
            computer.InvokeEvents();
        }
    }
}
