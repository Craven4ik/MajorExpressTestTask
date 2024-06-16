using MajorExpressTestTask.Domain.Models;

namespace MajorExpressTestTask.Domain.Interfaces.Repositories;

public interface ICourierRepository
{
    Task<List<Courier>> GetCouriersAsync();
}
