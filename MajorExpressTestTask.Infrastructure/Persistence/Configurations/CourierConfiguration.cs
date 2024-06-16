using MajorExpressTestTask.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MajorExpressTestTask.Infrastructure.Persistence.Configurations;

public class CourierConfiguration : IEntityTypeConfiguration<Courier>
{
    public void Configure(EntityTypeBuilder<Courier> builder)
    {
        builder.HasKey(c => c.Id);

        builder
            .HasMany(c => c.Deliveries)
            .WithOne(d => d.Courier)
            .HasForeignKey(d => d.CourierId);
    }
}
