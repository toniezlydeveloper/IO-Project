using System;
using System.Collections.Generic;
using System.Text;
using IO_Project.IO;

namespace IO_Project.Core.QueryExecutors
{
    interface IQueryExecutor
    {
        RequestType HandledRequestType { get; }

        void ExecuteQuery(Request request);
    }
}
