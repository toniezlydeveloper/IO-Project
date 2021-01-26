using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Project.Journey
{
    interface IJourneyCreationView
    {
        string Description { get; }
        string Location { get; }
        string Date { get; }
    }
}
