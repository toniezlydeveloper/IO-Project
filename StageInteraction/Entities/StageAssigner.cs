using System;
using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.IO.Responses;
using IO_Project.JourneyInteraction;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.StageInteraction.Entities
{
    class StageAssigner : AOperator
    {
        private IStageView stageView;
        private IJourneyView journeyView;
        private IRequestSender requestSender;

        public StageAssigner(IStageView stageView, IJourneyView journeyView)
        {
            this.stageView = stageView;
            this.journeyView = journeyView;
        }

        public override void TryPerformingOperation()
        {
            if (!IsViewValid())
            {
                return;
            }

            RequestStageStatus();
        }

        private bool IsViewValid()
        {
            return new StageSetupValidator(stageView).IsViewValid();
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

        private void RequestStageAssignment()
        {
            Request request = new RequestBuilder().OfType(RequestType.AssignStage)
                .WithPayload(StageAssignmentRequestPayload())
                .WithCallback(FinalizeOperation)
                .WithFailCallback(FinalizeFailedOperation).Build();
            requestSender.Send(request);
        }

        private StageAssignmentStatusPayload StageAssignmentStatusRequestPayload() => new StageAssignmentStatusPayload(stageView.Name,
            journeyView.Name);

        private StageAssignmentPayload StageAssignmentRequestPayload() => new StageAssignmentPayload(journeyView.Name,
            stageView.Name, stageView.Description, stageView.IconPath);

        private void ProcessAssignmentStatus(object response)
        {
            bool isAssigned = ((BinaryResponse)response).State;

            if (isAssigned)
            {
                FinalizeFailedOperation();
            }
            else
            {
                RequestStageAssignment();
            }
        }
    }
}
