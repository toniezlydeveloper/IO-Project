using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Project.IO.Payloads
{
    class CreateParticipantPayload
    {
        public string Name { get; }
        public string Surname { get; }

        public CreateParticipantPayload(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
