
namespace IO_Project.Panels
{
    partial class JourneyView
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
            this.DateBox = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(582, 7);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(206, 38);
            this.DateBox.TabIndex = 19;
            this.DateBox.Text = "Date";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(12, 7);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(564, 38);
            this.TitleBox.TabIndex = 20;
            this.TitleBox.Text = "Title";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(12, 49);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(564, 145);
            this.DescriptionBox.TabIndex = 21;
            this.DescriptionBox.Text = "Description";
            // 
            // JourneyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.DateBox);
            this.Name = "JourneyView";
            this.Text = "JourneyView";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DateBox;
        private System.Windows.Forms.Label TitleBox;
        private System.Windows.Forms.Label DescriptionBox;
    }
}