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
    public partial class StageView : Form, IPanelToggle, IStageView
    {
        public event Action<PanelType> OnToggleRequired;
        private IStageAssignRequester assignRequester;

        public StageView()
        {
            InitializeComponent();
        }

        public StageView(IStageAssignRequester assignRequester) : base()
        {
            this.assignRequester = assignRequester;
        }

        public string Description => PartDescriptionLabel.Text;

        public string IconPath { get; private set; }
        private void ModifyStage_Click(object sender, EventArgs e)
        {
            assignRequester.AssignStage(ChangePanel, InformAboutFail);
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

