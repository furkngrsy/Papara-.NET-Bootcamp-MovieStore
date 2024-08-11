using MovieStore.Entities;

namespace MovieStore.Repositories
{
    public interface IMovieRepository
    {
        void Add(Movie movie);
        void Update(Movie movie);
        void Delete(int id);
        Movie GetById(int id);
        List<Movie> GetAll();
    }

}
