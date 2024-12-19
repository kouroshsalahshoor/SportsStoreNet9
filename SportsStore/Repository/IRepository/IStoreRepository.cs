using SportsStore.Models;

namespace SportsStore.Repository.IRepository
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
