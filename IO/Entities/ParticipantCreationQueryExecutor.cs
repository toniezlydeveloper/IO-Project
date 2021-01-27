using IO_Project.IO.Payloads;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace IO_Project.IO.Entities
{
    class ParticipantCreationQueryExecutor : IQueryExecutor
    {
        private SqlConnection connection;

        public RequestType HandledRequestType => RequestType.CreateParticipant;
        public Type HandlePayloadType => typeof(ParticipantCreationPayload);

        public ParticipantCreationQueryExecutor(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void ExecuteQuery(Request request)
        {
            ParticipantCreationPayload payload = (ParticipantCreationPayload)request.Payload;
            addParticipantToDatabase(payload.FullName);

        }

        private void addParticipantToDatabase(string fullName)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(null, connection);
            string[] tmp = fullName.Split(' ');
            command.CommandText =
                    "INSERT INTO Participant (firstName,surname) " +
                    "VALUES (@firstName, @surname)";
            SqlParameter FirstNameParam = new SqlParameter("@firstName", SqlDbType.VarChar, 50);
            SqlParameter surnameParam = new SqlParameter("@surname", SqlDbType.VarChar, 50);
            FirstNameParam.Value = tmp[0];
            command.Parameters.Add(FirstNameParam);
            surnameParam.Value = tmp[1];
            command.Parameters.Add(surnameParam);

            command.Prepare();
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}
