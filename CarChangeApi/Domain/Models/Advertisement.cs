using System;

namespace CarChangeApi.Domain.Models
{
    public class Advertisement
    {
        // TODO: Add relations to Car and User 
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Ends { get; set; }
        public User User { get; set; }
        public Car Car { get; set; }
    }
}
