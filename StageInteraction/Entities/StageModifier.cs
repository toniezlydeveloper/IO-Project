using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.IO.Responses;
using IO_Project.JourneyInteraction;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.StageInteraction.Entities
{
    class StageModifier : AOperator
    {
        private IStageView modifiedView;
        private IStageView modificationView;
        private IJourneyView journeyView;
        private IRequestSender requestSender;

        public StageModifier(IStageView modificationView, IStageView modifiedView, IJourneyView journeyView)
        {
            this.modificationView = modificationView;
            this.modifiedView = modifiedView;
            this.journeyView = journeyView;
        }

        public override void TryPerformingOperation()
        {
            RequestStageStatus();
        }

        private void RequestStageStatus()
        {
            Request request = new RequestBuilder().OfType(RequestType.StageIsAssigned)
                .WithPayload(StageAssignmentStatusRequestPayload())
                .WithCallback(ProcessAssignmentStatus)
                .WithFailCallback(FinalizeFailedOperation).Build();
            requestSender.Send(request);
            IsBusy = true;
        }

        private void RequestStageModification()
        {
            Request request = new RequestBuilder().OfType(RequestType.ModifyStage)
                .WithPayload(StageAssignmentRequestPayload())
                .WithCallback(FinalizeOperation)
                .WithFailCallback(FinalizeFailedOperation).Build();
            requestSender.Send(request);
        }

        private StageAssignmentStatusPayload StageAssignmentStatusRequestPayload() =>
            new StageAssignmentStatusPayload(modificationView.Name, journeyView.Name);

        private StageModificationPayload StageAssignmentRequestPayload() => new StageModificationPayload(journeyView.Name,
            modifiedView.Name, modificationView.Name, modificationView.Description, modificationView.IconPath);

        private void ProcessAssignmentStatus(object response)
        {
            bool isAssigned = ((BinaryResponse)response).State;

            if (isAssigned)
            {
                FinalizeFailedOperation();
            }
            else
            {
                RequestStageModification();
            }
        }
    }
}
