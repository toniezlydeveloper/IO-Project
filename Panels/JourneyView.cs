using IO_Project.JourneyInteraction;
using IO_Project.StageInteraction;
using System;
using System.Windows.Forms;

namespace IO_Project.Panels
{
    public partial class JourneyView : Form, IPanelToggle, IJourneyView, IStageView {

        private IJourneyModificationRequester journeyModificationRequester;
        private IStageAssignRequester stageAssignRequester;

        public JourneyView()
        {
            InitializeComponent();
        }

        public string Description => DescriptionLabel.Text;

        public string Date => DateLabel.Text;

        public string IconPath {get; private set;}

        public event Action<PanelType> OnToggleRequired;

        private void ModifyJourney_Click(object sender, EventArgs e)
        {
            
            journeyModificationRequester.ModifyJourney(ChangePanel, InformAboutFail);
        }

        

        public JourneyView(IJourneyModificationRequester modifyRequester, IStageAssignRequester assignRequester) : base()
        {
            this.journeyModificationRequester = modifyRequester;
            this.stageAssignRequester = assignRequester;
        }

       

       

        private void ChangePanel()
        {
            OnToggleRequired?.Invoke(0);
        }

        private void InformAboutFail()
        {
            MessageBox.Show("Couldn't assign stage.");
        }
    }
}
