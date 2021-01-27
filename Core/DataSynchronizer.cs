using System;
using System.Collections.Generic;
using System.Text;
using IO_Project.IO;

namespace IO_Project.Core
{
    class DataSynchronizer : IRequestProcesssor
    {
        public void Process(Request request)
        {
            if (IsRequestValid(request))
            {
                ExecuteRequest(request);
            }
            else
            {
                FailRequest(request);
            }
        }

        private bool IsRequestValid(Request request)
        {
            var validator = RequestValidatorsFactory.RequestValidatorByType(request.Type);
            return validator.IsRequestValid(request);
        }

        private void ExecuteRequest(Request request)
        {
            ModifyJournal(request);
            SynchronizeWithDatabase(request);
        }

        private void ModifyJournal(Request request)
        {
            var modifier = JournalModifiersFactory.JournalModifierByType(request.Type);
            modifier.ModifyJournal(request);
        }

        private void SynchronizeWithDatabase(Request request)
        {
            var executor = QueryExecutorsFactory.QueryExecutorByType(request.Type);
            executor.ExecuteQuery(request);
        }

        private void FailRequest(Request request)
        {
            request.FailCallback?.Invoke();
        }
    }
}
