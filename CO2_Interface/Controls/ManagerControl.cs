using LoginRegis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO2_Interface.Controls
{
    public partial class ManagerControl : UserControl
    {

        oCenter oC = new oCenter();
        DataTable dt = new DataTable();

        public ManagerControl()
        {
            InitializeComponent();


            DataColumn id_accounts = new DataColumn("ID");

            
            LoadInfo();



        }

        private void LoadInfo()
        {
            String fname = "First Name : " + oCenter.sFirstName;
            String lname = "Last Name : " + oCenter.sLastName;
            String email = "Email : " + oCenter.sEmail;
        }
    }
}
