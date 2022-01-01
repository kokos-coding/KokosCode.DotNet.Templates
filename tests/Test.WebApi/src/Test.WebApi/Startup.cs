using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Test.WebApi
{
    /// <summary>
    /// Startup class. Service entrypoint
    /// </summary>
    public class Startup
    {
        private IConfiguration Configuration { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration">Instance of <see cref="IConfiguration" /></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        ///     Method for configure services of application
        /// </summary>
        /// <param name="services">Instance of <see cref="IServiceCollection" /></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCustomOptions(Configuration)
                .AddApplicationServices()
                .AddSwaggerServices()
                .AddMappers();

            services.AddControllers();
        }

        /// <summary>
        ///     Method for configure middlewares pipeline of application
        /// </summary>
        /// <param name="app">Instance of <see cref="IApplicationBuilder" /></param>
        /// <param name="env">Instance of <see cref="IWebHostEnvironment" /></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwaggerServices();

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }   
    }
}