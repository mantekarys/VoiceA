// <copyright file="ShortcutTest.cs">Copyright ©  2021</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceAssistant;

namespace VoiceAssistant.Tests
{
    /// <summary>This class contains parameterized unit tests for Shortcut</summary>
    [PexClass(typeof(Shortcut))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ShortcutTest
    {
        /// <summary>Test stub for CheckDir(String)</summary>
        [PexMethod]
        public void CheckDirTest(string path)
        {
            Shortcut.CheckDir(path);
            // TODO: add assertions to method ShortcutTest.CheckDirTest(String)
        }

        /// <summary>Test stub for Contains(String)</summary>
        [PexMethod]
        public bool ContainsTest(string path)
        {
            bool result = Shortcut.Contains(path);
            return result;
            // TODO: add assertions to method ShortcutTest.ContainsTest(String)
        }

        /// <summary>Test stub for ContainsURL(String)</summary>
        [PexMethod]
        public bool ContainsURLTest(string path)
        {
            bool result = Shortcut.ContainsURL(path);
            return result;
            // TODO: add assertions to method ShortcutTest.ContainsURLTest(String)
        }

        /// <summary>Test stub for Create(String, String, String)</summary>
        [PexMethod]
        public void CreateTest(
            string shortcutName,
            string shortcutPath,
            string targetPath
        )
        {
            Shortcut.Create(shortcutName, shortcutPath, targetPath);
            // TODO: add assertions to method ShortcutTest.CreateTest(String, String, String)
        }

        /// <summary>Test stub for CreateURL(String, String, String)</summary>
        [PexMethod]
        public void CreateURLTest(
            string shortcutName,
            string shortcutPath,
            string url
        )
        {
            Shortcut.CreateURL(shortcutName, shortcutPath, url);
            // TODO: add assertions to method ShortcutTest.CreateURLTest(String, String, String)
        }

        /// <summary>Test stub for Open(String, String)</summary>
        [PexMethod]
        [PexArguments()]
        public void OpenTest(string name, string path)
        {
            Shortcut.Open(name, path);
            // TODO: add assertions to method ShortcutTest.OpenTest(String, String)
        }

        /// <summary>Test stub for Remove(String, String)</summary>
        [PexMethod]
        public void RemoveTest(string name, string path)
        {
            Shortcut.Remove(name, path);
            // TODO: add assertions to method ShortcutTest.RemoveTest(String, String)
        }
    }
}
