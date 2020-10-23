using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Weather
    {
        public string Description { get; set; }
        public int WindSpeed { get; set; }
        public double Temperature { get; set; }
        public int Visibility { get; set; }
        public float Clouds { get; set; }
        public float Himidity { get; set; }
    }
}
