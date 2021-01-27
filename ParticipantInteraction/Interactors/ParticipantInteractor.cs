using System;
using IO_Project.IO;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.ParticipantInteraction
{
    class ParticipantInteractor : AInteractor, IParticipantCreator, IParticipantAssigner
    {
        public ParticipantInteractor(RequestInteractor requestInteractor)
            : base(requestInteractor)
        {
        }

        public void AssignParitcipant(Action assignCallback, Action assignFailCallback)
        {
            TryInteracting(RequestType.AssignParticipant, assignCallback, assignFailCallback);
        }

        public void CreateParticipant(Action creationCallback, Action creationFailCallback)
        {
            TryInteracting(RequestType.CreateParticipant, creationCallback, creationFailCallback);
        }
    }
}
