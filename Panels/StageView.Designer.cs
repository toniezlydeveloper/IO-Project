﻿
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
            this.PartTitleLabel = new System.Windows.Forms.Label();
            this.PartDescriptionLabel = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.JourneyTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
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
            this.ModifyStage.Click += new System.EventHandler(this.ModifyStage_Click);
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
            // PartTitleLabel
            // 
            this.PartTitleLabel.Location = new System.Drawing.Point(25, 61);
            this.PartTitleLabel.Name = "PartTitleLabel";
            this.PartTitleLabel.Size = new System.Drawing.Size(467, 39);
            this.PartTitleLabel.TabIndex = 28;
            this.PartTitleLabel.Text = "Tytul etapu";
            // 
            // PartDescriptionLabel
            // 
            this.PartDescriptionLabel.Location = new System.Drawing.Point(25, 109);
            this.PartDescriptionLabel.Name = "PartDescriptionLabel";
            this.PartDescriptionLabel.Size = new System.Drawing.Size(467, 167);
            this.PartDescriptionLabel.TabIndex = 29;
            this.PartDescriptionLabel.Text = "Opis etapu";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(498, 9);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(290, 267);
            this.PictureBox.TabIndex = 30;
            this.PictureBox.TabStop = false;
            // 
            // JourneyTitleLabel
            // 
            this.JourneyTitleLabel.Location = new System.Drawing.Point(25, 9);
            this.JourneyTitleLabel.Name = "JourneyTitleLabel";
            this.JourneyTitleLabel.Size = new System.Drawing.Size(467, 43);
            this.JourneyTitleLabel.TabIndex = 28;
            this.JourneyTitleLabel.Text = "Tytul podrozy";
            // 
            // StageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JourneyTitleLabel);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.PartDescriptionLabel);
            this.Controls.Add(this.PartTitleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModifyStage);
            this.Name = "StageView";
            this.Text = "StageView";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ModifyStage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PartTitleLabel;
        private System.Windows.Forms.Label PartDescriptionLabel;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label JourneyTitleLabel;
    }
}