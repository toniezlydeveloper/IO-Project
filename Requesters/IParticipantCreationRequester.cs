using System;

namespace IO_Project.ParticipantInteraction
{
    interface IParticipantCreationRequester
    {
        void CreateParticipant(Action creationCallback, Action creationFailCallback);
    }
}
