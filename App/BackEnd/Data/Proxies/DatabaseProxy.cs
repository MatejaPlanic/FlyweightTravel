using BackEnd.Config;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace BackEnd.Data.Proxies
{
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

                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
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

                using (var msDecrypt = new System.IO.MemoryStream(encryptedBytes))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
