namespace MYAcademy_AirbnbProject.Settings
{
    public class MongoDbSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }

        public string CategoryCollectionName { get; set; }

        public string CityCollectionName { get; set; }

        public string HouseCollectionName { get; set; }

        public string AppUserCollectionName { get; set; }

        public string ReservationCollectionName { get; set; }

        public string ReviewCollectionName { get; set; }

    }
}
