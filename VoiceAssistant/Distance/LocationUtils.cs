using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceAssistant
{
    public class LocationUtils
    {
        public static double[] GetLatiLongi(string location, string file)
        {
            location = location.ToLower();
            string line = "";
            using (StreamReader reader = new StreamReader(file))
            {
                string loc = "";
                while (!loc.ToLower().Equals(location) && line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                        loc = line.Split(',')[0].Trim('"');
                }
            }

            try
            {
                double lati = Double.Parse(line.Split(',')[2].Trim('"'));
                double longi = Double.Parse(line.Split(',')[3].Trim('"'));

                return new double[] { lati, longi };
            }
            catch
            {
                return new double[] { };
            }
        }

        public static int GetDistance(string location1, string location2)
        {
            double[] coo1 = GetLatiLongi(location1, Constants.DistanceFile);
            double[] coo2 = GetLatiLongi(location2, Constants.DistanceFile);

            if (coo1.Length == 2 && coo2.Length == 2)
            {
                Location point1 = new Location(coo1[0], coo1[1]);
                Location point2 = new Location(coo2[0], coo2[1]);

                var d1 = point1.Latitude * (Math.PI / 180.0);
                var num1 = point1.Longitude * (Math.PI / 180.0);
                var d2 = point2.Latitude * (Math.PI / 180.0);
                var num2 = point2.Longitude * (Math.PI / 180.0) - num1;
                var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) +
                         Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);

                return (int)(6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3))) / 1000);
            }

            if (coo1.Length == 0)
            {
                Console.WriteLine($"Location \"{ location1 }\" not found.");
                return -1;
            }
            if (coo2.Length == 0)
            {
                Console.WriteLine($"Location \"{ location2 }\" not found.");
                return -2;
            }
            
            return -3;
        }
    }
}
