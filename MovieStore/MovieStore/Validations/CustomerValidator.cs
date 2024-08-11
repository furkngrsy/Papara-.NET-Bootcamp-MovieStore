using MovieStore.DTOs;

namespace MovieStore.Validations
{
    public class CustomerValidator : AbstractValidator<CustomerDTO>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.FavoriteGenres).NotEmpty();
        }
    }

}
