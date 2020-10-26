using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Options
{
    interface IOption
    {
        string ApiUrl { get; set; }
        string ApiKey { get; set; }
    }
}
