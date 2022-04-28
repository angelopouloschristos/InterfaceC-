using System;
using System.Collections;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using CO2_Interface.Controls;
using CO2_Interface.Data;
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

            loadData();

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

        private void loadData()
        {
            int i, j;
            //string FilePath = Application.StartupPath.ToLower();
            string FilePath = Directory.GetCurrentDirectory();
            
            //FilePath.Replace(@"\", @"\\");
            FilePath += "\\Config.csv";
            try
            {   
                
                StreamReader Reader = new StreamReader(FilePath, ASCIIEncoding.Default);
                //MessageBox.Show(FilePath);


                string fileContent = Reader.ReadToEnd();

                i = fileContent.IndexOf("\r");

                var Text = string.Empty;
                for (j = 0; j < i; j++) Text += fileContent[j];


                if (Text == "DataSave")
                {
                    //get index line of start
                    i = fileContent.IndexOf("Start");
                    //get index line of end
                    int FileEnd = fileContent.IndexOf("End");
                    //on fait +=7 car Start a 5 chiffres et \r\n est considere commme 2 chiffre
                    //on va se trouver juste apres start
                    i += 7;

                    //si le start 
                    if (i >= FileEnd) ConfigFile_Status.Text = "Empty";

                    //ConfigFile_Content.Text = "";
                    ArrayList display = new ArrayList();
                    int current_elem = 0;
                    FromSensor.Measure obj = new FromSensor.Measure();

                    while (i < FileEnd)
                    {
                        display.Add(fileContent[i].ToString());
                        i++;
                        //si on a trouve un seperateur de element
                        //le current element dit si on est entrain de prende un id,type,data,...
                        if (fileContent[i]==';')
                        {
                            if (current_elem==0)
                            {
                                obj.ID =string_to_byte(display);
                                display.Clear();
                            }
                            else if (current_elem == 1)
                            {
                                obj.Type = string_to_byte(display);
                                display.Clear();

                            }
                            else if (current_elem == 2)
                            {
                                obj.ConvertedData = string_to_int16(display);
                                display.Clear();

                            }
                            else if (current_elem == 3)
                            {
                                obj.LowLimit = string_to_int16(display);
                                display.Clear();

                            }
                            else if (current_elem == 4)
                            {
                                obj.HighLimit = string_to_int16(display);
                                display.Clear();

                            }


                            i++;
                            current_elem++;
                            //si on a trouve tout les elemets de la ligne
                            if (current_elem>4)
                            {
                                current_elem = 0;
                                obj.config_status = true;
                                Collections.ObjectList.Add(obj);
                                combobox_id.Items.Add(obj.ID);
                                SerialDataHandler.Reception.change_min_max(obj.ID,obj.LowLimit,obj.HighLimit);
                                obj = new FromSensor.Measure();
                            }
                            
                        }
                    }
                    ConfigFile_Status.Text = "Load Complete";
                    Reader.Close();
                    foreach (FromSensor.Measure item in Collections.ObjectList)
                    {
                        Console.WriteLine("===================================");
                        Console.WriteLine(item.ID+" "+item.Type+" "+item.ConvertedData+" "+item.LowLimit+" "+item.HighLimit);
                        Console.WriteLine("===================================");

                    }
                }
                else ConfigFile_Status.Text = "Load Corrupted incomplete debut fichier";
            }
            catch (FileNotFoundException e)
            {
                ConfigFile_Status.Text = "Load file Not found";
                MessageBox.Show("Error: " + e.ToString());
            }
            catch (IOException e)
            {
                ConfigFile_Status.Text = "Not loaded";
                MessageBox.Show("Error: " + e.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
                ConfigFile_Status.Text = "Error";
            }

        }

        private byte string_to_byte(ArrayList display)
        {
            string result ="";
            foreach (var item in display)
            {
                result+=item.ToString();
            }
            //MessageBox.Show(result);
            byte temp = byte.Parse(result);

            return temp;
        }
        private Int16 string_to_int16(ArrayList display)
        {
            string result = "";
            foreach (var item in display)
            {
                result += item.ToString();
            }
            //MessageBox.Show(result);
            Int16 temp = Int16.Parse(result);

            return temp;
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

        //selected data is going to be save to a csv file
        private void save_button_Click(object sender, EventArgs e)
        {
            int id = 0;// the selected id
            int.TryParse(combobox_id.Text, out id);
            var fileContent = string.Empty;
            fileContent += "DataSave\r\n";
            fileContent += "Saved at "+DateTime.Now + "\r\n";
            fileContent += "ID ;";
            fileContent += "Type ;";
            fileContent += "Data ;";
            fileContent += "Low Limit ;";
            fileContent += "High Limit ;";
            fileContent += "\r\n";
            fileContent += "Start";
            fileContent += "\r\n";


            foreach (FromSensor.Measure item in Collections.ObjectList)
            {
                if (item.config_status)
                {
                    fileContent += item.ID+";";
                    fileContent += item.Type + ";";
                    fileContent += (int)item.ConvertedData + ";";
                    fileContent += item.LowLimit + ";";
                    fileContent += item.HighLimit + ";";
                    fileContent += "\r\n";
                }
                
            }

            fileContent += "End";

            string filePath = Directory.GetCurrentDirectory();
            filePath += "\\Config.csv";

            StreamWriter Writer = new StreamWriter(filePath, false);
            Writer.Write(fileContent);
            Writer.Close();
            MessageBox.Show("Saved with succes");
        }
        public string get_type_name(byte b)
        {
            if (b == 0)
            {
                return "alarme";
            }
            if (b == 1)
            {
                return "Co2";
            }
            if (b == 2)
            {
                return "Temperature";
            }
            if (b == 3)
            {
                return "Humidite";
            }

            return "type pas dans le systeme";
        }
    }
}
