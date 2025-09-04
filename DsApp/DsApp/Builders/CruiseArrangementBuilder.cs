

namespace DsApp.Builders
{
    public class CruiseArrangementBuilder : TravelPackageBuilder
    {
        public void BuildBoat(string boat)
        {
            package.Boat = boat;
        }

        public void BuildCabinType(string cabin)
        {
            package.CabinType = cabin;
        }

        public void BuildDateOfDeparture(string dod)
        {
            package.DateOfDeparture = dod;
        }

        public void BuildRoute(string route)
        {
            package.Route = route;
        }

    }
}
