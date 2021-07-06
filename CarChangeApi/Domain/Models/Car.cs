using System;

namespace CarChangeApi.Domain.Models
{
    public class Car
    {
        public CarType Type { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public float EngineCapacity { get; set; }
        public int HorsePower { get; set; }
        public DateTime ProductionYear { get; set; }
        public int MileageKm { get; set; }
        public int MileageMl { get; set; }
        public int Doors { get; set; }
    }
}
