using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication7.Models;
using WebApplication7.Options;

namespace WebApplication7.Services.Implements
{
    public class OpenWeatherMapWeatherService : IWeatherService
    {
        private IHttpClientFactory _factory;
        private IWeatherSerializer serializer;
        private OpenWeatherMapOptions options;

        public OpenWeatherMapWeatherService(IWeatherSerializer serializer, IHttpClientFactory factory, IOptions<OpenWeatherMapOptions> options)
        {
            this.serializer = serializer;
            this.options = options.Value;
            _factory = factory;
        }
        public async Task<Weather> GetCurrentWeatherInfo(string name)
        {
            var y = _factory.CreateClient("JsonHttpClient");
            // можно заменить Url-билдером из c#
            var x = await y.GetAsync(options.ApiUrl + "?appId=" + options.ApiKey + "&q=" + name);
            return serializer.Serialize(await x.Content.ReadAsStringAsync());
        }
    }
}
