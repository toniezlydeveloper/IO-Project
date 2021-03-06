﻿using System;

namespace IO_Project.IO
{
    class Request
    {
        public Action FailCallback { get; set; }
        public Action Callback { get; set; }
        public RequestType Type { get; set; }
        public object Payload { get; set; }
    }
}
