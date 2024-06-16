using MajorExpressTestTask.Application.Services;
using MajorExpressTestTask.Domain.Interfaces.Repositories;
using MajorExpressTestTask.Domain.Interfaces.Services;
using MajorExpressTestTask.Infrastructure.Persistence;
using MajorExpressTestTask.Infrastructure.Persistence.Repositories;
using MajorExpressTestTask.UI.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace MajorExpressTestTask.UI;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        string? connectionString = ConfigurationManager.AppSettings["ConnectionString"];

        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(connectionString));

        services
            .AddScoped<IRequestRepository, RequestRepository>()
            .AddScoped<ICourierRepository, CourierRepository>()
            .AddScoped<IDeliveryRepository, DeliveryRepository>()
            .AddScoped<IRequestService, RequestService>()
            .AddScoped<ICourierService, CourierService>()
            .AddTransient<MainForm>();
    }
}
