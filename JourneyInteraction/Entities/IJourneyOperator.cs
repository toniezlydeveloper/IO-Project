using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Project.JourneyInteraction.Entities
{
    interface IJourneyOperator
    {
        bool IsBusy { get; }

        void AssignOperationCallbacks(Action operationCallback, Action operationFailCallback);
        void TryPerformingOperation();
    }
}
