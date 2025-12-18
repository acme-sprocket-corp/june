using June.Infrastructure.DataAccess.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace June.Infrastructure.Dependencies
{
    /// <summary>
    /// Static registration for the application.
    /// </summary>
    public static class Registration
    {
        /// <summary>
        /// Registers all application dependencies.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void RegisterApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSqlServer<ApplicationContext>(configuration.GetConnectionString("Database"));
        }
    }
}
