using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using BinaxNow_Portal.Data;
using System.IO;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Layout.Borders;
using System.Threading;
using System.Drawing.Printing;

namespace BinaxNow_Portal.Forms
{
    public partial class PatientIntakeForm : Form
    {
        public PatientIntakeForm()
        {
            InitializeComponent();
        }
        
        private void CreatePatientbutton_Click(object sender, EventArgs e)
        {
           
            // Create variables for inputs
            var TodaysDate = DateTime.Now;
            //Patient info
            string Pname = NameTextbox.Text;
            string Pdob = DobPicker.Value.Date.ToShortDateString();
            string Phone = PhoneMTextBox.Text;
            string Pgender = "";
            string expo = "";
            string Prace = "";
            if (RaceListbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please make a race selection.");
            }
            else
            {
                Prace = RaceListbox.SelectedItem.ToString();
            }

            string Pethic = "";

            if (EthnicListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please make an ethnicity selection.");
            }
            else
            {
                Pethic = EthnicListBox.SelectedItem.ToString();
            }

            if (ExpolistBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please make a race selection.");
            }
            else
            {
                expo = ExpolistBox.SelectedItem.ToString() + " - " + ExpoTextBox.Text;
            }

            string Pstreet = StreetTextBox.Text;
            string Pcity = CityTextBox.Text;
            string Pstate = StateTextBox.Text;
            string Pzip = ZipTextBox.Text;
            string Pcounty = CountyTextBox.Text + " County";
            string address1 = Pstreet;
            string address2 = Pcity + ", " + Pstate + " " + Pzip;
            string comm = "For positive results, isolate for 10 days & reach out to close contacts.";

            // Kit info
            string KitNum = KitTextBox.Text;
            string KitXp = KitXpPicker.Value.Date.ToShortDateString();
            string KitRec = KitRecievedPicker.Value.Date.ToShortDateString();
            string KitVal = "";

            //Exception handling listbox race

            //Exception handling listbox race


            // Set Radio buttons
            try
            {
                if (MaleRadioButton.Checked == true)
                {
                    Pgender = "Male";
                }
                else if (FemaleRadioButton.Checked == true)
                {
                    Pgender = "Female";
                }
                else
                {
                    Pgender = "Other";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please make a gender selection.");
            }

            try
            {
                if (YesRadioButton.Checked == true)
                {
                    KitVal = "Yes";
                }
                else if (NoRadioButton.Checked == true)
                {
                    KitVal = "No";
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Please make a control result selection.");
            }

            // Save Info to DB
            //binaxRecordsTableAdapter.Insert(Pname,DobPicker.Value.Date,Phone,TodaysDate,"N/A");
            this.binaxRecordsTableAdapter.Insert(Pname, DobPicker.Value.Date, Phone, TodaysDate, "N/A",expo,Prace,Pethic,Pgender);
            // Create a Patient Document
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(@"C:\Users\bradl\source\repos\BinaxNow Portal Version 2.0\Images\Report_Template.pdf"), new PdfWriter("New_Report.pdf"));
            Document document = new Document(pdfDoc);

            // Set fonts and styles
            var Font = PdfFontFactory.CreateFont(FontConstants.TIMES_ROMAN);
          
            Paragraph p1 = new Paragraph();
            p1.SetFont(Font);
            p1.SetFontSize(14);
            string Name = "Patient Name: " + Pname;
            p1.Add(Name).SetFixedPosition(50,650,500);
            document.Add(p1);

            Paragraph p2 = new Paragraph();
            p2.SetFont(Font);
            p2.SetFontSize(14);
            string db = "Patient D.O.B: " + Pdob;
            p2.Add(db).SetFixedPosition(50, 635, 500);
            document.Add(p2);

            Paragraph p3 = new Paragraph();
            p3.SetFont(Font);
            p3.SetFontSize(14);
            string ph = "Patient Phone: " + Phone;
            p3.Add(ph).SetFixedPosition(50, 620, 500);
            document.Add(p3);

            Paragraph p4 = new Paragraph();
            p4.SetFont(Font);
            p4.SetFontSize(14);
            string ad1 = "Patient Address: " + address1;
            p4.Add(ad1).SetFixedPosition(50, 595, 600);
            document.Add(p4);
            Paragraph p5 = new Paragraph();
            p5.SetFont(Font);
            p5.SetFontSize(14);
            p5.Add(address2).SetFixedPosition(146, 580, 600);
            document.Add(p5);
            Paragraph p6 = new Paragraph();
            p6.SetFont(Font);
            p6.SetFontSize(14);
            p6.Add(Pcounty).SetFixedPosition(146, 565, 600);
            document.Add(p6);

            Paragraph p7 = new Paragraph();
            p7.SetFont(Font);
            p7.SetFontSize(14);
            string gen = "Patient Gender: " + Pgender;
            p7.Add(gen).SetFixedPosition(50, 540, 500);
            document.Add(p7);
            Paragraph p8 = new Paragraph();
            p8.SetFont(Font);
            p8.SetFontSize(14);
            string r = "Patient Race: " + Prace;
            p8.Add(r).SetFixedPosition(50, 525, 500);
            document.Add(p8);
            Paragraph p9 = new Paragraph();
            p9.SetFont(Font);
            p9.SetFontSize(14);
            string eth = "Patient Ethnicity: " + Pethic;
            p9.Add(eth).SetFixedPosition(50, 510, 500);
            document.Add(p9);

            Paragraph p10 = new Paragraph();
            p10.SetFont(Font);
            p10.SetFontSize(14);
            string k1 = "Kit Lot #: " + KitNum;
            p10.Add(k1).SetFixedPosition(350, 595, 500);
            document.Add(p10);
            Paragraph p11 = new Paragraph();
            p11.SetFont(Font);
            p11.SetFontSize(14);
            string k2 = "Kit Expiration Date: " + KitXp;
            p11.Add(k2).SetFixedPosition(350, 580, 500);
            document.Add(p11);
            Paragraph p12 = new Paragraph();
            p12.SetFont(Font);
            p12.SetFontSize(14);
            string k3 = "Kit Received Date: " + KitRec;
            p12.Add(k3).SetFixedPosition(350, 565, 500);
            document.Add(p12);
            Paragraph p13 = new Paragraph();
            p13.SetFont(Font);
            p13.SetFontSize(14);
            string k4 = "Procedural Control Results Valid: " + KitVal;
            p13.Add(k4).SetFixedPosition(350, 550, 500);
            document.Add(p13);

            Paragraph p14 = new Paragraph();
            p14.SetFont(Font);
            p14.SetFontSize(14);
            string n = "Notes: ";
            p14.Add(n).SetFixedPosition(50, 385,500);
            document.Add(p14);
            Paragraph p15 = new Paragraph();
            p15.SetFont(Font);
            p15.SetFontSize(14);
            p15.Add(comm).SetFixedPosition(70, 370, 500);
            document.Add(p15);

            Paragraph p16 = new Paragraph();
            p16.SetFont(Font);
            p16.SetFontSize(14);
            string t = "Testers Signature:________________________________";
            p16.Add(t).SetFixedPosition(50, 115, 500);
            document.Add(p16);
            Paragraph p17 = new Paragraph();
            p17.SetFont(Font);
            p17.SetFontSize(14);
            string d = "Date / Time of Test: " + TodaysDate.ToString();
            p17.Add(d).SetFixedPosition(50, 100, 500);
            document.Add(p17);

            Paragraph p18 = new Paragraph();
            p18.SetFont(Font);
            p18.SetFontSize(16);
            string res = "RESULTS";
            p18.Add(res).SetFixedPosition(410, 650, 100);
            document.Add(p18);

            Paragraph p19 = new Paragraph();
            p19.SetFont(Font);
            p19.SetFontSize(14);
            string PN = "Positive / Negative";
            p19.Add(PN).SetFixedPosition(390, 635, 200);
            document.Add(p19);

            //Close open docs
            document.Close();
            pdfDoc.Close();

            //open to view and print
            string Filepath = "New_Report.pdf";

            using (PrintDialog Dialog = new PrintDialog())
            {
                Dialog.ShowDialog();

                ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                {
                    Verb = "print",
                    CreateNoWindow = true,
                    FileName = Filepath,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process printProcess = new Process();
                printProcess.StartInfo = printProcessInfo;
                printProcess.Start();

                printProcess.WaitForInputIdle();

                Thread.Sleep(3000);

                if (false == printProcess.CloseMainWindow())
                {
                    printProcess.Kill();
                }
            }
            MessageBox.Show("Patient recorded and printed successfully.");
            this.Close();

        }


        private void PatientIntakeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pDBDataSetV2.BinaxRecords' table. You can move, or remove it, as needed.
            this.binaxRecordsTableAdapter.Fill(this.pDBDataSetV2.BinaxRecords);
            // TODO: This line of code loads data into the 'patientDBDataSet.BinaxRecords' table. You can move, or remove it, as needed.
            //this.binaxRecordsTableAdapter.Fill(this.patientDBDataSet.BinaxRecords);

        }

    }
}
