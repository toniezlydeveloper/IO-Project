using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.IO.Responses;

namespace IO_Project.JourneyInteraction.Entities
{
    class JourneyCreator : AOperator
    {
        private IJourneyView creationView;

        protected override RequestType HandledRequestType => RequestType.CreateJourney;
        protected override object Payload => new JourneyCreationPayload(creationView.Name,
            creationView.Description, creationView.Location, creationView.Date);

        public JourneyCreator(IRequestSender requestSender, IJourneyView journeyView)
            : base(requestSender)
        {
            this.creationView = journeyView;
        }
    }
}
