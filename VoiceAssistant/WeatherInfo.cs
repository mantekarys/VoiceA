using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace VoiceAssistant
{
    public class WeatherInfo
    {
        private readonly string Key = "9ea1ace10b453aed115d8803d37dffbd";
        private readonly string Units = "metric"; // standart, metric, imperial
        private readonly string Language = "en";
        private readonly string Mode = "xml"; // json, xml
            
        public string[] GetInfo(string location)
        {
            string url = String.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&mode={4}&units={1}&lang={2}&appid={3}", location, Units, Language, Key, Mode);
            XDocument doc = XDocument.Load(url);

            string temperature = doc.Root.Element("temperature").Attribute("value").Value + "°"; // + doc.Root.Element("temperature").Attribute("unit").Value;
            string humidity = doc.Root.Element("humidity").Attribute("value").Value + doc.Root.Element("humidity").Attribute("unit").Value;
            string pressure = doc.Root.Element("pressure").Attribute("value").Value + " " + doc.Root.Element("pressure").Attribute("unit").Value;
            string wind_speed = doc.Root.Element("wind").Element("speed").Attribute("value").Value + " " + doc.Root.Element("wind").Element("speed").Attribute("unit").Value;
            string wind_direction = doc.Root.Element("wind").Element("direction").Attribute("name").Value + ", " + doc.Root.Element("wind").Element("direction").Attribute("code").Value;
            string clouds = doc.Root.Element("clouds").Attribute("name").Value;

            string Location = doc.Root.Element("city").Attribute("name").Value;
            string Date = doc.Root.Element("lastupdate").Attribute("value").Value.Replace("T", " ");

            url = String.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&mode={4}&units={1}&lang={2}&appid={3}", location, Units, Language, Key, Mode);
            doc = XDocument.Load(url);

            string precipitation = doc.Root.Element("forecast").Elements("time").First().Element("precipitation").Attribute("probability").Value;

            if (doc.Root.Element("forecast").Elements("time").First().Element("precipitation").Attribute("type") != null)
            {
                precipitation += " " + doc.Root.Element("forecast").Elements("time").First().Element("precipitation").Attribute("type").Value;
            }
            else
            {
                if (float.Parse(precipitation) > 0.0f)
                {
                    precipitation += " mm rain";
                }
                else
                {
                    precipitation += " mm";
                }
            }

            return new string[] { temperature, humidity, pressure, wind_speed, wind_direction, clouds, precipitation, Location, Date };
        }


    }
}
