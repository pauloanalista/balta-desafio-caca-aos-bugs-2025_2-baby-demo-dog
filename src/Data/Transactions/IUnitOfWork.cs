namespace BugStore.Data.Transactions
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}
