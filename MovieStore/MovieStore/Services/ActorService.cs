using MovieStore.DTOs;
using MovieStore.Repositories;

namespace MovieStore.Services
{
    public class ActorService
    {
        private readonly IActorRepository _actorRepository;

        public ActorService(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

        public void AddActor(ActorDTO actorDTO) { }
        public void UpdateActor(int id, ActorDTO actorDTO) { }
        public void DeleteActor(int id) { }
        public ActorDTO GetActorById(int id) { return null; }
        public List<ActorDTO> GetAllActors() { return null; }
    }

}
