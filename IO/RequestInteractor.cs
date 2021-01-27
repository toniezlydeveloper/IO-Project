﻿using System;
using IO_Project.IO;

namespace IO_Project.JourneyInteraction.Entities
{
    class RequestInteractor
    {
        private IRequestSender requestSender;

        protected Action operationCallback;
        protected Action operationFailCallback;

        public bool IsBusy { get; private set; }

        public RequestInteractor(IRequestSender requestSender)
        {
            this.requestSender = requestSender;
        }

        public void AssignOperationCallbacks(Action operationCallback, Action operationFailCallback)
        {
            this.operationCallback = operationCallback;
            this.operationFailCallback = operationFailCallback;
        }

        public void PerformOperation(IRequestConfigurationProvider configurationProvider)
        {
            Request request = new RequestBuilder().OfType(configurationProvider.HandledRequestType)
                .WithPayload(configurationProvider.Payload)
                .WithCallback(FinalizeOperation)
                .WithFailCallback(FinalizeFailedOperation)
                .Build();
            requestSender.Send(request);
            IsBusy = true;
        }

        private void FinalizeOperation()
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
