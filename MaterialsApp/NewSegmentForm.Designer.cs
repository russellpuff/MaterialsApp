
namespace MaterialsApp
{
    partial class NewSegmentForm
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
            this.sTypeComboBox = new System.Windows.Forms.ComboBox();
            this.sNameTextBox = new System.Windows.Forms.TextBox();
            this.sTypeLabel = new System.Windows.Forms.Label();
            this.sNameLabel = new System.Windows.Forms.Label();
            this.sAcceptButton = new System.Windows.Forms.Button();
            this.sCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sTypeComboBox
            // 
            this.sTypeComboBox.FormattingEnabled = true;
            this.sTypeComboBox.Location = new System.Drawing.Point(12, 43);
            this.sTypeComboBox.Name = "sTypeComboBox";
            this.sTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.sTypeComboBox.TabIndex = 0;
            // 
            // sNameTextBox
            // 
            this.sNameTextBox.Location = new System.Drawing.Point(139, 43);
            this.sNameTextBox.Name = "sNameTextBox";
            this.sNameTextBox.Size = new System.Drawing.Size(204, 23);
            this.sNameTextBox.TabIndex = 1;
            // 
            // sTypeLabel
            // 
            this.sTypeLabel.AutoSize = true;
            this.sTypeLabel.Location = new System.Drawing.Point(12, 25);
            this.sTypeLabel.Name = "sTypeLabel";
            this.sTypeLabel.Size = new System.Drawing.Size(80, 15);
            this.sTypeLabel.TabIndex = 2;
            this.sTypeLabel.Text = "Segment type";
            // 
            // sNameLabel
            // 
            this.sNameLabel.AutoSize = true;
            this.sNameLabel.Location = new System.Drawing.Point(139, 25);
            this.sNameLabel.Name = "sNameLabel";
            this.sNameLabel.Size = new System.Drawing.Size(87, 15);
            this.sNameLabel.TabIndex = 3;
            this.sNameLabel.Text = "Segment name";
            // 
            // sAcceptButton
            // 
            this.sAcceptButton.Location = new System.Drawing.Point(97, 83);
            this.sAcceptButton.Name = "sAcceptButton";
            this.sAcceptButton.Size = new System.Drawing.Size(75, 23);
            this.sAcceptButton.TabIndex = 4;
            this.sAcceptButton.Text = "Accept";
            this.sAcceptButton.UseVisualStyleBackColor = true;
            this.sAcceptButton.Click += new System.EventHandler(this.SAcceptButton_Click);
            // 
            // sCancelButton
            // 
            this.sCancelButton.Location = new System.Drawing.Point(188, 83);
            this.sCancelButton.Name = "sCancelButton";
            this.sCancelButton.Size = new System.Drawing.Size(75, 23);
            this.sCancelButton.TabIndex = 5;
            this.sCancelButton.Text = "Cancel";
            this.sCancelButton.UseVisualStyleBackColor = true;
            this.sCancelButton.Click += new System.EventHandler(this.SCancelButton_Click);
            // 
            // NewSegmentForm
            // 
            this.AcceptButton = this.sAcceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.sCancelButton;
            this.ClientSize = new System.Drawing.Size(356, 120);
            this.Controls.Add(this.sCancelButton);
            this.Controls.Add(this.sAcceptButton);
            this.Controls.Add(this.sNameLabel);
            this.Controls.Add(this.sTypeLabel);
            this.Controls.Add(this.sNameTextBox);
            this.Controls.Add(this.sTypeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewSegmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New segment";
            this.Load += new System.EventHandler(this.NewSegmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sTypeComboBox;
        private System.Windows.Forms.TextBox sNameTextBox;
        private System.Windows.Forms.Label sTypeLabel;
        private System.Windows.Forms.Label sNameLabel;
        private System.Windows.Forms.Button sAcceptButton;
        private System.Windows.Forms.Button sCancelButton;
    }
}