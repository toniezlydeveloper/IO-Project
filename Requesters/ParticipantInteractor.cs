using System;
using IO_Project.IO;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.ParticipantInteraction
{
    class ParticipantInteractor : ARequester, IParticipantCreationRequester, IParticipantAssignRequester
    {
        public ParticipantInteractor(RequestInteractor requestInteractor)
            : base(requestInteractor)
        {
        }

        public void AssignParitcipant(Action assignCallback, Action assignFailCallback)
        {
            TryRequesting(RequestType.AssignParticipant, assignCallback, assignFailCallback);
        }

        public void CreateParticipant(Action creationCallback, Action creationFailCallback)
        {
            TryRequesting(RequestType.CreateParticipant, creationCallback, creationFailCallback);
        }
    }
}
