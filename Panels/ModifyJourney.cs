using IO_Project.JourneyInteraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IO_Project.Panels
{
    public partial class ModifyJourney : Form, IPanelToggle, IJourneyView, IJourneyPresenter
    {
        public event Action<PanelType> OnToggleRequired;

        private Journey journey;

        private IJourneyModificationRequester modificationRequester;

        string IJourneyView.Name => this.TitleBox.Text;
        public string Description => this.DescriptionBox.Text;

        public string Date => this.DateBox.Text;



        public ModifyJourney(IJourneyModificationRequester modificationRequester) : base()
        {
            InitializeComponent();
            this.modificationRequester = modificationRequester;

        }

        private void SaveAndQuit_Click(object sender, EventArgs e)
        {
            modificationRequester.ModifyJourney(ChangePanel, InformAboutFail);
            Program.requestInteractor.IsBusy = false;
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
            MessageBox.Show("Couldn't modify journey.");
        }

        public void PresentJourney(Journey journey)
        {
            TitleBox.Text = journey.Name;
            DescriptionBox.Text = journey.Description;
            DateBox.Text = journey.Date;
            this.journey = journey;
        }
    }
}
