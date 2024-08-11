using MovieStore.Entities;

namespace MovieStore.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public void Add(Movie movie) { }
        public void Update(Movie movie) { }
        public void Delete(int id) { }
        public Movie GetById(int id) { return null; }
        public List<Movie> GetAll() { return null; }
    }

}
