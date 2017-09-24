using System;

namespace MusicShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        MusicShopDbContext Init();
    }
}