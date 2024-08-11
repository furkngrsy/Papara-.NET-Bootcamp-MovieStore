using MovieStore.DTOs;

namespace MovieStore.Validations
{
    public class OrderValidator : AbstractValidator<OrderDTO>
    {
        public OrderValidator()
        {
            RuleFor(x => x.CustomerId).GreaterThan(0);
            RuleFor(x => x.MovieId).GreaterThan(0);
            RuleFor(x => x.Price).GreaterThan(0);
        }
    }

}
