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
    public class LocationUtilsTests
    {
        [TestMethod()]
        [DataRow("Moscow", "Beijing", 5797)]
        [DataRow("asd", "Beijing",-1)]
        [DataRow("Moscow", "asd",-2)]
        [DataRow("", "",-1)]
        [DataRow("asc", null,0)]
        [DataRow(null, "asc", 0)]
        public void GetDistanceTest(string location1, string location2, int expectedResult)
        {
            int result = LocationUtils.GetDistance(location1, location2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        [DataRow("Moscow", "C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Distance\\worldcities.csv")]
        [DataRow("Beijing", "C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Distance\\worldcities.csv")]
        public void GetLatiLongiTest(string location, string file)
        {
            LocationUtils.GetLatiLongi(location, file);
        }
    }
}