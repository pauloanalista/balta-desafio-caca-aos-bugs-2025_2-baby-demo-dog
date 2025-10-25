using BugStore.Domain.Entities.Base;

namespace BugStore.Domain.Entities;

public class Customer : EntityBase
{
    
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime BirthDate { get; set; }
}