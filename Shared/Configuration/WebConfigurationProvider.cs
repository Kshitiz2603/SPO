using System;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Shared{
    public static class WebConfigurationProvider
    {
        public static void Initialize(HostBuilderContext context, IConfigurationBuilder builder)
        {
            InitializeConfig(builder);
        }

        public static void InitializeConfig(IConfigurationBuilder builder)
        {

            builder.SetBasePath(AppContext.BaseDirectory);
            builder.AddJsonFile("config.json", optional: true, reloadOnChange: true);

            var configuration = builder.Build();

        }
    }

}