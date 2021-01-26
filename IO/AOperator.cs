using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Project.JourneyInteraction.Entities
{
    abstract class AOperator
    {
        protected Action operationCallback;
        protected Action operationFailCallback;

        public bool IsBusy { get; protected set; }

        public void AssignOperationCallbacks(Action operationCallback, Action operationFailCallback)
        {
            this.operationCallback = operationCallback;
            this.operationFailCallback = operationFailCallback;
        }

        public abstract void TryPerformingOperation();

        protected void FinalizeOperation(object response)
        {
            operationCallback?.Invoke();
            IsBusy = false;
        }

        protected void FinalizeFailedOperation()
        {
            operationFailCallback?.Invoke();
            IsBusy = false;
        }
    }
}
