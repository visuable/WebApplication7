using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;
using WebApplication7.Services;

namespace WebApplication7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class BridgeController : ControllerBase
    {
        private IWeatherService _service;
       public BridgeController(IWeatherService service)
        {
            _service = service;
        }
        [Route(nameof(GetWeather))]
        [HttpGet]
        public async Task<Weather> GetWeather(string name)
        {
            return await _service.GetCurrentWeatherInfo(name);
        }
    }
}
