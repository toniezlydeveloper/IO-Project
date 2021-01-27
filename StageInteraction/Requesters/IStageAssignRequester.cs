using System;

namespace IO_Project.StageInteraction
{
    interface IStageAssignRequester
    {
        void AssignStage(Action assignCallback, Action assignFailCallback);
    }
}
