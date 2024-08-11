namespace MovieStore.DTOs
{
    public class CustomerDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> PurchasedMovieIds { get; set; }
        public List<string> FavoriteGenres { get; set; }
    }

}
