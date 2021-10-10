using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialsApp
{
    public partial class SummaryForm : Form
    {
        readonly decimal sfGrandTotal;
        public SummaryForm(decimal importedTotal)
        {
            InitializeComponent();
            sfGrandTotal = importedTotal;
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            var ordered = Globals.segments.OrderBy(Segment => Segment.SegType);
            foreach(Segment s in ordered)
            {
                string info = s.SegType + ": \"" + s.SegName + "\" - Cost for segment: " + s.SegCost.ToString("C", CultureInfo.GetCultureInfo("en-US"));
                int i = 0;
                foreach (DataRow r in s.SegTable.Rows)
                {
                    string[] row = new string[7];
                    if (i == 0)
                    {
                        row = new string[7] { info, r[0].ToString(), r[1].ToString(), r[2].ToString(), r[3].ToString(), r[4].ToString(), r[5].ToString() };
                    } else
                    {
                        row = new string[7] { "", r[0].ToString(), r[1].ToString(), r[2].ToString(), r[3].ToString(), r[4].ToString(), r[5].ToString() };
                    }
                    ++i;
                    summaryDataGrid.Rows.Add(row);
                }
                Segment last = ordered.Last();
                if (!s.Equals(last))
                {
                    string[] row = new string[7] { "","","","","","","" }; // Formatting. Adds a blank row to divide segments. 
                    summaryDataGrid.Rows.Add(row);
                }
            }
            sGrandTotalLabel.Text = "Grand total: " + sfGrandTotal.ToString("C", CultureInfo.GetCultureInfo("en-US"));
        }

        private void SummaryDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            summaryDataGrid.ClearSelection();
        }

        private void ExportCSVButton_Click(object sender, EventArgs e)
        {
            var ordered = Globals.segments.OrderBy(Segment => Segment.SegType);

            SaveFileDialog saveFile = new();
            saveFile.Filter = "TSV File|*.tsv"; // Originally it exported to .csv but as it turns out, having commas in your dollar values fucks it up. 
            saveFile.Title = "Save Report As";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string filepath = saveFile.FileName;
                StreamWriter writer;
                try
                {
                    writer = new(filepath);
                } catch
                {
                    MessageBox.Show("There was a problem with the export. Are you trying to overwrite a file in use?", "Export error", MessageBoxButtons.OK);
                    return;
                }
                writer.Write("Building Materials Cost Estimate");
                writer.Write("\nInfo\tItem\tMaterial\tSize / Description\tQuantity\tUnit Cost\tTotal Cost");

                foreach (Segment s in ordered)
                {
                    string info = s.SegType + ": \"" + s.SegName + "\" - Cost for segment: " + s.SegCost.ToString("C", CultureInfo.GetCultureInfo("en-US"));
                    int i = 0;
                    foreach (DataRow r in s.SegTable.Rows)
                    {
                        string[] row = new string[7];
                        if (i == 0)
                        {
                            writer.Write("\n{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", info, r[0].ToString(), r[1].ToString(), r[2].ToString(), r[3].ToString(), r[4].ToString(), r[5].ToString());
                        }
                        else
                        {
                            writer.Write("\n\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}", r[0].ToString(), r[1].ToString(), r[2].ToString(), r[3].ToString(), r[4].ToString(), r[5].ToString());
                        }
                        ++i;
                    }
                    Segment last = ordered.Last();
                    if (!s.Equals(last))
                    {
                        writer.Write("\n"); 
                    }
                }

                writer.Write("\nGrand total: {0}", sfGrandTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                writer.Close();
                MessageBox.Show("Successfully exported to .tsv\nThis file can be opened in a spreadsheet editor such as Excel for formatting, if promtpted to select delimiter type, the type is Tab.", "Export successful", MessageBoxButtons.OK);
            } 
        }
    }
}
