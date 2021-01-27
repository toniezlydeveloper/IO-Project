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
    public partial class ModifyJourney : Form, IJourneyView, IJourneyModifier
    {

       string IJourneyView.Name
        {
            get
            {
                return TitleBox.Text;
            }
        }


        public string Description
        {
            get
            {
                
                return DescriptionBox.Text;
            }

        }
        
        public string Date
        {

            get
            {
               
                return DateBox.Text;
            }
        }
        public ModifyJourney()
        {

            InitializeComponent();
            //  presenter = new JourneyPresenter(journey, this);
        //    SubscribeToModelEvents();
        }
        /*
        private void SubscribeToModelEvents()
        {
            
        }


        */
        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void DateBox_TextChanged(object sender, EventArgs e)
        {

        } 

        private void SaveAndQuit_Click(object sender, EventArgs e)
        {

        }

        void IJourneyModifier.ModifyJourney(Action modificationCallback, Action modificationFailCallback)
        {
            
        }
    }
}
