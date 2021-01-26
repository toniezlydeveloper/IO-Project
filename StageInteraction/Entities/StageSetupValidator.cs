using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Project.StageInteraction.Entities
{
    class StageSetupValidator
    {
        private IStageView stageView;
        
        public StageSetupValidator(IStageView stageView)
        {
            this.stageView = stageView;
        }

        public bool IsViewValid()
        {
            return true;
        }
    }
}
