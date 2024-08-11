using MovieStore.DTOs;
using MovieStore.Repositories;

namespace MovieStore.Services
{
    public class MovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void AddMovie(MovieDTO movieDTO) { }
        public void UpdateMovie(int id, MovieDTO movieDTO) { }
        public void DeleteMovie(int id) { }
        public MovieDTO GetMovieById(int id) { return null; }
        public List<MovieDTO> GetAllMovies() { return null; }
    }

}
