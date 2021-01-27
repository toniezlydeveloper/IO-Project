using IO_Project.IO;
using IO_Project.IO.Payloads;

namespace IO_Project.Core.JournalModifiers
{
    class StageModifier : IJournalModifier
    {
        public RequestType HandledRequestType => RequestType.ModifyStage;

        private Journal journal;

        public StageModifier(Journal journal)
        {
            this.journal = journal;
        }

        public bool CanPerformModification(Request request)
        {
            var payload = (StageModificationPayload)request.Payload;
            var journey = journal.JourneyByName(payload.JourneyName);
            var stage = journey.StageByName(payload.NewName);
            return stage == default;
        }

        public void ModifyJournal(Request request)
        {
            var payload = (StageModificationPayload)request.Payload;
            var journey = journal.JourneyByName(payload.JourneyName);
            var stage = journey.StageByName(payload.OldName);
            stage.Name = payload.NewName;
            stage.Description = payload.Description;
            stage.IconPath = payload.IconPath;
        }
    }
}
