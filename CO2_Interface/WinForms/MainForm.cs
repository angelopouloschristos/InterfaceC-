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
        private Controls.MainControl mainConrol;
        private Controls.GraphsControl graphsConrol;
        private DataGridView ObjectsGrid;
        public int value = 0;
        //public static ComboBox combobox_id;


        public MainForm()
        {
            InitializeComponent();

            this.mainConrol = new Controls.MainControl();
            this.graphsConrol = new Controls.GraphsControl();
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

            Refresh();
            
        //MessageBox.Show(db.Tables.Count.ToString());
    }

        public static ComboBox GetComboBox() { return combobox_id; }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyContainer.Controls.Add(mainConrol);
            ObjectsGrid = mainConrol.ObjectsGrid1;

            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            SerialDataHandler.Reception.DataTreatment(Data.Tables.DataFromSensor, ObjectsGrid);
            graphsConrol.cpt++;
            //selected_id -> id choisi
            MessageBox.Show("/"+ combobox_id.SelectedValue.ToString());
            foreach (Data.FromSensor.Base item in Data.Collections.ObjectList) 
            {
                
                if (item.ID.ToString()==combobox_id.SelectedValue.ToString())
                {
                    graphsConrol.GraphUpdate((int)item.BinaryData);
                    
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
            MessageBox.Show(combobox_id.SelectedValue.ToString());
        }
    }
}
