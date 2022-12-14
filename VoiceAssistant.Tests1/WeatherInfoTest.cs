// <copyright file="WeatherInfoTest.cs">Copyright ©  2021</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceAssistant;

namespace VoiceAssistant.Tests
{
    /// <summary>This class contains parameterized unit tests for WeatherInfo</summary>
    [PexClass(typeof(WeatherInfo))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class WeatherInfoTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public WeatherInfo ConstructorTest()
        {
            WeatherInfo target = new WeatherInfo();
            return target;
            // TODO: add assertions to method WeatherInfoTest.ConstructorTest()
        }

        /// <summary>Test stub for GetInfo(String)</summary>
        [PexMethod]
        public string[] GetInfoTest([PexAssumeUnderTest]WeatherInfo target, string location)
        {
            string[] result = target.GetInfo(location);
            return result;
            // TODO: add assertions to method WeatherInfoTest.GetInfoTest(WeatherInfo, String)
        }
    }
}
