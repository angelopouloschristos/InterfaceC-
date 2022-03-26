using System;
using System.IO.Ports;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace CO2_Interface
{
    public partial class MainForm : Form
    {
        Timer timer1;
        Timer timer_clock;

        private Controls.MainControl mainConrol;
        private Controls.GraphsControl graphsConrol;
        private Controls.AccountControl AccountControl;
        private DataGridView ObjectsGrid;
        public int value = 0;
        //pour voir quel control est IN USE
        public string current_control = "start";
        //public static ComboBox combobox_id;


        public MainForm()
        {
            InitializeComponent();

            this.mainConrol = new Controls.MainControl();
            this.graphsConrol = new Controls.GraphsControl();
            this.AccountControl = new Controls.AccountControl();
            //combobox_id = combobox_id;
            //selected_id = combobox_id.SelectedValue.ToString();

            //reception de donnees
            SerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataHandler.Reception.ReceptionHandler);

            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Serial);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.ID);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Type);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.BinaryData);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Checksum);
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
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();
            MyContainer.Controls.Clear();
            MyContainer.Controls.Add(mainConrol);
            ObjectsGrid = mainConrol.ObjectsGrid1;
            current_control = "main";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            SerialDataHandler.Reception.DataTreatment(Data.Tables.DataFromSensor, ObjectsGrid, combobox_id);
            graphsConrol.cpt++;
            if (combobox_id.Text != null)
            {
                graphsConrol.current_id = combobox_id.Text.ToString();
                //selected_id -> id choisi
                //MessageBox.Show("/"+ combobox_id.SelectedValue.ToString());
                if (current_control == "graph")
                {

                    foreach (Data.FromSensor.Base item in Data.Collections.ObjectList)
                    {
                        if (combobox_id.SelectedItem != null)
                        {
                            if (item.ID.ToString() == combobox_id.SelectedItem.ToString())
                            {
                                graphsConrol.GraphUpdate((int)item.BinaryData);
                            }
                        }
                    }
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
            //MessageBox.Show(combobox_id.SelectedValue.ToString());
        }

        private void account_button_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyContainer.Controls.Add(AccountControl);
            current_control = "account";
        }
    }
}
