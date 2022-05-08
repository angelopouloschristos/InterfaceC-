using CO2_Interface.Data;
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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        oCenter oC = new oCenter();

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            oC.CheckEnterTextBox(txtFirstName, "First Name");
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            oC.CheckEnterTextBox(txtPassword, "Password");
        }
        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            oC.CheckLeaveTextBox(txtFirstName, "First Name");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            oC.CheckLeaveTextBox(txtPassword, "Password");
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
                dr["Access_ID"] = 2;

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
    }
}
