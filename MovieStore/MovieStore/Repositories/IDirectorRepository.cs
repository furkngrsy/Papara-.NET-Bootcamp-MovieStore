using MovieStore.Entities;

namespace MovieStore.Repositories
{
    public interface IDirectorRepository
    {
        void Add(Director director);
        void Update(Director director);
        void Delete(int id);
        Director GetById(int id);
        List<Director> GetAll();
    }

}
