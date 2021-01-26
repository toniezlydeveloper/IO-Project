namespace IO_Project.IO.Payloads
{
    class JourneyCreationPayload
    {
        public string Name { get; }
        public string Description { get; }
        public string Location { get; }
        public string Date { get; }

        public JourneyCreationPayload(string name, string description, string location, string date)
        {
            Name = name;
            Description = description;
            Location = location;
            Date = date;
        }
    }
}
