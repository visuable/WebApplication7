using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WebApplication7.Options;
using WebApplication7.Profiles;
using WebApplication7.Services;
using WebApplication7.Services.Implements;

namespace WebApplication7
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddOptions();
            // Изменил OpenWeatherMapWeatherSerializer на AutoMapper.
            services.AddAutoMapper(typeof(OpenWeatherMapToWeatherProfile));

            // OpenWeatherMapWeather ----
            services.AddTransient<IWeatherService, OpenWeatherMapWeatherService>();
            services.AddTransient<IWeatherSerializer, OpenWeatherMapWeatherSerializer>();
            services.AddTransient<IOption, OpenWeatherMapOptions>();
            // В appsettings.json вынесен api-key и api-url
            services.Configure<OpenWeatherMapOptions>(Configuration.GetSection(nameof(OpenWeatherMapOptions)));
            // ---- OpenWeatherMapWeather

            services.AddHttpClient("JsonHttpClient");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
