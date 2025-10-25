using BugStore.Domain.Domain.Contracts.Repositories;
using BugStore.Domain.Entities;
using BugStore.Infra.Data.Repositories.Base;

namespace BugStore.Infra.Data.Repositories
{
    public class RepositoryCustomer : RepositoryBase<Customer, Guid>, IRepositoryCustomer
    {
        protected readonly AppDbContext _context;

        public RepositoryCustomer(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}