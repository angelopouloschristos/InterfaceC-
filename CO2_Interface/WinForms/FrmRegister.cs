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

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            oC.CheckEnterTextBox(txtLastName, "Last Name");
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            oC.CheckEnterTextBox(txtEmail, "Email");
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            oC.CheckEnterTextBox(txtUsername, "Username");
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            oC.CheckEnterTextBox(txtPassword, "Password");
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            oC.CheckEnterTextBox(txtEmail, "Email");
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            oC.CheckEnterTextBox(txtUsername, "Username");
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            oC.CheckLeaveTextBox(txtFirstName, "First Name");
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            oC.CheckLeaveTextBox(txtLastName, "Last Name");
        }

        private void txtEmail_Leave_1(object sender, EventArgs e)
        {
            oC.CheckLeaveTextBox(txtEmail, "Email");
        }

        private void txtUsername_Leave_1(object sender, EventArgs e)
        {
            oC.CheckLeaveTextBox(txtUsername, "Username");
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

            if (txtLastName.Text.Equals("") || txtLastName.Text.Equals("Last Name"))
            {
                MessageBox.Show("Input Last Name", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtEmail.Text.Equals("") || txtEmail.Text.Equals("Email"))
            {
                MessageBox.Show("Input Email", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtUsername.Text.Equals("") || txtUsername.Text.Equals("Username"))
            {
                MessageBox.Show("Input Username", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text.Equals("") || txtPassword.Text.Equals("Password"))
            {
                MessageBox.Show("Input Password", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataSet dsAction = new DataSet("Sample");
            string sSqlSave = "SELECT * FROM tbUser WHERE Username = '" + txtUsername.Text.Trim() + "'";
            dsAction = oC.ShowData(sSqlSave, "tbUser", dsAction);
            if (dsAction.Tables["tbUser"].Rows.Count <= 0)
            {
                DataRow dr = dsAction.Tables["tbUser"].NewRow();
                dr["FirstName"] = txtFirstName.Text;
                dr["LastName"] = txtLastName.Text;
                dr["Email"] = txtEmail.Text;
                dr["Username"] = txtUsername.Text;
                dr["LPassword"] = txtPassword.Text;

                dsAction.Tables["tbUser"].Rows.Add(dr);
                oC.ReturnAda.Update(dsAction, "tbUser");
            }

            MessageBox.Show("Input Success", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTool();
        }

        private void ClearTool()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
