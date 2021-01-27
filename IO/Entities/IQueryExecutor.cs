using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Project.IO.Entities
{
    interface IQueryExecutor
    {
        RequestType HandledRequestType { get; }
        Type HandlePayloadType { get; }

        void ExecuteQuery(Request request);
    }
}
