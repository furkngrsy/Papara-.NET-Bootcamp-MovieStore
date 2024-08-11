using MovieStore.Entities;

namespace MovieStore.Repositories
{
    public interface IOrderRepository
    {
        void Add(Order order);
        void Update(Order order);
        void Delete(int id);
        Order GetById(int id);
        List<Order> GetAll();
    }

}
