using Microsoft.AspNetCore.Mvc;
using MovieStore.DTOs;
using MovieStore.Services;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DirectorsController : ControllerBase
    {
        private readonly DirectorService _directorService;

        public DirectorsController(DirectorService directorService)
        {
            _directorService = directorService;
        }

        [HttpPost]
        public IActionResult AddDirector([FromBody] DirectorDTO directorDTO)
        {
            _directorService.AddDirector(directorDTO);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDirector(int id, [FromBody] DirectorDTO directorDTO)
        {
            _directorService.UpdateDirector(id, directorDTO);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDirector(int id)
        {
            _directorService.DeleteDirector(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetDirectorById(int id)
        {
            var director = _directorService.GetDirectorById(id);
            return Ok(director);
        }

        [HttpGet]
        public IActionResult GetAllDirectors()
        {
            var directors = _directorService.GetAllDirectors();
            return Ok(directors);
        }
    }

}
