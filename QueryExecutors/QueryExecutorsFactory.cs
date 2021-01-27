using System.Collections.Generic;
using IO_Project.Core.QueryExecutors;
using IO_Project.IO;

namespace IO_Project.Core
{
    static class QueryExecutorsFactory
    {
        private static Dictionary<RequestType, IQueryExecutor> executorsByType =
            new Dictionary<RequestType, IQueryExecutor>();

        public static void RegisterQueryExecutor(IQueryExecutor journalModifier)
        {
            if (executorsByType.ContainsKey(journalModifier.HandledRequestType))
            {
                return;
            }

            executorsByType.Add(journalModifier.HandledRequestType, journalModifier);
        }

        public static IQueryExecutor QueryExecutorByType(RequestType requestType)
        {
            if (executorsByType.TryGetValue(requestType, out var modifier))
            {
                return modifier;
            }

            return default;
        }
    }
}
