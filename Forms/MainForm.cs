using BinaxNow_Portal.Data;
using BinaxNow_Portal.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaxNow_Portal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CpButton_Click(object sender, EventArgs e)
        {
            PatientIntakeForm PF = new PatientIntakeForm();
            PF.ShowDialog();
        }

        private void RecordsButton_Click(object sender, EventArgs e)
        {
            VerifyForm vf = new VerifyForm();
            vf.ShowDialog();

        }

        private void RedcapButton_Click(object sender, EventArgs e)
        {
            RedcapForm rc = new RedcapForm();
            rc.ShowDialog();
        }

        private void ResultsButton_Click(object sender, EventArgs e)
        {
            ResultEditForm rf = new ResultEditForm();
            rf.ShowDialog();
        }

        private void testdbutton_Click(object sender, EventArgs e)
        {
           var today = DateTime.Today;
           CountLabel.Text = this.binaxRecordsTableAdapter1.TestedCount(today).ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pDBDataSetV2.BinaxRecords' table. You can move, or remove it, as needed.
            this.binaxRecordsTableAdapter1.Fill(this.pDBDataSetV2.BinaxRecords);

        }
    }
}
