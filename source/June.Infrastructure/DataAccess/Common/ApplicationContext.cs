using System.Reflection;
using June.Domain.Sprockets;
using Microsoft.EntityFrameworkCore;

namespace June.Infrastructure.DataAccess.Common
{
    /// <inheritdoc />
    public sealed class ApplicationContext : DbContext
    {
        /// <inheritdoc />
        public ApplicationContext(DbContextOptions options)
            : base(options)
        {
            Database.EnsureCreated();

            Sprockets = Set<Sprocket>();
        }

        /// <summary>
        /// Gets the sprocket set.
        /// </summary>
        public DbSet<Sprocket> Sprockets { get; }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
