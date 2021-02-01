using IO_Project.Core;
using IO_Project.JourneyInteraction;
using IO_Project.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO_Project
{
    public partial class JournalView : Form, IJournalPresenter
    {
        Journal journal;
        public JournalView(Journal journal)
        {
            this.journal = journal;
            InitializeComponent();
            PresentJourneySet(this.journal);
            
        }

        public void PresentJourneySet(Journal journal)
        {
            List<Journey> journeys = journal.getJourneys();
            //  string title = @"Tytul ";
            //  TitleBox.Text = journal.JourneyByName(title).Name;
            //  DescriptionBox.Text = journal.JourneyByName(title).Description;
            /* foreach(Journey elem in journeys)
            {
                elem.Name;
                elem.Description

            } */

            int verticalOffset;

            for(int i=0; i < journeys.Count(); i++)
            {
               

                verticalOffset = i * 190;
                if(verticalOffset + 190 > this.ClientSize.Height)
                {
                    Button addButton = new Button();

                    addButton.Text = "Dodaj podroz";
                    addButton.Location = new System.Drawing.Point(627, 10 + verticalOffset);
                    addButton.Size = new System.Drawing.Size(161, 43);
                    addButton.Click += AddButton_Click;

                    this.Controls.Add(addButton);

                    break;
                }

                Label nameLabel = new Label();
                Label descriptionLabel = new Label();
                Button deleteButton = new Button();
                Button modifyButton = new Button();

                descriptionLabel.Text = journeys.ElementAt(i).Description;
                descriptionLabel.Location = new System.Drawing.Point(0, 147 + verticalOffset);
                descriptionLabel.Size = new System.Drawing.Size(622, 101);

                nameLabel.Text = journeys.ElementAt(i).Name;
                nameLabel.Location = new System.Drawing.Point(0, 75 + verticalOffset);
                nameLabel.Size = new System.Drawing.Size(321, 52);

             

                deleteButton.Text = "Usun podroz";
                deleteButton.Location = new System.Drawing.Point(627, 75 + verticalOffset);
                deleteButton.Size = new System.Drawing.Size(161, 43 );
                deleteButton.AccessibleName = journeys.ElementAt(i).Name;
                deleteButton.Click += DeleteButton_Click;


                modifyButton.Text = "Modyfikuj podroz";
                modifyButton.Location = new System.Drawing.Point(627, 137 + verticalOffset);
                modifyButton.Size = new System.Drawing.Size(161, 43);
                modifyButton.AccessibleName = journeys.ElementAt(i).Name;
                modifyButton.Click += ModifyButton_Click;

                this.Controls.Add(nameLabel);

                this.Controls.Add(descriptionLabel);

                this.Controls.Add(deleteButton);

                this.Controls.Add(modifyButton);
            }


        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string name = button.AccessibleName;
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string name = button.AccessibleName;
            Journey journey = this.journal.JourneyByName(name);
            JourneyView journeyView = new JourneyView(journey);
            journeyView.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            
            //handle switching to AddJourney
            
        }



        /*   public void createJourneyRepresentation()
           {

           }

           private void AddJourney_Click(object sender, EventArgs e)
           {

           }


           private void TitleBox_TextChanged(object sender, EventArgs e)
           {

           } */
    }
}
