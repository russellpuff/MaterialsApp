using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialsApp
{
    public partial class WorkspaceForm : Form
    {
        readonly string segmentType;
        readonly string segmentName;
        decimal grandTotal = 0;
        bool isDirty = false; // unsaved changes
        readonly bool newS = true;
        public decimal ReturnTotal { get; set; }
        public DataTable WsTable { get; }

        public WorkspaceForm(string segType, string segName, DataTable segDT, bool isNew = true)
        {
            InitializeComponent();
            segmentType = segType;
            segmentName = segName;
            WsTable = segDT;
            newS = isNew;
        }
        //
        // Workspace initialization.
        //
        private void WorkspaceForm_Load(object sender, EventArgs e)
        {
            if (newS)
            {
                for (int i = 0; i < workspaceDataGrid.Columns.Count; i++) // Gives the blank datatable correct headers.
                {
                    WsTable.Columns.Add(workspaceDataGrid.Columns[i].HeaderText);
                }
            } else
            {
                ExistingTableLoader();
            }
            workspaceLabel.Text = "Workspace for " + segmentType + " segment: \"" + segmentName + "\"";
            segmentTotalLabel.Text = "Grand total: " + grandTotal.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            //
            // comboPop is a list used to populate the combobox depending on what the segment's type is.
            // Regardless of the type, common items are always added. If a custom type is defined, only common items will appear.
            //
            List<string> comboPop = new();
            SegmentItemEntry wsLoadSeg = new();
            switch (segmentType)
            {
                case "Wall":
                    WallSegment wsLoadWall = new();
                    comboPop.AddRange(wsLoadWall.WallItem);
                    break;
                case "Roof":
                    RoofSegment wsLoadRoof = new();
                    comboPop.AddRange(wsLoadRoof.RoofItem);
                    break;
                case "Floor":
                    FloorSegment wsLoadFloor = new();
                    comboPop.AddRange(wsLoadFloor.FloorItem);
                    break;
                case "Opening":
                    OpeningSegment wsLoadOpening = new();
                    comboPop.AddRange(wsLoadOpening.OpeningItem);
                    break;
            }
            comboPop.AddRange(wsLoadSeg.CommonItems);
            itemComboBox.DataSource = comboPop;
        }

        private void ExistingTableLoader()
        {
            for (int i = 0; i < WsTable.Rows.Count; ++i)
            {
                string[] row = new string[6];
                for (int k = 0; k < 6; ++k)
                {
                    row[k] = WsTable.Rows[i][k].ToString();
                    if (k == 5)
                    {
                        string temp = row[k];
                        temp = temp.Substring(1);
                        decimal add = decimal.Parse(temp);
                        grandTotal += add;
                    }
                }
                workspaceDataGrid.Rows.Add(row);
            }

        }
        //
        // The long and arduous process of populating the material combobox.
        //
        private void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialComboBox.DataSource = MatComboBoxWhatIndex();
            materialComboBox.SelectedIndex = 0;
        }

        private void ItemComboBox_TextChanged(object sender, EventArgs e)
        {
            if (!itemComboBox.Items.Contains(itemComboBox.Text)) // Should the user have a custom input for the item, material is blank.
            {
                materialComboBox.DataSource = null;
                materialComboBox.Items.Clear();
            }
        }

        private List<string> MatComboBoxWhatIndex() // Step 1, figure out what type the segment is and go down that path. 
        {
            return segmentType switch
            {
                "Wall" => SegmentIsWall(),
                "Floor" => SegmentIsFloor(),
                "Roof" => SegmentIsRoof(),
                "Opening" => SegmentIsOpening(),
                _ => IndexIsCommonItem(),
            };
        }

        private List<string> SegmentIsWall()
        {
            WallSegment wsWallIndex = new();
            materialComboBox.DataSource = null;
            materialComboBox.Items.Clear();
            List<string> temp = new();
            switch (itemComboBox.SelectedIndex)
            {
                case 5: // drywall
                    temp.Add("Drywall");
                    break;
                case 6: // foam board panel
                    temp.Add("Fiberglass foam");
                    break;
                case 7: // brick
                    temp.Add("Brick");
                    break;
                case 8: // concrete block
                case 10: // poured concrete
                    temp.Add("Concrete");
                    break;
            }
            return itemComboBox.SelectedIndex switch
            {
                0 or 1 or 3 or 4 => wsWallIndex.GenericWoodMats, // stud, stud block, clapboard siding, log siding
                2 => wsWallIndex.SidingPanelMats, // siding panel
                5 or 6 or 7 or 8 or 10 => temp,
                9 => wsWallIndex.GenericStoneMats, // natural stone
                11 => wsWallIndex.InsulationMats, // insulation
                _ => IndexIsCommonItem(),
            };
        }

        private List<string> SegmentIsFloor()
        {
            FloorSegment wsFloorIndex = new();
            materialComboBox.DataSource = null;
            materialComboBox.Items.Clear();
            List<string> temp = new() { "Vinyl" };

            return itemComboBox.SelectedIndex switch
            {
                0 => wsFloorIndex.FoundationMats, // foundation
                1 => wsFloorIndex.GenericWoodMats, // hardwood
                2 => wsFloorIndex.GenericStoneMats, // stone
                3 => wsFloorIndex.TileMats, // tile
                4 => temp, // vinyl
                _ => IndexIsCommonItem(),
            };
        }

        private List<string> SegmentIsRoof()
        {
            RoofSegment wsRoofIndex = new();
            materialComboBox.DataSource = null;
            materialComboBox.Items.Clear();
            List<string> temp = new();

            switch (itemComboBox.SelectedIndex)
            {
                case 0: // clay roof tile
                    temp.Add("Clay");
                    break;
                case 1: // slate roof tile
                    temp.Add("Slate");
                    break;
                case 3: // asphalt shingle
                    temp.Add("Asphalt");
                    break;
                case 5: // rafter
                    temp.Add(wsRoofIndex.RafterMats);
                    temp.AddRange(wsRoofIndex.GenericWoodMats);
                    break;
            }
            return itemComboBox.SelectedIndex switch
            {
                0 or 1 or 3 or 5 => temp,
                2 => wsRoofIndex.GenericWoodMats, // wood roof tile
                4 => wsRoofIndex.MetalRoofMats, // metal roof
                _ => IndexIsCommonItem(),
            };
        }

        private List<string> SegmentIsOpening()
        {
            OpeningSegment wsOpeningIndex = new();
            materialComboBox.DataSource = null;
            materialComboBox.Items.Clear();
            List<string> temp = new();

            switch (itemComboBox.SelectedIndex)
            {
                case 0: // door
                case 1: // door frame
                case 5: // window frame
                    temp.AddRange(wsOpeningIndex.OpeningMats);
                    temp.AddRange(wsOpeningIndex.GenericWoodMats);
                    break;
                case 3: // weather strip
                case 4: // window glass
                    string agony = (itemComboBox.SelectedIndex == 3) ? "Vinyl" : "Glass";
                    temp.Add(agony);
                    break;
            }
            return itemComboBox.SelectedIndex switch
            {
                0 or 1 or 3 or 4 or 5 => temp,
                2 => wsOpeningIndex.GenericWoodMats, // header
                _ => IndexIsCommonItem(),
            };
        }

        private List<string> IndexIsCommonItem() // Should the selected item be a common item, it'll instead populate the combobox witha custom list of materials based on the common item.
        {
            List<string> temp = new();
            switch (itemComboBox.SelectedItem)
            {
                case "Anchor bolt":
                case "Rebar":
                    temp.Add("Steel");
                    break;
                case "Nails":
                case "Screws":
                    temp.Add("Galvanized steel");
                    break;
                case "Caulk":
                    temp.Add("Caulk");
                    break;
                case "Joint compound":
                    temp.Add("Gypsum mud");
                    break;
                case "Paint":
                    List<string> pnt = new() { "Chalk", "Chalkboard", "Enamel", "Latex-Based", "Oil-based", "Water-Based" }; // The paint list literally only appears in this specific case, so there's no reason to add it to the class. 
                    return pnt;
            }
            return temp;
        }
        //
        // Adding an item.
        //
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            bool check = ValidateRowAdd();
            if (check)
            {
                decimal unitCost = 0;
                decimal totalCost = 0;
                try
                {
                    unitCost = decimal.Parse(unitCostTextBox.Text);
                    totalCost = unitCost * decimal.Parse(quantityTextBox.Text);
                } catch
                {
                    MessageBox.Show("An error occured while trying to add your item. The quantity / unit cost may be too high.", "Item add error", MessageBoxButtons.OK);
                    return;
                }

                string[] row = new string[6] 
                {
                itemComboBox.Text,
                materialComboBox.Text,
                sizeDescTextBox.Text,
                quantityTextBox.Text,
                unitCost.ToString("C", CultureInfo.GetCultureInfo("en-US")),
                totalCost.ToString("C", CultureInfo.GetCultureInfo("en-US"))
                };
                workspaceDataGrid.Rows.Add(row);
                ClearButton_Click(null, null); // Clears the rows after they've been committed. 
                
                grandTotal += totalCost;
                segmentTotalLabel.Text = "Grand total: " + grandTotal.ToString("C", CultureInfo.GetCultureInfo("en-US"));
                isDirty = true;
            } else
            {
                System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("Error: All fields must be filled out before an item can be added.", "Incomplete entry", MessageBoxButtons.OK);
            }
        }

        private bool ValidateRowAdd()
        {
            bool validate1 = (itemComboBox.Text != string.Empty);
            bool validate2 = (materialComboBox.Text != string.Empty);
            bool validate3 = (sizeDescTextBox.Text != string.Empty);
            bool validate4 = (quantityTextBox.Text != string.Empty);
            bool validate5 = (unitCostTextBox.Text != string.Empty);
            if (!validate3)
            {
                sizeDescTextBox.Text = " ";
            }
            return (validate1 && validate2 && validate4 && validate5);
        }

        private void QuantityOrUnitCostTextBox_TextChanged(object sender, EventArgs e) // Not strictly speaking related to adding an item, but this event validates the quanity and unit cost text boxes before they can even be committed.
        {
            var textbox = (TextBox)sender;
            bool check;

            if (textbox.Name == "quantityTextBox")
            {
                check = Int32.TryParse(quantityTextBox.Text, out _);
            }
            else
            {
                check = decimal.TryParse(unitCostTextBox.Text, out _);
            }

            if (!check && textbox.Text != "")
            {
                textbox.Text = textbox.Text.Remove(textbox.Text.Length - 1); // Extremely crude method of input validation because I can't figure out how to use maskedTextBox to do what I want.
                System.Media.SystemSounds.Hand.Play();
            }
            else if (textbox.Name == "unitCostTextBox" && textbox.Text != "") // Stupid idiot's solution because le maskedtextbox doesn't work meme. 
            {
                decimal temp = decimal.Parse(unitCostTextBox.Text);
                if (temp % 1 != 0 && (temp * 100) % 1 != 0)
                {
                    textbox.Text = textbox.Text.Remove(unitCostTextBox.Text.Length - 1);
                    System.Media.SystemSounds.Hand.Play();
                }
            }
        }
        //
        // Saving your work.
        //
        private void SaveWorkspaceButton_Click(object sender, EventArgs e)
        {
            if (isDirty)
            {
                DataTableBuilder();
                isDirty = false;
                DialogResult result = MessageBox.Show("Changes saved. Do you want to continue working?", "Changes saved", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    this.ReturnTotal = grandTotal;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void DataTableBuilder()
        {
            WsTable.Clear();
            workspaceDataGrid.Sort(workspaceDataGrid.Columns[0], ListSortDirection.Ascending);
            foreach (DataGridViewRow row in workspaceDataGrid.Rows)
            {
                DataRow dr = WsTable.NewRow();
                for (int k = 0; k < workspaceDataGrid.Columns.Count; k++)
                {
                    dr[workspaceDataGrid.Columns[k].HeaderText] = row.Cells[k].Value;
                }
                WsTable.Rows.Add(dr);
            }
        }
        //
        // "The reset of the functions".
        //
        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            int f = workspaceDataGrid.CurrentCell.RowIndex;
            string deleteMsg = "Are you sure you want to delete this " + workspaceDataGrid.CurrentRow.Cells[0].Value.ToString() + " item?";
            DialogResult result;
            result = MessageBox.Show(deleteMsg, "Delete?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string temp = workspaceDataGrid.Rows[f].Cells[5].Value.ToString();
                temp = temp.Substring(1);
                grandTotal -= decimal.Parse(temp);
                segmentTotalLabel.Text = "Grand total: " + grandTotal.ToString("C", CultureInfo.GetCultureInfo("en-US"));
                workspaceDataGrid.Rows.Remove(workspaceDataGrid.Rows[f]);
                isDirty = true;
            }
        }

        private void CancelWorkspaceButton_Click(object sender, EventArgs e)
        {
            if (isDirty)
            {
                DialogResult result;
                result = MessageBox.Show("You have unsaved changes, are you sure you want to close the form?", "Unsaved changes", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            } else
            {
                this.Close();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            itemComboBox.Text = string.Empty;
            materialComboBox.Text = string.Empty;
            sizeDescTextBox.Text = string.Empty;
            quantityTextBox.Text = string.Empty;
            unitCostTextBox.Text = string.Empty;
        }

        private void WorkspaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDirty)
            {
                DialogResult result;
                result = MessageBox.Show("You have unsaved changes, are you sure you want to close the form?", "Unsaved changes", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                } else
                {
                    e.Cancel = true;
                }
            }
        }
    }
    //
    // Classes for combobox population.
    //
    public class SegmentItemEntry
    {
        public readonly List<string> GenericWoodMats = new()
        {
            "Cedar",
            "Cypress",
            "Fir",
            "Pine",
            "Red cedar",
            "Spruce",
            "Plywood"
        };
        public readonly List<string> GenericStoneMats = new()
        {
            "Granite",
            "Limestone",
            "Marble",
            "Sandstone",
            "Slate"
        };
        public readonly List<string> CommonItems = new()
        {
            "Anchor bolt", // steel
            "Caulk",
            "Joint compound", // custom entry only
            "Nails", // galvanized steel
            "Paint", // custom entry only
            "Rebar", // steel
            "Screws" // galvanized steel
        };
    }

    public class WallSegment : SegmentItemEntry
    {
        public readonly List<string> WallItem = new()
        {
            "Stud", // wood
            "Stud block", // wood
            "Siding panel", // custom mats
            "Clapboard siding", // wood
            "Log siding", // wood
            "Drywall panel",
            "Foam board panel",
            "Brick",
            "Concrete block",
            "Natural stone", // stone
            "Reinforced concrete",
            "Insulation" // custom mats
        };
        public readonly List<string> SidingPanelMats = new()
        {
            "Aluminum",
            "Plasterboard",
            "Plywood",
            "Steel",
            "Vinyl"
        };
        public readonly List<string> InsulationMats = new()
        {
            "Cellulose",
            "Concrete",
            "Fiberglass",
            "Mineral",
            "Rigid foam",
            "Spray-in foam"
        };
    }

    public class FloorSegment : SegmentItemEntry
    {
        public readonly List<string> FloorItem = new()
        {
            "Foundation", // custom mats
            "Hardwood", // wood
            "Stone", // stone
            "Tile", // custom mats
            "Vinyl"
        };
        public readonly List<string> FoundationMats = new()
        {
            "Basement",
            "Beam",
            "Concrete slab",
            "Crawlspace",
            "Wood"
        };
        public readonly List<string> TileMats = new()
        {
            "Ceramic",
            "Marble",
            "Porcelain"
        };
    }

    public class RoofSegment : SegmentItemEntry
    {
        public readonly List<string> RoofItem = new()
        {
            "Clay roof tile",
            "Slate roof tile",
            "Wood roof tile", // wood
            "Asphalt shingle",
            "Metal roof", // custom mats
            "Rafter", // custom mats
        };
        public readonly List<string> MetalRoofMats = new()
        {
            "Aluminum",
            "Copper and zinc",
            "Galvanized steel"
        };
        public readonly string RafterMats = "Steel"; // The generic wood list is attached to this.
    }

    public class OpeningSegment : SegmentItemEntry
    {
        public readonly List<string> OpeningItem = new()
        {
            "Door", // custom mats
            "Door frame", // custom mats
            "Header", // wood
            "Weather strip", // vinyl
            "Window glass", // glass
            "Window frame", // custom mats
        };
        public readonly List<string> OpeningMats = new()
        { // Also, the generic wood list is attached to this in all cases. 
            "Aluminum",
            "Fiberglass",
            "Vinyl",
        };
    }
}