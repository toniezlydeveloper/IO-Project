namespace IO_Project.IO.Payloads
{
    class ParticipantAssignmentPayload
    {
        public string JourneyName { get; }
        public string ParticipantFullName { get; }

        public ParticipantAssignmentPayload(string journeyName, string participantFullName)
        {
            JourneyName = journeyName;
            ParticipantFullName = participantFullName;
        }
    }
}
