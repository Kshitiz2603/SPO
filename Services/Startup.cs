using System;
using Shared;
using Interfaces;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using BL;
using Repositories;
using Microsoft.AspNetCore.CookiePolicy;

namespace SPO.Services
{
    public class Startup
    {
        private IConfiguration Configuration { get; }

        private bool enableSwagger {get;}

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            enableSwagger = Configuration.GetValue<bool>("EnableSwagger");
        }

        private void ConfigureDI(IServiceCollection services)
        {
            // Configure your dependency injection here
             services.AddScoped<IDbManager, DbManager>();
             services.AddScoped<ITestBusinessLogic, TestBusinessLogic>();
             services.AddScoped<ITestRepository, TestRepository>();

        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.HttpOnly = HttpOnlyPolicy.Always;
                options.Secure = CookieSecurePolicy.Always;
            });

            services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
                options.KnownNetworks.Clear();
                options.KnownProxies.Clear();
            });

            services.AddHttpContextAccessor();
            services.AddHttpClient();

           // services.ConfigureServicesForAPI(Configuration, enableSwagger);

            // Add your service configurations here
            ConfigureDI(services);
            services.AddSignalR();
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseForwardedHeaders();

        }
    }
}