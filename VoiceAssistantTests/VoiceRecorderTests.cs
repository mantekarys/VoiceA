using IWshRuntimeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Windows.Forms;
using VoiceAssistant;

namespace VoiceAssistantTests
{
    [TestClass]
    public class VoiceRecorderTests
    {
        [ClassCleanup()]
        public static void Teardown()
        {
            if (Directory.Exists("C:\\TesterFolder"))
            {
                Directory.Delete("C:\\TesterFolder",true);
                
            }
        }


        [TestMethod]
        [DataRow("C:\\TesterFolder")]
        public void ConstructorTest(string folder)
        {
            VoiceRecorder _voiceRecorder = new VoiceRecorder(folder);
            if (!Directory.Exists(folder) || _voiceRecorder.IsRecording || _voiceRecorder.GetRecordingsFolder()!=folder)
            {
                Assert.Fail();
            }
        }
        private VoiceRecorder _voiceRecorder = new VoiceRecorder("C:\\TesterFolder");
        [TestMethod]
        [DataRow(Keys.L)]
        public void KeyDownTest(Keys keyButton)
        {
            _voiceRecorder.SetKey(keyButton.ToString(), VoiceRecorder.KeyType.Keyboard);
            var arg = new KeyEventArgs(keyButton);
            _voiceRecorder.KeyDown(new object(), arg);
            Assert.AreEqual(keyButton.ToString(), _voiceRecorder.Keys);
        }


        [TestMethod]
        [DataRow(MouseButtons.Left)]
        public void MouseKeyDownTest(MouseButtons mouseButton)
        {
            var arg = new MouseEventArgs(mouseButton, 1, 1, 1, 0);
            _voiceRecorder.SetKey(mouseButton.ToString(), VoiceRecorder.KeyType.Mouse);

            _voiceRecorder.MouseKeyDown(new object(), arg);
            Assert.AreEqual(mouseButton.ToString(), _voiceRecorder.Keys);
        }

        [TestMethod]
        [DataRow("Left", VoiceRecorder.KeyType.Mouse)]
        [DataRow("Control, M", VoiceRecorder.KeyType.Keyboard)]

        public void SetKeyTest(string keys, VoiceRecorder.KeyType type)
        {
            _voiceRecorder.SetKey(keys, type);
            Assert.AreEqual(_voiceRecorder.Keys, keys);
        }

        [TestMethod]
        public void StartTest()
        {
            _voiceRecorder.Start();
            Assert.IsTrue(_voiceRecorder.IsRecording);
        }
        [TestInitialize]
        public void TestInitialize()
        {
            _voiceRecorder.Start();
        }
        [TestMethod]
        public void StopTest()
        {
            _voiceRecorder.Stop();
            Assert.IsFalse(_voiceRecorder.IsRecording);
        }
    }
}
