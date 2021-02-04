
namespace IO_Project.Panels
{
    partial class ModifyPart
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
            this.PartIconPath = new System.Windows.Forms.RichTextBox();
            this.SetPicture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PartTitleBox
            // 
            this.PartTitleBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PartTitleBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PartTitleBox.ForeColor = System.Drawing.Color.Black;
            this.PartTitleBox.Location = new System.Drawing.Point(12, 12);
            this.PartTitleBox.Name = "PartTitleBox";
            this.PartTitleBox.Size = new System.Drawing.Size(406, 32);
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
            this.SaveAndQuit.Click += new System.EventHandler(this.SaveAndQuit_Click);
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
            // PartIconPath
            // 
            this.PartIconPath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PartIconPath.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PartIconPath.ForeColor = System.Drawing.Color.Black;
            this.PartIconPath.Location = new System.Drawing.Point(12, 254);
            this.PartIconPath.Name = "PartIconPath";
            this.PartIconPath.Size = new System.Drawing.Size(304, 34);
            this.PartIconPath.TabIndex = 21;
            this.PartIconPath.Text = "Miniaturka etapu ";
            // 
            // SetPicture
            // 
            this.SetPicture.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetPicture.Location = new System.Drawing.Point(322, 254);
            this.SetPicture.Name = "SetPicture";
            this.SetPicture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SetPicture.Size = new System.Drawing.Size(96, 34);
            this.SetPicture.TabIndex = 23;
            this.SetPicture.Text = "Przegladaj";
            this.SetPicture.UseVisualStyleBackColor = true;
            this.SetPicture.Click += new System.EventHandler(this.SetPicture_Click);
            // 
            // AddNewPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetPicture);
            this.Controls.Add(this.PartIconPath);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SaveAndQuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartDescriptionBox);
            this.Controls.Add(this.PartTitleBox);
            this.Name = "ModifyPart";
            this.Text = "ModifyPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox PartTitleBox;
        private System.Windows.Forms.RichTextBox PartDescriptionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveAndQuit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.RichTextBox PartIconPath;
        private System.Windows.Forms.Button SetPicture;
    }
}