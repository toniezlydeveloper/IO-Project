using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.ParticipantInteraction;

namespace IO_Project.Core.JournalModifiers
{
    class ParticipantAssigner : IJournalModifier
    {
        public RequestType HandledRequestType => RequestType.AssignParticipant;

        private Journal journal;

        public ParticipantAssigner(Journal journal)
        {
            this.journal = journal;
        }

        public bool CanPerformModification(Request request)
        {
            var payload = (ParticipantAssignmentPayload)request.Payload;
            var journey = journal.JourneyByName(payload.JourneyName);
            var participant = journal.ParticipantByFullName(payload.ParticipantFullName);
            return participant == default;
        }

        public void ModifyJournal(Request request)
        {
            var payload = (ParticipantAssignmentPayload)request.Payload;
            var journey = journal.JourneyByName(payload.JourneyName);
            var participant = new Participant(payload.ParticipantFullName);
            journal.AssignParticipantToJourney(participant, journey);
        }
    }
}
