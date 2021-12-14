using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.WebApi
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
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCustomOptions(Configuration)
                .AddCustomServices()
#if(useSwagger)
                .AddCustomSwagger()
#endif
                .AddCustomAutoMapper();

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

#if(useSwagger)
            app.UseSwagger();
            app.UseSwaggerUI(cfg =>
            {
                cfg.SwaggerEndpoint("/swagger/v1/swagger.json", "DevQuiz Admin API");
                cfg.RoutePrefix = string.Empty;
            });
#endif

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }   
    }
}