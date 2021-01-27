
namespace IO_Project.Panels
{
    partial class StageView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ModifyStage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.JourneyNameLabel = new System.Windows.Forms.Label();
            this.PartTitleLabel = new System.Windows.Forms.Label();
            this.PartDescritpitonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ModifyStage
            // 
            this.ModifyStage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModifyStage.Location = new System.Drawing.Point(331, 294);
            this.ModifyStage.Name = "ModifyStage";
            this.ModifyStage.Size = new System.Drawing.Size(161, 43);
            this.ModifyStage.TabIndex = 25;
            this.ModifyStage.Text = "Edytuj etap";
            this.ModifyStage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(-66, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(917, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "---------------------";
            // 
            // JourneyNameLabel
            // 
            this.JourneyNameLabel.Location = new System.Drawing.Point(25, 16);
            this.JourneyNameLabel.Name = "JourneyNameLabel";
            this.JourneyNameLabel.Size = new System.Drawing.Size(745, 34);
            this.JourneyNameLabel.TabIndex = 27;
            this.JourneyNameLabel.Text = "Tytul podrozy";
            // 
            // PartTitleLabel
            // 
            this.PartTitleLabel.Location = new System.Drawing.Point(331, 50);
            this.PartTitleLabel.Name = "PartTitleLabel";
            this.PartTitleLabel.Size = new System.Drawing.Size(161, 32);
            this.PartTitleLabel.TabIndex = 28;
            this.PartTitleLabel.Text = "Tytul etapu";
            // 
            // PartDescritpitonLabel
            // 
            this.PartDescritpitonLabel.Location = new System.Drawing.Point(25, 86);
            this.PartDescritpitonLabel.Name = "PartDescritpitonLabel";
            this.PartDescritpitonLabel.Size = new System.Drawing.Size(745, 190);
            this.PartDescritpitonLabel.TabIndex = 29;
            this.PartDescritpitonLabel.Text = "Opis etapu";
            // 
            // StageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PartDescritpitonLabel);
            this.Controls.Add(this.PartTitleLabel);
            this.Controls.Add(this.JourneyNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModifyStage);
            this.Name = "StageView";
            this.Text = "StageView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ModifyStage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label JourneyNameLabel;
        private System.Windows.Forms.Label PartTitleLabel;
        private System.Windows.Forms.Label PartDescritpitonLabel;
    }
}