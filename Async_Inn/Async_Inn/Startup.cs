using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Async_Inn.Data;
using Async_Inn.Interfaces;
using Async_Inn.Models.Services;

namespace Async_Inn
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        
        public IHostingEnvironment Environment { get; }

        public Startup(IHostingEnvironment environment)
        {
            Environment = environment;
            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            string connectionString = Environment.IsDevelopment()
                                                 ? Configuration["ConnectionStrings:DefaultConnection"]
                                                 : Configuration["ConnectionStrings:ProductionConnection"];

            services.AddDbContext<AsyncInnDbContext>(options =>
            options.UseSqlServer(connectionString));

            services.AddScoped<IAmenitiesManager, AmenitiesService>();
            services.AddScoped<IHotelsManager, HotelsService>();
            services.AddScoped<IRoomsManager, RoomsService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(route =>
            {
                route.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
