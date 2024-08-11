using MovieStore.Entities;

namespace MovieStore.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Add(Customer customer) { }
        public void Update(Customer customer) { }
        public void Delete(int id) { }
        public Customer GetById(int id) { return null; }
        public List<Customer> GetAll() { return null; }
    }

}
