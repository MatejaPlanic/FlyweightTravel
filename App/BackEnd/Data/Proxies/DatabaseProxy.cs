namespace BackEnd.Data.Proxies
{
    public class DatabaseProxy : IDatabaseService
    {
        private readonly RealDatabaseService realService;
        private bool isLoggedIn = false;

        public DatabaseProxy(RealDatabaseService realService)
        {
            this.realService = realService;
        }

        public void Login(string username, string password)
        {
            if (username == "admin" && password == "pass")
            {
                isLoggedIn = true;
                Console.WriteLine("Login uspešan.");
            }
            else
            {
                Console.WriteLine("Login neuspešan.");
            }
        }

        public void ExecuteQuery(string query)
        {
            if (isLoggedIn)
            {
                realService.ExecuteQuery(query);
            }
            else
            {
                Console.WriteLine("Pristup odbijen. Morate se prijaviti.");
            }
        }
    }
}
