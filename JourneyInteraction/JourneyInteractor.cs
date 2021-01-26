using System;
using IO_Project.IO;
using IO_Project.IO.Payloads;

namespace IO_Project.JourneyInteraction
{
    class JourneyInteractor : IJourneyCreator
    {
        private IJourneyView creationView;
        private IRequestSender requestSender;

        public void CreateJourney(Action creationCallback, Action creationFailCallback)
        {
            if (!IsSetupValid())
            {
                return;
            }

            Request request = new RequestBuilder().OfType(RequestType.CreateJourney)
                .WithPayload(GetPayload())
                .WithCallback(creationCallback)
                .WithFailCallback(creationFailCallback).Build();
            requestSender.Send(request);
        }

        private CreateJourneyPayload GetPayload()
        {
            return new CreateJourneyPayload(creationView.Name, creationView.Description, creationView.Location, creationView.Date);
        }

        private bool IsSetupValid()
        {
            return IsNameValid() && IsDescriptionValid() && IsLocationValid() && IsDateValid();
        }

        private bool IsNameValid()
        {
            return !string.IsNullOrEmpty(creationView.Name);
        }

        private bool IsDescriptionValid()
        {
            return !string.IsNullOrEmpty(creationView.Description);
        }

        private bool IsLocationValid()
        {
            return !string.IsNullOrEmpty(creationView.Date);
        }

        private bool IsDateValid()
        {
            return !string.IsNullOrEmpty(creationView.Location);
        }
    }
}
