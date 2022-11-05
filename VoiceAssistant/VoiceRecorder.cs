using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceAssistant
{
    public class VoiceRecorder
    {
        private string RecordingsFolder;

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        private IKeyboardMouseEvents GlobalHook = Hook.GlobalEvents();

        public enum KeyType
        {
            Mouse,
            Keyboard
        }

        private string KeyString = "Control, Alt, R";
        private KeyType KeyT = KeyType.Keyboard;

        public string Keys
        {
            get
            {
                return KeyString.Replace(", ", " + ");
            }
        }

        public string[] KeysArray
        {
            get
            {
                string[] keysArray = KeyString.Split(',');

                for (int i = 0; i < keysArray.Length; i++)
                {
                    keysArray[i] = keysArray[i].Trim();
                }

                return keysArray;
            }
        }

        private bool recording;

        public bool IsRecording
        {
            get
            {
                return recording;
            }
        }

        public VoiceRecorder(string folder) 
        {
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            RecordingsFolder = folder;
            recording = false;
        }

        public void Start()
        {
            if (!recording)
            {
                mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
                mciSendString("record recsound", "", 0, 0);

                GlobalHook.KeyDown += KeyDown;
                GlobalHook.MouseDown += MouseKeyDown;

                recording = true;
            }
        }

        public void Stop()
        {
            if (recording)
            {
                int id = TaskUtils.GetFileNames(RecordingsFolder).Length;

                mciSendString($"save recsound { Path.Combine(RecordingsFolder, $"Recording_{ id }.wav") }", "", 0, 0);
                mciSendString("close recsound ", "", 0, 0);

                GlobalHook.KeyDown -= KeyDown;
                GlobalHook.MouseDown -= MouseKeyDown;

                recording = false;
            }
        }

        public void SetKey(string keys, KeyType type)
        {
            KeyString = keys;
            KeyT = type;
        }

        public void MouseKeyDown(object sender, MouseEventArgs e)
        {
            if (KeyT == KeyType.Mouse)
            {
                string mouseButton = e.Button.ToString();

                if (mouseButton.Equals(KeyString))
                    Start();
            }
        }

        public void KeyDown(object sender, KeyEventArgs e)
        {
            if (KeyT == KeyType.Keyboard)
            {
                string[] keysPressed = e.KeyData.ToString().Split(',');

                int match = 0;
                foreach (string key in KeysArray)
                {
                    foreach (string keyPressed in keysPressed)
                    {
                        string ser = key.Trim().ToLower();
                        string pre = keyPressed.Trim().ToLower();

                        if (ser.Equals(pre))
                        {
                            match++;
                            break;
                        }
                    }
                }

                if (match == KeysArray.Length)
                    Stop();
            }
        }

    }
}
