// <copyright file="ActivationKeyTest.cs">Copyright ©  2021</copyright>
using System;
using System.Windows.Forms;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceAssistant;

namespace VoiceAssistant.Tests
{
    /// <summary>This class contains parameterized unit tests for ActivationKey</summary>
    [PexClass(typeof(ActivationKey))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ActivationKeyTest
    {
        /// <summary>Test stub for GlobalHook_KeyDown(Object, KeyEventArgs)</summary>
        [PexMethod]
        internal void GlobalHook_KeyDownTest(object sender, KeyEventArgs e)
        {
            ActivationKey.GlobalHook_KeyDown(sender, e);
            // TODO: add assertions to method ActivationKeyTest.GlobalHook_KeyDownTest(Object, KeyEventArgs)
        }

        /// <summary>Test stub for GlobalHook_KeyUp(Object, KeyEventArgs)</summary>
        [PexMethod]
        internal void GlobalHook_KeyUpTest(object sender, KeyEventArgs e)
        {
            ActivationKey.GlobalHook_KeyUp(sender, e);
            // TODO: add assertions to method ActivationKeyTest.GlobalHook_KeyUpTest(Object, KeyEventArgs)
        }

        /// <summary>Test stub for GlobalHook_MouseKeyDown(Object, MouseEventArgs)</summary>
        [PexMethod]
        internal void GlobalHook_MouseKeyDownTest(object sender, MouseEventArgs e)
        {
            ActivationKey.GlobalHook_MouseKeyDown(sender, e);
            // TODO: add assertions to method ActivationKeyTest.GlobalHook_MouseKeyDownTest(Object, MouseEventArgs)
        }

        /// <summary>Test stub for GlobalHook_MouseKeyUp(Object, MouseEventArgs)</summary>
        [PexMethod]
        internal void GlobalHook_MouseKeyUpTest(object sender, MouseEventArgs e)
        {
            ActivationKey.GlobalHook_MouseKeyUp(sender, e);
            // TODO: add assertions to method ActivationKeyTest.GlobalHook_MouseKeyUpTest(Object, MouseEventArgs)
        }

        /// <summary>Test stub for IsClicked()</summary>
        [PexMethod]
        internal bool IsClickedTest()
        {
            bool result = ActivationKey.IsClicked();
            return result;
            // TODO: add assertions to method ActivationKeyTest.IsClickedTest()
        }

        /// <summary>Test stub for get_KeysArray()</summary>
        [PexMethod]
        internal string[] KeysArrayGetTest()
        {
            string[] result = ActivationKey.KeysArray;
            return result;
            // TODO: add assertions to method ActivationKeyTest.KeysArrayGetTest()
        }

        /// <summary>Test stub for get_Keys()</summary>
        [PexMethod]
        internal string KeysGetTest()
        {
            string result = ActivationKey.Keys;
            return result;
            // TODO: add assertions to method ActivationKeyTest.KeysGetTest()
        }

        /// <summary>Test stub for Set(String)</summary>
        [PexMethod]
        internal void SetTest(string keys)
        {
            ActivationKey.Set(keys);
            // TODO: add assertions to method ActivationKeyTest.SetTest(String)
        }

        /// <summary>Test stub for SetType(KeyType)</summary>
        [PexMethod]
        internal void SetTypeTest(ActivationKey.KeyType type)
        {
            ActivationKey.SetType(type);
            // TODO: add assertions to method ActivationKeyTest.SetTypeTest(KeyType)
        }
    }
}
