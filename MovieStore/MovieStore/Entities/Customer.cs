namespace MovieStore.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Movie> PurchasedMovies { get; set; }
        public List<string> FavoriteGenres { get; set; }
    }

}
