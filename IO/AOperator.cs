using System;
using IO_Project.IO;

namespace IO_Project.JourneyInteraction.Entities
{
    abstract class AOperator
    {
        private IRequestSender requestSender;
        protected Action operationCallback;
        protected Action operationFailCallback;

        protected abstract RequestType HandledRequestType { get; }
        protected abstract object Payload { get; }
        public bool IsBusy { get; private set; }

        public AOperator(IRequestSender requestSender)
        {
            this.requestSender = requestSender;
        }

        public void AssignOperationCallbacks(Action operationCallback, Action operationFailCallback)
        {
            this.operationCallback = operationCallback;
            this.operationFailCallback = operationFailCallback;
        }

        public void TryPerformingOperation()
        {
            Request request = new RequestBuilder().OfType(HandledRequestType)
                .WithPayload(Payload)
                .WithCallback(FinalizeOperation)
                .WithFailCallback(FinalizeFailedOperation)
                .Build();
            requestSender.Send(request);
        }

        private void FinalizeOperation(object response)
        {
            operationCallback?.Invoke();
            IsBusy = false;
        }

        private void FinalizeFailedOperation()
        {
            operationFailCallback?.Invoke();
            IsBusy = false;
        }
    }
}
