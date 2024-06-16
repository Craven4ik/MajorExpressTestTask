using MajorExpressTestTask.Domain.Enums;
using MajorExpressTestTask.Domain.Interfaces.Repositories;
using MajorExpressTestTask.Domain.Interfaces.Services;
using MajorExpressTestTask.Domain.Models;
using MajorExpressTestTask.UI.Contracts;

namespace MajorExpressTestTask.Application.Services;

public class RequestService(IRequestRepository repository, IDeliveryRepository deliveryRepository) : IRequestService
{
    private readonly IRequestRepository _repository = repository;
    private readonly IDeliveryRepository _deliveryRepository = deliveryRepository;

    public async Task<Request?> GetRequestByIdAsync(Guid id)
    {
        return await _repository.GetRequestByIdAsync(id);
    }

    public async Task<List<Request>> GetRequestsAsync()
    {
        return await _repository.GetRequestsAsync();
    }

    public async Task<List<Request>> FindRequestsAsync(string searchText)
    {
        return await _repository.FindRequestsAsync(searchText.ToLower());
    }

    public async Task CreateRequestAsync(RequestInfo request)
    {
        var newRequest = new Request()
        {
            Name = request.Name,
            Description = request.Description,
            DeliveryAddress = request.DeliveryAddress,
            Status = Domain.Enums.Status.New,
            CreatedDate = DateTime.Now.ToUniversalTime()
        };

        await _repository.CreateRequestAsync(newRequest);
    }

    public async Task UpdateRequestAsync(Guid id, RequestInfo request)
    {
        var newRequest = new Request()
        {
            Name = request.Name,
            Description = request.Description,
            DeliveryAddress = request.DeliveryAddress,
        };

        await _repository.UpdateRequestAsync(id, newRequest);
    }

    public async Task AssignCourierAsync(Guid id, Guid courierId)
    {
        var request = await _repository.GetRequestByIdAsync(id);

        if (request == null)
        {
            throw new Exception("Request not found");
        }

        request.Status = Status.InProgress;

        var delivery = new Delivery
        {
            RequestId = request.Id,
            CourierId = courierId
        };

        await _deliveryRepository.AddDeliveryAsync(delivery);
        await _repository.UpdateRequestAsync(id, request);
    }

    public async Task ExecuteRequestAsync(Guid id)
    {
        var request = await _repository.GetRequestByIdAsync(id);

        if (request == null)
        {
            throw new Exception("Request not found");
        }

        request.Status = Status.Completed;

        await _repository.UpdateRequestAsync(id, request);
    }

    public async Task CancelRequestAsync(Guid id, string cancellingReason)
    {
        var request = await _repository.GetRequestByIdAsync(id);

        if (request == null)
        {
            throw new Exception("Request not found");
        }

        request.Status = Status.Cancelled;
        request.CancellingReason = cancellingReason;

        await _repository.UpdateRequestAsync(id, request);
    }

    public async Task DeleteRequestAsync(Guid id)
    {
        await _repository.DeleteRequestAsync(id);
    }
}
