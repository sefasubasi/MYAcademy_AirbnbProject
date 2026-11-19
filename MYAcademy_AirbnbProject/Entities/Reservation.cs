using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MYAcademy_AirbnbProject.Entities
{
    public class Reservation
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ReservationId { get; set; }

        public string HouseId { get; set; }

        public string AppUserId { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public int GuestCount { get; set; }

        public decimal TotalPrice { get; set; }

        public string ReservationStatus { get; set; } = "Pending";

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    }
}
