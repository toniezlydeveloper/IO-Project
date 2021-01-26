namespace IO_Project.IO.Payloads
{
    class StageModificationPayload
    {
        public string JourneyName { get; }
        public string OldName { get; }
        public string NewName { get; }
        public string Description { get; }
        public string IconPath { get; }

        public StageModificationPayload(string journeyName, string oldName, string newName, string description, string iconPath)
        {
            JourneyName = journeyName;
            OldName = oldName;
            NewName = newName;
            Description = description;
            IconPath = iconPath;
        }
    }
}
