namespace BugStore.Infra.Data.Transactions
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}
