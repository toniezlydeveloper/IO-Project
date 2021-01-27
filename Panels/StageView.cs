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
    public partial class StageView : Form, IStageView
    {
        public StageView()
        {
            InitializeComponent();
        }

        public string Description
        {
            get => throw new NotImplementedException();
            set
            {
                PartDescritpitonLabel.Text = value;
            }
        }
        public string IconPath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
