using MovieStore.Entities;

namespace MovieStore.Repositories
{
    public interface IActorRepository
    {
        void Add(Actor actor);
        void Update(Actor actor);
        void Delete(int id);
        Actor GetById(int id);
        List<Actor> GetAll();
    }

}
