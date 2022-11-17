using IWshRuntimeLibrary;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace VoiceAssistant
{
    public class Shortcut
    {
        public static FileManagment fileManagment = new FileManagment();//mock

        public static void Create(string shortcutName, string shortcutPath, string targetPath, FileManagment fileManagment = null)
        {
            CheckDir(shortcutPath);
            if (fileManagment == null) Shortcut.fileManagment.CreateLink(shortcutName, shortcutPath, targetPath);//not test
            else fileManagment.CreateLink(shortcutName, shortcutPath, targetPath);

        }
        public static void CreateURL(string shortcutName, string shortcutPath, string url, FileManagment fileManagment = null)
        {
            CheckDir(shortcutPath);
            if (fileManagment == null) Shortcut.fileManagment.CreateUrl(shortcutName, shortcutPath, url);
            else fileManagment.CreateUrl(shortcutName, shortcutPath, url);
        }

        public static void Remove(string name, string path, FileManagment fileManagment = null)
        {
            CheckDir(path);
            try
            {
                string fullName = Directory.GetFiles(path, name + ".*")[0];
                //System.IO.File.Delete(Path.Combine(path, fullName));
                if (fileManagment == null) Shortcut.fileManagment.Delete(Path.Combine(path, fullName));//not test
                else fileManagment.Delete(Path.Combine(path, fullName));
            }
            catch
            { }
        }

        public static void Open(string name, string path, FileManagment fileManagment = null)
        {
            CheckDir(path);

            if (Directory.GetFiles(path, name + ".*").Length != 0)
            {
                string fullName = Directory.GetFiles(path, name + ".*")[0];
                try
                {
                    if (fileManagment == null) Shortcut.fileManagment.Open(Path.Combine(path, fullName));//not test
                    else fileManagment.Open(Path.Combine(path, fullName));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void CheckDir(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public static bool Contains(string path) 
        {
            string[] files = TaskUtils.GetFileNames(Constants.ShortcutsFolder);
            foreach (string file in files)
            {
                if (file.Equals(path + ".lnk"))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ContainsURL(string path)
        {
            string[] files = TaskUtils.GetFileNames(Constants.ShortcutsFolder);

            foreach (string file in files)
            {
                if (file.Equals(path + ".url"))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
