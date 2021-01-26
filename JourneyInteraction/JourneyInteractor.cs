using System;
using IO_Project.IO;

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

            Request request = new RequestBuilder().OfType(RequestType.JourneyWithNameExists)
                .WithPayload(creationView.Name)
                .WithCallback(response => ProcessResponse((bool)response, creationCallback, creationFailCallback))
                .WithFailCallback(creationFailCallback).Build();
            requestSender.Send(request);
        }

        private void ProcessResponse(bool journeyExists, Action creationCallback, Action creationFailCallback)
        {
            if (journeyExists)
            {
                creationFailCallback?.Invoke();
            }
            else
            {
                creationCallback?.Invoke();
            }
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
