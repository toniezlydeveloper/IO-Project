using System;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.IO
{
    abstract class ARequester
    {
        private RequestInteractor requestInteractor;

        public ARequester(RequestInteractor requestInteractor)
        {
            this.requestInteractor = requestInteractor;
        }

        protected void TryRequesting(RequestType requestType, Action operationCallback, Action operationFailCallback)
        {
            if (requestInteractor.IsBusy)
            {
                operationFailCallback?.Invoke();
            }
            else
            {
                IRequestConfigurationProvider configurationProvider =
                    RequestConfigurationProvidersFactory.ConfigurationProviderByType(requestType);
                requestInteractor.AssignOperationCallbacks(operationCallback, operationFailCallback);
                requestInteractor.PerformOperation(configurationProvider);
            }
        }
    }
}
