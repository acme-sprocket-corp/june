using June.Domain.Sprockets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace June.Infrastructure.DataAccess.Sprockets
{
    /// <inheritdoc />
    public class SprocketModelBuilder : IEntityTypeConfiguration<Sprocket>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Sprocket> builder)
        {
            builder.Property(x => x.Id)
                .ValueGeneratedNever();
        }
    }
}
