using System;

namespace IO_Project.StageInteraction
{
    interface IStageModificationRequester
    {
        void ModifyStage(Action modificationCallback, Action modificationFailCallback);
    }
}
