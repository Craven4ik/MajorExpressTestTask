using MajorExpressTestTask.Domain.Models;
using MajorExpressTestTask.UI.Contracts;

namespace MajorExpressTestTask.Domain.Interfaces.Services;

public interface IRequestService
{
    Task<Request?> GetRequestByIdAsync(Guid id);
    Task<List<Request>> GetRequestsAsync();
    Task<List<Request>> FindRequestsAsync(string searchText);
    Task CreateRequestAsync(RequestInfo request);
    Task UpdateRequestAsync(Guid id, RequestInfo request);
    Task AssignCourierAsync(Guid requestId, Guid courierId);
    Task ExecuteRequestAsync(Guid id);
    Task CancelRequestAsync(Guid id, string cancellingReason);
    Task DeleteRequestAsync(Guid id);
}
