﻿using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.JourneyInteraction;

namespace IO_Project.Core.JournalModifiers
{
    class JourneyCreator : IJournalModifier
    {
        public RequestType HandledRequestType => RequestType.CreateJourney;

        private Journal journal;

        public JourneyCreator(Journal journal)
        {
            this.journal = journal;
        }

        public bool CanPerformModification(Request request)
        {
            var payload = (JourneyCreationPayload)request.Payload;
            var journey = journal.JourneyByName(payload.Name);
            return journey == default;
        }

        public void ModifyJournal(Request request)
        {
            var payload = (JourneyCreationPayload)request.Payload;
            var journey = new Journey(payload.Name, payload.Description, payload.Date);
            journal.AddJourney(journey);
        }
    }
}
