using CO2_Interface.Data;
using CO2_Interface.WinForms;
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
        public User current_user = null;
        public AccountControl()
        {
            InitializeComponent();
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
                lblFirstName.Text = "Name : " + dsAction.Tables["UserTable"].Rows[0]["UserName"].ToString();
                lblLastName.Text = "Password : " + dsAction.Tables["UserTable"].Rows[0]["UserPassword"].ToString();
                string access_id_str = dsAction.Tables["UserTable"].Rows[0]["Access_ID"].ToString();
                int access_id = Convert.ToInt32(access_id_str);

                User user = new User(id, dsAction.Tables["UserTable"].Rows[0]["UserName"].ToString(), dsAction.Tables["UserTable"].Rows[0]["UserPassword"].ToString(),access_id);
                //Collections.Users.Add(user);
                current_user = user;
                login_layout.Hide();
                btn_logout.Show();
                if (access_id==0)
                {
                    add_account_btn.Show();

                }
                ManagerControl.is_logged =true;
                tb_input_name.Text = "";
                tb_input_password.Text = "";
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

        private void btn_logout_Click(object sender, EventArgs e)
        {
            current_user = null;
            login_layout.Show();
            btn_logout.Hide();
            add_account_btn.Hide();
            ManagerControl.is_logged = false;
        }

        private void add_account_btn_Click(object sender, EventArgs e)
        {
            UserCreation frm = new UserCreation();
            frm.ShowDialog();
        }
    }
}
