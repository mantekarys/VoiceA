using System;
using System.Collections.Generic;
using System.IO;

namespace VoiceAssistant
{
    static class Constants
    {
        public static readonly string ShortcutsFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Name == "VoiceAssistantTests" ?
            Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "VoiceAssistant\\Shortcuts") :
            Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Shortcuts");//Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Shortcuts");

        public static readonly string SystemFolder = Environment.SystemDirectory;

        public static readonly string DistanceFile = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Distance", "worldcities.csv");
        public static readonly string LocationFile = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Distance", "locationList.txt");
        
    }
}
