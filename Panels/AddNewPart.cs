using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using IO_Project.StageInteraction;

namespace IO_Project.Panels
{
    public partial class AddNewPart : Form, IPanelToggle, IStageView
    {
        public event Action<PanelType> OnToggleRequired;
        private IStageAssignRequester assignRequester;

        public string IconPath { get; private set; }
        public string Description => PartDescriptionBox.Text;

        public AddNewPart()
        {
            InitializeComponent();
        }

        public AddNewPart(IStageAssignRequester assignRequester) : base()
        {
            this.assignRequester = assignRequester;
            InitializeComponent();
        }

        private void SaveAndQuit_Click(object sender, EventArgs e)
        {
            assignRequester.AssignStage(ChangePanel, InformAboutFail);
        }

        private void SetPicture_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    IconPath = fbd.SelectedPath;
                }
            }
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
