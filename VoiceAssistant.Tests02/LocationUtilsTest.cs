// <copyright file="LocationUtilsTest.cs">Copyright ©  2021</copyright>
using System;
using System.IO;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceAssistant;

namespace VoiceAssistant.Tests
{
    /// <summary>This class contains parameterized unit tests for LocationUtils</summary>
    [PexClass(typeof(LocationUtils))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class LocationUtilsTest
    {
        /// <summary>Test stub for GetDistance(String, String)</summary>
        [PexMethod]
        //[PexAllowedException(typeof(NullReferenceException))]
        [PexArguments("Moscow", "Beijing")]
        public int GetDistanceTest(string location1, string location2)
        {
            int result = LocationUtils.GetDistance(location1, location2);
            return result;
            // TODO: add assertions to method LocationUtilsTest.GetDistanceTest(String, String)
        }

        /// <summary>Test stub for GetLatiLongi(String, String)</summary>
        [PexMethod]
        [PexArgumentsAttribute("Moscow", "C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Distance\\worldcities.csv")]
        [PexArgumentsAttribute("Beijing", "C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Distance\\worldcities.csv")]
        public double[] GetLatiLongiTest(string location, string file)
        {
            double[] result = LocationUtils.GetLatiLongi(location, file);
            return result;
            // TODO: add assertions to method LocationUtilsTest.GetLatiLongiTest(String, String)
        }
    }
}
