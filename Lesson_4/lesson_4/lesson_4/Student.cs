using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    public class Student : IStudent
    {
        static Random random = new Random();
        static string[] firstNames = {"Евдоким","Назар","Иван","Тарас","Станислав","Василий","Влад","Роман","Егор" };
        static string[] lastNames = {"Смирнов", "Иванов", "Петров", "Попов", "Соколов", "Лазарев","Кузнецов" };
        public static Student GenerateStudent()
        {
            string FirstName = firstNames[random.Next(firstNames.Count())];
            string LastName = lastNames[random.Next(lastNames.Count())];
            int[] scores = new int[4];
            for (int i = 0; i < 4; i++)
                scores[i] = random.Next(2, 6);
            return new Student(FirstName, LastName, scores[0], scores[1], scores[2], scores[3]);
        }

        private string _firstName;
        private string _lastName;
        private Dictionary<string, int> scores = new Dictionary<string, int>();

        public Student(string FirstName, string LastName, int ProgScore, int PhylScore, int NetwScore, int SingScore)
        {
            _firstName = FirstName; _lastName = LastName; 
            scores.Add("Programming", ProgScore);
            scores.Add("Phylosophy", PhylScore);
            scores.Add("Networks", NetwScore);
            scores.Add("Singing", SingScore);
        }

        public string GetStudentInfo()
        {
            string studentInfo = $"First Name: {_firstName}, Last Name: {_lastName}\n";
            foreach(KeyValuePair<string, int> score in scores)
                studentInfo += $"{score.Key}: {score.Value} \n ";
            return studentInfo;
        }
        public bool GetDecision()
        {
            int badScores = 0;
            foreach(int score in scores.Values)
                if (score < 3) badScores++;
            if (badScores >= 3) return true;

            int mark;
            scores.TryGetValue("Programming", out mark);
            if (mark < 3) return true;
            scores.TryGetValue("Networks", out mark);
            if (mark < 3) return true;
            return false;
        }
    }
}
