using MajorExpressTestTask.Domain.Models;

namespace MajorExpressTestTask.Domain.Interfaces.Repositories;

public interface IDeliveryRepository
{
    Task AddDeliveryAsync(Delivery delivery);
}
