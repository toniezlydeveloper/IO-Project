using System;

namespace IO_Project.ParticipantInteraction
{
    public interface IParticipantAssignRequester
    {
        void AssignParticipant(Action assignCallback, Action assignFailCallback);
    }
}
