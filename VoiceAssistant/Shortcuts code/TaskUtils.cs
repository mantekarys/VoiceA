using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceAssistant
{
    public static class TaskUtils
    {
        //public static void DisplayContents(string path)
        //{
        //    Shortcut.CheckDir(path);

        //    Console.WriteLine("Files in: " + path + ":");
        //    DirectoryInfo dirInfo = new DirectoryInfo(path);
        //    var xshortcuts = from file in dirInfo.GetFileSystemInfos() select file.Name;
        //    foreach (var file in dirInfo.GetFileSystemInfos())
        //    {
        //        Console.WriteLine(file.Name);
        //    }
        //    Console.WriteLine("---");
        //}
        public static String[] GetFileNames(string path)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                return (from file in dirInfo.GetFileSystemInfos() select file.Name).ToArray();
            }
            catch 
            { 
                return null;    
            }
        }
    }
}
