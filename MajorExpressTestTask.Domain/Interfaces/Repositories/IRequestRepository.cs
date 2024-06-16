using MajorExpressTestTask.Domain.Models;

namespace MajorExpressTestTask.Domain.Interfaces.Repositories;

public interface IRequestRepository
{
    Task<Request?> GetRequestByIdAsync(Guid id);
    Task<List<Request>> GetRequestsAsync();
    Task<List<Request>> FindRequestsAsync(string searchText);
    Task CreateRequestAsync(Request request);
    Task UpdateRequestAsync(Guid id, Request request);
    Task DeleteRequestAsync(Guid id);
}
