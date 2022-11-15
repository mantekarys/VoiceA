using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VoiceAssistant;
using Moq;
using static VoiceAssistant.VoiceRecorder;
using System.Windows.Forms;

namespace VoiceAssistantTests
{
    [TestClass]
    public class ActivationKeyTests
    {
        [TestMethod]
        public void IsClickedTest()
        {
            Assert.IsFalse(ActivationKey.IsClicked());
        }
        [TestMethod]
        [DataRow("A")]
        public void SetTest(string keys)
        {
            ActivationKey.Set(keys);
            Assert.AreEqual(keys, ActivationKey.KeyString); // ActivationKey.KeyString / might need to switch some variables to public to see whether it changed
        }
        [TestMethod]
        [DataRow(ActivationKey.KeyType.Keyboard)]
        [DataRow(ActivationKey.KeyType.Mouse)]
        public void SetTypeTest(ActivationKey.KeyType type)
        {
            ActivationKey.SetType(type);
            Assert.AreEqual(type, ActivationKey.KeyT); // might need to switch some variables to public to see whether it changed
        }
        [TestMethod]
        [DataRow(MouseButtons.Left)]
        public void GlobalHook_MouseKeyDownTest(MouseButtons mouseButton)
        {
            ActivationKey.clicked = false;
            ActivationKey.SetType(ActivationKey.KeyType.Mouse);
            ActivationKey.Set("Left");
            var arg = new MouseEventArgs(mouseButton, 1, 1, 1, 0);
            ActivationKey.GlobalHook_MouseKeyDown(new object(), arg);
            Assert.IsTrue(ActivationKey.IsClicked());
        }
        
        [TestMethod]
        [DataRow(MouseButtons.Left)]
        public void GlobalHook_MouseKeyUpTest(MouseButtons mouseButton)
        {
            ActivationKey.clicked = true;
            ActivationKey.SetType(ActivationKey.KeyType.Mouse);
            ActivationKey.Set("Left");
            var arg = new MouseEventArgs(mouseButton, 1, 1, 1, 0);
            ActivationKey.GlobalHook_MouseKeyUp(new object(), arg);
            Assert.IsFalse(ActivationKey.IsClicked());
        }
        [TestMethod]
        [DataRow(Keys.M)]
        public void GlobalHook_KeyDownTest(Keys key)
        {
            ActivationKey.clicked = false;
            ActivationKey.SetType(ActivationKey.KeyType.Keyboard);
            ActivationKey.Set("M");
            var arg = new KeyEventArgs(key);
            ActivationKey.GlobalHook_KeyDown(new object(), arg);
            Assert.IsTrue(ActivationKey.IsClicked());
        }
        [TestMethod]
        [DataRow(Keys.M)]
        public void GlobalHook_KeyUpTest(Keys key)
        {
            ActivationKey.clicked = true;
            ActivationKey.SetType(ActivationKey.KeyType.Keyboard);
            ActivationKey.Set("M");
            var arg = new KeyEventArgs(key);
            ActivationKey.GlobalHook_KeyUp(new object(), arg);
            Assert.IsFalse(ActivationKey.IsClicked());
        }
    }
}
