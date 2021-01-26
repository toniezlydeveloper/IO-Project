using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Project.IO
{
    class Request
    {
        public Action<object> Callback { get; set; }
        public Action FailCallback { get; set; }
        public RequestType Type { get; set; }
        public object Payload { get; set; }
    }
}
