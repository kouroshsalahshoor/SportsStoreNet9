using SportsStore.Models;

namespace SportsStore.Repository.IRepository
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}