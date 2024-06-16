using MajorExpressTestTask.Domain.Models;
using MajorExpressTestTask.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace MajorExpressTestTask.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public DbSet<Request> Requests { get; set; }
    public DbSet<Courier> Couriers { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new RequestConfiguration());
        modelBuilder.ApplyConfiguration(new CourierConfiguration());
        modelBuilder.ApplyConfiguration(new DeliveryConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
