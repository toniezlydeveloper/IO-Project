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
            //JourneyCreationQueryExecutor dupa2 = new JourneyCreationQueryExecutor(con);
            // dupa2.insertJourneyToDatabase("Warszawa", "tu chodzilismy na kremowki", "nie wiem jakis string lokation", "12/10/2021");
            //dupa2.insertJourneyToDatabase("Watykan", "Wycieczka do stolicy polski", "nie wiem jakis string lokation", "21/10/2021");
            //dupa2.insertJourneyToDatabase("Morenka", "Kazdy wie co tu sie dzialo", "nie wiem jakis string lokation", "11/10/2021");
            //dupa2.updateJourneyToDatabase("Warszawa", "Wadowice", "nie wiem", "po co ", "to komu");
            //dupa2.addParticipantToJourneyInDatabase("lezore", "Tomasz Stach");
            //dupa2.addStageToDatabase("lezore", "Podroz do tunezji", "fajnie byo", "jakisPath");
            // dupa2.modifyStageInDatabase("po co", "Podroz do tunezji", "GOMBAO GOMBAO", "tu ", "to");
            StageModificationQueryExecutor dupa69 = new StageModificationQueryExecutor(con);


        }
    }
}
