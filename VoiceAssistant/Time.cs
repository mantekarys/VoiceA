using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VoiceAssistant
{
    public class Time
    {
        /// <summary>
        /// gets the current time in a specified city, or Vilnius if left empty
        /// </summary>
        /// <param name="city">the city</param>
        /// <returns>the city and country; time HH-MM-SS</returns>
        public static string getTimeInCity(string city)
        {
            if(city == "")
            {
                city = "Vilnius";
            }
            string link = "https://time.is/";
            string fullLink = link + city;
            WebClient client = new WebClient();
            client.Headers.Add("User-Agent: Other");
            client.Headers.Add(HttpRequestHeader.AcceptLanguage, "en");
            string info;
            try
            {
                info = client.DownloadString(fullLink);
            }
            catch (WebException)
            {
                return "error";
            }
            int startIndex = info.IndexOf("<head><title>Time in" ,StringComparison.Ordinal) + 21;
            int endIndex = info.IndexOf(" now - Time.is</title>", StringComparison.Ordinal);
            string foundCity;
            try
            {
                foundCity = info.Substring(startIndex, endIndex - startIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                return "error";
            }
            startIndex = info.IndexOf("<time id=\"clock\">", StringComparison.Ordinal) + 17;
            string foundTime = info.Substring(startIndex, 8);
            string[] foundTimeSplit = foundTime.Split(':');
            string result = foundCity + " " + foundTimeSplit[0] + " hours " + foundTimeSplit[1] + " minutes";

            return result;
        }
    }
}
