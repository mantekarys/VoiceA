using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceAssistant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceAssistant.Tests
{
    [TestClass()]
    public class TimeTests
    {
        [TestMethod()]
        [DataRow(null)]
        [DataRow("adsadasdasf")]
        [DataRow("","Vilnius, Lithuania")]
        [DataRow("Moscow", "Moscow, Russia")] //Moscow, Russia 19 hours 14 minutes
        [DataRow("Paris", "Paris, France")] //Paris, France 17 hours 16 minutes
        [DataRow("Beijing", "Beijing, China")] //Beijing, China 00 hours 16 minutes
        public void getTimeInCityTest(string city, string result = "error")
        {
            var time = Time.getTimeInCity(city);
            Assert.IsTrue(time.StartsWith(result));
        }
    }
}