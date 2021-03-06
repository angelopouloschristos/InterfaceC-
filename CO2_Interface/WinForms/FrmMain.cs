using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginRegis
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        oCenter oC = new oCenter();
        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin Frm = new FrmLogin();
            Frm.ShowDialog();

            if (oCenter.sFirstName.Equals(""))
            {
                Application.Exit();
            }

            lblFirstName.Text = "First Name : " + oCenter.sFirstName;
            lblLastName.Text = "Last Name : " + oCenter.sLastName;
            lblEmail.Text = "Email : " + oCenter.sEmail;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
