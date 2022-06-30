using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppStandards
{
    public class AuthKeys
    {
        public static readonly Dictionary<string,string> Keys = new Dictionary<string, string> { { "DA5A510D-CD02-4686-A7BC-E32D200747E3", "App1" } };

        public static readonly Dictionary<string, string> ApiPermissions = new Dictionary<string, string> { { "App1", "/WeatherForecast123" } };


    }
}
