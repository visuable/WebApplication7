using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;
using WebApplication7.Services.Implements;

namespace WebApplication7.Services
{
    public interface IWeatherService
    {
        Task<Weather> GetCurrentWeatherInfo(string name);
    }
}
