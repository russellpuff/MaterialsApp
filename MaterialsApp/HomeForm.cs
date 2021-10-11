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
        bool isDirty = false; // unsaved changes
        bool brandNew = true; // form has never been saved before
        decimal homeGrandTotal = 0;
        const string grandTotalHeader = "Grand Total";

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            ControlEnable();
        }
        //
        // Home Buttons and their related functionality.
        //
        private void NewSegmentButton_Click(object sender, EventArgs e)
        {
            NewSegmentForm nsf = new();
            if (nsf.ShowDialog() == DialogResult.OK)
            {
                Segment seg = new();
                seg.SegType = nsf.SegTypeDefined;
                seg.SegName = nsf.SegNameDefined;

                Random rand = new();
                bool pass = false;
                int idTest = 0;
                while (!pass) // In the slim chance the ID is in use, generates a new one. 
                {
                    idTest = rand.Next(1, 65535);
                    if (!Globals.segments.Any()) // Dodges an infinite loop caused when creating the first segment in any given project.
                    {
                        pass = true;
                    }
                    foreach (Segment s in Globals.segments)
                    {
                        pass = true;
                        if (s.SegId == idTest)
                        {
                            pass = false;
                        } 
                    }
                }
                seg.SegId = idTest;

                seg.SegTable = new DataTable
                {
                    TableName = "SegTable" // Cereal machine yells at me if these are unnamed. 
                };
                WorkspaceFormOpener(seg);
            }
            ControlEnable();
        }

        private void EditSegmentButton_Click(object sender, EventArgs e)
        {

            int index = homeDataGrid.CurrentCell.RowIndex;
            string temp = homeDataGrid.Rows[index].Cells[3].Value.ToString();
            int tempID = Int32.Parse(temp);
            int target = IndexHunt(tempID, true);
            WorkspaceFormOpener(Globals.segments[target], false);
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
                ControlEnable();
            }
        }

        private void WorkspaceFormOpener(Segment obj, bool newWS = true)
        {
            WorkspaceForm ws = new(obj.SegType, obj.SegName, obj.SegTable, newWS);
            this.Enabled = false;
            if (ws.ShowDialog() == DialogResult.OK)
            {
                obj.SegTable = ws.WsTable;
                obj.SegCost = ws.ReturnTotal;
                if (newWS)
                {
                    Globals.segments.Add(obj);
                    string[] row = new string[4] { obj.SegType, obj.SegName, obj.SegCost.ToString("C", CultureInfo.GetCultureInfo("en-US")), obj.SegId.ToString() };
                    homeDataGrid.Rows.Add(row);
                } else
                {
                    int ind = IndexHunt(obj.SegId, false);
                    string dparse = homeDataGrid.Rows[ind].Cells[2].Value.ToString();
                    dparse = dparse.Substring(1);
                    decimal sub = decimal.Parse(dparse);
                    homeGrandTotal -= sub;
                    homeDataGrid.Rows[ind].Cells[2].Value = obj.SegCost;
                }
                homeGrandTotal += obj.SegCost;
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
                    string temperone = r.Cells[3].Value.ToString();
                    if (Int32.Parse(temperone) == id)
                    {
                        return i;
                    }
                    ++i;
                }
            }
            return -1; // Debug value.
        }
        //
        // UI and table stuff. 
        //
        private void ControlEnable() // Enables or disables a myriad of controls based on whether the user has any segments. Avoids headaches. 
        {
            bool isEmpty = !Globals.segments.Any();
            if (isEmpty)
            {
                saveToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
                viewReportToolStripMenuItem.Enabled = false;
                editSegmentButton.Enabled = false;
                deleteSegmentButton.Enabled = false;
            } else
            {
                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
                viewReportToolStripMenuItem.Enabled = true;
                editSegmentButton.Enabled = true;
                deleteSegmentButton.Enabled = true;
            }
        }
        private void HomeDataGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) // Cell editing stuff. 
        {
            string headerText = homeDataGrid.Columns[e.ColumnIndex].HeaderText;
            if (!headerText.Equals("Name")) return; // Aborts if for some reason the cell being edited isn't in the right column. 

            int index = homeDataGrid.CurrentCell.RowIndex;
            string oldName = homeDataGrid.Rows[index].Cells[1].Value.ToString();

            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                MessageBox.Show("Name cannot be empty.", "Rename error", MessageBoxButtons.OK);
                e.Cancel = true;
            }
            else if (e.FormattedValue.ToString() != oldName)
            {
                DialogResult result;
                string msg = "Are you sure you want to rename " + oldName + " to " + e.FormattedValue.ToString() + "?";
                result = MessageBox.Show(msg, "Rename confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string temp = homeDataGrid.Rows[index].Cells[3].Value.ToString();
                    int ind = Int32.Parse(temp);
                    ind = IndexHunt(ind, true);
                    Globals.segments[ind].SegName = e.FormattedValue.ToString();
                }
                else
                {
                    e.Cancel = true;
                    homeDataGrid.CancelEdit();
                }
            }
        }
        //
        // Menu strip stuff.
        //
        private void MenuStripOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new()
            {
                Filter = "XML files (*xml)|*xml",
                Title = "Open"
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
                        Globals.filepath = openFile.FileName;
                        bool saveOk;
                        List<Segment> loadTest = new(Globals.segments);
                        try
                        {
                            XmlSerializer cereal = new(loadTest.GetType());
                            TextReader reader = new StreamReader(Globals.filepath);
                            Globals.segments.Clear();
                            Globals.segments = (List<Segment>)cereal.Deserialize(reader);
                            reader.Close();
                            saveOk = true;
                            brandNew = false;
                        } catch
                        {
                            MessageBox.Show("There was an error with the file you tried to open.", "Open file error", MessageBoxButtons.OK);
                            Globals.segments = loadTest;
                            saveOk = false;
                        }
                        ControlEnable();

                        if (saveOk)
                        {
                            homeDataGrid.Rows.Clear();
                            homeGrandTotal = 0;
                            foreach (Segment s in Globals.segments)
                            {
                                string[] row = new string[4] { s.SegType, s.SegName, s.SegCost.ToString("C", CultureInfo.GetCultureInfo("en-US")), s.SegId.ToString() };
                                homeDataGrid.Rows.Add(row);
                                homeGrandTotal += s.SegCost;
                            }
                            homeGrandTotalLabel.Text = grandTotalHeader + "\n" + homeGrandTotal.ToString("C", CultureInfo.GetCultureInfo("en-US"));
                        }
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
            saveFile.Title = "Save As";
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

        private void MenuStripViewReport_Click(object sender, EventArgs e)
        {
            SummaryForm sf = new(homeGrandTotal);
            this.Enabled = false;
            sf.ShowDialog();
            this.Enabled = true;
        }

        private void MenuStripAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Materials List Estimator is a free report builder for constructon companies. It was created for the SDEV240 final project at ITCC by Ben Christmas and Brian LaTulip in C#.", "About", MessageBoxButtons.OK);
        }

        private void MenuStripDocumentation_Click(object sender, EventArgs e)
        {
            AboutForm af = new();
            af.ShowDialog();
        }

        private void MenuStripNew_Click(object sender, EventArgs e) // It doesn't like it if I add a third variable to the Click event. 
        {
            MenuStripNewWorkaround();
        }

        private void MenuStripNewWorkaround(int newType = 0) // 0 is the first time it's fired, 1 means it's either saved or ignored, 2 means cancelled
        {
            if (!isDirty)
            {
                newType = 1; // Avoids a bug where the user can't create a new project if they load an existing project then immediately try to start a new one. 
            }
            switch (newType)
            {
                case 0:
                    int z = 1;
                    HomeForm_FormClosing(z, null);
                    break;
                case 1:
                    Application.Restart();
                    break;
                // 2 doesn't have a case but is an expected value. In the scenario where the user tries to open a new project without saving, if they hit cancel, this dodges the act of restarting the application.
            }
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDirty)
            {
                DialogResult result;
                if (isDirty)
                {
                    result = MessageBox.Show("You currently have unsaved changes. Save your changes?", "Unsaved changes", MessageBoxButtons.YesNoCancel);
                }
                else
                {
                    result = DialogResult.No;
                }
                switch (result)
                {
                    case DialogResult.Yes:
                        MenuStripSave_Click(null, null);
                        break;
                    case DialogResult.Cancel:
                        try
                        {
                            if ((int)sender != 1)
                            {
                                e.Cancel = true;
                            }
                        } catch
                        {
                            e.Cancel = true;
                        }
                        break;
                }
                try
                {
                    if ((result == DialogResult.Yes || result == DialogResult.No) && (int)sender == 1) // Big stupid idiot solution to a problem with Application.Restart() when the user decides to cancel creating a new project. 
                    {
                        isDirty = false;
                        MenuStripNewWorkaround(1);
                    }
                    else if (result == DialogResult.Cancel && (int)sender == 1)
                    {
                        MenuStripNewWorkaround(2);
                    }
                } catch { } // Doesn't allow me to tryparse to avoid an exception, so instead I'll do a trycatch without a catch. 
            }
        }
    }
    public class Segment // Ya bois.
    {
        public string SegType { get; set; }
        public string SegName { get; set; }
        public int SegId { get; set; }
        public decimal SegCost { get; set; }
        public DataTable SegTable { get; set; }
    }

    public static class Globals
    {
        public static List<Segment> segments = new(); // Ya bois home.
        public static string filepath;
    }
}
