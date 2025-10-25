using BugStore.Domain.Entities.Base;

namespace BugStore.Domain.Entities;

public class Order : EntityBase
{
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public List<OrderLine> Lines { get; set; } = null;
}