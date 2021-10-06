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
    public partial class WorkspaceForm : Form
    {
        public WorkspaceForm(string segType, string segName, int segID, bool isNew = true)
        {
            InitializeComponent();

            if (!isNew)
            {
                // Populate the data grid with existing data associated with the ID. 
            }
        }

        private void CloseWorkspaceButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
