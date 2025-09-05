using DsApp.Builders;
using DsApp.Config;
using DsApp.Data.Proxies;
using DsApp.Models;
using DsApp.Services;
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
            realService = new RealDatabaseService();
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

            string encryptedPassportNumber = Encrypt(brojPasosa);


            realService.AddClient(ime, prezime, encryptedPassportNumber, datumRodjenja, emailAdresa, brojTelefona);

            Console.WriteLine(GetDecryptedPassportNumber(encryptedPassportNumber));
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
            if (tr == null) throw new ArgumentNullException(nameof(tr));
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

            realService.AddNewPackage(new SqlEnvelope { Query = sql, Parameters = args });
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
            realService.AddNewReservation(destinacija,tipId,broj_osoba,klijentId);
        }

        public void CancelReservation(int id)
        {
            realService.CancelReservation(id);
        }
    }
}
