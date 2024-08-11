using Microsoft.AspNetCore.Mvc;
using MovieStore.DTOs;
using MovieStore.Services;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActorsController : ControllerBase
    {
        private readonly ActorService _actorService;

        public ActorsController(ActorService actorService)
        {
            _actorService = actorService;
        }

        [HttpPost]
        public IActionResult AddActor([FromBody] ActorDTO actorDTO)
        {
            _actorService.AddActor(actorDTO);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateActor(int id, [FromBody] ActorDTO actorDTO)
        {
            _actorService.UpdateActor(id, actorDTO);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteActor(int id)
        {
            _actorService.DeleteActor(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetActorById(int id)
        {
            var actor = _actorService.GetActorById(id);
            return Ok(actor);
        }

        [HttpGet]
        public IActionResult GetAllActors()
        {
            var actors = _actorService.GetAllActors();
            return Ok(actors);
        }
    }

}
