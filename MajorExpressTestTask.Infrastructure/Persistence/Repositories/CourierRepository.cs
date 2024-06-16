using MajorExpressTestTask.Domain.Interfaces.Repositories;
using MajorExpressTestTask.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MajorExpressTestTask.Infrastructure.Persistence.Repositories;

public class CourierRepository(ApplicationDbContext context) : ICourierRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task<List<Courier>> GetCouriersAsync()
    {
        return await _context.Couriers.AsNoTracking().ToListAsync();
    }
}
