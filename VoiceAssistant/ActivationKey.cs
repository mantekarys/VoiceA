using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VoiceAssistant
{
    public static class ActivationKey
    {
        public enum KeyType
        {
            Mouse,
            Keyboard
        }

        public static string KeyString = Properties.Settings.Default.Keybind;
        public static KeyType KeyT = KeyType.Keyboard;


        public static string[] KeysArray
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

        public static bool clicked;

        public static bool IsClicked()
        {
            return clicked;
        }

        public static void Set(string keys)
        {
            KeyString = keys;
        }

        public static void SetType(KeyType type)
        {
            KeyT = type;
            clicked = false;
        }

        public static void GlobalHook_MouseKeyDown(object sender, MouseEventArgs e)
        {
            if (KeyT == KeyType.Mouse)
            {
                string mouseButton = e.Button.ToString();
                
                if (mouseButton.Equals(KeyString))
                    clicked = true;
            }
        }

        public static void GlobalHook_MouseKeyUp(object sender, MouseEventArgs e)
        {
            if (KeyT == KeyType.Mouse)
            {
                string mouseButton = e.Button.ToString();

                if (mouseButton.Equals(KeyString))
                    clicked = false;
            }
        }

        public static void GlobalHook_KeyDown(object sender, KeyEventArgs e)
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
                    clicked = true;
            }
        }

        public static void GlobalHook_KeyUp(object sender, KeyEventArgs e)
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
                    clicked = false;
            }
        }

    }
}
