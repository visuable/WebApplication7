using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;
using WebApplication7.Models.FirstModels;

namespace WebApplication7.Profiles
{
    public class OpenWeatherMapToWeatherProfile : Profile
    {
        public OpenWeatherMapToWeatherProfile()
        {
            CreateMap<_OpenWeatherMapWeather, Weather>()
                .ForMember(d => d.Clouds, opt => opt.MapFrom(s => s.clouds.all))
                .ForMember(d => d.Description, opt => opt.MapFrom(s => s.weather[0].description))
                .ForMember(d => d.Himidity, opt => opt.MapFrom(s => s.main.humidity))
                .ForMember(d => d.Temperature, opt => opt.MapFrom(s => s.main.temp))
                .ForMember(d => d.Visibility, opt => opt.MapFrom(s => s.visibility))
                .ForMember(d => d.WindSpeed, opt => opt.MapFrom(s => s.wind.speed));
        }
    }
}
