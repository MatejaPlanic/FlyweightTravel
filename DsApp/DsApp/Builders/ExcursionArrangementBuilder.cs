namespace DsApp.Builders
{
    public class ExcursionArrangementBuilder : TravelPackageBuilder
    {

        public void BuildDestination(string dest)
        {
            package.Destination = dest;
        }

        public void BuildDuration(double duration)
        {
            package.Duration = duration;
        }

        public void BuildGuide(string guide)
        {
            package.Guide = guide;
        }

        public void BuildTransportType(string trans)
        {
            package.TransportType = trans;
        }
    }
}
