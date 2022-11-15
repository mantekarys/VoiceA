using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoiceAssistant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Moq.AutoMock;
using Moq;
using IWshRuntimeLibrary;
using System.Security.Policy;
using System.Diagnostics;

using ShortCuts;
namespace VoiceAssistant.Tests
{
    [TestClass()]
    public class ShortcutTests
    {

        [TestMethod()]
        [DataRow("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts", "new", "C:\\Users\\mante\\Desktop\\log.txt")]
        public void CreateTest(string shortcutName, string shortcutPath, string targetPath)
        {
            var fileMock = new Mock<FileManagment>();
            fileMock.Setup(x => x.CreateLink(shortcutName, shortcutPath, targetPath));

            Shortcut.Create(shortcutName, shortcutPath, targetPath, fileMock.Object);

            fileMock.VerifyAll();
        }

        [TestMethod()]
        [DataRow("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts", "youtube", "https://www.youtube.com")]
        public void CreateURLTest(string shortcutName, string shortcutPath, string url)
        {
            var fileMock = new Mock<FileManagment>();
            fileMock.Setup(x => x.CreateUrl(shortcutName, shortcutPath, url));

            Shortcut.CreateURL(shortcutName, shortcutPath, url, fileMock.Object);

            fileMock.VerifyAll();
        }
        [TestMethod()]
        [DataRow("new", "C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts")]
        public void RemoveTest(string name, string path)
        {
            var fileMock = new Mock<FileManagment>();
            string fullName = Directory.GetFiles(path, name + ".*")[0];
            fileMock.Setup(x => x.Delete(Path.Combine(path, fullName)));

            Shortcut.Remove(name, path, fileMock.Object);
            fileMock.VerifyAll();
        }

        [TestMethod()]
        [DataRow("new", "C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts")]
        public void OpenTest(string name, string path)
        {
            var fileMock = new Mock<FileManagment>();
            string fullName = Directory.GetFiles(path, name + ".*")[0];
            fileMock.Setup(x => x.Open(Path.Combine(path, fullName)));

            Shortcut.Open(name, path, fileMock.Object);

            fileMock.VerifyAll();
        }

        [TestMethod()]
        [DataRow("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts")]
        [DataRow("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\test5")]
        public void CheckDirTest(string path)
        {
            Shortcut.CheckDir(path);
            Assert.IsTrue(Directory.Exists(path));
        }
        [TestCleanup()]
        //[ClassCleanup()]
        public void Teardown()
        {
            if (Directory.Exists("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\test5"))
            {
                Directory.Delete("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\test5");
            }
        }

        [TestMethod()]
        [DataRow("test", true)]
        [DataRow("testDoesntExist", false)]
        public void ContainsTest(string path, bool expectedResult)
        {

            bool result = Shortcut.Contains(path);
            Assert.AreEqual(expectedResult,result);

        }

        [TestMethod()]
        [DataRow("testUrl", true)]
        [DataRow("testDoesntExist", false)]
        public void ContainsURLTest(string path, bool expectedResult)
        {
            Shortcut.CreateURL("testUrl", "C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts", "https://www.youtube.com");
            Shortcut.Remove("testDoesntExist", "C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts");
            bool result = Shortcut.ContainsURL(path);
            Assert.AreEqual(expectedResult, result);
        }
    }
}