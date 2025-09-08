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

        private BackupManager(string filePath)
        {

            string[] lines = System.IO.File.ReadAllLines(filePath);
            _connectionString = lines[1];
            _isMySql = _connectionString.Contains("Server=");
            _timer = new System.Timers.Timer(24 * 60 * 60 * 1000); // 24 sata
            _timer.Elapsed += OnTimedEvent;


            _backupFolderPath = "../../../Config/";
        }

        public static BackupManager GetInstance(string filePath)
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new BackupManager(filePath);
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
        public void ExecuteBackup()
        {
            if (_isMySql)
            {
                BackupMySql();
            }
            else
            {
                BackupSqlite();
            }
        }
        private void BackupSqlite()
        {
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
            if (!Directory.Exists(_backupFolderPath))
            {
                Directory.CreateDirectory(_backupFolderPath);
            }
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

            string mysqldumpPath = @"C:\wamp64\bin\mysql\mysql9.1.0\bin\mysqldump.exe";
            if (!File.Exists(mysqldumpPath))
            {
                throw new FileNotFoundException($"'mysqldump.exe' nije pronađen na putanji: {mysqldumpPath}. Molimo prilagodite putanju.");
            }

            try
            {
                Process process = new Process();
                process.StartInfo.FileName = mysqldumpPath;
                process.StartInfo.Arguments = $"-u root {dbName}";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();

                using (StreamWriter sw = new StreamWriter(backupPath))
                {
                    sw.Write(process.StandardOutput.ReadToEnd());
                }

                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    Console.WriteLine($"MySQL bekap uspešno kreiran: {backupPath}");
                }
                else
                {
                    string error = process.StandardError.ReadToEnd();
                    Console.WriteLine($"MySQL bekap nije uspeo: {error}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška pri kreiranju MySQL bekapa: {ex.Message}");
            }
        }
    }
}
