using IO_Project.IO;
using IO_Project.IO.Entities;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IO_Project
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6D6O41;Initial Catalog=IO_proj1;Integrated Security=True;Pooling=False");
            DatabaseInteractor dupa = new DatabaseInteractor();
            dupa.checkUserNames();
            JourneyCreationQueryExecutor dupa2 = new JourneyCreationQueryExecutor(con);
            dupa2.insertJourneyToDatabase("lezore", "wycieczka szkolna", "nie wiem jakis string lokation", "24/10/2021");

        }
    }
}
