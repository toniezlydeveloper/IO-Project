namespace IO_Project.IO.Payloads
{
    class StageAssignmentStatusPayload
    {
        public string StageName { get; }
        public string JourneyName { get; }

        public StageAssignmentStatusPayload(string stageName, string journeyName)
        {
            StageName = stageName;
            JourneyName = journeyName;
        }
    }
}
