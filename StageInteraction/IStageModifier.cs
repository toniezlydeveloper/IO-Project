using System;

namespace IO_Project.StageInteraction
{
    interface IStageModifier
    {
        void ModifyStage(Action modificationCallback, Action modificationFailCallback);
    }
}
