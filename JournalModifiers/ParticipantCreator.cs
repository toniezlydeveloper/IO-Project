using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.ParticipantInteraction;

namespace IO_Project.Core.JournalModifiers
{
    class ParticipantCreator : IJournalModifier
    {
        public RequestType HandledRequestType => RequestType.CreateParticipant;

        private Journal journal;

        public ParticipantCreator(Journal journal)
        {
            this.journal = journal;
        }

        public bool CanPerformModification(Request request)
        {
            var payload = (ParticipantCreationPayload)request.Payload;
            var participant = journal.ParticipantByFullName(payload.FullName);
            return participant == default;
        }

        public void ModifyJournal(Request request)
        {
            var payload = (ParticipantCreationPayload)request.Payload;
            var participant = new Participant(payload.FullName);
            journal.AddParticipant(participant);
        }
    }
}
