using MajorExpressTestTask.Domain.Models;

namespace MajorExpressTestTask.Domain.Interfaces.Services;

public interface ICourierService
{
    Task<List<Courier>> GetCouriersAsync();
}
