namespace BackEnd.Builders
{
    public abstract class TravelPackageBuilder
    {
        protected TravelPackage package = new TravelPackage();
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
