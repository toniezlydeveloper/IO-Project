using System;
using System.Collections.Generic;
using System.Text;
using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.ParticipantInteraction;

namespace IO_Project.Core.JournalModifiers
{
    class ParticipantCreator : IJournalModifier
    {
        public RequestType HandledRequestType => RequestType.CreateParticipant;

        private Journal journal;

        public bool CanPerformModification(Request request)
        {
            throw new NotImplementedException();
        }

        public void ModifyJournal(Request request)
        {
            var payload = (ParticipantCreationPayload)request.Payload;
            var participant = new Participant(payload.FullName);
            journal.AddParticipant(participant);
        }
    }
}
