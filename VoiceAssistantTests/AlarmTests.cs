using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceAssistant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using Moq;
using Castle.Core.Internal;

namespace VoiceAssistant.Tests
{
    [TestClass()]
    public class AlarmTests
    {
        [TestMethod()]
        [DataRow(1,2,"0123",true)]
        [DataRow(null, null, null, false)]
        public void AlarmTest(int hour, int minute, string days, bool enabled)
        {
            Alarm alarm = new Alarm(hour,minute,days,enabled);
            Assert.IsTrue(hour == alarm.Hour && minute == alarm.Minute && enabled == alarm.Enabled);
        }

        [TestMethod()]
        [DataRow("12:31:0156:True")]
        [DataRow("14:1:6:True")]
        [DataRow(":::")]
        [DataRow("5:5:6:7")]
        [DataRow(null)]
        public void ReadLineTest(string line)
        {
            Alarm alarm = Alarm.ReadLine(line);
            if (line.IsNullOrEmpty())
            {
                Assert.IsNull(alarm);
                return;
            }
            string[] values = line.Split(':');
            if(int.TryParse(values[0],out int hour)&& int.TryParse(values[1], out int minute)&& bool.TryParse(values[3], out bool enabled))
            {
                string days = values[2];
                Assert.IsTrue(hour == alarm.Hour && minute == alarm.Minute && enabled == alarm.Enabled);
            }
            else
            {
                Assert.IsNull(alarm);
            }
            
        }
        [TestMethod()]
        [DataRow("file")]
        [DataRow(null)]
        public void ReadFileTest(string fileName)
        {
            var fileMock = new Mock<FileManagment>();
            fileMock.Setup(x => x.ReadAllLines(fileName)).Returns(new string[] { "12:31:0156:True", "12:32:15:True", "18:21:25:True" });
            List<Alarm> alarms = Alarm.ReadFile(fileName, fileMock.Object);
            Assert.IsTrue(alarms.Count == fileMock.Object.ReadAllLines(fileName).Length);
        }



        [TestMethod()]
        [DataRow("file")]
        public void UpdateFileTest(string fileName)
        {
            List<Alarm> alarms = new List<Alarm>()
            {
                new Alarm(1,2,"01",true),
                new Alarm(4,4,"34",false),
                new Alarm(12,12,"6",true)
            };

            var fileMock = new Mock<FileManagment>();
            string[] lines = new string[alarms.Count];
            for (int i = 0; i < alarms.Count; i++)
            {
                lines[i] = alarms[i].Hour.ToString() + ":" + alarms[i].Minute.ToString() + ":" + alarms[i].getDayString() + ":" + alarms[i].Enabled.ToString();
            }
            fileMock.Setup(x => x.WriteAllLines(fileName, lines));
            Alarm.UpdateFile(fileName, alarms, fileMock.Object);
            fileMock.VerifyAll();
        }

        [TestMethod()]
        public void getDayStringTest()
        {
            string[] strings = new string[] { "01", "34", "6" };
            List<Alarm> alarms = new List<Alarm>()
            {
                new Alarm(1,2,"01",true),
                new Alarm(4,4,"34",false),
                new Alarm(12,12,"6",true)
            };
            for (int i = 0; i < alarms.Count; i++)
            {
                Assert.IsTrue(alarms[i].getDayString().Equals(strings[i]));
            }
        }
    }
}