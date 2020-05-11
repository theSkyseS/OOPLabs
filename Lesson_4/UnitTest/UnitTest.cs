using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using lesson_4;

namespace UnitTest
{
    public class UnitTest
    {
        [TestCase(2,2,2,2, true)]
        [TestCase(5,5,5,5, false)]
        [TestCase(3,5,2,3, true)]
        [TestCase(5,2,5,3, false)]
        [TestCase(2,5,5,5, true)]
        public void GetDecisionTest(int ProgScore, int PhylScore, int NetwScore, int SingScore, bool result)
        {
            Student student = new Student("Name", "NotName", ProgScore, PhylScore, NetwScore, SingScore);
            bool decision = student.GetDecision();
            Assert.AreEqual(result, decision);
        }
    }
}
