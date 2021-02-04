
namespace IO_Project.Panels
{
    partial class ModifyJourney
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
            this.TitleBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.DateBox = new System.Windows.Forms.RichTextBox();
            this.SaveAndQuit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TitleBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleBox.ForeColor = System.Drawing.Color.Black;
            this.TitleBox.Location = new System.Drawing.Point(12, 12);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(776, 43);
            this.TitleBox.TabIndex = 7;
            this.TitleBox.Text = "Tytul podrozy";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DescriptionBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionBox.ForeColor = System.Drawing.Color.Black;
            this.DescriptionBox.Location = new System.Drawing.Point(12, 61);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(776, 241);
            this.DescriptionBox.TabIndex = 8;
            this.DescriptionBox.Text = "Opis podrozy";
           
            // 
            // DateBox
            // 
            this.DateBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DateBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateBox.ForeColor = System.Drawing.Color.Black;
            this.DateBox.Location = new System.Drawing.Point(12, 308);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(776, 43);
            this.DateBox.TabIndex = 10;
            this.DateBox.Text = "Data podrozy";
         
            // 
            // SaveAndQuit
            // 
            this.SaveAndQuit.BackColor = System.Drawing.Color.SpringGreen;
            this.SaveAndQuit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveAndQuit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveAndQuit.Location = new System.Drawing.Point(12, 372);
            this.SaveAndQuit.Name = "SaveAndQuit";
            this.SaveAndQuit.Size = new System.Drawing.Size(155, 66);
            this.SaveAndQuit.TabIndex = 15;
            this.SaveAndQuit.Text = "Zapisz i wyjdz";
            this.SaveAndQuit.UseVisualStyleBackColor = false;
            this.SaveAndQuit.Click += new System.EventHandler(this.SaveAndQuit_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.OrangeRed;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancel.Location = new System.Drawing.Point(633, 372);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(155, 66);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "Anuluj ";
            this.Cancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(-60, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(917, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "---------------------";
            // 
            // ModifyJourney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SaveAndQuit);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.TitleBox);
            this.Name = "ModifyJourney";
            this.Text = "ModifyJourney";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TitleBox;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.RichTextBox DateBox;
        private System.Windows.Forms.Button SaveAndQuit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
    }
}