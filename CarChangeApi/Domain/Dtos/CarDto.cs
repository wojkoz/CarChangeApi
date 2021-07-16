using CarChangeApi.Domain.Enums;

namespace CarChangeApi.Domain.Dtos
{
    public class CarDto
    {
        public int CarId { get; set; }
        public CarType Type { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int EngineCapacity { get; set; }
        public int HorsePower { get; set; }
        public int ProductionYear { get; set; }
        public int MileageKm { get; set; }
        public int MileageMl { get; set; }
        public int Doors { get; set; }
        public GearBoxType GearboxType { get; set; }

        public int AdvertisementId { get; set; }
    }
}
