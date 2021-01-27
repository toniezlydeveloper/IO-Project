using System;
using System.Collections.Generic;
using System.Text;
using IO_Project.IO;

namespace IO_Project.Core
{
    interface IJournalModifier
    {
        RequestType HandledRequestType { get; }

        bool CanPerformModification(Request request);
        void ModifyJournal(Request request);
    }
}
