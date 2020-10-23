using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.Services.Implements
{
    public interface IWeatherSerializer
    {
        Weather Serialize(string text);
    }
}
