using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceAssistant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;
using Castle.Core.Internal;

namespace VoiceAssistant.Tests
{
    [TestClass()]
    public class WeatherInfoTests
    {
        [TestMethod()]
        [DataRow("Barcelona")]
        [DataRow("London")]
        [DataRow("Tokyo")]
        [DataRow("Cumming")]
        [DataRow("Beijing")]
        [DataRow("Austin")]
        [DataRow("Ottawa")]
        [DataRow("Singapore")]
        [DataRow("Cairo")]
        [DataRow("Ankara")]
        [DataRow(null)]
        [DataRow("sdgdsgdfh")]
        public void GetInfoTest(string location)
        {

            WeatherInfo weatherInfo = new WeatherInfo();
            var info = weatherInfo.GetInfo(location);
            if (location.IsNullOrEmpty() || info.IsNullOrEmpty())
            {
                Assert.IsNull(info);
                return;
            }
            Assert.AreEqual(location, info[7]);
        }
    }
}