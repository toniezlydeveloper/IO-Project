using System;
using IO_Project.IO;
using IO_Project.IO.Payloads;
using IO_Project.JourneyInteraction;

namespace IO_Project.ParticipantInteraction
{
    class ParticipantInteractor : IParticipantCreator, IParticipantAssigner
    {
        private IJourneyView journeyView;
        private IRequestSender requestSender;
        private IParticipantView participantView;

        public void AssignParitcipant(Action assignCallback, Action assignFailCallback)
        {
            if (!IsSetupValid())
            {
                return;
            }
        }

        public void CreateParticipant(Action creationCallback, Action creationFailCallback)
        {
        }

        private bool IsSetupValid()
        {
            return true;
        }
    }
}
