using IO_Project.JourneyInteraction;
using IO_Project.StageInteraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IO_Project.Panels
{
    public partial class StageView : Form, IPanelToggle, IStageView, IStagePresenter, IJourneyView
    {
        public event Action<PanelType> OnToggleRequired;
        private IStageAssignRequester assignRequester;

        private Journey journey;
        private Stage stage;

        public StageView(IStageAssignRequester assignRequester) : base()
        {
            this.assignRequester = assignRequester;
            InitializeComponent();
        }

        string IStageView.Name => PartTitleLabel.Text;
        public string Description => PartDescriptionLabel.Text;

        public string IconPath => PictureBox.ImageLocation;

        public string Date {get; }

        string IJourneyView.Description { get; }

        string IJourneyView.Name => JourneyTitleLabel.Text;

        private void ModifyStage_Click(object sender, EventArgs e)
        {
            assignRequester.AssignStage(ChangePanel, InformAboutFail);
        }

       

        private void ChangePanel()
        {
            OnToggleRequired?.Invoke(0);
            this.Hide();
            Program.modifyStage.PresentStage(this.stage, this.journey);
            Program.modifyStage.Show();
        }

        private void InformAboutFail()
        {
            MessageBox.Show("Couldn't assign stage.");
        }

        public void PresentStage(Stage stage, Journey journey)
        {
            PartTitleLabel.Text = stage.Name;
            PartDescriptionLabel.Text = stage.Description;
            PictureBox.ImageLocation = stage.IconPath;
            PictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            JourneyTitleLabel.Text = journey.Name;
            this.stage = stage;
            this.journey = journey;
        }

        
    }



}

