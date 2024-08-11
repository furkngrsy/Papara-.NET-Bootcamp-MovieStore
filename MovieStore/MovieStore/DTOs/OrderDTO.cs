namespace MovieStore.DTOs
{
    public class OrderDTO
    {
        public int CustomerId { get; set; }
        public int MovieId { get; set; }
        public decimal Price { get; set; }
    }

}
