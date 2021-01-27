using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace IO_Project.IO
{
    class DatabaseInteractor
    {
        SqlConnection con;
        SqlCommand cmd;
        public DatabaseInteractor()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-B6D6O41;Initial Catalog=IO_proj1;Integrated Security=True;Pooling=False");
           
        }
        public void checkUserNames()
        {
            string imie = "Janek";
            string surname = "Adamowski";
            con.Open();
            cmd = new SqlCommand("insert into Participant values('" + imie + "','" + surname + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
