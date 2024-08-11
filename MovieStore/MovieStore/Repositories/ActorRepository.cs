using MovieStore.Entities;

namespace MovieStore.Repositories
{
    public class ActorRepository : IActorRepository
    {
        public void Add(Actor actor) { }
        public void Update(Actor actor) { }
        public void Delete(int id) { }
        public Actor GetById(int id) { return null; }
        public List<Actor> GetAll() { return null; }
    }

}
