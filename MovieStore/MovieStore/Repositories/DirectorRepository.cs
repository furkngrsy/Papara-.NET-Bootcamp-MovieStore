using MovieStore.Entities;

namespace MovieStore.Repositories
{
    public class DirectorRepository : IDirectorRepository
    {
        public void Add(Director director) { }
        public void Update(Director director) { }
        public void Delete(int id) { }
        public Director GetById(int id) { return null; }
        public List<Director> GetAll() { return null; }
    }

}
