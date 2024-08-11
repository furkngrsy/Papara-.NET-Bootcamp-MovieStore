using MovieStore.DTOs;

namespace MovieStore.Validations
{
    public class MovieValidator : AbstractValidator<MovieDTO>
    {
        public MovieValidator()
        {
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.Year).GreaterThan(1900);
            RuleFor(x => x.Price).GreaterThan(0);
        }
    }

}
