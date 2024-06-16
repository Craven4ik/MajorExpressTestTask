using MajorExpressTestTask.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MajorExpressTestTask.Infrastructure.Persistence.Configurations;

public class DeliveryConfiguration : IEntityTypeConfiguration<Delivery>
{
    public void Configure(EntityTypeBuilder<Delivery> builder)
    {
        builder.HasKey(d => d.Id);

        builder
            .HasOne(d => d.Courier)
            .WithMany(c => c.Deliveries)
            .HasForeignKey(d => d.CourierId);

        builder
            .HasOne(d => d.Request)
            .WithOne(r => r.Delivery)
            .HasForeignKey<Delivery>(d => d.RequestId);
    }
}
