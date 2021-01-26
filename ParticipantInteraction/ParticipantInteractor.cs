using System;
using IO_Project.JourneyInteraction;

namespace IO_Project.ParticipantInteraction
{
    class ParticipantInteractor : IParticipantCreator
    {
        private IJourneyView journeyView;
        private IParticipantView participantView;

        public void CreateParticipant(Action creationCallback, Action creationFailCallback)
        {
        }
    }
}
