using System;
using System.IO.Ports;
using System.Windows.Forms;
using CO2_Interface.Controls;
using LoginRegis;

namespace CO2_Interface
{
    public partial class MainForm : Form
    {
        Timer timer1;
        Timer timer_clock;

        private Controls.MainControl mainConrol;
        private Controls.GraphsControl graphsConrol;
        private Controls.AccountControl AccountControl;
        private Controls.AlarmControl alarmControl;
        private DataGridView ObjectsGrid;
        public int value = 0;
        //pour voir quel control est IN USE
        public string current_control = "start";


        public MainForm()
        {
            InitializeComponent();

            this.mainConrol = new Controls.MainControl();
            this.graphsConrol = new Controls.GraphsControl();
            this.AccountControl = new Controls.AccountControl();
            this.alarmControl = new Controls.AlarmControl();

            //reception de donnees
            SerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataHandler.Reception.ReceptionHandler);

            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.ID);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Config_status);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Type);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.BinaryData);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Last_updated);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Alarm);


            try
            {
                SerialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (SerialPort.IsOpen) ConnexionStatus_Label.Text = "Open";
            else ConnexionStatus_Label.Text = "Error with port";

            //TIMER POUR LA HORLOGE
            timer_clock = new Timer();
            timer_clock.Tick += new EventHandler(timer_clock_Tick);
            timer_clock.Interval = 1000; // in miliseconds
            timer_clock.Start();


            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // in miliseconds

            Refresh();

            //MessageBox.Show(db.Tables.Count.ToString());
        }

        private void timer_clock_Tick(object sender, EventArgs e) 
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            String day = DateTime.Now.Day.ToString();
            String month = DateTime.Now.Month.ToString();
            String year = DateTime.Now.Year.ToString();


            //time
            string time ="";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            lb_clock.Text = time +" "+day+"/"+month+"/"+year;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            MyContainer.Controls.Clear();
            MyContainer.Controls.Add(mainConrol);
            ObjectsGrid = mainConrol.ObjectsGrid1;
            current_control = "main";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            SerialDataHandler.Reception.DataTreatment(Data.Tables.DataFromSensor, ObjectsGrid, combobox_id);
            if (current_control=="graph")
            {
                GraphsControl.setCpt();
                SerialDataHandler.Reception.update_graph(combobox_id);
            }
            
            foreach (Data.FromSensor.Measure item in Data.Collections.ObjectList)
            {
                item.time++;
                
                if (item.time > 10 && !item.outdated)
                {
                    //MessageBox.Show("Le capteur avec id: " + item.ID + " a pas ete rafrechis", "Alarme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    item.outdated = true;
                }
                
            }
        }
    

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyContainer.Controls.Add(graphsConrol);
            current_control = "graph";
        }

        private void account_button_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyContainer.Controls.Add(AccountControl);
            current_control = "account";
        }

        private void btn_change_minmax_Click(object sender, EventArgs e)
        {
            int min = 0;
            int.TryParse(min_value.Text, out min);

            int max = 0;
            int.TryParse(max_value.Text, out max);

            int id = 0;
            int.TryParse(combobox_id.Text,out id);

            SerialDataHandler.Reception.change_min_max(id,min,max);
        }

        private void alarm_button_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyContainer.Controls.Add(alarmControl);
            current_control = "alarm";
        }
    }
}
