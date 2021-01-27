namespace IO_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AppTitle = new System.Windows.Forms.Label();
            this.AddJourney = new System.Windows.Forms.Button();
            this.DeleteJourney = new System.Windows.Forms.Button();
            this.TitleBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModifyJourney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AppTitle
            // 
            this.AppTitle.AutoSize = true;
            this.AppTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AppTitle.Location = new System.Drawing.Point(12, 9);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(257, 37);
            this.AppTitle.TabIndex = 1;
            this.AppTitle.Text = "Pamietnik z podrozy";
            // 
            // AddJourney
            // 
            this.AddJourney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddJourney.Location = new System.Drawing.Point(555, 371);
            this.AddJourney.Name = "AddJourney";
            this.AddJourney.Size = new System.Drawing.Size(233, 67);
            this.AddJourney.TabIndex = 3;
            this.AddJourney.Text = "Dodaj nowa podroz";
            this.AddJourney.UseVisualStyleBackColor = true;
            this.AddJourney.Click += new System.EventHandler(this.AddJourney_Click);
            // 
            // DeleteJourney
            // 
            this.DeleteJourney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteJourney.Location = new System.Drawing.Point(627, 145);
            this.DeleteJourney.Name = "DeleteJourney";
            this.DeleteJourney.Size = new System.Drawing.Size(161, 43);
            this.DeleteJourney.TabIndex = 4;
            this.DeleteJourney.Text = "Usun podroz";
            this.DeleteJourney.UseVisualStyleBackColor = true;
            this.DeleteJourney.Click += new System.EventHandler(this.ModifyJourney_Click);
            // 
            // TitleBox
            // 
            this.TitleBox.BackColor = System.Drawing.SystemColors.Control;
            this.TitleBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleBox.ForeColor = System.Drawing.Color.Black;
            this.TitleBox.Location = new System.Drawing.Point(225, 75);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(321, 52);
            this.TitleBox.TabIndex = 5;
            this.TitleBox.Text = "Tytul podrozy";
            this.TitleBox.TextChanged += new System.EventHandler(this.TitleBox_TextChanged);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.SystemColors.Control;
            this.DescriptionBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionBox.ForeColor = System.Drawing.Color.Black;
            this.DescriptionBox.Location = new System.Drawing.Point(0, 147);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(622, 101);
            this.DescriptionBox.TabIndex = 6;
            this.DescriptionBox.Text = "Opis podrozy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(-1, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(917, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "---------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(-59, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(917, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "---------------------";
            // 
            // ModifyJourney
            // 
            this.ModifyJourney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModifyJourney.Location = new System.Drawing.Point(627, 207);
            this.ModifyJourney.Name = "ModifyJourney";
            this.ModifyJourney.Size = new System.Drawing.Size(161, 43);
            this.ModifyJourney.TabIndex = 9;
            this.ModifyJourney.Text = "Edytuj podroz";
            this.ModifyJourney.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ModifyJourney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.DeleteJourney);
            this.Controls.Add(this.AddJourney);
            this.Controls.Add(this.AppTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.Button AddJourney;
        private System.Windows.Forms.Button DeleteJourney;
        private System.Windows.Forms.RichTextBox TitleBox;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ModifyJourney;
    }
}
