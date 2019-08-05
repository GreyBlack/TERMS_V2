using System;
using Microsoft.Extensions.Configuration;

namespace TERMS_V2.Infrastructure
{
    public class ConfigHelper
    {
        public static IConfiguration Configs;
        public static string GetValue(string key)
        {
            return Configs.GetSection(key).Value;
        }
    }
}