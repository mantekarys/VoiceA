// <copyright file="VoiceTest.cs">Copyright ©  2021</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceAssistant;

namespace VoiceAssistant.Tests
{
    /// <summary>This class contains parameterized unit tests for Voice</summary>
    [PexClass(typeof(Voice))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class VoiceTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public Voice ConstructorTest()
        {
            Voice target = new Voice();
            return target;
            // TODO: add assertions to method VoiceTest.ConstructorTest()
        }
    }
}
