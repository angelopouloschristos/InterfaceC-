using CO2_Interface.Data;
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
        public bool is_logged = false;

        public ManagerControl()
        {
            InitializeComponent();


            Tables.Users.Columns.Add(Tables.Columns.ID_user);
            Tables.Users.Columns.Add(Tables.Columns.user_name);
            Tables.Users.Columns.Add(Tables.Columns.user_password);
            Tables.Users.Columns.Add(Tables.Columns.Access_id);

            data_grid_accounts.DataSource = Tables.Users;
            data_grid_accounts.Sort(data_grid_accounts.Columns[0], ListSortDirection.Ascending);

            Tables.Permissions.Columns.Add(Tables.Columns.ID_access);
            Tables.Permissions.Columns.Add(Tables.Columns.name);
            Tables.Permissions.Columns.Add(Tables.Columns.create_id);
            Tables.Permissions.Columns.Add(Tables.Columns.destroy_id);
            Tables.Permissions.Columns.Add(Tables.Columns.config_alarm);
            Tables.Permissions.Columns.Add(Tables.Columns.create_user);

            data_grid_perm.DataSource = Tables.Permissions;
            data_grid_perm.Sort(data_grid_perm.Columns[0], ListSortDirection.Ascending);
            LoadPerm();

            LoadInfo();



        }

        private void LoadPerm()
        {
            DataSet dsAction = new DataSet("perm");
            string sSqlSave = "SELECT * FROM AccessTable ";
            dsAction = oC.ShowData(sSqlSave, "AccessTable", dsAction);
            if (dsAction.Tables["AccessTable"].Rows.Count > 0)
            {
                for (int i = 0; i < dsAction.Tables["AccessTable"].Rows.Count; i++)
                {
                    string perm_id = dsAction.Tables["AccessTable"].Rows[i]["ID"].ToString();
                    Int32 id = int.Parse(perm_id);
                    string perm_name = dsAction.Tables["AccessTable"].Rows[i]["Name"].ToString();
                    string create = dsAction.Tables["AccessTable"].Rows[i]["AllowCreateID"].ToString();
                    string destroy = dsAction.Tables["AccessTable"].Rows[i]["AllowDestroyID"].ToString();
                    string config = dsAction.Tables["AccessTable"].Rows[i]["AllowConfigAlarm"].ToString();
                    string user_create = dsAction.Tables["AccessTable"].Rows[i]["UserCreation"].ToString();

                    Access perm = new Access(id, perm_name, Convert.ToBoolean(create), Convert.ToBoolean(destroy), Convert.ToBoolean(config), Convert.ToBoolean(user_create));
                    Collections.AccessList.Add(perm);
                    Tables.Permissions.Rows.Add(new object[] { perm_id, perm_name, create, destroy, config, user_create });

                }
                //MessageBox.Show(dsAction.Tables["tbUser"].Rows.Count.ToString()); // <-- MAX

            }
            else
            {
                MessageBox.Show("Load permissions Failed", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void LoadInfo()
        {

            //data_grid_accounts.Rows.Clear();

            DataSet dsAction = new DataSet("Sample");
            string sSqlSave = "SELECT * FROM UserTable ";
            dsAction = oC.ShowData(sSqlSave, "UserTable", dsAction);
            if (dsAction.Tables["UserTable"].Rows.Count > 0)
            {
                for (int i = 0; i < dsAction.Tables["UserTable"].Rows.Count; i++)
                {
                    string user_id = dsAction.Tables["UserTable"].Rows[i]["ID"].ToString();
                    Int32 id = int.Parse(user_id);
                    string name = dsAction.Tables["UserTable"].Rows[i]["UserName"].ToString();
                    string password = dsAction.Tables["UserTable"].Rows[i]["UserPassword"].ToString();
                    string access_id = dsAction.Tables["UserTable"].Rows[i]["Access_ID"].ToString();
                    int id_a = int.Parse(access_id);

                    User user = new User(id,name,password,id_a);
                    Collections.Users.Add(user);
                    Tables.Users.Rows.Add(new object[] {id.ToString(),name,password, id_a.ToString() });

                }
                //MessageBox.Show(dsAction.Tables["tbUser"].Rows.Count.ToString()); // <-- MAX

            }
            else
            {
                MessageBox.Show("Load accounts Failed", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
    }
}
