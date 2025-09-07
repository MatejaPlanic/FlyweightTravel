using DsApp.Builders;
using DsApp.Data.Proxies;
using DsApp.Models;
using System.Text.RegularExpressions;

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
            if (string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime) ||
                string.IsNullOrEmpty(brojPasosa) || string.IsNullOrEmpty(datumRodjenja) ||
                string.IsNullOrEmpty(emailAdresa) || string.IsNullOrEmpty(brojTelefona))
            {
                throw new ArgumentException("Sva polja su obavezna.");
            }

            string emailRegexPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(emailAdresa, emailRegexPattern))
            {
                throw new FormatException("Email adresa nije u ispravnom formatu.");
            }
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
