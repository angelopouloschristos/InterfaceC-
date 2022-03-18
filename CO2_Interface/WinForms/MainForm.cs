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
        public MainForm()
        {
            InitializeComponent();

            this.mainConrol = new Controls.MainControl();



            //reception de donnees
            SerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataHandler.Reception.ReceptionHandler);

            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Serial);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.ID);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Type);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.BinaryData);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Checksum);
            
            
            Refresh();
            
        //MessageBox.Show(db.Tables.Count.ToString());
    }            
        private void button_COM_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort.Open();
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);   
            }

            if (SerialPort.IsOpen) ConnexionStatus_Label.Text = "Open";
            else ConnexionStatus_Label.Text = "Close";
        }

        private void button_DataTreatment_Click(object sender, EventArgs e)
        {
            //on prend les donnes dans la table
            //SerialDataHandler.Reception.DataTreatment(Data.Tables.DataFromSensor, ObjectsGrid);
            //Console.WriteLine(Data.Collections.SerialBuffer.ToString());
            //mise a jour de la bare d'affichage
            // dt;
            

            ObjectsGrid.DataSource = ObjectsGrid;
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 500; // in miliseconds
            timer1.Start();/*
            for (int i = 1; i < 6; i++)
            {
                ObjectsGrid.Rows.Add(new object[] { i, 0, 0, 0, 0 });
            }*/
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            SerialDataHandler.Reception.DataTreatment(Data.Tables.DataFromSensor, ObjectsGrid);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyContainer.Controls.Add(mainConrol);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
