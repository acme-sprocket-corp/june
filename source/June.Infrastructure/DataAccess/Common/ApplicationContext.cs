using Microsoft.EntityFrameworkCore;

namespace June.Infrastructure.DataAccess.Common
{
    /// <inheritdoc />
    public sealed class ApplicationContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public ApplicationContext(DbContextOptions options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
