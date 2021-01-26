using System;

namespace IO_Project.StageInteraction
{
    interface IStageAssigner
    {
        void AssignStage(Action assignCallback, Action assignFailCallback);
    }
}
