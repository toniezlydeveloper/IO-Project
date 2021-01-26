using System;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.IO
{
    abstract class AInteractor
    {
        private RequestOperator requestOperator;

        public AInteractor(RequestOperator requestOperator)
        {
            this.requestOperator = requestOperator;
        }

        protected void TryInteracting(RequestType requestType, Action operationCallback, Action operationFailCallback)
        {
            if (requestOperator.IsBusy)
            {
                operationFailCallback?.Invoke();
            }
            else
            {
                IRequestConfigurationProvider configurationProvider =
                    RequestConfigurationProvidersFactory.ConfigurationProviderByType(requestType);
                requestOperator.AssignOperationCallbacks(operationCallback, operationFailCallback);
                requestOperator.PerformOperation(configurationProvider);
            }
        }
    }
}
