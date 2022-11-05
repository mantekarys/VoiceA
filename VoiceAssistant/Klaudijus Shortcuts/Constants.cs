using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;

namespace ShortCuts
{
    static class Constants
    {
        public static readonly string ShortcutsFolder = 
            Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Name == "VoiceAssistantTests" ? 
            Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "VoiceAssistant\\Shortcuts") : 
            Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Shortcuts");//Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Shortcuts");
        public static readonly string SystemFolder = Environment.SystemDirectory;
    }
}
