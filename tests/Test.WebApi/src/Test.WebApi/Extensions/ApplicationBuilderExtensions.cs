namespace Microsoft.AspNetCore.Builder
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseSwaggerServices(this IApplicationBuilder builder)
        {
            builder.UseSwagger();
            builder.UseSwaggerUI(cfg =>
            {
                cfg.SwaggerEndpoint("/swagger/v1/swagger.json", "DevQuiz Admin API");
                cfg.RoutePrefix = string.Empty;
            });

            return builder;
        }
    }
}