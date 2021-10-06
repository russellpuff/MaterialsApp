
namespace MaterialsApp
{
    partial class WorkspaceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cancelWorkspaceButton = new System.Windows.Forms.Button();
            this.acceptWorkspaceButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ben\'s stuff";
            // 
            // cancelWorkspaceButton
            // 
            this.cancelWorkspaceButton.Location = new System.Drawing.Point(936, 599);
            this.cancelWorkspaceButton.Name = "cancelWorkspaceButton";
            this.cancelWorkspaceButton.Size = new System.Drawing.Size(75, 23);
            this.cancelWorkspaceButton.TabIndex = 1;
            this.cancelWorkspaceButton.Text = "Close";
            this.cancelWorkspaceButton.UseVisualStyleBackColor = true;
            this.cancelWorkspaceButton.Click += new System.EventHandler(this.CloseWorkspaceButton_Click);
            // 
            // acceptWorkspaceButton
            // 
            this.acceptWorkspaceButton.Location = new System.Drawing.Point(823, 599);
            this.acceptWorkspaceButton.Name = "acceptWorkspaceButton";
            this.acceptWorkspaceButton.Size = new System.Drawing.Size(75, 23);
            this.acceptWorkspaceButton.TabIndex = 2;
            this.acceptWorkspaceButton.Text = "Accept";
            this.acceptWorkspaceButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(406, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // WorkspaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.acceptWorkspaceButton);
            this.Controls.Add(this.cancelWorkspaceButton);
            this.Controls.Add(this.label1);
            this.Name = "WorkspaceForm";
            this.Text = "WorkspaceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelWorkspaceButton;
        private System.Windows.Forms.Button acceptWorkspaceButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}