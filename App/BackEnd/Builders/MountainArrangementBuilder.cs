namespace BackEnd.Builders
{
    public class MountainArrangementBuilder : TravelPackageBuilder
    {
        public void BuildAccommodationType(string accomm)
        {
            package.AccommodationType = accomm;
        }

        public void BuildAdditionalActivities(string additact)
        {
            package.AdditionalActivities = additact;
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
