using IO_Project.IO;
using IO_Project.IO.Payloads;

namespace IO_Project.JourneyInteraction.Entities
{
    class JourneyModifier : AOperator
    {
        private IJourneyView modifiedView;
        private IJourneyView modificationView;
        private IRequestSender requestSender;

        public JourneyModifier(IJourneyView modifiedView, IJourneyView modificationView, IRequestSender requestSender)
        {
            this.modifiedView = modifiedView;
            this.modificationView = modificationView;
            this.requestSender = requestSender;
        }

        public override void TryPerformingOperation()
        {
            RequestJourneyModification();
        }

        private void RequestJourneyModification()
        {
            Request request = new RequestBuilder().OfType(RequestType.ModifyJourney)
                .WithPayload(RequestModificationPayload())
                .WithCallback(FinalizeOperation)
                .WithFailCallback(FinalizeFailedOperation).Build();
            requestSender.Send(request);
            IsBusy = true;
        }

        private JourneyModificationPayload RequestModificationPayload() => new JourneyModificationPayload(modifiedView.Name,
            modificationView.Name, modificationView.Description, modificationView.Location, modificationView.Date);
    }
}
