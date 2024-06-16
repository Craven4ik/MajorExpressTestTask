using MajorExpressTestTask.Domain.Interfaces.Repositories;
using MajorExpressTestTask.Domain.Models;

namespace MajorExpressTestTask.Infrastructure.Persistence.Repositories;

public class DeliveryRepository(ApplicationDbContext context) : IDeliveryRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task AddDeliveryAsync(Delivery delivery)
    {
        await _context.Deliveries.AddAsync(delivery);
        await _context.SaveChangesAsync();
    }
}
