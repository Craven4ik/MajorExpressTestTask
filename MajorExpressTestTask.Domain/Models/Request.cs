using MajorExpressTestTask.Domain.Enums;

namespace MajorExpressTestTask.Domain.Models;

public class Request
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Status Status { get; set; } = Status.New;
    public DateTime CreatedDate { get; set; }
    public string DeliveryAddress { get; set; } = string.Empty;
    public string? CancellingReason { get; set; }
    public virtual Delivery? Delivery { get; set; }
}
