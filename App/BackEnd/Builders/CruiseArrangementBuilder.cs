namespace BackEnd.Builders
{
    public class CruiseArrangementBuilder : TravelPackageBuilder
    {
        public override void BuildAccommodationType(string accomm)
        {
            package.AccommodationType = accomm;
        }

        public override void BuildAdditionalActivities(string additact)
        {
            package.AdditionalActivities = additact;
        }

        public override void BuildBoat(string boat)
        {
            package.Boat = boat;
        }

        public override void BuildCabinType(string cabin)
        {
            package.CabinType = cabin;
        }

        public override void BuildDateOfDeparture(string dod)
        {
            package.DateOfDeparture = dod;
        }

        public override void BuildDestination(string dest)
        {
            package.Destination = dest;
        }

        public override void BuildDuration(double duration)
        {
            package.Duration = duration;
        }

        public override void BuildGuide(string guide)
        {
            package.Guide = guide;
        }

        public override void BuildRoute(string route)
        {
            package.Route = route;
        }

        public override void BuildTransportType(string trans)
        {
            package.TransportType = trans;
        }
    }
}
