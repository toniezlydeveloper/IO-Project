using System.Data;
using IO_Project.Core.QueryExecutors;
using IO_Project.IO.Payloads;

namespace IO_Project.IO.Entities
{
    class JourneyModificationQueryExecutor : IQueryExecutor
    {
        private SqlConnection connection;

        public RequestType HandledRequestType => RequestType.ModifyJourney;

        public JourneyModificationQueryExecutor(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void ExecuteQuery(Request request)
        {
            JourneyModificationPayload payload = (JourneyModificationPayload)request.Payload;
            updateJourneyToDatabase(payload.OldName, payload.NewName, payload.NewDescription, payload.NewDate);
        }


        private void updateJourneyToDatabase(string oldName, string newName, string description, string date)
        {

            using (connection)
            {
                connection.Open();
                SqlCommand command = new SqlCommand(null, connection);


                command.CommandText =
                    "UPDATE Trip " +
                    "SET Name = @newName, Description = @description, StartDate = @date " +
                    "WHERE Name = @oldName";
                SqlParameter newNameParam = new SqlParameter("@newName", SqlDbType.VarChar, 40);
                SqlParameter oldNameParam = new SqlParameter("@oldName", SqlDbType.VarChar, 40);
                SqlParameter descParam = new SqlParameter("@description", SqlDbType.VarChar, 500);
                SqlParameter dateParam = new SqlParameter("@date", SqlDbType.Date, 10);
                newNameParam.Value = newName;
                command.Parameters.Add(newNameParam);
                oldNameParam.Value = oldName;
                command.Parameters.Add(oldNameParam);
                descParam.Value = description;
                command.Parameters.Add(descParam);
                dateParam.Value = date;
                command.Parameters.Add(dateParam);

                // Call Prepare after setting the Commandtext and Parameters.
                command.Prepare();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
}
