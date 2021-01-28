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
    public partial class ModifyJourney : Form, IPanelToggle, IJourneyView
    {
        public event Action<PanelType> OnToggleRequired;
        private IJourneyModificationRequester modificationRequester;

        string IJourneyView.Name => TitleBox.Text;
        public string Description => DescriptionBox.Text;

        public string Date => DateBox.Text;

        public ModifyJourney()
        {

            InitializeComponent();
        
        }

        public ModifyJourney(IJourneyModificationRequester modificationRequester) : base()
        {
            this.modificationRequester = modificationRequester;
        }

        private void SaveAndQuit_Click(object sender, EventArgs e)
        {
            modificationRequester.ModifyJourney(ChangePanel, InformAboutFail);
        }

       

        private void ChangePanel()
        {
            OnToggleRequired?.Invoke(0);
        }

        private void InformAboutFail()
        {
            MessageBox.Show("Couldn't modify journey.");
        }


    }
}
