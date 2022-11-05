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
            //Assert.Fail();
        }

        [TestMethod()]
        [DataRow("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts")]
        [DataRow("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\test5")]
        public void CheckDirTest(string path)
        {
            Shortcut.CheckDir(path);
            if (!Directory.Exists(path))
            {
                Assert.Fail();
            }
        }
        [TestCleanup()]
        //[ClassCleanup()]
        public void Teardown()
        {
            if (Directory.Exists("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\test5"))
            {
                Directory.Delete("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\test5");
            }
            //ar butina?????????????
        }
        //[ClassInitialize()]
        //public void Setup2()
        //{
        //    Shortcut.Create("test", "C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts", "C:\\Users\\mante\\Desktop\\log.txt");
        //    Shortcut.Remove("testDoesntExist", "C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts");
        //}
        [TestMethod()]
        [DataRow("test")]
        [DataRow("testDoesntExist")]
        public void ContainsTest(string path)
        {

            bool result = Shortcut.Contains(path);
            if (!result && path=="test")
            {
                Assert.Fail();
            }
            if (result && path == "testDoesntExist")
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        [DataRow("testUrl")]
        [DataRow("testDoesntExist")]
        public void ContainsURLTest(string path)
        {
            Shortcut.CreateURL("testUrl", "C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts", "https://www.youtube.com");
            Shortcut.Remove("testDoesntExist", "C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts");
            bool result = Shortcut.ContainsURL(path);
            if (!result && path == "testUrl")
            {
                Assert.Fail();
            }
            if (result && path == "testDoesntExist")
            {
                Assert.Fail();
            }
        }
        //public class PathWrapper
        //{
        //    public virtual string Combine(string one, string two)
        //    {
        //        return Path.Combine(one, two);
        //    }
        //}
        //public class TaskUtilsWrapper
        //{
        //    public virtual string[] GetFileNames(string one)
        //    {
        //        return TaskUtils.GetFileNames(one);
        //    }
        //}
        //public class ConstantsFake
        //{
        //    public static string ShortcutsFolder = "C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts";
        //}
        //[TestClass()]
        //public class ShortcutTests
        //{

        //    [TestMethod()]
        //    [DataRow("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts", "new", "C:\\Users\\mante\\Desktop\\log.txt")]
        //    public void CreateTest(string shortcutPath, string shortcutName, string targetPath)
        //    {
        //        CheckDirTest(shortcutPath);
        //        var pathStub = new Mock<PathWrapper>();
        //        pathStub.Setup(x => x.Combine(shortcutPath, shortcutName + ".lnk")).Returns("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts\\sas.lnk");
        //        var shortcutLocation = pathStub.Object.Combine(shortcutPath, shortcutName + ".lnk");//Path.Combine(shortcutPath, shortcutName + ".lnk");

        //        var shellStub = new Mock<WshShell>();
        //        shellStub.Setup(x => x.CreateShortcut(shortcutLocation)).Returns("smth");//pakeist
        //        //var shell = new WshShell();
        //        var shortcut = shellStub.Object.CreateShortcut(shortcutLocation);// as IWshShortcut;
        //        //shortcut.TargetPath = targetPath;//ka su sita nesamone daryt???
        //        //shortcut.Save();//ka pries ir po testavimo metodus?????
        //        //Assert.Fail();//integration testai?????//pratestuot kai duodam bloga kelia ar bloga name
        //    }

        //    [TestMethod()]
        //    [DataRow("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts", "youtube", "https://www.youtube.com")]
        //    public void CreateURLTest(string shortcutPath, string shortcutName, string url)
        //    {
        //        CheckDirTest(shortcutPath);

        //        using (StreamWriter writer = new StreamWriter(Path.Combine(shortcutPath, shortcutName + ".url")))
        //        {
        //            writer.WriteLine("[InternetShortcut]");
        //            writer.WriteLine("URL=" + url);
        //        }

        //        using (StreamReader reader = new StreamReader(Path.Combine(shortcutPath, shortcutName + ".url")))
        //        {
        //            string l1 = reader.ReadLine();
        //            string l2 = reader.ReadLine();
        //            if (l1 != "[InternetShortcut]" || l2 != "URL=" + url) Assert.Fail();
        //        }
        //    }
        //    [TestInitialize()]
        //    public void Setup()
        //    {
        //        Shortcut.Create("new", "C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts", "C:\\Users\\mante\\Desktop\\log.txt");
        //        //Directory.Delete("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\test5");
        //    }

        //    [TestMethod()]
        //    [DataRow("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts", "new")]
        //    public void RemoveTest(string path, string name)
        //    {
        //        CheckDirTest(path);
        //        try
        //        {
        //            string fullName = Directory.GetFiles(path, name + ".*")[0];
        //            System.IO.File.Delete(Path.Combine(path, fullName));
        //        }
        //        catch
        //        {
        //            Assert.Fail();//pratestuiot
        //        }
        //    }

        //    [TestMethod()]
        //    [DataRow("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts", "new")]
        //    public void OpenTest(string path, string name)
        //    {
        //        CheckDirTest(path);

        //        if (Directory.GetFiles(path, name + ".*").Length != 0)//ar mockint directory
        //        {
        //            string fullName = Directory.GetFiles(path, name + ".*")[0];//ar uzmokint
        //            try
        //            {
        //                Process.Start(Path.Combine(path, fullName));//ar mockint path
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //                Assert.Fail();//paziuret
        //            }
        //        }
        //    }

        //    [TestMethod()]
        //    [DataRow("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Shortcuts")]
        //    [DataRow("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\test5")]
        //    public void CheckDirTest(string path)
        //    {
        //        if (!Directory.Exists(path))
        //        {
        //            Directory.CreateDirectory(path);
        //        }
        //        if (!Directory.Exists(path))
        //        {
        //            Assert.Fail();
        //        }
        //    }
        //    [TestCleanup()]
        //    //[ClassCleanup()]
        //    public void Teardown()
        //    {
        //        if (Directory.Exists("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\test5"))
        //        {
        //            Directory.Delete("C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\test5");
        //        }
        //        //ar butina?????????????
        //    }

        //    [TestMethod()]
        //    [DataRow("sas")]
        //    public void ContainsTest(string path)
        //    {
        //        var taskUtilsStub = new Mock<TaskUtilsWrapper>();
        //        taskUtilsStub.Setup(x => x.GetFileNames(ConstantsFake.ShortcutsFolder)).Returns(new String[] { "GoogleJP.url", "sas.lnk" });
        //        string[] files = taskUtilsStub.Object.GetFileNames(ConstantsFake.ShortcutsFolder);//TaskUtils.GetFileNames(ConstantsFake.ShortcutsFolder);

        //        foreach (string file in files)
        //        {
        //            if (file.Equals(path + ".lnk"))
        //            {
        //                //return true;
        //            }
        //        }

        //        //return false;
        //        //Assert.Fail();
        //    }

        //    [TestMethod()]
        //    [DataRow("GoogleJP")]
        //    public void ContainsURLTest(string path)
        //    {
        //        //string[] files = TaskUtils.GetFileNames(ConstantsFake.ShortcutsFolder);
        //        var taskUtilsStub = new Mock<TaskUtilsWrapper>();
        //        taskUtilsStub.Setup(x => x.GetFileNames(ConstantsFake.ShortcutsFolder)).Returns(new String[] { "GoogleJP.url", "sas.lnk" });
        //        string[] files = taskUtilsStub.Object.GetFileNames(ConstantsFake.ShortcutsFolder);//TaskUtils.GetFileNames(ConstantsFake.ShortcutsFolder);

        //        foreach (string file in files)
        //        {
        //            if (file.Equals(path + ".url"))
        //            {
        //                //return true;
        //            }
        //        }

        //        //return false;
        //        //Assert.Fail();
        //    }
    }
}