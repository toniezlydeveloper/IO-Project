using System;
using IO_Project.IO;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.ParticipantInteraction
{
    class ParticipantInteractor : AInteractor, IParticipantCreator, IParticipantAssigner
    {
        private AOperator participantCreator;
        private AOperator participantAssigner;

        public void AssignParitcipant(Action assignCallback, Action assignFailCallback)
        {
            TryPerformingOperation(participantAssigner, assignCallback, assignFailCallback);
        }

        public void CreateParticipant(Action creationCallback, Action creationFailCallback)
        {
            TryPerformingOperation(participantCreator, creationCallback, creationFailCallback);
        }
    }
}
