using System;

namespace IO_Project.ParticipantInteraction
{
    interface IParticipantAssignRequester
    {
        void AssignParitcipant(Action assignCallback, Action assignFailCallback);
    }
}
