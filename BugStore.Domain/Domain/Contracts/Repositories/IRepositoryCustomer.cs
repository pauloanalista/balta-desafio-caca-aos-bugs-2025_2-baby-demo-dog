using BugStore.Domain.Domain.Contracts.Repositories.Base;
using BugStore.Domain.Entities;

namespace BugStore.Domain.Domain.Contracts.Repositories
{
    public interface IRepositoryCustomer : IRepositoryBase<Customer, Guid>
    {
    }
}
