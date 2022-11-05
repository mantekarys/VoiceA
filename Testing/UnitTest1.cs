using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using VoiceAssistant;
namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow]
        public void TestRemove(string result)
        {
            var form = new CalendarForm();
            form.List(10);
            string answer; 
            int num;
            bool flag = false;
            if (int.TryParse(result, out num))
            {
                flag = true;
                answer = form.Remove(num - 1);
            }
            else
            {
                answer = "You had to say a number of which event to remove";
            }
            if (flag)
            {
                if (num <= 10)
                {
                    Assert.AreEqual("seip event was removed", answer);
                }
                else
                {
                    Assert.AreEqual("This event is not in the calendar list", answer);
                }
            }
            else
            {
                Assert.AreEqual("You had to say a number of which event to remove", answer);
            }
         
        }
        [TestMethod]
        public void TestRemoveWithNumbers()
        {
            Random rand = new Random();
            for(int i = 0; i < 5; i++)
            {
                TestRemove(rand.Next(0, 21).ToString());
            }
        }
        [TestMethod]
        public void TestRemoveWithLetters()
        {
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                TestRemove(((char)rand.Next(0, 21)).ToString());
            }
        }
    }
}
