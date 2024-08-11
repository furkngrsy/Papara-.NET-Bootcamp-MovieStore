namespace MovieStore.DTOs
{
    public class MovieDTO
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public int DirectorId { get; set; }
        public List<int> ActorIds { get; set; }
    }

}
