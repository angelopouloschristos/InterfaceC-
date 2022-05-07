using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginRegis
{
    class oCenter
    {
        OleDbDataAdapter oleDaAc = new OleDbDataAdapter();
        OleDbConnection oleCon = new OleDbConnection();

        public static string sName = "";
        public static string sPassword = "";
        private bool bCheckConnect = false;

        private void ConnectDB()
        {
            try
            {
                bCheckConnect = false;

                string sPath = System.Windows.Forms.Application.StartupPath.ToLower();
                sPath.Replace(@"\",@"\\");
                string sDatabase = "login_regis.accdb";
                string sConn = "Provider = Microsoft.ACE.OLEDB.12.0; data source =" + sPath + "\\" + sDatabase;

                if (oleCon.State == ConnectionState.Open)
                {
                    oleCon.Close();
                }

                oleCon.ConnectionString = sConn;
                oleCon.Open();
                bCheckConnect = true;

            } catch(Exception ex)
            {
                bCheckConnect = false;
                MessageBox.Show("Error : "+ ex.Message.ToString() ,"Msg",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        public DataSet ShowData(string _sSql, string _sTable, DataSet _ds)
        {
            DataSet dsSet;
            if(!bCheckConnect)
            {
                ConnectDB();
            }

            try
            {
                _ds.Clear();
                oleDaAc = new OleDbDataAdapter(_sSql, oleCon);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(oleDaAc);
                oleDaAc.Fill(_ds, _sTable);
                dsSet = _ds;
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message.ToString(), "Msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dsSet = null;
            } 
            finally
            {
                bCheckConnect = false;
                oleCon.Close();
            }

            return dsSet;
        }

        public OleDbDataAdapter ReturnAda
        {
            get
            {
                return oleDaAc;
            }
            set
            {
                oleDaAc = value;
            }
        }

        //==================================
        public void CheckEnterTextBox(TextBox _txtEnter, string _sMessage)
        {
            string sText = _txtEnter.Text.Trim();
            if (sText.Equals(_sMessage))
            {
                _txtEnter.Text = "";
                _txtEnter.ForeColor = Color.Black;
            }
        }

        public void CheckLeaveTextBox(TextBox _txtLeave, string _sMessage)
        {
            string sText = _txtLeave.Text.Trim();
            if(sText.Equals(_sMessage) || _txtLeave.Text.Equals(""))
            {
                _txtLeave.Text = _sMessage;
                _txtLeave.ForeColor = Color.Gray;
                if (_txtLeave.Equals("Password"))
                {
                    _txtLeave.UseSystemPasswordChar = false;
                }
            }
        }
    }
}
