using BugStore.Domain.Entities.Base;

namespace BugStore.Domain.Entities;

public class Product : EntityBase
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Slug { get; set; }
    public decimal Price { get; set; }
}