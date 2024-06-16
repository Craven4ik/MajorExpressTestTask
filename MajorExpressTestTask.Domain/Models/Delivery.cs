namespace MajorExpressTestTask.Domain.Models;

public class Delivery
{
    public Guid Id { get; set; }
    public Guid RequestId { get; set; }
    public virtual Request? Request { get; set; }
    public Guid CourierId { get; set; }
    public virtual Courier? Courier { get; set; }
}
