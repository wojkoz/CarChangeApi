using System;

namespace CarChangeApi.Domain.Dtos
{
    public class CreateAdvertisementDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public DateTime Ends { get; set; }
        public CreateCarDto Car { get; set; }
    }
}
