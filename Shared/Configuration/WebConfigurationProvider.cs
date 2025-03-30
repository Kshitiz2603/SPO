using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Shared{
    public static class WebConfigurationProvider
    {
        public static void Initialize(HostBuilderContext context, IConfigurationBuilder builder)
        {
            // Add your custom configuration sources here
            builder.AddJsonFile("config.json", optional: true, reloadOnChange: true);
            builder.AddEnvironmentVariables();
        }
    }

}