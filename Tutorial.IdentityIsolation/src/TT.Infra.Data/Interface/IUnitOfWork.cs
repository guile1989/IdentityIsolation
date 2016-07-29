namespace TT.Infra.Data.Interface
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
    }
}
