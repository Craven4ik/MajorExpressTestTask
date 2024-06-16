using MajorExpressTestTask.Domain.Enums;
using MajorExpressTestTask.Domain.Interfaces.Repositories;
using MajorExpressTestTask.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MajorExpressTestTask.Infrastructure.Persistence.Repositories;

public class RequestRepository(ApplicationDbContext context) : IRequestRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Request?> GetRequestByIdAsync(Guid id)
    {
        return await _context.Requests.AsNoTracking().FirstOrDefaultAsync(x => x.Id.Equals(id));
    }
    
    public async Task<List<Request>> GetRequestsAsync()
    {
        return await _context.Requests.AsNoTracking()
            .Include(x => x.Delivery)
            .ThenInclude(x => x.Courier)
            .ToListAsync();
    }

    public async Task<List<Request>> FindRequestsAsync(string searchText)
    {
        return await _context.Requests
            .AsNoTracking()
            .Include(r => r.Delivery)
            .ThenInclude(d => d.Courier)
            .Where(x => x.Name.ToLower().Contains(searchText)
                || x.Description.ToLower().Contains(searchText)
                || x.DeliveryAddress.ToLower().Contains(searchText)
                || (x.CancellingReason != null && x.CancellingReason.ToLower().Contains(searchText))
                || (x.Delivery != null && x.Delivery.Courier != null && x.Delivery.Courier.Name.ToLower().Contains(searchText)))
            .ToListAsync();
    }

    public async Task CreateRequestAsync(Request request)
    {
        await _context.Requests.AddAsync(request);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateRequestAsync(Guid id, Request request)
    {
        await _context.Requests
            .Where(x => x.Id.Equals(id))
            .ExecuteUpdateAsync(s => s
                .SetProperty(c => c.Name, request.Name)
                .SetProperty(c => c.Description, request.Description)
                .SetProperty(c => c.Status, request.Status)
                .SetProperty(c => c.DeliveryAddress, request.DeliveryAddress)
                .SetProperty(c => c.CancellingReason, request.CancellingReason));
    }

    public async Task DeleteRequestAsync(Guid id)
    {
        await _context.Requests
            .Where(x => x.Id.Equals(id))
            .ExecuteDeleteAsync();
    }
}
