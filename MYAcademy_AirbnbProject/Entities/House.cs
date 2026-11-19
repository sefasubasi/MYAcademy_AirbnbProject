using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MYAcademy_AirbnbProject.Entities
{
    public class House
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string HouseId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string CityId { get; set; }

        public string CategoryId { get; set; }

        public string Address { get; set; }

        public string District { get; set; }

        public decimal PricePerNight { get; set; }

        public int GuestCapacity { get; set; }

        public int BedroomCount { get; set; }

        public int BedCount { get; set; }

        public int BathroomCount { get; set; }

        public int SquareMeters { get; set; }

        public string ImageUrl { get; set; }

        public List<string> Images { get; set; } = new();

        public List<string> Amenities { get; set; } = new();

        public bool IsActive { get; set; } = true;

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    }
}
