﻿namespace MovieStore.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Movie Movie { get; set; }
        public decimal Price { get; set; }
        public DateTime PurchaseDate { get; set; }
    }

}
