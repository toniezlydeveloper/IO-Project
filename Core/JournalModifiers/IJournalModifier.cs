using System;
using System.Collections.Generic;
using System.Text;
using IO_Project.IO;

namespace IO_Project.Core
{
    interface IJournalModifier
    {
        RequestType HandledRequestType { get; }

        void ModifyJournal(Request request);
    }
}
