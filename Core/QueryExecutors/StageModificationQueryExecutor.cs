using System.Data;
using IO_Project.Core.QueryExecutors;
using IO_Project.IO.Payloads;

namespace IO_Project.IO.Entities
{
    class StageModificationQueryExecutor : IQueryExecutor
    {
        private SqlConnection connection;

        public RequestType HandledRequestType => RequestType.ModifyStage;

        public StageModificationQueryExecutor(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void ExecuteQuery(Request request)
        {
            StageModificationPayload payload = (StageModificationPayload)request.Payload;
            modifyStageInDatabase(payload.JourneyName, payload.OldName, payload.NewName, payload.Description, payload.IconPath);
        }

        private void modifyStageInDatabase(string journeyName, string oldName, string newName, string description, string iconPath)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(null, connection);

            command.CommandText =
                "UPDATE Stage SET Title = @newName, Description = @description, iconPath=@iconPath " +
                "WHERE (Title = @oldName AND Trip = (SELECT MAX(id) FROM Trip where Name = @jName))";
            SqlParameter newNameParam = new SqlParameter("@newName", SqlDbType.VarChar, 40);
            SqlParameter oldNameParam = new SqlParameter("@oldName", SqlDbType.VarChar, 40);
            SqlParameter descParam = new SqlParameter("@description", SqlDbType.VarChar, 500);
            SqlParameter iconPathParam = new SqlParameter("@iconPath", SqlDbType.VarChar, 250);
            SqlParameter jNameParam = new SqlParameter("@jName", SqlDbType.VarChar, 40);

            newNameParam.Value = newName;
            command.Parameters.Add(newNameParam);
            oldNameParam.Value = oldName;
            command.Parameters.Add(oldNameParam);
            descParam.Value = description;
            command.Parameters.Add(descParam);
            iconPathParam.Value = iconPath;
            command.Parameters.Add(iconPathParam);
            jNameParam.Value = journeyName;
            command.Parameters.Add(jNameParam);


            command.Prepare();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
