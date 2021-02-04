using System;

namespace IO_Project.StageInteraction
{
    public interface IStageModificationRequester
    {
        void ModifyStage(Action modificationCallback, Action modificationFailCallback);
    }
}
