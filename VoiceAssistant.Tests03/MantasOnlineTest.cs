// <copyright file="MantasOnlineTest.cs">Copyright ©  2021</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceAssistant;

namespace VoiceAssistant.Tests
{
    /// <summary>This class contains parameterized unit tests for MantasOnline</summary>
    [PexClass(typeof(MantasOnline))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class MantasOnlineTest
    {
        /// <summary>Test stub for Definition()</summary>
        [PexMethod]
        public string DefinitionTest()
        {
            string result = MantasOnline.Definition();
            return result;
            // TODO: add assertions to method MantasOnlineTest.DefinitionTest()
        }

        /// <summary>Test stub for Translate()</summary>
        [PexMethod]
        public string TranslateTest()
        {
            string result = MantasOnline.Translate();
            return result;
            // TODO: add assertions to method MantasOnlineTest.TranslateTest()
        }
    }
}
