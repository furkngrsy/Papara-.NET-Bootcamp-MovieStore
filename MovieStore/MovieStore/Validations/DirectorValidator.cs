using MovieStore.DTOs;

namespace MovieStore.Validations
{
    public class DirectorValidator : AbstractValidator<DirectorDTO>
    {
        public DirectorValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
        }
    }

}
