using BackEnd.Builders;
using BackEnd.Config;
using BackEnd.Facade;
using Microsoft.Data.Sqlite;
using MySqlConnector;
using Npgsql;

namespace BackEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AgencyFacade ker = new AgencyFacade();
            /*ker.AddNewClient("Stefan", "Grujicic", "0522320", "24.06.2003.", "stefan@gmail.com", "0603252928");*/


            SeaArrangementBuilder s = new SeaArrangementBuilder();

        }
    }
}
