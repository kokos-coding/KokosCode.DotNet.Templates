
namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extensions for instance of <see cref="IServiceCoolection"/>
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add repositories for current service
        /// </summary>
        /// <param name="services">Instance of <see cref="IServiceCoolection"/></param>
        /// <returns>Original instance of <see cref="IServiceCoolection"/></returns>
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services;
        }

#if('$(use-orm)' == 'EFCore')
        /// <summary>
        /// Register DbContexts to services
        /// </summary>
        /// <param name="services">Instance of <see cref="IServiceCoolection"/></param>
        /// <returns>Original instance of <see cref="IServiceCoolection"/></returns>
        public static IServiceCollection AddDbContexts(this IServiceCollection services)
        {
            return services;
        }
#endif
    }
}