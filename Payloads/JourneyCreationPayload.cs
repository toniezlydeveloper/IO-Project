namespace IO_Project.IO.Payloads
{
    class JourneyCreationPayload
    {
        public string Name { get; }
        public string Description { get; }
        public string Date { get; }

        public JourneyCreationPayload(string name, string description, string date)
        {
            Name = name;
            Description = description;
            Date = date;
        }
    }
}
