using DsApp.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AgencyFacade agencyFacade = new AgencyFacade();
            agencyFacade.AddNewClient("Matundra123", "Ker", "02020323", "24.2.3.", "aoskj@gmail.com", "9'812389'1");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
        }
    }
}
