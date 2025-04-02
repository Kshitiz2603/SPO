using System;
using Shared;
using Interfaces;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace SPO.Services
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Add your service configurations here
            ConfigureDI(services);
        }

        private void ConfigureDI(IServiceCollection services)
        {
            // Configure your dependency injection here
             services.AddScoped<IDbManager, DbManager>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}