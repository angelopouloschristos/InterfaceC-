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

namespace CO2_Interface.WinForms
{
    public partial class UserCreation : Form
    {
        oCenter oC = new oCenter();

        public UserCreation()
        {
            InitializeComponent();
            rights_combo_box.Items.Add(0);
            rights_combo_box.Items.Add(1);
            rights_combo_box.Items.Add(2);
            rights_combo_box.SelectedIndex = 0;
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals("") || txtFirstName.Text.Equals("First Name"))
            {
                MessageBox.Show("Input First Name", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text.Equals("") || txtPassword.Text.Equals("Password"))
            {
                MessageBox.Show("Input Password", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataSet dsAction = new DataSet("Sample");
            string sSqlSave = "SELECT * FROM UserTable WHERE Username = '" + txtFirstName.Text.Trim() + "'";
            dsAction = oC.ShowData(sSqlSave, "UserTable", dsAction);
            if (dsAction.Tables["UserTable"].Rows.Count <= 0)
            {
                DataRow dr = dsAction.Tables["UserTable"].NewRow();
                dr["ID"] = Collections.Users.Count;
                dr["UserName"] = txtFirstName.Text;
                dr["UserPassword"] = txtPassword.Text;
                dr["Access_ID"] = (int)rights_combo_box.SelectedItem;

                dsAction.Tables["UserTable"].Rows.Add(dr);
                oC.ReturnAda.Update(dsAction, "UserTable");
            }

            MessageBox.Show("Input Success", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTool();
            this.Close();

        }
        private void ClearTool()
        {
            txtFirstName.Text = "";
            txtPassword.Text = "";
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
