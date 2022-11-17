using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceAssistant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace VoiceAssistant.Tests
{
    [TestClass()]
    public class MantasOnlineTests
    {
        [TestMethod()]
        [DataRow("Langas", "The window")]
        [DataRow("Nosis", "Nose")]
        [DataRow("собака", "dog")]
        [DataRow("asd", "Translation is asd. Are you sure you selected an existing word, that is not in English?")]
        [DataRow("", "text not selected")]
        public void TranslateTest(string textToTranslate, string expectedResult)
        {
            var copyMock = new Mock<MantasOnlineWrapper>();
            copyMock.Setup(x => x.GetClipBoradData()).Returns(textToTranslate);

            string result = MantasOnline.Translate(copyMock.Object);
            copyMock.VerifyAll();
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        [DataRow("Sky", "The sky is an unobstructed view upward from the surface of the Earth. It includes the atmosphere and outer space. It may also be considered a place between the ground and outer space, thus distinct from outer space.")]
        [DataRow("Car", "A car or automobile is a motor vehicle with wheels. Most definitions of cars say that they run primarily on roads, seat one to eight people, have four wheels, and mainly transport people instead of goods.[1][2]")]
        [DataRow("nafss", "no definition")]
        [DataRow("", "no definition")]
        public void DefinitionTest(string textToDefine, string expectedResult)
        {
            var copyMock = new Mock<MantasOnlineWrapper>();
            copyMock.Setup(x => x.GetClipBoradData()).Returns(textToDefine);
            string result = MantasOnline.Definition(copyMock.Object);
            copyMock.VerifyAll();
            Assert.AreEqual(expectedResult, result);
        }
    }
}