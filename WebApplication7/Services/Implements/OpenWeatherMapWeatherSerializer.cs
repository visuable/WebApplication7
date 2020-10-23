using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using WebApplication7.Models;
using WebApplication7.Models.FirstModels;

namespace WebApplication7.Services.Implements
{
    public class OpenWeatherMapWeatherSerializer : IWeatherSerializer
    {
        public Weather Serialize(string text)
        {
            var root = JsonConvert.DeserializeObject<OpenWeatherMapWeather>(text);
            Weather weather = new Weather();
            weather.Clouds = root.clouds.all;
            weather.Description = root.weather.First().description;
            weather.Himidity = root.main.humidity;
            weather.Temperature = root.main.temp;
            weather.Visibility = root.visibility;
            weather.WindSpeed = root.wind.speed;
            return weather;
        }
    }
}
