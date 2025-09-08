using DsApp.Builders;
using DsApp.Config;
using DsApp.Data.Proxies;
using DsApp.Models;
using DsApp.Services;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace DsApp.Data.Proxies
{
    public sealed class SqlEnvelope
    {
        public string Query { get; init; } = "";
        public Dictionary<string, object?> Parameters { get; init; } = new();
    }
    public class DatabaseProxy
    {
        private RealDatabaseService? realService = null;
        private static DatabaseProxy? instance = null;
        private static readonly object padlock = new object();
        private static readonly byte[] key = Encoding.UTF8.GetBytes("matundrastefi123");
        private static readonly byte[] iv = Encoding.UTF8.GetBytes("stefimatundra123");
        private DatabaseProxy()
        {
            realService = RealDatabaseService.GetInstance();
        }

        public static DatabaseProxy getProxy()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new DatabaseProxy();
                }
                return instance;
            }
        }

        public void AddClient(string ime, string prezime,
        string brojPasosa, string datumRodjenja, string emailAdresa, string brojTelefona)
        {
            string query = "INSERT INTO client (Ime, Prezime, BrojPasosa, DatumRodjenja, EmailAdresa, BrojTelefona) " +
                              "VALUES (@ime, @prezime, @brojPasosa, @datumRodjenja, @emailAdresa, @brojTelefona);";

            var args = new Dictionary<string, object?>();

            string encryptedPassportNumber = Encrypt(brojPasosa);

            args["@ime"] = ime;
            args["@prezime"] = prezime;
            args["@brojPasosa"] = encryptedPassportNumber;
            args["@datumRodjenja"] = datumRodjenja;
            args["@emailAdresa"] = emailAdresa;
            args["@brojTelefona"] = brojTelefona;

            

            realService.UnveilEnvelopeClients(new SqlEnvelope { Query = query, Parameters = args });

        }

        public string GetDecryptedPassportNumber(string encryptedPassportNumber)
        {
            return Decrypt(encryptedPassportNumber);
        }

        private string Encrypt(string plaintext)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plaintext);
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
        }

        private string Decrypt(string encryptedText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

                using (var msDecrypt = new MemoryStream(encryptedBytes))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        public void AddNewPackage(TravelPackageBuilder tr)
        {
            var p = tr.GetPackage();

            var args = new Dictionary<string, object?>();
            string sql;

            if (tr is SeaArrangementBuilder)
            {
                sql = @"
         INSERT INTO packages
           (ime, cena, tip_paketa, smestaj, destinacija, transport)
         VALUES
           (@ime, @cena, @tip, @smestaj, @destinacija, @transport);";

                args["@ime"] = p.Name;
                args["@cena"] = p.Price;
                args["@tip"] = p.PackageType;
                args["@smestaj"] = p.AccommodationType;
                args["@destinacija"] = p.Destination;
                args["@transport"] = p.TransportType;
            }
            else if (tr is MountainArrangementBuilder)
            {
                sql = @"
         INSERT INTO packages
           (ime, cena, tip_paketa, smestaj, destinacija, transport, dodatne_aktivnosti)
         VALUES
           (@ime, @cena, @tip, @smestaj, @destinacija, @transport, @aktivnosti);";

                args["@ime"] = p.Name;
                args["@cena"] = p.Price;
                args["@tip"] = p.PackageType;
                args["@smestaj"] = p.AccommodationType;
                args["@destinacija"] = p.Destination;
                args["@transport"] = p.TransportType;
                args["@aktivnosti"] = p.AdditionalActivities;
            }
            else if (tr is ExcursionArrangementBuilder)
            {
                sql = @"
         INSERT INTO packages
           (ime, cena, tip_paketa, destinacija, transport, vodic, trajanje)
         VALUES
           (@ime, @cena, @tip, @destinacija, @transport, @vodic, @trajanje);";

                args["@ime"] = p.Name;
                args["@cena"] = p.Price;
                args["@tip"] = p.PackageType;
                args["@destinacija"] = p.Destination;
                args["@transport"] = p.TransportType;
                args["@vodic"] = p.Guide;
                args["@trajanje"] = p.Duration;
            }
            else if (tr is CruiseArrangementBuilder)
            {
                sql = @"
         INSERT INTO packages
           (ime, cena, tip_paketa, brod, ruta, datum_polaska, tip_kabine, destinacija)
         VALUES
           (@ime, @cena, @tip, @brod, @ruta, @datum, @kabina, @destinacija);";

                args["@ime"] = p.Name;
                args["@cena"] = p.Price;
                args["@tip"] = p.PackageType;
                args["@brod"] = p.Boat;
                args["@ruta"] = p.Route;
                args["@datum"] = p.DateOfDeparture;
                args["@kabina"] = p.CabinType;
                args["@destinacija"] = p.Destination;
            }
            else
            {
                throw new ArgumentException("Nepoznat tip paketa.");
            }

            realService.UnveilEnvelopePackages(new SqlEnvelope { Query = sql, Parameters = args });
        }

        public List<Client> GetAllClients()
        {
            List<Client> clients = realService.GetAllClients();
            foreach (Client client in clients)
            {
                client.BrojPasosa = Decrypt(client.BrojPasosa);
            }

            return clients;
        }

        public List<TravelPackage> GetAllPackages()
        {
            return realService.GetAllPackages();
        }

        public List<string> GetAllDestinations()
        {
            return realService.GetAllDestinations();
        }
        public List<(string Name, int Id)> GetAllPackageDestinationNames(string dest)
        {
            return realService.GetAllPackageDestinationNames(dest);
        }

        public List<Reservation> GetAllReservations(int id)
        {
            return realService.GetAllReservations(id);
        }

        public void AddNewReservation(string destinacija, int tipId, int broj_osoba, int klijentId)
        {
        const string sql = @"
        INSERT INTO reservations
            (id_client, id_package, state, datum_rezervacije, broj_osoba, destinacija)
        VALUES
            (@client, @package, @state, @datum, @broj, @dest);";
            string datum = DateTime.Now.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            var args = new Dictionary<string, object?>();

            args["@client"] = klijentId;
            args["@package"] = tipId;
            args["@state"] = "Rezervisana";
            args["@datum"] = datum;
            args["@broj"] = broj_osoba;
            args["@dest"] = destinacija;

        realService.UnveilEnvelopeReservations(new SqlEnvelope { Query = sql, Parameters = args });

        }

        public void CancelReservation(int id)
        {
            const string sql = @"
            UPDATE reservations
            SET state = @state
            WHERE id = @id;";

            var args = new Dictionary<string, object?>();

            args["@state"] = "Otkazana";
            args["@id"] = id;

            realService.UnveilEnvelopeReservations(new SqlEnvelope { Query = sql, Parameters = args });
        }
        public List<Client> SearchClients(string srch)
        {
            List<Client> clients = realService.SearchClients(srch);
            foreach (Client client in clients)
            {
                client.BrojPasosa = Decrypt(client.BrojPasosa);
            }

            return clients;

        }

        public void DeleteReservation(int id)
        {
            const string sql = @"
            DELETE FROM reservations
            WHERE id = @id;";

            var args = new Dictionary<string, object?>();

            args["@id"] = id;

            realService.UnveilEnvelopeReservations(new SqlEnvelope { Query = sql, Parameters = args });
        }

        public void UpdateReservation(int id, string destinacija, int tip_id, int broj_osoba)
        {
            const string sql = @"
            UPDATE reservations
            SET destinacija = @dest,
                id_package  = @pkg,
                broj_osoba  = @broj,
                state       = @state
            WHERE id = @id;";

            var args = new Dictionary<string, object?>();

            args["@dest"] = destinacija;
            args["@pkg"] = tip_id;
            args["@broj"] = broj_osoba;
            args["@state"] = "Ažurirana";
            args["@id"] = id;


            realService.UnveilEnvelopeReservations(new SqlEnvelope { Query = sql, Parameters = args });
        }
    }
}
