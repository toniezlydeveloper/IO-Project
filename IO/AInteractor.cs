using System;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.IO
{
    abstract class AInteractor
    {
        private RequestInteractor requestInteractor;

        public AInteractor(RequestInteractor requestInteractor)
        {
            this.requestInteractor = requestInteractor;
        }

        protected void TryInteracting(RequestType requestType, Action operationCallback, Action operationFailCallback)
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
