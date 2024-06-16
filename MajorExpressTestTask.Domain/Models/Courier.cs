namespace MajorExpressTestTask.Domain.Models;

public class Courier
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public virtual ICollection<Delivery>? Deliveries { get; set; }
}
