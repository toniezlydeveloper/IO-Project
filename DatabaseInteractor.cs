using System;
using System.Data.SqlClient;
using IO_Project.Core;

namespace IO_Project
{
    class DatabaseInteractor
    {
        private SqlConnection connection;

        public DatabaseInteractor(SqlConnection connection)
        {
            this.connection = connection;
        }

        public Journal LoadJournal()
        {
            throw new NotImplementedException();
        }
    }
}
