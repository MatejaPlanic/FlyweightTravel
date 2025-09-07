using DsApp.Builders;
using DsApp.Data.Proxies;
using DsApp.Models;

namespace DsApp.Services
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

        public List<Client> GetAllClients()
        {
            return proxy.GetAllClients();
        }

        public List<Client> SearchClients(string srch)
        {
            return proxy.SearchClients(srch);
        }
    }
}
