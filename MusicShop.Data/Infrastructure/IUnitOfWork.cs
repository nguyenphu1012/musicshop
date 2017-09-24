namespace MusicShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}