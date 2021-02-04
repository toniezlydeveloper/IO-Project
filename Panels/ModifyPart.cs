using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using IO_Project.JourneyInteraction;
using IO_Project.StageInteraction;

namespace IO_Project.Panels
{
    public partial class ModifyPart : Form, IPanelToggle, IStagePresenter, IStageView
    {
        public event Action<PanelType> OnToggleRequired;
        private IStageModificationRequester modificationRequester;

        private Stage stage;
        private Journey journey;

        string IStageView.Name => PartTitleBox.Text;
        public string IconPath => PartIconPath.Text;
        public string Description => PartDescriptionBox.Text;

        

        public ModifyPart(IStageModificationRequester modificationRequester) : base()
        {
            this.modificationRequester = modificationRequester;
            InitializeComponent();
        }

        private void SaveAndQuit_Click(object sender, EventArgs e)
        {
            modificationRequester.ModifyStage(ChangePanel, InformAboutFail);
            Program.requestInteractor.IsBusy = false;
        }

        private void SetPicture_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
                {
                    PartIconPath.Text = ofd.FileName;
                }
            }
        }

        private void ChangePanel()
        {
            OnToggleRequired?.Invoke(0);
            this.Hide();
            Program.journalView.deleteControls();
            Program.journalView.PresentJourneySet(Program.journal);
            Program.journalView.Show();
        }

        private void InformAboutFail()
        {
            MessageBox.Show("Couldn't modify stage.");
        }

        public void PresentStage(Stage stage, Journey journey)
        {
            PartTitleBox.Text = stage.Name;
            PartIconPath.Text = stage.IconPath;
            PartDescriptionBox.Text = stage.Description;
            this.stage = stage;
            this.journey = journey;
        }
    }
}
