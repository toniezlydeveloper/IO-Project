namespace IO_Project.IO.Payloads
{
    class JourneyModificationPayload
    {
        public string OldName { get; }
        public string NewName { get; }
        public string NewDescription { get; }
        public string NewDate { get; }

        public JourneyModificationPayload(string oldName, string newName, string description, string date)
        {
            OldName = oldName;
            NewName = newName;
            NewDescription = description;
            NewDate = date;
        }
    }
}
