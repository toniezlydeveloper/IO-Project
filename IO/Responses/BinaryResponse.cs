using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Project.IO.Responses
{
    class BinaryResponse
    {
        public bool State { get; }

        public BinaryResponse(bool state)
        {
            State = state;
        }
    }
}
