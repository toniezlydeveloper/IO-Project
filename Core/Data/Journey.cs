using System;
using System.Collections.Generic;
using IO_Project.ParticipantInteraction;
using IO_Project.StageInteraction;

namespace IO_Project.JourneyInteraction
{
    class Journey
    {
        private List<Stage> stages { get; } = new List<Stage>();
        private List<Participant> participantNames { get; } = new List<Participant>();

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

        public Stage StageByName(string oldName)
        {
            throw new NotImplementedException();
        }

        public void AddStage(Stage stage)
        {
            throw new NotImplementedException();
        }
    }
}
