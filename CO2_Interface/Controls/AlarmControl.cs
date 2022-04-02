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
    public partial class AlarmControl : UserControl
    {
        Timer timer;

        public AlarmControl()
        {
            InitializeComponent();
            Tables.AlarmData.Columns.Add(Tables.Columns.ID_alarm);
            Tables.AlarmData.Columns.Add(Tables.Columns.Type_alarm);
            Tables.AlarmData.Columns.Add(Tables.Columns.Critical_min);
            Tables.AlarmData.Columns.Add(Tables.Columns.Warning_min);
            Tables.AlarmData.Columns.Add(Tables.Columns.Warning_max);
            Tables.AlarmData.Columns.Add(Tables.Columns.Criitical_max);
            Tables.AlarmData.Columns.Add(Tables.Columns.Status);

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000; // in miliseconds
            timer.Start();

            //alarm_grid_view.DataSource = Tables.AlarmData;
            //Refresh();
            //alarm_grid_view.Refresh();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (Data.FromSensor.Measure obj in Data.Collections.ObjectList)
            {
                if (obj.config_status)
                {
                    Data.Tables.AlarmData.Rows.Add(new object[] { 
                        obj.ID, SerialDataHandler.Reception.get_type_name(obj.Type), 
                        obj.CriticalMin + SerialDataHandler.Reception.get_unite(obj), 
                        obj.WarningMin+ SerialDataHandler.Reception.get_unite(obj), 
                        obj.WarningMax + SerialDataHandler.Reception.get_unite(obj), 
                        obj.CriticalMax + SerialDataHandler.Reception.get_unite(obj), 
                        getStatus(obj.ConvertedData,obj.CriticalMin,obj.WarningMin,obj.WarningMax,obj.CriticalMax) });
                }
            }

            update_data_table(Tables.AlarmData);
            alarm_grid_view.DataSource = Tables.AlarmData;
        }

        public string getStatus(double data,int cMin,int wMin, int wMax, int cMax)
        {
            if (data <= cMin )
            {
                return "too low";
            }
            else if (data > cMin && data <= wMin)
            {
                return "low";
            }
            else if (data > wMin && data <= wMax)
            {
                return "ok";
            }
            else if (data > wMax && data < cMax)
            {
                return "high";
            }
            else if (data >= cMax )
            {
                return "too high";
            }
            return "";
        }
        private void update_data_table(DataTable dt)
        {

            dt.Rows.Clear();
            foreach (FromSensor.Measure obj in Data.Collections.ObjectList)
            {
                Data.Tables.AlarmData.Rows.Add(new object[] {
                        obj.ID, SerialDataHandler.Reception.get_type_name(obj.Type),
                        obj.CriticalMin + SerialDataHandler.Reception.get_unite(obj),
                        obj.WarningMin+ SerialDataHandler.Reception.get_unite(obj),
                        obj.WarningMax + SerialDataHandler.Reception.get_unite(obj),
                        obj.CriticalMax + SerialDataHandler.Reception.get_unite(obj),
                        getStatus(obj.ConvertedData,obj.CriticalMin,obj.WarningMin,obj.WarningMax,obj.CriticalMax) });

            }

        }
    }
}
