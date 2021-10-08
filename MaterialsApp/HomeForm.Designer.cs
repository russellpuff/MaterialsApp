
namespace MaterialsApp
{
    partial class HomeForm
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
            this.newSegmentButton = new System.Windows.Forms.Button();
            this.hDataGrid = new System.Windows.Forms.DataGridView();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editSegmentButton = new System.Windows.Forms.Button();
            this.deleteSegmentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // newSegmentButton
            // 
            this.newSegmentButton.Location = new System.Drawing.Point(12, 386);
            this.newSegmentButton.Name = "newSegmentButton";
            this.newSegmentButton.Size = new System.Drawing.Size(75, 23);
            this.newSegmentButton.TabIndex = 6;
            this.newSegmentButton.Text = "New";
            this.newSegmentButton.UseVisualStyleBackColor = true;
            this.newSegmentButton.Click += new System.EventHandler(this.NewSegmentButton_Click);
            // 
            // hDataGrid
            // 
            this.hDataGrid.AllowUserToAddRows = false;
            this.hDataGrid.AllowUserToDeleteRows = false;
            this.hDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeColumn,
            this.nameColumn,
            this.costColumn,
            this.idColumn});
            this.hDataGrid.Location = new System.Drawing.Point(12, 36);
            this.hDataGrid.Name = "hDataGrid";
            this.hDataGrid.ReadOnly = true;
            this.hDataGrid.RowHeadersVisible = false;
            this.hDataGrid.RowTemplate.Height = 25;
            this.hDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hDataGrid.Size = new System.Drawing.Size(303, 333);
            this.hDataGrid.TabIndex = 7;
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // costColumn
            // 
            this.costColumn.HeaderText = "Cost";
            this.costColumn.Name = "costColumn";
            this.costColumn.ReadOnly = true;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // editSegmentButton
            // 
            this.editSegmentButton.Location = new System.Drawing.Point(125, 386);
            this.editSegmentButton.Name = "editSegmentButton";
            this.editSegmentButton.Size = new System.Drawing.Size(75, 23);
            this.editSegmentButton.TabIndex = 8;
            this.editSegmentButton.Text = "Edit";
            this.editSegmentButton.UseVisualStyleBackColor = true;
            // 
            // deleteSegmentButton
            // 
            this.deleteSegmentButton.Location = new System.Drawing.Point(240, 386);
            this.deleteSegmentButton.Name = "deleteSegmentButton";
            this.deleteSegmentButton.Size = new System.Drawing.Size(75, 23);
            this.deleteSegmentButton.TabIndex = 9;
            this.deleteSegmentButton.Text = "Delete";
            this.deleteSegmentButton.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 577);
            this.Controls.Add(this.deleteSegmentButton);
            this.Controls.Add(this.editSegmentButton);
            this.Controls.Add(this.hDataGrid);
            this.Controls.Add(this.newSegmentButton);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materials Cost Estimator";
            ((System.ComponentModel.ISupportInitialize)(this.hDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newSegmentButton;
        private System.Windows.Forms.DataGridView hDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.Button editSegmentButton;
        private System.Windows.Forms.Button deleteSegmentButton;
    }
}

