using System.Data;
using IO_Project.Core.QueryExecutors;
using IO_Project.IO.Payloads;

namespace IO_Project.IO.Entities
{
    class ParticipantAssignmentQueryExecutor : IQueryExecutor
    {
        private SqlConnection connection;

        public RequestType HandledRequestType => RequestType.AssignParticipant;

        public ParticipantAssignmentQueryExecutor(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void ExecuteQuery(Request request)
        {
            ParticipantAssignmentPayload payload = (ParticipantAssignmentPayload)request.Payload;
            addJourneyToParticipantInDatabase(payload.JourneyName, payload.ParticipantFullName);
        }

        private void addJourneyToParticipantInDatabase(string journeyName, string participantFullName)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(null, connection);
            string[] tmp = participantFullName.Split(' ');
            command.CommandText =
                    "UPDATE Participant " +
                    "SET Trip = (SELECT MAX(id) FROM Trip WHERE name = @jName) " +
                    "WHERE firstName=@firstName AND surname = @surname";
            SqlParameter FirstNameParam = new SqlParameter("@firstName", SqlDbType.VarChar, 50);
            SqlParameter surnameParam = new SqlParameter("@surname", SqlDbType.VarChar, 50);
            SqlParameter journeyNameParam = new SqlParameter("@jName", SqlDbType.VarChar, 50);
            FirstNameParam.Value = tmp[0];
            command.Parameters.Add(FirstNameParam);
            surnameParam.Value = tmp[1];
            command.Parameters.Add(surnameParam);
            journeyNameParam.Value = journeyName;
            command.Parameters.Add(journeyNameParam);

            command.Prepare();
            command.ExecuteNonQuery();
            connection.Close();

        }

    }
}
