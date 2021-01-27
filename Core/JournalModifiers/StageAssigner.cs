using System;
using System.Collections.Generic;
using System.Text;
using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.StageInteraction;

namespace IO_Project.Core.JournalModifiers
{
    class StageAssigner : IJournalModifier
    {
        public RequestType HandledRequestType => RequestType.AssignStage;

        private Journal journal;

        public bool CanPerformModification(Request request)
        {
            throw new NotImplementedException();
        }

        public void ModifyJournal(Request request)
        {
            var payload = (StageAssignmentPayload)request.Payload;
            var journey = journal.JourneyByName(payload.JourneyName);
            var stage = new Stage(payload.StageName, payload.Description, payload.IconPath);
            journey.AddStage(stage);
        }
    }
}
