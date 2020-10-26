using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Options
{
    public class OpenWeatherMapOptions : IOption
    {
        public string ApiUrl { get; set; }
        public string ApiKey { get; set; }
    }
}
