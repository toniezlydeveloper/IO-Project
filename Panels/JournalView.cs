using IO_Project.Core;
using IO_Project.JourneyInteraction;
using IO_Project.JourneyInteraction.Entities;
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


        public string Date => throw new NotImplementedException();

        public JournalView(Journal journal)
        {
            this.journal = journal;
            InitializeComponent();
            PresentJourneySet(this.journal);

        }

        public void deleteControls()
        {

            this.Controls.Clear();

        }
        private void DisplayJourneysFromRange(List<Journey> journeys, int min, int max)
        {
            Label AppTitle = new Label();
            AppTitle.AutoSize = true;
            AppTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AppTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            AppTitle.Location = new System.Drawing.Point(12, 9);
            AppTitle.Name = "AppTitle";
            AppTitle.Size = new System.Drawing.Size(257, 37);
            AppTitle.TabIndex = 1;
            AppTitle.Text = "Pamietnik z podrozy";
            
            this.Controls.Add(AppTitle);

            int verticalOffset;

            int pageNumber = min / 3;
            bool isLast = false;

            if(max >= journeys.Count() - 1)
            {
                max = journeys.Count() - 1;
                isLast = true;
            }

            for (int i = min; i <= max; i++)
            {
                verticalOffset = (i-min) * 190;
                

                Label nameLabel = new Label();
                Label descriptionLabel = new Label();
                Button viewButton = new Button();

                descriptionLabel.Text = journeys.ElementAt(i).Description;
                descriptionLabel.Location = new System.Drawing.Point(0, 147 + verticalOffset);
                descriptionLabel.Size = new System.Drawing.Size(622, 101);

                nameLabel.Text = journeys.ElementAt(i).Name;
                nameLabel.Location = new System.Drawing.Point(0, 75 + verticalOffset);
                nameLabel.Size = new System.Drawing.Size(321, 52);

                viewButton.Text = "Przegladaj podroz";
                viewButton.Location = new System.Drawing.Point(627, 75 + verticalOffset);
                viewButton.Size = new System.Drawing.Size(161, 86);
                viewButton.AccessibleName = journeys.ElementAt(i).Name;
                viewButton.Click += ViewButton_Click;

                this.Controls.Add(nameLabel);
                this.Controls.Add(descriptionLabel);
                this.Controls.Add(viewButton);




                
            }
            if (!isLast)
            {
                Button nextButton = new Button();

                nextButton.Text = "Nastepne";
                nextButton.Location = new System.Drawing.Point(327, this.ClientSize.Height - 53);
                nextButton.Size = new System.Drawing.Size(161, 43);
                nextButton.AccessibleName = (pageNumber + 1).ToString();
                nextButton.Click += NextButton_Click;

                this.Controls.Add(nextButton);
            }
            if (pageNumber > 0)
            {
                Button previousButton = new Button();

            
                previousButton.Text = "Poprzednie";
                previousButton.Location = new System.Drawing.Point(27, this.ClientSize.Height - 53);
                previousButton.Size = new System.Drawing.Size(161, 43);
                previousButton.AccessibleName = (pageNumber - 1).ToString();
                previousButton.Click += PreviousButton_Click;

                this.Controls.Add(previousButton);
            }
            

            this.DisplayAddButton();

        }

        public void PresentJourneySet(Journal journal)
        {
            List<Journey> journeys = journal.getJourneys();



            this.DisplayJourneysFromRange(journeys, 0, 2);


        }

        private void DisplayAddButton()
        {
            

         


            Button addButton = new Button();

            addButton.Text = "Dodaj podroz";
            addButton.Location = new System.Drawing.Point(627, this.ClientSize.Height - 53);
            addButton.Size = new System.Drawing.Size(161, 43);
            addButton.Click += AddButton_Click;

            this.Controls.Add(addButton);
        }


        private void ViewButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string name = button.AccessibleName;

            this.Hide();
            this.deleteControls();

            Journey journey = this.journal.JourneyByName(name);
            Program.journeyView.PresentJourney(journey);
            Program.journeyView.Show();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string name = button.AccessibleName;
            int i = Int32.Parse(name);
            this.deleteControls();
            this.DisplayJourneysFromRange(this.journal.getJourneys(), i*3, i*3+2);
            
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string name = button.AccessibleName;
            int i = Int32.Parse(name);
            this.deleteControls();
            this.DisplayJourneysFromRange(this.journal.getJourneys(), i*3, i*3+2);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.deleteControls();
            Program.addJourneyView.Show();


        }


    }
}
