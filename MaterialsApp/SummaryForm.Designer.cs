
namespace MaterialsApp
{
    partial class SummaryForm
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
            this.summaryDataGrid = new System.Windows.Forms.DataGridView();
            this.sInfoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sItemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaterialNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSizeDescColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUnitCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTotalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportTSVButton = new System.Windows.Forms.Button();
            this.sGrandTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.summaryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // summaryDataGrid
            // 
            this.summaryDataGrid.AllowUserToAddRows = false;
            this.summaryDataGrid.AllowUserToDeleteRows = false;
            this.summaryDataGrid.AllowUserToResizeColumns = false;
            this.summaryDataGrid.AllowUserToResizeRows = false;
            this.summaryDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.summaryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summaryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sInfoColumn,
            this.sItemNameColumn,
            this.sMaterialNameColumn,
            this.sSizeDescColumn,
            this.sQuantityColumn,
            this.sUnitCostColumn,
            this.sTotalCostColumn});
            this.summaryDataGrid.Location = new System.Drawing.Point(12, 10);
            this.summaryDataGrid.MultiSelect = false;
            this.summaryDataGrid.Name = "summaryDataGrid";
            this.summaryDataGrid.ReadOnly = true;
            this.summaryDataGrid.RowHeadersVisible = false;
            this.summaryDataGrid.RowTemplate.Height = 25;
            this.summaryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.summaryDataGrid.Size = new System.Drawing.Size(1295, 465);
            this.summaryDataGrid.TabIndex = 8;
            this.summaryDataGrid.SelectionChanged += new System.EventHandler(this.SummaryDataGrid_SelectionChanged);
            // 
            // sInfoColumn
            // 
            this.sInfoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sInfoColumn.HeaderText = "Info";
            this.sInfoColumn.Name = "sInfoColumn";
            this.sInfoColumn.ReadOnly = true;
            this.sInfoColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sInfoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sInfoColumn.Width = 34;
            // 
            // sItemNameColumn
            // 
            this.sItemNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sItemNameColumn.HeaderText = "Item";
            this.sItemNameColumn.Name = "sItemNameColumn";
            this.sItemNameColumn.ReadOnly = true;
            this.sItemNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sItemNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sItemNameColumn.Width = 125;
            // 
            // sMaterialNameColumn
            // 
            this.sMaterialNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sMaterialNameColumn.HeaderText = "Material";
            this.sMaterialNameColumn.Name = "sMaterialNameColumn";
            this.sMaterialNameColumn.ReadOnly = true;
            this.sMaterialNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sMaterialNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sMaterialNameColumn.Width = 125;
            // 
            // sSizeDescColumn
            // 
            this.sSizeDescColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sSizeDescColumn.HeaderText = "Size / Description";
            this.sSizeDescColumn.Name = "sSizeDescColumn";
            this.sSizeDescColumn.ReadOnly = true;
            this.sSizeDescColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sSizeDescColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sQuantityColumn
            // 
            this.sQuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sQuantityColumn.HeaderText = "Quantity";
            this.sQuantityColumn.Name = "sQuantityColumn";
            this.sQuantityColumn.ReadOnly = true;
            this.sQuantityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sQuantityColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sQuantityColumn.Width = 59;
            // 
            // sUnitCostColumn
            // 
            this.sUnitCostColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sUnitCostColumn.HeaderText = "Unit Cost";
            this.sUnitCostColumn.Name = "sUnitCostColumn";
            this.sUnitCostColumn.ReadOnly = true;
            this.sUnitCostColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sUnitCostColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sUnitCostColumn.Width = 62;
            // 
            // sTotalCostColumn
            // 
            this.sTotalCostColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sTotalCostColumn.HeaderText = "Total Cost";
            this.sTotalCostColumn.Name = "sTotalCostColumn";
            this.sTotalCostColumn.ReadOnly = true;
            this.sTotalCostColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sTotalCostColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sTotalCostColumn.Width = 65;
            // 
            // exportTSVButton
            // 
            this.exportTSVButton.Location = new System.Drawing.Point(12, 481);
            this.exportTSVButton.Name = "exportTSVButton";
            this.exportTSVButton.Size = new System.Drawing.Size(96, 30);
            this.exportTSVButton.TabIndex = 9;
            this.exportTSVButton.Text = "Export to .tsv";
            this.exportTSVButton.UseVisualStyleBackColor = true;
            this.exportTSVButton.Click += new System.EventHandler(this.ExportCSVButton_Click);
            // 
            // sGrandTotalLabel
            // 
            this.sGrandTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sGrandTotalLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sGrandTotalLabel.Location = new System.Drawing.Point(762, 491);
            this.sGrandTotalLabel.Name = "sGrandTotalLabel";
            this.sGrandTotalLabel.Size = new System.Drawing.Size(545, 20);
            this.sGrandTotalLabel.TabIndex = 10;
            this.sGrandTotalLabel.Text = "Grand Total: $0.00";
            this.sGrandTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 522);
            this.Controls.Add(this.sGrandTotalLabel);
            this.Controls.Add(this.exportTSVButton);
            this.Controls.Add(this.summaryDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SummaryForm";
            this.Text = "Summary";
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.summaryDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView summaryDataGrid;
        private System.Windows.Forms.Button exportTSVButton;
        private System.Windows.Forms.Label sGrandTotalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn sInfoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sItemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaterialNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSizeDescColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUnitCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTotalCostColumn;
    }
}