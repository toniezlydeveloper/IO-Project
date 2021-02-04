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
    public partial class AddParticipant : Form, IPanelToggle, IParticipantView, IParticipantPresenter
    {
        public event Action<PanelType> OnToggleRequired;
        private IParticipantAssignRequester assignRequester;
        private IParticipantCreationRequester creationRequester;

        List<Participant> participants;

        public AddParticipant(IParticipantAssignRequester assignRequester, IParticipantCreationRequester creationRequester) : base()
        {
            this.assignRequester = assignRequester;
            this.creationRequester = creationRequester;

            InitializeComponent();
        }
        public string FullName => FirstName.Text + " " + LastName.Text;

        private void SetPicture_Click(object sender, EventArgs e)
        {
            creationRequester.CreateParticipant(Assign, InformAboutCreationFail);
            Program.requestInteractor.IsBusy = false;

        }

        private void Assign()
        {
            assignRequester.AssignParticipant(ChangePanel, InformAboutFail);
            Program.requestInteractor.IsBusy = false;
        }
        private void ChangePanel()
        {
            OnToggleRequired?.Invoke(0);
            this.Hide();


           
        }

        private void InformAboutFail()
        {
            MessageBox.Show("Couldn't assign participant.");
        }

        private void InformAboutCreationFail()
        {
            MessageBox.Show("Couldn't create participant.");
        }



        public void PresentParticipantSet(List<Participant> participants)
            
        {
            ListOfParticipants.Items.Clear();
            foreach (Participant e in participants)
            {
                ListOfParticipants.Items.Add(e.FullName);
            }
        }
    }
}
