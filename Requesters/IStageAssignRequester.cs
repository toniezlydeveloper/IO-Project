using System;

namespace IO_Project.StageInteraction
{
    public interface IStageAssignRequester
    {
        void AssignStage(Action assignCallback, Action assignFailCallback);
    }
}
