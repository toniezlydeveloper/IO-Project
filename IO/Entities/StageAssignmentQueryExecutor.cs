using IO_Project.IO.Payloads;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace IO_Project.IO.Entities
{
    class StageAssignmentQueryExecutor : IQueryExecutor
    {
        private SqlConnection connection;

        public RequestType HandledRequestType => RequestType.AssignStage;
        public Type HandlePayloadType => typeof(StageAssignmentPayload);

        public StageAssignmentQueryExecutor(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void ExecuteQuery(Request request)
        {
            StageAssignmentPayload payload = (StageAssignmentPayload)request.Payload;
            addStageToDatabase(payload.JourneyName, payload.StageName, payload.Description, payload.IconPath);
        }

       
        private void addStageToDatabase(string journeyName, string stageName, string description, string iconPath)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(null, connection);
            command.CommandText =
                    "INSERT INTO Stage  (Description, Title, IconPath) " +
                    "VALUES (@desc, @title, @iconPath)";

            SqlParameter DescParam = new SqlParameter("@desc", SqlDbType.VarChar, 500);
            SqlParameter titleParam = new SqlParameter("@title", SqlDbType.VarChar, 40);
            SqlParameter iconPathParam = new SqlParameter("@iconPath", SqlDbType.VarChar, 250);
            DescParam.Value = description;
            command.Parameters.Add(DescParam);
            titleParam.Value = stageName;
            command.Parameters.Add(titleParam);
            iconPathParam.Value = iconPath;
            command.Parameters.Add(iconPathParam);

            command.Prepare();
            command.ExecuteNonQuery();
            connection.Close();
            connectStageToJourney(journeyName, stageName);
        }

        private void connectStageToJourney(string journeyName, string stageName)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(null, connection);
            command.CommandText =
                    "UPDATE Stage " +
                    "SET Trip = (SELECT  MAX(id) FROM Trip where Name = @jName) " +
                    "WHERE Title = @sName";
            SqlParameter jNameParam = new SqlParameter("@jName", SqlDbType.VarChar, 40);
            SqlParameter sNameParam = new SqlParameter("@sName", SqlDbType.VarChar, 40);

            jNameParam.Value = journeyName;
            command.Parameters.Add(jNameParam);
            sNameParam.Value = stageName;
            command.Parameters.Add(sNameParam);
            command.Prepare();
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}

