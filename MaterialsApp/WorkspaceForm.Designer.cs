
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkspaceForm));
            this.addItemButton = new System.Windows.Forms.Button();
            this.cancelWorkspaceButton = new System.Windows.Forms.Button();
            this.saveWorkspaceButton = new System.Windows.Forms.Button();
            this.workspaceDataGrid = new System.Windows.Forms.DataGridView();
            this.itemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDescColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.workspaceTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.unitCostTextBox = new System.Windows.Forms.TextBox();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.sizeDescTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.workspaceLabel = new System.Windows.Forms.Label();
            this.workspaceBottomTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.segmentTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceDataGrid)).BeginInit();
            this.workspaceTableLayout.SuspendLayout();
            this.workspaceBottomTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(3, 3);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(144, 39);
            this.addItemButton.TabIndex = 8;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // cancelWorkspaceButton
            // 
            this.cancelWorkspaceButton.Location = new System.Drawing.Point(1053, 3);
            this.cancelWorkspaceButton.Name = "cancelWorkspaceButton";
            this.cancelWorkspaceButton.Size = new System.Drawing.Size(94, 39);
            this.cancelWorkspaceButton.TabIndex = 11;
            this.cancelWorkspaceButton.Text = "Cancel";
            this.cancelWorkspaceButton.UseVisualStyleBackColor = true;
            this.cancelWorkspaceButton.Click += new System.EventHandler(this.CancelWorkspaceButton_Click);
            // 
            // saveWorkspaceButton
            // 
            this.saveWorkspaceButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveWorkspaceButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.saveWorkspaceButton.Location = new System.Drawing.Point(953, 3);
            this.saveWorkspaceButton.Name = "saveWorkspaceButton";
            this.saveWorkspaceButton.Size = new System.Drawing.Size(94, 39);
            this.saveWorkspaceButton.TabIndex = 10;
            this.saveWorkspaceButton.Text = "Save";
            this.saveWorkspaceButton.UseVisualStyleBackColor = true;
            this.saveWorkspaceButton.Click += new System.EventHandler(this.SaveWorkspaceButton_Click);
            // 
            // workspaceDataGrid
            // 
            this.workspaceDataGrid.AllowUserToAddRows = false;
            this.workspaceDataGrid.AllowUserToDeleteRows = false;
            this.workspaceDataGrid.AllowUserToResizeColumns = false;
            this.workspaceDataGrid.AllowUserToResizeRows = false;
            this.workspaceDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.workspaceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workspaceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameColumn,
            this.materialNameColumn,
            this.sizeDescColumn,
            this.quantityColumn,
            this.unitCostColumn,
            this.totalCostColumn});
            this.workspaceTableLayout.SetColumnSpan(this.workspaceDataGrid, 6);
            this.workspaceDataGrid.Location = new System.Drawing.Point(3, 42);
            this.workspaceDataGrid.Name = "workspaceDataGrid";
            this.workspaceDataGrid.RowHeadersVisible = false;
            this.workspaceDataGrid.RowTemplate.Height = 25;
            this.workspaceDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workspaceDataGrid.Size = new System.Drawing.Size(1144, 394);
            this.workspaceDataGrid.TabIndex = 7;
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.HeaderText = "Item";
            this.itemNameColumn.Name = "itemNameColumn";
            this.itemNameColumn.ReadOnly = true;
            this.itemNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.itemNameColumn.Width = 150;
            // 
            // materialNameColumn
            // 
            this.materialNameColumn.HeaderText = "Material";
            this.materialNameColumn.Name = "materialNameColumn";
            this.materialNameColumn.ReadOnly = true;
            this.materialNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.materialNameColumn.Width = 150;
            // 
            // sizeDescColumn
            // 
            this.sizeDescColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sizeDescColumn.HeaderText = "Size / Description";
            this.sizeDescColumn.Name = "sizeDescColumn";
            this.sizeDescColumn.ReadOnly = true;
            this.sizeDescColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // quantityColumn
            // 
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ReadOnly = true;
            this.quantityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // unitCostColumn
            // 
            this.unitCostColumn.HeaderText = "Unit Cost";
            this.unitCostColumn.Name = "unitCostColumn";
            this.unitCostColumn.ReadOnly = true;
            this.unitCostColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // totalCostColumn
            // 
            this.totalCostColumn.HeaderText = "Total Cost";
            this.totalCostColumn.Name = "totalCostColumn";
            this.totalCostColumn.ReadOnly = true;
            this.totalCostColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(153, 3);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(144, 39);
            this.deleteItemButton.TabIndex = 9;
            this.deleteItemButton.Text = "Delete Item";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // workspaceTableLayout
            // 
            this.workspaceTableLayout.ColumnCount = 6;
            this.workspaceTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.workspaceTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.workspaceTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 542F));
            this.workspaceTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.workspaceTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.workspaceTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.workspaceTableLayout.Controls.Add(this.unitCostTextBox, 4, 0);
            this.workspaceTableLayout.Controls.Add(this.workspaceDataGrid, 0, 2);
            this.workspaceTableLayout.Controls.Add(this.itemComboBox, 0, 0);
            this.workspaceTableLayout.Controls.Add(this.materialComboBox, 1, 0);
            this.workspaceTableLayout.Controls.Add(this.sizeDescTextBox, 2, 0);
            this.workspaceTableLayout.Controls.Add(this.quantityTextBox, 3, 0);
            this.workspaceTableLayout.Controls.Add(this.clearButton, 5, 0);
            this.workspaceTableLayout.Location = new System.Drawing.Point(12, 12);
            this.workspaceTableLayout.Name = "workspaceTableLayout";
            this.workspaceTableLayout.RowCount = 3;
            this.workspaceTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.workspaceTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.workspaceTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.workspaceTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.workspaceTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.workspaceTableLayout.Size = new System.Drawing.Size(1150, 441);
            this.workspaceTableLayout.TabIndex = 9;
            // 
            // unitCostTextBox
            // 
            this.unitCostTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.unitCostTextBox.Location = new System.Drawing.Point(949, 4);
            this.unitCostTextBox.Name = "unitCostTextBox";
            this.unitCostTextBox.Size = new System.Drawing.Size(94, 23);
            this.unitCostTextBox.TabIndex = 5;
            this.unitCostTextBox.TextChanged += new System.EventHandler(this.QuantityOrUnitCostTextBox_TextChanged);
            // 
            // itemComboBox
            // 
            this.itemComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(3, 4);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(148, 23);
            this.itemComboBox.TabIndex = 1;
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemComboBox_SelectedIndexChanged);
            this.itemComboBox.TextChanged += new System.EventHandler(this.ItemComboBox_TextChanged);
            // 
            // materialComboBox
            // 
            this.materialComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.materialComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.materialComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(157, 4);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(144, 23);
            this.materialComboBox.TabIndex = 2;
            // 
            // sizeDescTextBox
            // 
            this.sizeDescTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sizeDescTextBox.Location = new System.Drawing.Point(307, 4);
            this.sizeDescTextBox.Name = "sizeDescTextBox";
            this.sizeDescTextBox.Size = new System.Drawing.Size(536, 23);
            this.sizeDescTextBox.TabIndex = 3;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.quantityTextBox.Location = new System.Drawing.Point(849, 4);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(94, 23);
            this.quantityTextBox.TabIndex = 4;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.QuantityOrUnitCostTextBox_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearButton.Location = new System.Drawing.Point(1060, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // workspaceLabel
            // 
            this.workspaceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.workspaceLabel.AutoSize = true;
            this.workspaceLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.workspaceLabel.Location = new System.Drawing.Point(303, 12);
            this.workspaceLabel.Name = "workspaceLabel";
            this.workspaceLabel.Size = new System.Drawing.Size(381, 20);
            this.workspaceLabel.TabIndex = 14;
            this.workspaceLabel.Text = "Workspace for undefined segment: \"undefined\"";
            this.workspaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workspaceBottomTableLayout
            // 
            this.workspaceBottomTableLayout.ColumnCount = 6;
            this.workspaceBottomTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.workspaceBottomTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.workspaceBottomTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.workspaceBottomTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.workspaceBottomTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.workspaceBottomTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.workspaceBottomTableLayout.Controls.Add(this.segmentTotalLabel, 3, 0);
            this.workspaceBottomTableLayout.Controls.Add(this.addItemButton, 0, 0);
            this.workspaceBottomTableLayout.Controls.Add(this.deleteItemButton, 1, 0);
            this.workspaceBottomTableLayout.Controls.Add(this.workspaceLabel, 2, 0);
            this.workspaceBottomTableLayout.Controls.Add(this.cancelWorkspaceButton, 5, 0);
            this.workspaceBottomTableLayout.Controls.Add(this.saveWorkspaceButton, 4, 0);
            this.workspaceBottomTableLayout.Location = new System.Drawing.Point(12, 459);
            this.workspaceBottomTableLayout.Name = "workspaceBottomTableLayout";
            this.workspaceBottomTableLayout.RowCount = 1;
            this.workspaceBottomTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.workspaceBottomTableLayout.Size = new System.Drawing.Size(1150, 45);
            this.workspaceBottomTableLayout.TabIndex = 15;
            // 
            // segmentTotalLabel
            // 
            this.segmentTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.segmentTotalLabel.AutoSize = true;
            this.segmentTotalLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.segmentTotalLabel.Location = new System.Drawing.Point(821, 12);
            this.segmentTotalLabel.Name = "segmentTotalLabel";
            this.segmentTotalLabel.Size = new System.Drawing.Size(126, 20);
            this.segmentTotalLabel.TabIndex = 16;
            this.segmentTotalLabel.Text = "Grand total: $0.00";
            // 
            // WorkspaceForm
            // 
            this.AcceptButton = this.addItemButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 516);
            this.Controls.Add(this.workspaceBottomTableLayout);
            this.Controls.Add(this.workspaceTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WorkspaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workspace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkspaceForm_FormClosing);
            this.Load += new System.EventHandler(this.WorkspaceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workspaceDataGrid)).EndInit();
            this.workspaceTableLayout.ResumeLayout(false);
            this.workspaceTableLayout.PerformLayout();
            this.workspaceBottomTableLayout.ResumeLayout(false);
            this.workspaceBottomTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button cancelWorkspaceButton;
        private System.Windows.Forms.Button saveWorkspaceButton;
        private System.Windows.Forms.DataGridView workspaceDataGrid;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.TableLayoutPanel workspaceTableLayout;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDescColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostColumn;
        private System.Windows.Forms.TextBox unitCostTextBox;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.TextBox sizeDescTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label workspaceLabel;
        private System.Windows.Forms.TableLayoutPanel workspaceBottomTableLayout;
        private System.Windows.Forms.Label segmentTotalLabel;
        private System.Windows.Forms.Button clearButton;
    }
}