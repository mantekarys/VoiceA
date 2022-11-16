using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using OpenQA.Selenium.DevTools.V105.Network;

namespace VoiceAssistant
{
    public class Alarm
    {
        public static FileManagment fileManagment = new FileManagment();
        public int Hour { get; set; }
        public int Minute { get; set; }
        public bool[] Days { get; set; }
        public bool Enabled;
        public Alarm(int hour, int minute, string days, bool enabled)
        {
            Hour = hour;
            Minute = minute;
            Days = new bool[7];
            for (int i = 0; i < 7; i++)
            {
                if (days != null && days.Contains(i.ToString()))
                    Days[i] = true;
                else
                    Days[i] = false;
            }
            Enabled = enabled;
        }
        public static Alarm ReadLine(string line)
        {
            if (line == null) return null;
            string[] values = line.Split(':');
            try
            {
                Alarm alarm = new Alarm(int.Parse(values[0]), int.Parse(values[1]), values[2], bool.Parse(values[3]));
                return alarm;
            }
            catch
            {
                return null;
            }
        }
        public static List<Alarm> ReadFile(string fileName, FileManagment fileManagment = null)
        {
            List<Alarm> alarms = new List<Alarm>();
            string[] lines;
            if (fileManagment == null)
            {
                lines = Alarm.fileManagment.ReadAllLines(fileName);
            }
            else
            {
                lines = fileManagment.ReadAllLines(fileName);
            }
            foreach (string line in lines)
            {
                Alarm alarm = ReadLine(line);
                alarms.Add(alarm);
            }
            return alarms;
        }
        public static void UpdateFile(string fileName, List<Alarm> alarms, FileManagment fileManagment = null)
        {
            string[] lines = new string[alarms.Count];
            for (int i = 0; i < alarms.Count; i++)
            {
                lines[i] = alarms[i].Hour.ToString() + ":" + alarms[i].Minute.ToString() + ":" + alarms[i].getDayString() + ":" + alarms[i].Enabled.ToString();
            }

            if (fileManagment == null)
            {
                Alarm.fileManagment.WriteAllLines(fileName, lines);
            }
            else
            {
                fileManagment.WriteAllLines(fileName, lines);
            }
        }
        public string getDayString()
        {
            string dayString = "";
            for (int i = 0; i < 7; i++)
            {
                if (Days[i])
                {
                    dayString = String.Concat(dayString, i.ToString());
                }
            }
            return dayString;
        }
    }
}
