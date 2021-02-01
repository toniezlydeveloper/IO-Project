using System.Collections.Generic;
using System.Linq;
using IO_Project.JourneyInteraction;
using IO_Project.ParticipantInteraction;

namespace IO_Project.Core
{
    public class Journal
    {
        private List<Journey> journeys = new List<Journey>();
        private List<Participant> participants = new List<Participant>();

        public Journal(List<Journey> journeys, List<Participant> participants)
        {
            this.journeys = journeys;
            this.participants = participants;
        }

        public List<Journey> getJourneys() {
            return this.journeys;
        }

        public void AddJourney(Journey journey)
        {
            journeys.Add(journey);
        }

        public Journey JourneyByName(string name)
        {
            return journeys.First(journey => journey.Name == name);
        }

       

        public void AddParticipant(Participant participant)
        {
            participants.Add(participant);
        }

        public Participant ParticipantByFullName(string fullName)
        {
            return participants.First(participant => participant.FullName == fullName);
        }
    }
}
