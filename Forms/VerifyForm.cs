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

namespace BinaxNow_Portal.Data
{
    public partial class VerifyForm : Form
    {
        public VerifyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Password = "9090";
            string Answer = "";
            Answer = passtextbox.Text;

            if (Password == Answer)
            {
                MessageBox.Show("Credentials correct.");
                ManagerForm mf = new ManagerForm();
                mf.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Credentials incorrect.");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
