using System;

namespace IO_Project.ParticipantInteraction
{
    public interface IParticipantCreationRequester
    {
        void CreateParticipant(Action creationCallback, Action creationFailCallback);
    }
}
