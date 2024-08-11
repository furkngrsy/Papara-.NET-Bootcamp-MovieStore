using System.IO;

namespace MovieStore.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public Director Director { get; set; }
        public List<Actor> Actors { get; set; }
    }

}
