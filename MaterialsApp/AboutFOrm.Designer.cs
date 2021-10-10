
namespace MaterialsApp
{
    partial class AboutForm
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
            this.aboutHeaderLabel = new System.Windows.Forms.Label();
            this.aboutBodyLabel = new System.Windows.Forms.Label();
            this.aboutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // aboutHeaderLabel
            // 
            this.aboutHeaderLabel.AutoSize = true;
            this.aboutHeaderLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutHeaderLabel.Location = new System.Drawing.Point(27, 9);
            this.aboutHeaderLabel.Name = "aboutHeaderLabel";
            this.aboutHeaderLabel.Size = new System.Drawing.Size(197, 20);
            this.aboutHeaderLabel.TabIndex = 0;
            this.aboutHeaderLabel.Text = "Materials List Estimator";
            // 
            // aboutBodyLabel
            // 
            this.aboutBodyLabel.AutoSize = true;
            this.aboutBodyLabel.Location = new System.Drawing.Point(12, 38);
            this.aboutBodyLabel.Name = "aboutBodyLabel";
            this.aboutBodyLabel.Size = new System.Drawing.Size(227, 60);
            this.aboutBodyLabel.TabIndex = 1;
            this.aboutBodyLabel.Text = "A copy of the user manual was included\r\nin the .zip the application\'s executable " +
    "file\r\nwas located when downloaded. An online\r\ncopy can be found at the link belo" +
    "w.";
            this.aboutBodyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // aboutLinkLabel
            // 
            this.aboutLinkLabel.AutoSize = true;
            this.aboutLinkLabel.Location = new System.Drawing.Point(86, 111);
            this.aboutLinkLabel.Name = "aboutLinkLabel";
            this.aboutLinkLabel.Size = new System.Drawing.Size(73, 15);
            this.aboutLinkLabel.TabIndex = 2;
            this.aboutLinkLabel.TabStop = true;
            this.aboutLinkLabel.Text = "User Manual";
            this.aboutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutLinkLabel_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 137);
            this.Controls.Add(this.aboutLinkLabel);
            this.Controls.Add(this.aboutBodyLabel);
            this.Controls.Add(this.aboutHeaderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutHeaderLabel;
        private System.Windows.Forms.Label aboutBodyLabel;
        private System.Windows.Forms.LinkLabel aboutLinkLabel;
    }
}