using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.Services.Implements
{
    public class OpenWeatherMapWeatherService : IWeatherService
    {
        private IHttpClientFactory _factory;
        public OpenWeatherMapWeatherService(IHttpClientFactory factory)
        {
            _factory = factory;
        }
        public async Task<Weather> GetCurrentWeatherInfo(string name)
        {
            var y = _factory.CreateClient("JsonHttpClient");
            var x = await y.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={name}&appid=a3977c6f3b246e3e3828147d541116a5");
            return new OpenWeatherMapWeatherSerializer().Serialize(await x.Content.ReadAsStringAsync());
        }
    }
}
