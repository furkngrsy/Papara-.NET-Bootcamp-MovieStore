using Microsoft.AspNetCore.Mvc;
using MovieStore.DTOs;
using MovieStore.Services;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public IActionResult AddOrder([FromBody] OrderDTO orderDTO)
        {
            _orderService.AddOrder(orderDTO);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateOrder(int id, [FromBody] OrderDTO orderDTO)
        {
            _orderService.UpdateOrder(id, orderDTO);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            _orderService.DeleteOrder(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            var order = _orderService.GetOrderById(id);
            return Ok(order);
        }

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var orders = _orderService.GetAllOrders();
            return Ok(orders);
        }
    }

}
