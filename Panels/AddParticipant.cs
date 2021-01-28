using IO_Project.ParticipantInteraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IO_Project.Panels
{
    public partial class AddParticipant : Form, IPanelToggle, IParticipantView
    {
        public event Action<PanelType> OnToggleRequired;
        private IParticipantAssignRequester assignRequester;
        public AddParticipant()
        {
            InitializeComponent();
        }

        public AddParticipant(IParticipantAssignRequester assignRequester) : base()
        {
            this.assignRequester = assignRequester;
        }
        public string FullName => FirstName.Text + LastName.Text;

        private void SetPicture_Click(object sender, EventArgs e)
        {
            assignRequester.AssignParticipant(ChangePanel, InformAboutFail);
        }

        private void ChangePanel()
        {
            OnToggleRequired?.Invoke(0);
        }

        private void InformAboutFail()
        {
            MessageBox.Show("Couldn't assign participant.");
        }
    }
}
