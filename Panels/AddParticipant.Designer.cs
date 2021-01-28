
namespace IO_Project.Panels
{
    partial class AddParticipant
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
            this.ParticipantsInfo = new System.Windows.Forms.RichTextBox();
            this.FirstName = new System.Windows.Forms.RichTextBox();
            this.LastName = new System.Windows.Forms.RichTextBox();
            this.SetPicture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveAndQuit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.ListOfParticipants = new System.Windows.Forms.ListView();
            this.Imie = new System.Windows.Forms.ColumnHeader();
            this.Nazwisko = new System.Windows.Forms.ColumnHeader();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ParticipantsInfo
            // 
            this.ParticipantsInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ParticipantsInfo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ParticipantsInfo.ForeColor = System.Drawing.Color.Black;
            this.ParticipantsInfo.Location = new System.Drawing.Point(12, 26);
            this.ParticipantsInfo.Name = "ParticipantsInfo";
            this.ParticipantsInfo.Size = new System.Drawing.Size(280, 61);
            this.ParticipantsInfo.TabIndex = 14;
            this.ParticipantsInfo.Text = "Ponizej wpisz imie i nazwisko uczestnika podrozy";
            // 
            // FirstName
            // 
            this.FirstName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FirstName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName.ForeColor = System.Drawing.Color.Black;
            this.FirstName.Location = new System.Drawing.Point(12, 102);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(280, 34);
            this.FirstName.TabIndex = 22;
            this.FirstName.Text = "Imie";
            // 
            // LastName
            // 
            this.LastName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LastName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName.ForeColor = System.Drawing.Color.Black;
            this.LastName.Location = new System.Drawing.Point(12, 142);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(280, 34);
            this.LastName.TabIndex = 23;
            this.LastName.Text = "Nazwisko";
            // 
            // SetPicture
            // 
            this.SetPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SetPicture.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetPicture.Location = new System.Drawing.Point(69, 192);
            this.SetPicture.Name = "SetPicture";
            this.SetPicture.Size = new System.Drawing.Size(156, 59);
            this.SetPicture.TabIndex = 24;
            this.SetPicture.Text = "Dodaj uczestnika";
            this.SetPicture.UseVisualStyleBackColor = false;
            this.SetPicture.Click += new System.EventHandler(this.SetPicture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(-55, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(917, 15);
            this.label1.TabIndex = 25;
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
            this.SaveAndQuit.TabIndex = 26;
            this.SaveAndQuit.Text = "Zapisz i wyjdz";
            this.SaveAndQuit.UseVisualStyleBackColor = false;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.OrangeRed;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancel.Location = new System.Drawing.Point(633, 372);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(155, 66);
            this.Cancel.TabIndex = 27;
            this.Cancel.Text = "Anuluj ";
            this.Cancel.UseVisualStyleBackColor = false;
            // 
            // ListOfParticipants
            // 
            this.ListOfParticipants.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ListOfParticipants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Imie,
            this.Nazwisko});
            this.ListOfParticipants.GridLines = true;
            this.ListOfParticipants.HideSelection = false;
            this.ListOfParticipants.Location = new System.Drawing.Point(425, 72);
            this.ListOfParticipants.Name = "ListOfParticipants";
            this.ListOfParticipants.Size = new System.Drawing.Size(344, 256);
            this.ListOfParticipants.TabIndex = 28;
            this.ListOfParticipants.UseCompatibleStateImageBehavior = false;
            this.ListOfParticipants.View = System.Windows.Forms.View.Details;
            // 
            // Imie
            // 
            this.Imie.Text = "Imie";
            this.Imie.Width = 172;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Text = "Nazwisko";
            this.Nazwisko.Width = 172;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(500, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(185, 37);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "Lista uczestnikow";
            // 
            // AddParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ListOfParticipants);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SaveAndQuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetPicture);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.ParticipantsInfo);
            this.Name = "AddParticipant";
            this.Text = "AddParticipant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ParticipantsInfo;
        private System.Windows.Forms.RichTextBox FirstName;
        private System.Windows.Forms.RichTextBox LastName;
        private System.Windows.Forms.Button SetPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveAndQuit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ListView ListOfParticipants;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ColumnHeader Imie;
        private System.Windows.Forms.ColumnHeader Nazwisko;
    }
}