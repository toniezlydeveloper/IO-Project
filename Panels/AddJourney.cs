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
    public partial class AddJourney : Form, IPanelToggle, IJourneyView
    {
        public event Action<PanelType> OnToggleRequired;
        private IJourneyCreationRequester creationRequester;

        string IJourneyView.Name => this.TitleBox.Text;
        public string Description => this.DescriptionBox.Text;

        public string Date => this.DateBox.Text;

        public AddJourney()
        {

            InitializeComponent();
        
        }

        public AddJourney(IJourneyCreationRequester creationRequester) : base()
        {
            this.creationRequester = creationRequester;
            InitializeComponent();
        }

        private void SaveAndQuit_Click(object sender, EventArgs e)
        {
            creationRequester.CreateJourney(ChangePanel, InformAboutFail);

        }

       

        private void ChangePanel()
        {
            OnToggleRequired?.Invoke(0);
            this.Hide();
            Program.journalView.PresentJourneySet(Program.journal);
            Program.journalView.Show();
        }

        private void InformAboutFail()
        {
            MessageBox.Show("Couldn't create journey.");
        }


    }
}
