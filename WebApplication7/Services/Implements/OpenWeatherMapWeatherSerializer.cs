using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Newtonsoft.Json;
using WebApplication7.Models;
using WebApplication7.Models.FirstModels;

namespace WebApplication7.Services.Implements
{
    public class OpenWeatherMapWeatherSerializer : IWeatherSerializer
    {
        private IMapper mapper;
        public OpenWeatherMapWeatherSerializer(IMapper mapper)
        {
            this.mapper = mapper;
        }
        public Weather Serialize(string text)
        {
            var root = JsonConvert.DeserializeObject<_OpenWeatherMapWeather>(text);
            var map = mapper.Map<Weather>(root);
            return map;
        }
    }
}
