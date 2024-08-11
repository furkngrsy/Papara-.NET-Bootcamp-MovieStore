using MovieStore.DTOs;
using MovieStore.Repositories;

namespace MovieStore.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void AddOrder(OrderDTO orderDTO) { }
        public void UpdateOrder(int id, OrderDTO orderDTO) { }
        public void DeleteOrder(int id) { }
        public OrderDTO GetOrderById(int id) { return null; }
        public List<OrderDTO> GetAllOrders() { return null; }
    }

}
