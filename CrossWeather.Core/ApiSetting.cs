using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrossWeather.Core
{
    public class ApiSettings
    {
        public static string GetUrl(string city)
        {
            string apiKey = "063acd0698cb37392b0b6426788638b4";
            return $"http://api.openweathermap.org/data/2.5/weather?q=Detroit&appid=063acd0698cb37392b0b6426788638b4"
        }

            
    }
}
