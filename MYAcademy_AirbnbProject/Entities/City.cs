using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MYAcademy_AirbnbProject.Entities
{
    public class City
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CityId { get; set; }

        public string CityName { get; set; }

        public string CountryName { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
