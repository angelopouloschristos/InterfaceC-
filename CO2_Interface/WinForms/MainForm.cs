using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.IO.Ports;
using System.Net;
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

        private MainControl mainConrol;
        private GraphsControl graphsConrol;
        private AccountControl AccountControl;
        private AlarmControl alarmControl;
        private SettingsControl settingsControl;
        private ManagerControl managerControl;
        private ConfigControl configControl;
        private DataGridView ObjectsGrid;
        private bool connected = false; //connected to port
        public int value = 0;
        public int send_time = 0;
        //pour voir quel control est IN USE
        public string current_control = "start";
        Random rnd = new Random();
        private string port_name = "";
        
        public MainForm()
        {
            InitializeComponent();

            this.mainConrol = new MainControl();
            this.graphsConrol = new GraphsControl();
            this.AccountControl = new AccountControl() ;
            this.alarmControl = new AlarmControl();
            this.settingsControl = new SettingsControl();
            this.managerControl = new ManagerControl();
            configControl = new ConfigControl();

            login_container.Controls.Clear();
            login_container.Controls.Add(AccountControl);

            //AccountControl.Hide();

            //reception de donnees
            SerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataHandler.Reception.ReceptionHandler);

            Tables.DataFromSensor.Columns.Add(Tables.Columns.ID);
            Tables.DataFromSensor.Columns.Add(Tables.Columns.Config_status);
            Tables.DataFromSensor.Columns.Add(Tables.Columns.Type);
            Tables.DataFromSensor.Columns.Add(Tables.Columns.BinaryData);
            Tables.DataFromSensor.Columns.Add(Tables.Columns.Last_updated);
            Tables.DataFromSensor.Columns.Add(Tables.Columns.Alarm);

            managerControl.LoadInfo();


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
                            else if (current_elem == 5)
                            {
                                obj.WarningMin = string_to_int16(display);
                                display.Clear();

                            }
                            else if (current_elem == 6)
                            {
                                obj.WarningMax = string_to_int16(display);
                                display.Clear();

                            }
                            else if (current_elem == 7)
                            {
                                obj.CriticalMin = string_to_int16(display);
                                display.Clear();

                            }
                            else if (current_elem == 8)
                            {
                                obj.CriticalMax = string_to_int16(display);
                                display.Clear();

                            }


                            i++;
                            current_elem++;
                            //si on a trouve tout les elemets de la ligne
                            if (current_elem>8)
                            {
                                current_elem = 0;
                                obj.config_status = true;
                                Data.Collections.ObjectList.Add(obj);
                                combobox_id.Items.Add(obj.ID);
                                SerialDataHandler.Reception.change_min_max(obj.ID, obj);
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
            if (connected)
            {
                timer1.Start();
                //ConfigContainer.Controls.Clear();
                //ConfigContainer.Controls.Add(configControl);

                MyContainer.Controls.Clear();
                MyContainer.Controls.Add(mainConrol);
                ObjectsGrid = mainConrol.ObjectsGrid1;
                current_control = "main";
            }
            else 
            {
                ConnexionStatus_Label.Text = "Connect to your port";
                ConnexionStatus_Label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ff0000");
            }
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //partie sending data every x temps
            send_time++;
            if (send_time >= settingsControl.time_to_send)
            {
                send_time = 0;
                send_data_to_server();
            }


            SerialDataHandler.Reception.DataTreatment(Data.Tables.DataFromSensor, ObjectsGrid, combobox_id);
            ObjectsGrid.Sort(ObjectsGrid.Columns[0], ListSortDirection.Ascending);

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

        private void send_data_to_server()
        {
            
            int local = -1;
            int type = -1;
            int taux = -1;
            lb_status.Text = "Sending status: Sending....";
            foreach (FromSensor.Measure item in Collections.ObjectList)
            {
                if (item.config_status )
                {
                    local = rnd.Next(1,4);
                    type = item.Type;
                    taux = (int)item.ConvertedData;
                    string URL = "http://vps-70f2628e.vps.ovh.net/csharp.php?taux=" + taux + "&type=" + type + "&local=" + local;
                    using (WebClient client = new WebClient())
                    {
                        string src = client.DownloadString(URL);
                    }
                    lb_status.Text = "Sending status: Done :)";

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
            if (ManagerControl.is_logged)
            {
                MyContainer.Controls.Clear();
                MyContainer.Controls.Add(managerControl);
                current_control = "manager";
                managerControl.LoadInfo();
                managerControl.update_users();

            }
            else
            {
                MessageBox.Show("Please login first");
            }
            
        }

        private void btn_change_minmax_Click(object sender, EventArgs e)
        {

            FromSensor.Measure mesure = new FromSensor.Measure();



            int.TryParse(min_value.Text, out mesure.LowLimit);

            int.TryParse(max_value.Text, out mesure.HighLimit);
       
            int.TryParse(criticalMinValue.Text, out mesure.CriticalMin);

            int.TryParse(criticalMaxValue.Text, out mesure.CriticalMax);
    
            int.TryParse(warningMinValue.Text, out mesure.WarningMin);
     
            int.TryParse(warningMaxValue.Text, out mesure.WarningMax);

            int.TryParse(maxPeriodValue.Text, out mesure.AlarmMaxPeriod);

            int id = 0;
            int.TryParse(combobox_id.Text,out id);

            SerialDataHandler.Reception.change_min_max(id, mesure);
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
            fileContent += "Warning min ; ";
            fileContent += "Warning max ; ";
            fileContent += "Critical min ; ";
            fileContent += "Critical max ; ";
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
                    fileContent += item.WarningMin + ";";
                    fileContent += item.WarningMax + ";";
                    fileContent += item.CriticalMin + ";";
                    fileContent += item.CriticalMax + ";";
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
                return "Temperature";
            }
            if (b == 2)
            {
                return "Humidite";
            }
            if (b == 3)
            {
                return "Co2";
            }

            return "type pas dans le systeme";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_send_Click(object sender, EventArgs e)
        {
           
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void strip_button_settings_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyContainer.Controls.Add(settingsControl);
            current_control = "settings";
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            port_name = combo_box_com.Text;

            if(port_name == "")
            {
                MessageBox.Show("Please select a Port");
                return;
            }

            SerialPort.PortName = port_name;
            
            if (port_name == "")//error
            {
                ConnexionStatus_Label.Text = "Select port please";
                ConnexionStatus_Label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ff0000");
            }
            else 
            {
                try
                {
                    SerialPort.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (SerialPort.IsOpen)
                {
                    ConnexionStatus_Label.Text = "Port Open";
                    ConnexionStatus_Label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1aff00");
                    connected = true;
                }
                else
                {
                    ConnexionStatus_Label.Text = "Error with port";
                    ConnexionStatus_Label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ff0000");

                }
            }

            
        }

        private void accountControl1_Load(object sender, EventArgs e)
        {

        }

    }
}
