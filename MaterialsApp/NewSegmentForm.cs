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
    public partial class NewSegmentForm : Form
    {
        public string SegNameDefined { get; set; }
        public string SegTypeDefined { get; set; }
        public NewSegmentForm()
        {
            InitializeComponent();
        }

        private void NewSegmentForm_Load(object sender, EventArgs e)
        {
            string[] cBox = new string[4] { "Wall", "Floor", "Roof", "Opening" };
            sTypeComboBox.DataSource = cBox;
        }

        private void SAcceptButton_Click(object sender, EventArgs e)
        {
            if (sTypeComboBox.Text == string.Empty || sNameTextBox.Text == string.Empty)
            {
                System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("Fields cannot be empty.", "Error", MessageBoxButtons.OK);
            } else
            {
                this.SegNameDefined = sNameTextBox.Text;
                this.SegTypeDefined = sTypeComboBox.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void SCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
