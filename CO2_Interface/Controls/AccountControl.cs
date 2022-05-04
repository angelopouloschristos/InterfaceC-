using LoginRegis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO2_Interface.Controls
{
    public partial class AccountControl : UserControl
    {
        oCenter oC = new oCenter();
        public AccountControl()
        {
            InitializeComponent();
            LoadInfo();
        }

        
        private void LoadInfo()
        {
            lblFirstName.Text = "First Name : " + oCenter.sFirstName;
            lblLastName.Text = "Last Name : " + oCenter.sLastName;
            lblEmail.Text = "Email : " + oCenter.sEmail;
        }

        private void AccountControl_Load(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
