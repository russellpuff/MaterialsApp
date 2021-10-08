using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialsApp
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void NewSegmentButton_Click(object sender, EventArgs e)
        {
            string segmentType = "Example";
            string segmentName = "Example";
            int segmentID = 0;
            // write code here that prompts the user to enter a name for their segment
            // if they create a "custom" segment, have them give a name to the segment as well
            // generate random ID between 1 and 65535. 
            // If the ID matches an existing ID, generate a new one. The user won't be making a lot of segments, so just use a while loop. 
            // When a new segment is created, show the user (in the data grid) the Type in column 0 and the name in column 1. Store the ID in column 2 but hide it.
            WorkspaceForm ws = new(segmentType, segmentName, segmentID);
            this.Enabled = false;
            if (ws.ShowDialog() == DialogResult.OK)
            {
                // Add the item to the data grid. Else do nothing because the user cancelled. 
            }
            this.Enabled = true;

        }
    }
}
