using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Project.JourneyInteraction.Entities
{
    class JourneySetupValidator
    {
        private IJourneyView journeyView;

        public JourneySetupValidator(IJourneyView journeyView)
        {
            this.journeyView = journeyView;
        }

        public bool IsViewValid()
        {
            return IsNameValid() && IsDescriptionValid() && IsLocationValid() && IsDateValid();
        }

        private bool IsNameValid()
        {
            return !string.IsNullOrEmpty(journeyView.Name);
        }

        private bool IsDescriptionValid()
        {
            return !string.IsNullOrEmpty(journeyView.Description);
        }

        private bool IsLocationValid()
        {
            return !string.IsNullOrEmpty(journeyView.Date);
        }

        private bool IsDateValid()
        {
            return !string.IsNullOrEmpty(journeyView.Location);
        }
    }
}
