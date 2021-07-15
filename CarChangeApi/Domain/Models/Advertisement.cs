using System;

namespace CarChangeApi.Domain.Models
{
    public class Advertisement
    {
        public int AdvertisementId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Ends { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public Car Car { get; set; }
    }
}
