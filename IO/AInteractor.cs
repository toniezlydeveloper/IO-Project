using System;
using System.Collections.Generic;
using System.Text;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.IO
{
    abstract class AInteractor
    {
        protected void TryPerformingOperation(AOperator journeyOperator, Action operationCallback, Action operationFailCallback)
        {
            if (journeyOperator.IsBusy)
            {
                operationFailCallback?.Invoke();
            }
            else
            {
                journeyOperator.AssignOperationCallbacks(operationCallback, operationFailCallback);
                journeyOperator.TryPerformingOperation();
            }
        }
    }
}
