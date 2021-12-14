using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet.WebApi.Domain.Services;
using DotNet.WebApi.ApplicationServices.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}