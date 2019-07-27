using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Micron;
namespace LoginRegistration
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //create database connection to my_database


            MicronConfig setUp = new MicronConfig()
            {
                DatabaseName= "my_database"
            };

            MicronDbContext.AddConnectionSetup(setUp);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
