
namespace DsApp.Builders
{
    public class SeaArrangementBuilder : TravelPackageBuilder
    {
        public void BuildAccommodationType(string accomm)
        {
            package.AccommodationType = accomm;
        }

        public void BuildDestination(string dest)
        {
            package.Destination = dest;
        }

        public void BuildTransportType(string trans)
        {
            package.TransportType = trans;
        }
    }
}
