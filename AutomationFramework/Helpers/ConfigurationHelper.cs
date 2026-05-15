using Microsoft.Extensions.Configuration;
using RazorEngine.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.Helpers
{
    public static class ConfigurationHelper
    {
        private static IConfigurationRoot configuration;

        static ConfigurationHelper()
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        public static string GetBaseUrl()
        {
            return configuration["ApiSettings:BaseUrl"];
        }

        public static int GetTimeout()
        {
            return int.Parse(configuration["ApiSettings:Timeout"]);
        }
    }

}
