namespace IO_Project.JourneyInteraction
{
    interface IJourneyView
    {
        public string Name { get; }
        public string Description { get; }
        public string Location { get; }
        public string Date { get; }
    }
}
