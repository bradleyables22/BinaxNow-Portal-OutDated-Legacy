using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaxNow_Portal.Forms
{
    public partial class ResultEditForm : Form
    {
        public ResultEditForm()
        {
            InitializeComponent();
        }

        

        private void ResultEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pDBDataSetV2.BinaxRecords' table. You can move, or remove it, as needed.
            this.binaxRecordsTableAdapter.Fill(this.pDBDataSetV2.BinaxRecords);
            // TODO: This line of code loads data into the 'patientDBDataSet.BinaxRecords' table. You can move, or remove it, as needed.
            //this.binaxRecordsTableAdapter.Fill(this.patientDBDataSet.BinaxRecords);

        }

        private void Namebutton_Click(object sender, EventArgs e)
        {
            string N = NametextBox.Text;
            this.binaxRecordsTableAdapter.SearchbyName(this.pDBDataSetV2.BinaxRecords, N);
            NametextBox.Text = "";
            PhoneTextBox.Text = "";
        }

        private void phonebutton_Click(object sender, EventArgs e)
        {
            string P = PhoneTextBox.Text;
            this.binaxRecordsTableAdapter.SearchbyPhone(this.pDBDataSetV2.BinaxRecords, P);
            PhoneTextBox.Text = "";
            NametextBox.Text = "";
        }

        private void binaxRecordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.binaxRecordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pDBDataSetV2);

        }
    }
}
