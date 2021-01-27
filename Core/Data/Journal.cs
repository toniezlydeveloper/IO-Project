using System;
using System.Collections.Generic;
using System.Text;
using IO_Project.JourneyInteraction;
using IO_Project.ParticipantInteraction;
using IO_Project.StageInteraction;

namespace IO_Project.Core
{
    class Journal
    {
        private List<Journey> journeys = new List<Journey>();

        public bool CanAddJourney(Journey journey)
        {
            return false;
        }

        public void AddJourney(Journey journey)
        {
            journeys.Add(journey);
        }

        public bool CanAddStageToJourney(Stage stage, Journey journey)
        {
            return false;
        }

        public void AssignStageToJourney(Stage stage, Journey journey)
        {
            
        }

        public bool CanAssignParticipantToJourney(Participant participant, Journey journey)
        {
            return false;
        }

        public void AssignParticipantToJourney(Participant participant, Journey journey)
        {
        }
    }
}
