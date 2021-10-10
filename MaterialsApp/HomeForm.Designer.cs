
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
            this.homeDataGrid = new System.Windows.Forms.DataGridView();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editSegmentButton = new System.Windows.Forms.Button();
            this.deleteSegmentButton = new System.Windows.Forms.Button();
            this.homeGrandTotalLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.homeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.homeDataGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.homeMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // newSegmentButton
            // 
            this.newSegmentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newSegmentButton.Location = new System.Drawing.Point(3, 3);
            this.newSegmentButton.Name = "newSegmentButton";
            this.newSegmentButton.Size = new System.Drawing.Size(71, 30);
            this.newSegmentButton.TabIndex = 1;
            this.newSegmentButton.Text = "New";
            this.newSegmentButton.UseVisualStyleBackColor = true;
            this.newSegmentButton.Click += new System.EventHandler(this.NewSegmentButton_Click);
            // 
            // homeDataGrid
            // 
            this.homeDataGrid.AllowUserToAddRows = false;
            this.homeDataGrid.AllowUserToDeleteRows = false;
            this.homeDataGrid.AllowUserToResizeColumns = false;
            this.homeDataGrid.AllowUserToResizeRows = false;
            this.homeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeColumn,
            this.nameColumn,
            this.costColumn,
            this.idColumn});
            this.homeDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.homeDataGrid.Location = new System.Drawing.Point(12, 27);
            this.homeDataGrid.Name = "homeDataGrid";
            this.homeDataGrid.RowHeadersVisible = false;
            this.homeDataGrid.RowTemplate.Height = 25;
            this.homeDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.homeDataGrid.Size = new System.Drawing.Size(303, 342);
            this.homeDataGrid.TabIndex = 0;
            this.homeDataGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.HomeDataGrid_CellValidating);
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.ReadOnly = true;
            this.typeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // costColumn
            // 
            this.costColumn.HeaderText = "Cost";
            this.costColumn.Name = "costColumn";
            this.costColumn.ReadOnly = true;
            this.costColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idColumn.Visible = false;
            // 
            // editSegmentButton
            // 
            this.editSegmentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editSegmentButton.Location = new System.Drawing.Point(115, 3);
            this.editSegmentButton.Name = "editSegmentButton";
            this.editSegmentButton.Size = new System.Drawing.Size(71, 30);
            this.editSegmentButton.TabIndex = 2;
            this.editSegmentButton.Text = "Edit";
            this.editSegmentButton.UseVisualStyleBackColor = true;
            this.editSegmentButton.Click += new System.EventHandler(this.EditSegmentButton_Click);
            // 
            // deleteSegmentButton
            // 
            this.deleteSegmentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteSegmentButton.Location = new System.Drawing.Point(227, 3);
            this.deleteSegmentButton.Name = "deleteSegmentButton";
            this.deleteSegmentButton.Size = new System.Drawing.Size(73, 30);
            this.deleteSegmentButton.TabIndex = 3;
            this.deleteSegmentButton.Text = "Delete";
            this.deleteSegmentButton.UseVisualStyleBackColor = true;
            this.deleteSegmentButton.Click += new System.EventHandler(this.DeleteSegmentButton_Click);
            // 
            // homeGrandTotalLabel
            // 
            this.homeGrandTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeGrandTotalLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeGrandTotalLabel.Location = new System.Drawing.Point(9, 425);
            this.homeGrandTotalLabel.Name = "homeGrandTotalLabel";
            this.homeGrandTotalLabel.Size = new System.Drawing.Size(303, 40);
            this.homeGrandTotalLabel.TabIndex = 4;
            this.homeGrandTotalLabel.Text = "Grand Total\r\n$0.00";
            this.homeGrandTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.Controls.Add(this.editSegmentButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteSegmentButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.newSegmentButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 375);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 36);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // homeMenuStrip
            // 
            this.homeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.homeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.homeMenuStrip.Name = "homeMenuStrip";
            this.homeMenuStrip.Size = new System.Drawing.Size(326, 24);
            this.homeMenuStrip.TabIndex = 13;
            this.homeMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.viewReportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.MenuStripNew_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.MenuStripOpen_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.MenuStripSave_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.MenuStripSaveAs_Click);
            // 
            // viewReportToolStripMenuItem
            // 
            this.viewReportToolStripMenuItem.Name = "viewReportToolStripMenuItem";
            this.viewReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewReportToolStripMenuItem.Text = "View Report";
            this.viewReportToolStripMenuItem.Click += new System.EventHandler(this.MenuStripViewReport_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.documentationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.MenuStripAbout_Click);
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            this.documentationToolStripMenuItem.Click += new System.EventHandler(this.MenuStripDocumentation_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 474);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.homeGrandTotalLabel);
            this.Controls.Add(this.homeDataGrid);
            this.Controls.Add(this.homeMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.homeMenuStrip;
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materials Cost Estimator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homeDataGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.homeMenuStrip.ResumeLayout(false);
            this.homeMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newSegmentButton;
        private System.Windows.Forms.DataGridView homeDataGrid;
        private System.Windows.Forms.Button editSegmentButton;
        private System.Windows.Forms.Button deleteSegmentButton;
        private System.Windows.Forms.Label homeGrandTotalLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip homeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
    }
}

