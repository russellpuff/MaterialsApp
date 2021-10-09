using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace MaterialsApp
{
    public partial class HomeForm : Form
    {
        decimal workspaceReturnTotal;
        decimal homeGrandTotal = 0;

        bool isDirty = false; // unsaved changes
        bool brandNew = true; // form has never been saved before

        OpenFileDialog openFile;

        const string grandTotalHeader = "Grand Total";

        public HomeForm()
        {
            InitializeComponent();
        }

        private void WorkspaceFormOpener(Segment obj, bool newWS = true)
        {
            WorkspaceForm ws = new(obj.SegType, obj.SegName, obj.SegTable, newWS);
            this.Enabled = false;
            if (ws.ShowDialog() == DialogResult.OK)
            {
                obj.SegTable = ws.WsTable;
                workspaceReturnTotal = ws.ReturnTotal;
                if (newWS)
                {
                    Globals.segments.Add(obj);
                    string[] row = new string[4] { obj.SegType, obj.SegName, workspaceReturnTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")), obj.SegId.ToString() };
                    homeDataGrid.Rows.Add(row);
                } else
                {
                    int ind = IndexHunt(obj.SegId, false);
                    decimal sub = (decimal)homeDataGrid.Rows[ind].Cells[2].Value;
                    homeGrandTotal -= sub;
                }
                homeGrandTotal += workspaceReturnTotal;
                homeGrandTotalLabel.Text = grandTotalHeader + "\n" + homeGrandTotal.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            }
            isDirty = true;
            this.Enabled = true;
        }

        private int IndexHunt(int id, bool listHunt) // listHunt = you have the ID from the row and need the list index
        { // !listHunt = you have the ID from the list, you need the row index
            int i = 0;
            
            if (listHunt)
            {
                foreach (Segment s in Globals.segments)
                {
                    if (s.SegId == id)
                    {
                        return i;
                    }
                    ++i;
                }
            } else
            {
                foreach (DataGridViewRow r in homeDataGrid.Rows)
                {
                    if ((int)r.Cells[3].Value == id)
                    {
                        return i;
                    }
                    ++i;
                }
            }
            return -1; // Theoretically impossible, but required to avoid IDE bitching.
        }

        private void NewSegmentButton_Click(object sender, EventArgs e)
        {
            NewSegmentForm nsf = new();
            if (nsf.ShowDialog() == DialogResult.OK)
            {
                Segment seg = new();
                seg.SegType = nsf.SegTypeDefined;
                seg.SegName = nsf.SegNameDefined;
                Random rand = new();
                seg.SegId = rand.Next(1, 65535);
                seg.SegTable = new DataTable
                {
                    TableName = "SegTable" // Cereal machine yells at me if these are unnamed. 
                };
                WorkspaceFormOpener(seg);
            }
            SaveEnable();
        }

        private void EditSegmentButton_Click(object sender, EventArgs e)
        {
            int index = homeDataGrid.CurrentCell.RowIndex;
            if (index != 1)
            {
                string temp = homeDataGrid.Rows[index].Cells[3].Value.ToString();
                int tempID = Int32.Parse(temp);
                int target = IndexHunt(tempID, true);
                WorkspaceFormOpener(Globals.segments[target], false);
            }
        }

        private void DeleteSegmentButton_Click(object sender, EventArgs e)
        {
            int index = homeDataGrid.CurrentCell.RowIndex;
            string tempType = homeDataGrid.Rows[index].Cells[0].Value.ToString();
            string tempName = homeDataGrid.Rows[index].Cells[1].Value.ToString();
            string tempMessage = "Are you sure you want to delete this " + tempType + " segment: \"" + tempName + "\"?";
            DialogResult result;
            result = MessageBox.Show(tempMessage, "Delete segment?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string temp = homeDataGrid.Rows[index].Cells[3].Value.ToString();
                int tempID = Int32.Parse(temp);
                int target = IndexHunt(tempID, true);

                temp = homeDataGrid.Rows[index].Cells[2].Value.ToString();
                temp = temp.Substring(1);
                decimal tempCost = decimal.Parse(temp);
                homeGrandTotal -= tempCost;
                homeGrandTotalLabel.Text = grandTotalHeader + "\n" + homeGrandTotal.ToString("C", CultureInfo.GetCultureInfo("en-US"));

                Globals.segments.RemoveAt(target);
                homeDataGrid.Rows.RemoveAt(index);
                SaveEnable();
            }
        }

        private void SaveEnable()
        {
            bool isEmpty = !Globals.segments.Any();
            if (isEmpty)
            {
                saveToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
            } else
            {
                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
            }
        }

        private void MenuStripOpen_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog()
            {
                FileName = "Select a project file",
                Filter = "XML files (*xml)|*xml",
                Title = "Open XML file"
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                DialogResult result;
                if (isDirty) 
                {
                    result = MessageBox.Show("You currently have unsaved changes. Save your changes?", "Unsaved changes", MessageBoxButtons.YesNoCancel);
                } else
                {
                    result = DialogResult.No;
                }
                switch (result)
                {
                    case DialogResult.Yes:
                        MenuStripSave_Click(null, null);
                        goto case DialogResult.No;
                    case DialogResult.No:
                        Globals.filepath = openFile.FileName; // do stuff with the file once loaded
                        SaveEnable();
                        break;
                }
            }
        }

        private void MenuStripSave_Click(object sender, EventArgs e)
        {
            if (brandNew && isDirty)
            {
                MenuStripSaveAs_Click(null, null);
                brandNew = false;
            } else
            {
                XmlSerializer cereal = new(Globals.segments.GetType());
                TextWriter writer = new StreamWriter(Globals.filepath);
                cereal.Serialize(writer, Globals.segments);
                writer.Close();
            }
            isDirty = false;
        }

        private void MenuStripSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new();
            saveFile.Filter = "XML File|*.xml";
            saveFile.Title = "Save Project File";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Globals.filepath = saveFile.FileName;

                XmlSerializer cereal = new(Globals.segments.GetType());
                TextWriter writer = new StreamWriter(Globals.filepath);

                cereal.Serialize(writer, Globals.segments);
                writer.Close();
                isDirty = false;
            }
        }

        private void MenuStripBuildReport_Click(object sender, EventArgs e)
        {

        }

        private void MenuStripAbout_Click(object sender, EventArgs e)
        {

        }

        private void MenuStripDocumentation_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            SaveEnable();
        }
    }
    public class Segment
    {
        public string SegType { get; set; }
        public string SegName { get; set; }
        public int SegId { get; set; }
        public DataTable SegTable { get; set; }
    }

    public static class Globals
    {
        public static List<Segment> segments = new();
        public static string filepath;
    }
}
