using System;
using IO_Project.IO;
using IO_Project.JourneyInteraction.Entities;

namespace IO_Project.StageInteraction
{
    class StageInteractor : ARequester, IStageAssignRequester, IStageModificationRequester
    {
        public StageInteractor(RequestInteractor requestInteractor)
            : base(requestInteractor)
        {
        }

        public void AssignStage(Action assignCallback, Action assignFailCallback)
        {
            TryRequesting(RequestType.AssignStage, assignCallback, assignFailCallback);
        }

        public void ModifyStage(Action modificationCallback, Action modificationFailCallback)
        {
            TryRequesting(RequestType.ModifyStage, modificationCallback, modificationFailCallback);
        }
    }
}
