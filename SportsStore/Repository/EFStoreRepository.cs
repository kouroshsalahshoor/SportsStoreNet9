using SportsStore.Data;
using SportsStore.Models;
using SportsStore.Repository.IRepository;

namespace SportsStore.Repository
{
    public class EFStoreRepository : IStoreRepository
    {
        private ApplicationDbContext context;
        public EFStoreRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }

}
