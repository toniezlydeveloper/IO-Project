using System;
using System.Collections.Generic;
using IO_Project.JourneyInteraction;
using IO_Project.ParticipantInteraction;

namespace IO_Project.Core
{
    class Journal
    {
        private List<Journey> journeys = new List<Journey>();

        public void AddJourney(Journey journey)
        {
            journeys.Add(journey);
        }

        public Journey JourneyByName(string name)
        {
            throw new NotImplementedException();
        }

        public void AddParticipant(Participant participant)
        {
            throw new NotImplementedException();
        }

        public void AssignParticipantToJourney(Participant participant, Journey journey)
        {
        }

        internal object ParticipantByFullName(string participantFullName)
        {
            throw new NotImplementedException();
        }
    }
}
