namespace DsApp.Builders
{
    public class TravelPackage
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Destination { get; set; }
        public string TransportType { get; set; }
        public string AccommodationType { get; set; }
        public double Price { get; set; }
        public string AdditionalActivities { get; set; }
        public string Guide {  get; set; }

        public string Duration { get; set; }

        public string Boat { get; set; }

        public string Route { get; set; }

        public string DateOfDeparture { get; set; }

        public string CabinType { get; set; }
        public string PackageType { get; set; }
    }
}
