// <copyright file="ConstantsTest.cs">Copyright ©  2021</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceAssistant;

namespace VoiceAssistant.Tests
{
    /// <summary>This class contains parameterized unit tests for Constants</summary>
    [PexClass(typeof(Constants))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ConstantsTest
    {
    }
}
