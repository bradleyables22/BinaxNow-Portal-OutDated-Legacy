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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string SD = StartPicker.Value.ToShortDateString();
            string ED = EndPicker.Value.ToShortDateString();
            this.binaxRecordsTableAdapter.Searchbydates(this.pDBDataSetV2.BinaxRecords, SD,ED);
        }

        private void Namebutton_Click(object sender, EventArgs e)
        {
            //filter by name
            string N = NametextBox.Text;
            this.binaxRecordsTableAdapter.SearchbyName(this.pDBDataSetV2.BinaxRecords, N);
        }

        private void DOBbutton_Click(object sender, EventArgs e)
        {
            //Search by dob
            string DOB = DOBpicker.Value.ToShortDateString();
            this.binaxRecordsTableAdapter.SearchbyDOB(this.pDBDataSetV2.BinaxRecords, DOB);
            
        }

        private void Phonebutton_Click(object sender, EventArgs e)
        {
            //Search by Phone
            string P = PhoneTextBox.Text;
            this.binaxRecordsTableAdapter.SearchbyPhone(this.pDBDataSetV2.BinaxRecords, P);
        }

        private void PosButton_Click(object sender, EventArgs e)
        {
            //show positives only
            string Pos = "pos";
            this.binaxRecordsTableAdapter.SearchResult(this.pDBDataSetV2.BinaxRecords, Pos);
        }

        private void NegButton_Click(object sender, EventArgs e)
        {
            //show negitives only
            string Neg = "neg";
            this.binaxRecordsTableAdapter.SearchResult(this.pDBDataSetV2.BinaxRecords, Neg);
        }

        private void ResButton_Click(object sender, EventArgs e)
        {
            //reset grid
            this.binaxRecordsTableAdapter.Fill(this.pDBDataSetV2.BinaxRecords);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show all other results
            string other = "N/A";
            this.binaxRecordsTableAdapter.SearchResult(this.pDBDataSetV2.BinaxRecords, other);
        }

        private void Exportbutton_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < binaxRecordsDataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = binaxRecordsDataGridView.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < binaxRecordsDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < binaxRecordsDataGridView.Columns.Count; j++)
                {
                   worksheet.Cells[i + 2, j + 1] = binaxRecordsDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            string da = DateTime.Now.ToShortDateString();
            // save the application  
            //workbook.SaveAs("Binax_Report_" + da + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        private void binaxRecordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.binaxRecordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pDBDataSetV2);

        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pDBDataSetV2.BinaxRecords' table. You can move, or remove it, as needed.
            this.binaxRecordsTableAdapter.Fill(this.pDBDataSetV2.BinaxRecords);

        }

    }
}
