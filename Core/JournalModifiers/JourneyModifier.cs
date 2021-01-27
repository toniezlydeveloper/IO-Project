using System;
using System.Collections.Generic;
using System.Text;
using IO_Project.IO;
using IO_Project.IO.Payloads;

namespace IO_Project.Core.JournalModifiers
{
    class JourneyModifier : IJournalModifier
    {
        public RequestType HandledRequestType => RequestType.ModifyJourney;

        private Journal journal;

        public JourneyModifier(Journal journal)
        {
            this.journal = journal;
        }

        public bool CanPerformModification(Request request)
        {
            throw new NotImplementedException();
        }

        public void ModifyJournal(Request request)
        {
            var payload = (JourneyModificationPayload)request.Payload;
            var journey = journal.JourneyByName(payload.OldName);
            journey.Name = payload.NewName;
            journey.Description = payload.NewDescription;
            journey.Date = payload.NewDate;
        }
    }
}
