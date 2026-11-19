using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MYAcademy_AirbnbProject.Entities
{
    public class Review
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ReviewId { get; set; }

        public string HouseId { get; set; }

        public string AppUserId { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;

    }
}
