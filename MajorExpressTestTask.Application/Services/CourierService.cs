using MajorExpressTestTask.Domain.Interfaces.Repositories;
using MajorExpressTestTask.Domain.Interfaces.Services;
using MajorExpressTestTask.Domain.Models;

namespace MajorExpressTestTask.Application.Services;

public class CourierService(ICourierRepository repository) : ICourierService
{
    private readonly ICourierRepository _repository = repository;

    public async Task<List<Courier>> GetCouriersAsync()
    {
        return await _repository.GetCouriersAsync();
    }
}
