using System.Collections.Generic;

namespace IO_Project.ParticipantInteraction
{
    interface IParticipantPresenter
    {
        void PresentParticipantSet(List<Participant> participants);
    }
}