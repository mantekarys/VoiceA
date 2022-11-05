using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VoiceAssistant
{
    public class FileManagment
    {
        public virtual void Delete(string path)
        {
            System.IO.File.Delete(path);
        }
        public string[] GetFiles(string path)
        {
            return Directory.GetFiles(path);
        }
        public virtual void Open(string path)
        {
            Process.Start(path);
        }
        public virtual void CreateUrl(string shortcutName, string shortcutPath, string url)
        {
            using (StreamWriter writer = new StreamWriter(Path.Combine(shortcutPath, shortcutName + ".url")))
            {
                writer.WriteLine("[InternetShortcut]");
                writer.WriteLine("URL=" + url);
            }
        }
        public virtual void CreateLink(string shortcutName, string shortcutPath, string targetPath)
        {
            var shortcutLocation = Path.Combine(shortcutPath, shortcutName + ".lnk");
            var shell = new WshShell();
            var shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.TargetPath = targetPath;
            shortcut.Save();
        }
    }
}
