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
    public partial class SettingsControl : UserControl
    {
        public int time_to_send=300;

        public SettingsControl()
        {
            InitializeComponent();
            update_display();
        }

        public void btn_save_sending_data_Click(object sender, EventArgs e)
        {
            Decimal value = input_time_for_sending.Value;
            time_to_send = (int) value;
            update_display();
        }
        private void update_display() 
        {
            display_time_to_send.Text = "Sending data every " + time_to_send + " seconds";
        }
    }
}
