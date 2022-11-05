using IWshRuntimeLibrary;
using System.Diagnostics;
using System.IO;

namespace ShortCuts
{
    static class Shortcut
    {
        /// <summary>
        /// Creates shortcut to a file or folder.
        /// </summary>
        /// <param name="shortcutName"> Name of the shortcut </param>
        /// <param name="shortcutPath"> Path to shortcuts folder </param>
        /// <param name="targetPath"> Path to a file of folder to make shortcut to </param>
        public static void Create(string shortcutName, string shortcutPath, string targetPath)
        {
            CheckDir(shortcutPath);

            var shortcutLocation = Path.Combine(shortcutPath, shortcutName + ".lnk");
            var shell = new WshShell();
            var shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.TargetPath = targetPath;
            shortcut.Save();
        }

        /// <summary>
        /// Creates shortcut to a web page.
        /// </summary>
        /// <param name="shortcutName"> Name of the shortcut </param>
        /// <param name="shortcutPath"> Path to shortcuts folder </param>
        /// <param name="url"> URL of a web page </param>
        public static void CreateURL(string shortcutName, string shortcutPath, string url)
        {
            CheckDir(shortcutPath);

            using (StreamWriter writer = new StreamWriter(Path.Combine(shortcutPath, shortcutName + ".url"))) 
            {
                writer.WriteLine("[InternetShortcut]");
                writer.WriteLine("URL=" + url);
            }
        }

        public static void Remove(string name, string path)
        {
            CheckDir(path);

            string fullName = Directory.GetFiles(path, name + ".*")[0];
            System.IO.File.Delete(Path.Combine(path, fullName));
        }

        public static void Open(string name, string path)
        {
            CheckDir(path);

            string fullName = Directory.GetFiles(path, name + ".*")[0];
            Process.Start(Path.Combine(path, fullName));
        }

        public static void CheckDir(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

    }
}
