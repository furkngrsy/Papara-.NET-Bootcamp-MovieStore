using MovieStore.Entities;

namespace MovieStore.Repositories
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
        Customer GetById(int id);
        List<Customer> GetAll();
    }

}
