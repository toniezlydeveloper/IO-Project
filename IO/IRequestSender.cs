using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Project.IO
{
    interface IRequestSender
    {
        void Send(Request request);
    }
}
