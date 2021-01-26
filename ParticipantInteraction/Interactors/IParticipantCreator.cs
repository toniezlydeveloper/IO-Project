using System;

namespace IO_Project.ParticipantInteraction
{
    interface IParticipantCreator
    {
        void CreateParticipant(Action creationCallback, Action creationFailCallback);
    }
}
