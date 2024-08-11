using Microsoft.AspNetCore.Mvc;
using MovieStore.DTOs;
using MovieStore.Services;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly MovieService _movieService;

        public MoviesController(MovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpPost]
        public IActionResult AddMovie([FromBody] MovieDTO movieDTO)
        {
            _movieService.AddMovie(movieDTO);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, [FromBody] MovieDTO movieDTO)
        {
            _movieService.UpdateMovie(id, movieDTO);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            _movieService.DeleteMovie(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            var movie = _movieService.GetMovieById(id);
            return Ok(movie);
        }

        [HttpGet]
        public IActionResult GetAllMovies()
        {
            var movies = _movieService.GetAllMovies();
            return Ok(movies);
        }
    }

}
