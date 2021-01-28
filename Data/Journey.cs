using System.Collections.Generic;
using System.Linq;
using IO_Project.ParticipantInteraction;
using IO_Project.StageInteraction;

namespace IO_Project.JourneyInteraction
{
    class Journey
    {
        private List<Stage> stages { get; } = new List<Stage>();
        private List<Participant> participants { get; } = new List<Participant>();

        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }

        public Journey(string name, string description, string date)
        {
            Name = name;
            Description = description;
            Date = date;
        }

        public Stage StageByName(string name)
        {
            return stages.First(stage => stage.Name == name);
        }

        public void AddStage(Stage stage)
        {
            stages.Add(stage);
        }

        public void AddStages(List<Stage> stages)
        {
            stages.AddRange(stages);
        }

        public void AssignParticipant(Participant participant)
        {
            participants.Add(participant);
        }
        public void AssignParticipants(List<Participant> participants)
        {
            participants.AddRange(participants);
        }
    }
}
