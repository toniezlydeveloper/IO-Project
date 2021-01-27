using IO_Project.IO.Payloads;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace IO_Project.IO.Entities
{
    class JourneyCreationQueryExecutor : IQueryExecutor
    {
        private SqlConnection connection;
        private SqlCommand cmd;

        public RequestType HandledRequestType => RequestType.CreateJourney;
        public Type HandlePayloadType => typeof(JourneyCreationPayload);

        public JourneyCreationQueryExecutor(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void ExecuteQuery(Request request)
        {
            JourneyCreationPayload payload = (JourneyCreationPayload)request.Payload;

        }
        public void insertJourneyToDatabase(string name, string description, string location, string date)
        {

            // connection.Open();
            // var tmp = DateTime.Parse(date);
            // cmd = new SqlCommand("insert into Trip values('" + name + "'," + "CONVERT(datetime, '" + date + "') " + "," + "NULL" + ",'" + description + "'," + "NULL" + "," + "NULL" + ")", connection);
            // cmd.ExecuteNonQuery();
            // connection.Close();
            using (connection)
            {
                connection.Open();
                SqlCommand command = new SqlCommand(null, connection);

                // Create and prepare an SQL statement.
                //command.CommandText =
                //    "INSERT INTO Trip (Id, Name, StartDate, EndDate, Description, ShortDescription) " +
                //    "VALUES (@id, @name, @startDate, NULL, @desc, NULL)";
                //SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int, 0);
                //SqlParameter descParam =
                //    new SqlParameter("@desc", SqlDbType.Text, 100);
                //idParam.Value = 20;
                //descParam.Value = "First Region";
                //command.Parameters.Add(idParam);
                //command.Parameters.Add(descParam);
                //
                //// Call Prepare after setting the Commandtext and Parameters.
                //command.Prepare();
                //command.ExecuteNonQuery();
                //
                //// Change parameter values and call ExecuteNonQuery.
                //command.Parameters[0].Value = 21;
                //command.Parameters[1].Value = "Second Region";
                //command.ExecuteNonQuery();
            }

        }
    }
}
