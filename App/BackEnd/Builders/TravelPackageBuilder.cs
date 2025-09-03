namespace BackEnd.Builders
{
    public abstract class TravelPackageBuilder
    {
        protected TravelPackage package = new TravelPackage();

        public abstract void BuildDestination(string dest);
        public abstract void BuildTransportType(string trans);
        public abstract void BuildAccommodationType(string accomm);
        public abstract void BuildAdditionalActivities(string additact);
        public abstract void BuildGuide(string guide);
        public abstract void BuildDuration(double duration);
        public abstract void BuildBoat(string boat);
        public abstract void BuildRoute(string route);
        public abstract void BuildDateOfDeparture(string dod);
        public abstract void BuildCabinType(string cabin);

        public void BuildCommonDetails(string name, double price, string packageType)
        {
            package.Name = name;
            package.Price = price;
            package.PackageType = packageType;
        }

        public TravelPackage GetPackage()
        {
            return package;
        }
    }
}
