using BackEnd.Config;
using Npgsql;

namespace BackEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {

            PostgreBroker db = (PostgreBroker)PostgreBroker.GetInstance("./Config/config1.txt");

            Console.WriteLine(db.GetConnectionString());

            Console.WriteLine(db.GetAgencyName());

            Console.WriteLine(db.getDB());

            var result = new List<(int, string, string)>();

            db.getDB().Open();
            string sql = "SELECT UserId, Username, Email FROM public.Users";

            using (var cmd = new NpgsqlCommand(sql, db.getDB()))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.Add((reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                }
                Console.WriteLine(result);
            }

            db.getDB().Close();
        
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
