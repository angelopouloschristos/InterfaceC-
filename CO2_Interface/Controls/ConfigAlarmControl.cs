using CO2_Interface.Data;
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
    public partial class ConfigAlarmControl : UserControl
    {
        ComboBox comboAlarm;

        public ConfigAlarmControl()
        {
            InitializeComponent();
            
        }
        public void setCombo(ComboBox box) 
        {
            this.comboAlarm = box;
        }

        private void btn_config_alarm_Click(object sender, EventArgs e)
        {
            if (ManagerControl.is_logged)
            {
                //User current_user = Tables.Users[0];
                FromSensor.Measure mesure = new FromSensor.Measure();
                int.TryParse(criticalMinValue.Text, out mesure.CriticalMin);
                criticalMinValue.Text = "";
                int.TryParse(criticalMaxValue.Text, out mesure.CriticalMax);
                criticalMaxValue.Text = "";
                int.TryParse(warningMinValue.Text, out mesure.WarningMin);
                warningMinValue.Text = "";
                int.TryParse(warningMaxValue.Text, out mesure.WarningMax);
                warningMaxValue.Text = "";

                if (mesure.HighLimit < mesure.LowLimit)
                {
                    MessageBox.Show("Min value are bigger then max value");
                    return;
                }

                int id = 0;
                int.TryParse(comboAlarm.Text, out id);
                //MessageBox.Show(id.ToString());
                SerialDataHandler.Reception.change_min_max(id, mesure);
                SerialDataHandler.Reception.configAlarm(id, mesure);


            }
            else
            {
                MessageBox.Show("Please login first");
            }
        }
    }
}
