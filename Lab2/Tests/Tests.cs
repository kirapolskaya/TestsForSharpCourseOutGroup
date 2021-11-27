using NUnit.Framework;

namespace Lab2.Tests
{
    public class Tests
    {
        [TestCase(new string[] { "Citizen", "Voter", "Statesman" }, 3)]
        [("Убрать после реализации метода")]
        public void Test1(string[] verificationData, int count)
        {
            struct[] objs = { new Citizen(), new Voter(), new Statesman() };
            string[] tempString = new string[objs.Length];
            for (int i = 0; i < objs.Length; i++)
            {
                 tempString[i] = objs[i].Print();
            }
             Assert.AreEqual(tempString, verificationData, "Данные реализованы не верно");
        }

        [TestCase(new string[] { "CitizenInterface", "It is VoterInterface", "It is StatesmanInterface" }, 3)]
        [("Убрать после реализации метода")]
        public void Test2(string[] verificationData, int count)
        {
             struct[] objs = { new Citizen(), new Voter(), new Statesman() };
            string[] tempString = new string[objs.Length];
             for (int i = 0; i < objs.Length; i++)
             {
                tempString[i] = objs[i].PringFromInterface();
            }
             Assert.AreEqual(tempString, verificationData, "Данные реализованы не верно");
        }
    }
}