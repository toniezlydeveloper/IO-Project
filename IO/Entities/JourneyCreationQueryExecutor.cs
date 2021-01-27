using IO_Project.IO.Payloads;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace IO_Project.IO.Entities
{
    class JourneyQueryExecutor : IQueryExecutor
    {
        private SqlConnection connection;

        public RequestType HandledRequestType => RequestType.CreateJourney;
        public Type HandlePayloadType => typeof(JourneyCreationPayload);

        public JourneyQueryExecutor(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void ExecuteQuery(Request request)
        {
            JourneyCreationPayload payload = (JourneyCreationPayload)request.Payload;
            insertJourneyToDatabase(payload.Name, payload.Description, payload.Date);

        }
        private void insertJourneyToDatabase(string name, string description, string date)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(null, connection);

            command.CommandText =
                "INSERT INTO Trip (Name, StartDate, EndDate, Description, ShortDescription) " +
                "VALUES (@name, @startDate, NULL, @desc, NULL)";
            SqlParameter nameParam = new SqlParameter("@name", SqlDbType.Text, 100);
            SqlParameter descParam = new SqlParameter("@desc", SqlDbType.Text, 100);
            SqlParameter dateParam = new SqlParameter("@startdate", SqlDbType.Date, 10);
            descParam.Value = description;
            command.Parameters.Add(descParam);
            dateParam.Value = date;
            command.Parameters.Add(dateParam);
            nameParam.Value = name;
            command.Parameters.Add(nameParam);

            // Call Prepare after setting the Commandtext and Parameters.
            command.Prepare();
            command.ExecuteNonQuery();
            connection.Close();
        }
      
            
    }
}



