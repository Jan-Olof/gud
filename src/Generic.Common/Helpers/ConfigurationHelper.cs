using Microsoft.Extensions.Configuration;

namespace Generic.Common.Helpers
{
    public static class ConfigurationHelper
    {
        public static IConfigurationRoot GetConfiguration(string settingsFile = "appsettings.json")
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile(settingsFile, false);
            return builder.Build();
        }
    }
}