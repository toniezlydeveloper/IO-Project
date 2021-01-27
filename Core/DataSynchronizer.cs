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
            if (CanProcessRequest(request))
            {
                ExecuteRequest(request);
            }
            else
            {
                InformAboutRequestFail(request);
            }
        }

        private bool CanProcessRequest(Request request)
        {
            var modifier = JournalModifiersFactory.JournalModifierByType(request.Type);
            return modifier.CanPerformModification(request);
        }

        private void ExecuteRequest(Request request)
        {
            ModifyJournal(request);
            SynchronizeWithDatabase(request);
            InformAboutRequestSuccess(request);
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

        private void InformAboutRequestSuccess(Request request)
        {
            request.Callback?.Invoke();
        }

        private void InformAboutRequestFail(Request request)
        {
            request.FailCallback?.Invoke();
        }
    }
}
