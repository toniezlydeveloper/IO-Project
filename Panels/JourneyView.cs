using IO_Project.JourneyInteraction;
using IO_Project.StageInteraction;
using System;
using System.Windows.Forms;

namespace IO_Project.Panels
{
    public partial class JourneyView : Form, IPanelToggle, IJourneyView, IStageView, IJourneyPresenter {

        private IJourneyModificationRequester journeyModificationRequester;
        private IStageAssignRequester stageAssignRequester;

        private Journey journey;
        public JourneyView(Journey journey)
        {
            InitializeComponent();
            this.journey = journey;
            PresentJourney(this.journey);
           
        }
        string IJourneyView.Name => TitleLabel.Text;
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
            InitializeComponent();
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

        public void PresentJourney(Journey journey)
        {
            TitleLabel.Text = journey.Name;
            DescriptionLabel.Text = journey.Description;
            DateLabel.Text = journey.Date;
            
        }
    }
}
