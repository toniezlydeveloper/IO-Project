
namespace IO_Project.Panels
{
    partial class AddNewPart
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
            this.PartTitleBox = new System.Windows.Forms.RichTextBox();
            this.PartDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveAndQuit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.StagePicture = new System.Windows.Forms.PictureBox();
            this.SetPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StagePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PartTitleBox
            // 
            this.PartTitleBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PartTitleBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PartTitleBox.ForeColor = System.Drawing.Color.Black;
            this.PartTitleBox.Location = new System.Drawing.Point(12, 12);
            this.PartTitleBox.Name = "PartTitleBox";
            this.PartTitleBox.Size = new System.Drawing.Size(289, 32);
            this.PartTitleBox.TabIndex = 13;
            this.PartTitleBox.Text = "Tytul etapu";
            // 
            // PartDescriptionBox
            // 
            this.PartDescriptionBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PartDescriptionBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PartDescriptionBox.ForeColor = System.Drawing.Color.Black;
            this.PartDescriptionBox.Location = new System.Drawing.Point(12, 60);
            this.PartDescriptionBox.Name = "PartDescriptionBox";
            this.PartDescriptionBox.Size = new System.Drawing.Size(607, 133);
            this.PartDescriptionBox.TabIndex = 14;
            this.PartDescriptionBox.Text = "Opis etapu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(-70, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(917, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "---------------------";
            // 
            // SaveAndQuit
            // 
            this.SaveAndQuit.BackColor = System.Drawing.Color.SpringGreen;
            this.SaveAndQuit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveAndQuit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveAndQuit.Location = new System.Drawing.Point(12, 372);
            this.SaveAndQuit.Name = "SaveAndQuit";
            this.SaveAndQuit.Size = new System.Drawing.Size(155, 66);
            this.SaveAndQuit.TabIndex = 19;
            this.SaveAndQuit.Text = "Zapisz i wyjdz";
            this.SaveAndQuit.UseVisualStyleBackColor = false;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.OrangeRed;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancel.Location = new System.Drawing.Point(618, 372);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(155, 66);
            this.Cancel.TabIndex = 20;
            this.Cancel.Text = "Anuluj ";
            this.Cancel.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(12, 254);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(304, 34);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "Miniaturka etapu ";
            // 
            // StagePicture
            // 
            this.StagePicture.Location = new System.Drawing.Point(357, 199);
            this.StagePicture.Name = "StagePicture";
            this.StagePicture.Size = new System.Drawing.Size(155, 152);
            this.StagePicture.TabIndex = 22;
            this.StagePicture.TabStop = false;
            // 
            // SetPicture
            // 
            this.SetPicture.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetPicture.Location = new System.Drawing.Point(533, 290);
            this.SetPicture.Name = "SetPicture";
            this.SetPicture.Size = new System.Drawing.Size(102, 61);
            this.SetPicture.TabIndex = 23;
            this.SetPicture.Text = "Ustaw jako miniaturke";
            this.SetPicture.UseVisualStyleBackColor = true;
            // 
            // AddNewPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetPicture);
            this.Controls.Add(this.StagePicture);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SaveAndQuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartDescriptionBox);
            this.Controls.Add(this.PartTitleBox);
            this.Name = "AddNewPart";
            this.Text = "AddNewPart";
            ((System.ComponentModel.ISupportInitialize)(this.StagePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox PartTitleBox;
        private System.Windows.Forms.RichTextBox PartDescriptionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveAndQuit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox StagePicture;
        private System.Windows.Forms.Button SetPicture;
    }
}