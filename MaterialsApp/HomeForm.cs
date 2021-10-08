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
        string workspaceReturnTotal;
        string workspaceGrandTotal;
        

        public HomeForm()
        {
            InitializeComponent();
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
                seg.SegTable = new DataTable();

                
                Globals.segments.Add(seg);

                WorkspaceForm ws = new(seg.SegType, seg.SegName, seg.SegTable);
                this.Enabled = false;
                if (ws.ShowDialog() == DialogResult.OK)
                {
                    seg.SegTable = ws.WsTable;
                    workspaceReturnTotal = ws.ReturnTotal; // This is the total cost of the workspace segment. Add this to the datagridview and calculate the grand total from all returns. 
                    dataGridView1.Rows.Add(seg.SegType);
                    dataGridView1.Rows.Add(seg.SegName);
                    dataGridView1.Rows.Add(seg.SegId);
                }
                this.Enabled = true;
            }
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
        public static List<Segment> segments = new List<Segment>();
    }


}
