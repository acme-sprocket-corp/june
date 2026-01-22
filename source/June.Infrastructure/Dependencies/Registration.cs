using June.Application.Sprockets;
using June.Infrastructure.DataAccess.Common;
using June.Infrastructure.DataAccess.Sprockets;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using Serilog;

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
            // Data Access
            services.AddSqlServer<ApplicationContext>(configuration.GetConnectionString("Database"));

            BsonSerializer.TryRegisterSerializer(new GuidSerializer(GuidRepresentation.Standard));
            services.AddScoped(_ => new MongoClient(configuration.GetConnectionString("Mongo")));

            services.AddTransient<ISprocketRepository, SprocketRepository>();

            // Logging
            services.AddSerilog((serviceProvider, lc) => lc
                .ReadFrom.Services(serviceProvider)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.Debug());
        }
    }
}
