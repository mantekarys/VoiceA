// <copyright file="VoiceRecorderTest.cs">Copyright ©  2021</copyright>
using System;
using System.Windows.Forms;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceAssistant;

namespace VoiceAssistant.Tests
{
    /// <summary>This class contains parameterized unit tests for VoiceRecorder</summary>
    [PexClass(typeof(VoiceRecorder))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class VoiceRecorderTest
    {
        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        public VoiceRecorder ConstructorTest(string folder)
        {
            VoiceRecorder target = new VoiceRecorder(folder);
            return target;
            // TODO: add assertions to method VoiceRecorderTest.ConstructorTest(String)
        }

        /// <summary>Test stub for get_IsRecording()</summary>
        [PexMethod]
        public bool IsRecordingGetTest([PexAssumeUnderTest]VoiceRecorder target)
        {
            bool result = target.IsRecording;
            return result;
            // TODO: add assertions to method VoiceRecorderTest.IsRecordingGetTest(VoiceRecorder)
        }

        /// <summary>Test stub for KeyDown(Object, KeyEventArgs)</summary>
        [PexMethod]
        public void KeyDownTest(
            [PexAssumeUnderTest]VoiceRecorder target,
            object sender,
            KeyEventArgs e
        )
        {
            target.KeyDown(sender, e);
            // TODO: add assertions to method VoiceRecorderTest.KeyDownTest(VoiceRecorder, Object, KeyEventArgs)
        }

        /// <summary>Test stub for get_KeysArray()</summary>
        [PexMethod]
        public string[] KeysArrayGetTest([PexAssumeUnderTest]VoiceRecorder target)
        {
            string[] result = target.KeysArray;
            return result;
            // TODO: add assertions to method VoiceRecorderTest.KeysArrayGetTest(VoiceRecorder)
        }

        /// <summary>Test stub for get_Keys()</summary>
        [PexMethod]
        public string KeysGetTest([PexAssumeUnderTest]VoiceRecorder target)
        {
            string result = target.Keys;
            return result;
            // TODO: add assertions to method VoiceRecorderTest.KeysGetTest(VoiceRecorder)
        }

        /// <summary>Test stub for MouseKeyDown(Object, MouseEventArgs)</summary>
        [PexMethod]
        public void MouseKeyDownTest(
            [PexAssumeUnderTest]VoiceRecorder target,
            object sender,
            MouseEventArgs e
        )
        {
            target.MouseKeyDown(sender, e);
            // TODO: add assertions to method VoiceRecorderTest.MouseKeyDownTest(VoiceRecorder, Object, MouseEventArgs)
        }

        /// <summary>Test stub for SetKey(String, KeyType)</summary>
        [PexMethod]
        public void SetKeyTest(
            [PexAssumeUnderTest]VoiceRecorder target,
            string keys,
            VoiceRecorder.KeyType type
        )
        {
            target.SetKey(keys, type);
            // TODO: add assertions to method VoiceRecorderTest.SetKeyTest(VoiceRecorder, String, KeyType)
        }

        /// <summary>Test stub for Start()</summary>
        [PexMethod]
        public void StartTest([PexAssumeUnderTest]VoiceRecorder target)
        {
            target.Start();
            // TODO: add assertions to method VoiceRecorderTest.StartTest(VoiceRecorder)
        }

        /// <summary>Test stub for Stop()</summary>
        [PexMethod]
        public void StopTest([PexAssumeUnderTest]VoiceRecorder target)
        {
            target.Stop();
            // TODO: add assertions to method VoiceRecorderTest.StopTest(VoiceRecorder)
        }
    }
}
