using MovieStore.DTOs;
using MovieStore.Repositories;

namespace MovieStore.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void AddCustomer(CustomerDTO customerDTO) { }
        public void UpdateCustomer(int id, CustomerDTO customerDTO) { }
        public void DeleteCustomer(int id) { }
        public CustomerDTO GetCustomerById(int id) { return null; }
        public List<CustomerDTO> GetAllCustomers() { return null; }
    }

}
