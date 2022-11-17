using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceAssistant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Moq;
using Castle.Core.Internal;

namespace VoiceAssistant.Tests
{
    [TestClass()]
    public class TaskUtilsTests
    {
        [TestMethod()]
        [DataRow("Resources")]
        public void GetFileNamesTestResources(string path)
        {
            var s = new string[] { "MicBlack.png", "MicGreen.png" };
            var result = TaskUtils.GetFileNames(path);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.IsTrue(result[i].Equals(s[i]));
            }
            
        }

        [TestMethod()]
        [DataRow(null)]
        public void GetFileNamesTestNull(string path)
        {
            string[] result = TaskUtils.GetFileNames(path);
            Assert.IsNull(result);
        }

        [TestMethod()]
        [DataRow("ThisFileDoesntExist")]
        public void GetFileNamesTestFakeFile(string path)
        {
                string[] result = TaskUtils.GetFileNames(path);
                Assert.IsNull(result);
        }
    }
}