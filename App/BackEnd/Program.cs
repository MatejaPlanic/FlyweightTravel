using BackEnd.Config;
using Microsoft.Data.Sqlite;
using MySqlConnector;
using Npgsql;

namespace BackEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {

            MySqlBroker db = (MySqlBroker)MySqlBroker.GetInstance("./Config/config2.txt");

            Console.WriteLine(db.GetConnectionString());
            Console.WriteLine(db.GetAgencyName());
            Console.WriteLine(db.getDB());

            var result = new List<(long Id, string Username)>();

            db.getDB().Open();

            const string sql = "SELECT id, username FROM korisnik;";

            using (var cmd = new MySqlCommand(sql, (MySqlConnection)db.getDB()))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // SQLite INTEGER je Int64
                    long id = reader.GetInt64(0);
                    string username = reader.GetString(1);
                    result.Add((id, username));
                }
            }

            db.getDB().Close();

            // primer ispisa
            if (result.Count > 0)
                Console.WriteLine($"{result[0].Id} - {result[0].Username}");


            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
