using System;

namespace IO_Project.IO
{
    class RequestBuilder
    {
        private Request request = new Request();

        public Request Build()
        {
            return request;
        }

        public RequestBuilder OfType(RequestType type)
        {
            request.Type = type;
            return this;
        }

        public RequestBuilder WithPayload(object payload)
        {
            request.Payload = payload;
            return this;
        }

        public RequestBuilder WithCallback(Action<object> callback)
        {
            request.Callback = callback;
            return this;
        }

        public RequestBuilder WithFailCallback(Action failCallback)
        {
            request.FailCallback = failCallback;
            return this;
        }
    }
}
