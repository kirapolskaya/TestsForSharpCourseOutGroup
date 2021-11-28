using NUnit.Framework;

namespace Lab2.Tests
{
    public class Tests
    {
        [TestCase(new string[] { "Person", "Patient", "Visitor" }, 3)]
        [("Убрать после реализации метода")]
        public void Test1(string[] verificationData, int count)
        {
            struct[] objs = { new Person(), new Patient(), new Visitor() };
            string[] tempString = new string[objs.Length];
            for (int i = 0; i < objs.Length; i++)
            {
                 tempString[i] = objs[i].Print();
            }
             Assert.AreEqual(tempString, verificationData, "Данные реализованы не верно");
        }

        [TestCase(new string[] { "ItsclasstestInterface", "ItsclasstestInterface", "ItsclasstestInterface" }, 3)]
        
        public void Test2(string[] verificationData, int count)
        {
             struct[] objs = { new Person(), new Patient(), new Primary_care_doctor() };
            string[] tempString = new string[objs.Length];
             for (int i = 0; i < objs.Length; i++)
             {
                tempString[i] = objs[i].PringFromInterface();
            }
             Assert.AreEqual(tempString, verificationData, "Данные реализованы не верно");
        }
    }
}