using MovieStore.Entities;

namespace MovieStore.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void Add(Order order) { }
        public void Update(Order order) { }
        public void Delete(int id) { }
        public Order GetById(int id) { return null; }
        public List<Order> GetAll() { return null; }
    }

}
