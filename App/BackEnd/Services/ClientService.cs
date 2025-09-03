using BackEnd.Data.Proxies;

namespace BackEnd.Services
{
    public class ClientService
    {
        private DatabaseProxy? proxy = null;

        public ClientService()
        {
            proxy = DatabaseProxy.getProxy();
        }
        public void AddClient(string ime, string prezime,
            string brojPasosa, string datumRodjenja, string emailAdresa, string brojTelefona)
        { 
            proxy.AddClient(ime, prezime, brojPasosa, datumRodjenja, emailAdresa, brojTelefona);
        }
    }
}
