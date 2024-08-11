using MovieStore.DTOs;

namespace MovieStore.Validations
{
    public class ActorValidator : AbstractValidator<ActorDTO>
    {
        public ActorValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
        }
    }

}
