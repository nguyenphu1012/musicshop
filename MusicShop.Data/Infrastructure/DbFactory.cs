namespace MusicShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private MusicShopDbContext dbContext;

        public MusicShopDbContext Init()
        {
            return dbContext ?? (dbContext = new MusicShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}