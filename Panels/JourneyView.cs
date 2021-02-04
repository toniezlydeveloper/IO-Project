using IO_Project.JourneyInteraction;
using IO_Project.StageInteraction;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace IO_Project.Panels
{
    public partial class JourneyView : Form, IPanelToggle, IJourneyPresenter, IJourneyView
    {

        private IJourneyModificationRequester journeyModificationRequester;
        private IStageAssignRequester stageAssignRequester;

        private Journey journey;

        string IJourneyView.Name => TitleBox.Text;
        public string Description => DescriptionBox.Text;

        public string Date => DateBox.Text;

        public event Action<PanelType> OnToggleRequired;

        public JourneyView(IJourneyModificationRequester modifyRequester, IStageAssignRequester assignRequester) : base()
        {
            InitializeComponent();
            this.journeyModificationRequester = modifyRequester;
            this.stageAssignRequester = assignRequester;

        }

        private void ModifyJourney_Click(object sender, EventArgs e)
        {
            
            OnToggleRequired?.Invoke(0);
            this.Hide();
            this.deleteControls();

            Journey journey = this.journey;
            Program.modifyJourneyView.PresentJourney(journey);
            Program.modifyJourneyView.Show();

        }


        private void ChangePanel()
        {
            OnToggleRequired?.Invoke(0);
            this.Hide();


            Program.stageView.Show();
        }

        private void InformAboutFail()
        {
            MessageBox.Show("Couldn't assign stage.");
        }

        public void PresentJourney(Journey journey)
        {
            TitleBox.Text = journey.Name;
            DescriptionBox.Text = journey.Description;
            DateBox.Text = journey.Date;
            this.journey = journey;
           // this.deleteControls();
            this.DisplayStagesFromRange(journey, 0, 1);

        }



        private void DisplayStagesFromRange(Journey journey, int min, int max)
        {
            this.deleteControls();

            List<Stage> stages = journey.getStages();

            Button modifyJourney = new Button();

            modifyJourney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            modifyJourney.Location = new System.Drawing.Point(590, 48);
            modifyJourney.Name = "ModifyJourney";
            modifyJourney.Size = new System.Drawing.Size(151, 40);
            modifyJourney.TabIndex = 11;
            modifyJourney.Text = "Edytuj podroz";
            modifyJourney.UseVisualStyleBackColor = true;
            modifyJourney.Click += new System.EventHandler(this.ModifyJourney_Click);

            this.Controls.Add(modifyJourney);

            Button participantsView = new Button();

            participantsView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            participantsView.Location = new System.Drawing.Point(590, 90);
            participantsView.Name = "ModifyJourney";
            participantsView.Size = new System.Drawing.Size(151, 40);
            participantsView.TabIndex = 11;
            participantsView.Text = "Uczestnicy";
            participantsView.UseVisualStyleBackColor = true;
            participantsView.Click += new System.EventHandler(this.ParticipantsView_Click);

            this.Controls.Add(participantsView);

            int verticalOffset;

            int pageNumber = min / 2;
            bool isLast = false;

            if (max >= stages.Count() - 1)
            {
                max = stages.Count() - 1;
                isLast = true;
            }

            for (int i = min; i <= max; i++)
            {
                verticalOffset = (i - min) * 190 + 150;

                
                Label nameLabel = new Label();
                Label partDescriptionLabel = new Label();
                Button viewButton = new Button();

                partDescriptionLabel.Text = stages.ElementAt(i).Description;
                partDescriptionLabel.Location = new System.Drawing.Point(0, 147 + verticalOffset);
                partDescriptionLabel.Size = new System.Drawing.Size(622, 101);
                partDescriptionLabel.Name = "partDesc";

                nameLabel.Text = stages.ElementAt(i).Name;
                nameLabel.Location = new System.Drawing.Point(0, 75 + verticalOffset);
                nameLabel.Size = new System.Drawing.Size(321, 52);
                nameLabel.Name = "partTitle";

                viewButton.Text = "Przegladaj etap";
                viewButton.Location = new System.Drawing.Point(627, 75 + verticalOffset);
                viewButton.Size = new System.Drawing.Size(161, 86);
                viewButton.AccessibleName = stages.ElementAt(i).Name;
                viewButton.Click += ViewButton_Click;
                viewButton.Name = "ViewButton";

                this.Controls.Add(nameLabel);
                this.Controls.Add(partDescriptionLabel);
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
                nextButton.Name = "NextButton";

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
                previousButton.Name = "PreviousButton";

                this.Controls.Add(previousButton);
            }


            Button addButton = new Button();

            addButton.Text = "Dodaj etap";
            addButton.Location = new System.Drawing.Point(627, this.ClientSize.Height - 53);
            addButton.Size = new System.Drawing.Size(161, 43);
            addButton.Click += AddButton_Click;
            addButton.Name = "AddButton";

            this.Controls.Add(addButton);

        }


        private void ParticipantsView_Click(object sender, EventArgs e)
        {
           

           

            
            Program.addParticipantView.PresentParticipantSet(this.journey.getParticipants());
            Program.addParticipantView.ShowDialog();
        }


        private void ViewButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string name = button.AccessibleName;
            this.Hide();
            

            Stage stage = this.journey.StageByName(name);
            Program.stageView.PresentStage(stage, this.journey);
            Program.stageView.Show();
       //     this.stageAssignRequester.AssignStage(ChangePanel, InformAboutFail);
        //    Program.requestInteractor.IsBusy = false;

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string name = button.AccessibleName;
            int i = Int32.Parse(name);
           // this.deleteControls();
            this.DisplayStagesFromRange(this.journey, i * 2, i * 2 + 1);

        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string name = button.AccessibleName;
            int i = Int32.Parse(name);
          //  this.deleteControls();
            this.DisplayStagesFromRange(this.journey, i * 2, i * 2 + 1);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.deleteControls();
            Program.addStageView.Show();


        }

        public void deleteControls()
        {
            
            for(int i=this.Controls.Count -1; i>= 0; i--)
            {
                Control item = Controls[i];
                if(item.GetType() == typeof(Button))
                {
                    if (item.Name == "ModifyJourney" | item.Name == "AddButton" | item.Name == "ViewButton" | item.Name == "NextButton" | item.Name == "PreviousButton")
                    {
                        
                        this.Controls.Remove(item);
                        item.Dispose();

                    }
                } else if (item.GetType() == typeof(Label))
                {
                    if (item.Name == "partTitle" | item.Name == "partDesc")
                    {
                       
                        this.Controls.Remove(item);
                        item.Dispose();
                    }
                }
                
               
            }
            
        }

       
    }
}
