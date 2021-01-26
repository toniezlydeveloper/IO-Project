namespace IO_Project.IO.Payloads
{
    class StageAssignmentPayload
    {
        public string JourneyName { get; set; }
        public string StageName { get; set; }
        public string Description { get; set; }
        public string IconPath { get; set; }

        public StageAssignmentPayload(string journeyName, string stageName, string description, string iconPath)
        {
            JourneyName = journeyName;
            StageName = stageName;
            Description = description;
            IconPath = iconPath;
        }
    }
}
