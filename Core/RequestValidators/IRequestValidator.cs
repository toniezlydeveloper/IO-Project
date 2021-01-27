using System;
using System.Collections.Generic;
using System.Text;
using IO_Project.IO;

namespace IO_Project.Core.RequestValidators
{
    interface IRequestValidator
    {
        RequestType HandledRequestType { get; }

        bool IsRequestValid(Request request);
    }
}
