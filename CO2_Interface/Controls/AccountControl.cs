using CO2_Interface.Data;
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
        String name;
        String pass;
        public AccountControl()
        {
            InitializeComponent();
        }

        
        private void LoadInfo()
        {
            lblFirstName.Text = "First Name : " + oCenter.sName;
            lblLastName.Text = "Last Name : " + oCenter.sPassword;
        }

        private void AccountControl_Load(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            name = tb_input_name.Text.Trim();
            pass = tb_input_password.Text.Trim();

            DataSet dsAction = new DataSet("Sample");
            string sSqlSave = "SELECT * FROM UserTable WHERE UserName = '" + name + "' AND UserPassword = '" + pass + "'";
            dsAction = oC.ShowData(sSqlSave, "UserTable", dsAction);
            if (dsAction.Tables["UserTable"].Rows.Count > 0)
            {
                string id_string = dsAction.Tables["UserTable"].Rows[0]["ID"].ToString();
                int id = Convert.ToInt32(id_string);
                lblFirstName.Text = "First Name : " + dsAction.Tables["UserTable"].Rows[0]["UserName"].ToString();
                lblLastName.Text = "Last Name : " + dsAction.Tables["UserTable"].Rows[0]["UserPassword"].ToString();
                string access_id_str = dsAction.Tables["UserTable"].Rows[0]["Access_ID"].ToString();
                int access_id = Convert.ToInt32(access_id_str);

                User user = new User(id, dsAction.Tables["UserTable"].Rows[0]["UserName"].ToString(), dsAction.Tables["UserTable"].Rows[0]["UserPassword"].ToString(),access_id);
                //Collections.Users.Add(user);
                login_layout.Hide();
                ManagerControl.is_logged =true;
            }
            else
            {
                MessageBox.Show("Login Fail", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            FrmRegister Frm = new FrmRegister();
            Frm.ShowDialog();
        }
    }
}
