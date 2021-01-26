using System;

namespace IO_Project.ParticipantInteraction
{
    interface IParticipantAssigner
    {
        void AssignParitcipant(Action assignCallback, Action assignFailCallback);
    }
}
