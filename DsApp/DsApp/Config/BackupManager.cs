using MySqlConnector;
using System.Data;
using System.IO;
using System;
using System.Diagnostics;
using System.Threading;
using System.Timers;

namespace DsApp.Config
{
    public sealed class BackupManager
    {
        private static BackupManager? instance = null;
        private static readonly object padlock = new object();
        private readonly System.Timers.Timer _timer;
        private readonly string _connectionString;
        private readonly bool _isMySql;
        private readonly string _backupFolderPath;

        private BackupManager(string connectionString)
        {
            _connectionString = connectionString;
            _isMySql = connectionString.Contains("Server=");
            _timer = new System.Timers.Timer(24 * 60 * 60 * 1000); // 24 sata
            _timer.Elapsed += OnTimedEvent;

            // Define backup folder path
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            _backupFolderPath = Path.Combine(baseDirectory, "Backups");
        }

        public static BackupManager GetInstance(string connectionString)
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new BackupManager(connectionString);
                }
                return instance;
            }
        }

        public void StartBackupTimer()
        {
            _timer.AutoReset = true;
            _timer.Enabled = true;
            Console.WriteLine("Automatski backup baze podataka je pokrenut.");
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Pokretanje automatskog backupa.");
            try
            {
                if (_isMySql)
                {
                    BackupMySql();
                }
                else
                {
                    BackupSqlite();
                }
                Console.WriteLine($"Backup uspešno kreiran u: {_backupFolderPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška tokom backupa: {ex.Message}");
            }
        }

        private void BackupSqlite()
        {
            // SQLite backup je jednostavan: kopiranje fajla baze podataka
            var dbPath = _connectionString.Split(';')[0].Split('=')[1];
            if (!File.Exists(dbPath))
            {
                throw new FileNotFoundException($"Fajl baze podataka nije pronađen: {dbPath}");
            }

            if (!Directory.Exists(_backupFolderPath))
            {
                Directory.CreateDirectory(_backupFolderPath);
            }

            var backupFileName = $"sqlite_backup_{DateTime.Now:yyyyMMdd_HHmmss}.db";
            var backupPath = Path.Combine(_backupFolderPath, backupFileName);

            File.Copy(dbPath, backupPath, true);
        }

        private void BackupMySql()
        {
            // MySQL backup zahteva korišćenje mysqldump alata
            if (!Directory.Exists(_backupFolderPath))
            {
                Directory.CreateDirectory(_backupFolderPath);
            }

            // Izvuci ime baze iz connection stringa
            var dbName = "";
            var connectionParts = _connectionString.Split(';');
            foreach (var part in connectionParts)
            {
                if (part.Trim().StartsWith("Database="))
                {
                    dbName = part.Split('=')[1].Trim();
                    break;
                }
            }

            if (string.IsNullOrEmpty(dbName))
            {
                throw new ArgumentException("Ime baze podataka nije pronađeno u connection stringu.");
            }

            var backupFileName = $"mysql_backup_{dbName}_{DateTime.Now:yyyyMMdd_HHmmss}.sql";
            var backupPath = Path.Combine(_backupFolderPath, backupFileName);

            // PUTANJA do mysqldump.exe mora biti ispravna.
            // Ovo je default lokacija za XAMPP, ali možda moraš da je prilagodiš.
            string mysqldumpPath = @"C:\xampp\mysql\bin\mysqldump.exe";
            if (!File.Exists(mysqldumpPath))
            {
                throw new FileNotFoundException($"'mysqldump.exe' nije pronađen na putanji: {mysqldumpPath}. Molimo prilagodite putanju.");
            }

            // Kreiranje komande za mysqldump
            string command = $"--user=root --password= {dbName} > \"{backupPath}\"";

            Process process = new Process();
            process.StartInfo.FileName = mysqldumpPath;
            process.StartInfo.Arguments = command;
            process.StartInfo.RedirectStandardInput = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            process.WaitForExit();
        }
    }
}
