using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Project.IO.Payloads
{
    class CreateJourneyPayload
    {
        public string Name { get; }
        public string Description { get; }
        public string Location { get; }
        public string Date { get; }

        public CreateJourneyPayload(string name, string description, string location, string date)
        {
            Name = name;
            Description = description;
            Location = location;
            Date = date;
        }
    }
}
