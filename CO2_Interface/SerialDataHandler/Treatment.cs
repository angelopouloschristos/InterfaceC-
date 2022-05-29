using System.Windows.Forms;
using System.Data;
using System;
using System.Linq;
using CO2_Interface.Controls;
using CO2_Interface.Data;

namespace CO2_Interface.SerialDataHandler
{
    internal static partial class Reception
    {
        //elle est appele dans mainForm
        public static double last_data_used = 0; 


        internal static void DataTreatment(DataTable dt, DataGridView dg,ComboBox combobox)
        {

            //CHECK LE DEBUT DE TRAMME ET ENLEVE LES 3 PREMIERS ELEMENTS DE LA QUEUE LIST
            while ((Data.Collections.SerialBuffer.Count > 3) &&
                ((Data.Collections.SerialBuffer.ElementAt(0) != 0x55)  ||
                    (Data.Collections.SerialBuffer.ElementAt(1) != 0x55)  ||
                    (Data.Collections.SerialBuffer.ElementAt(2) != 0xAA)) 
                    ) Data.Collections.SerialBuffer.Dequeue();
            //-------!!!!!!!!!!!!!!!!!!1 CHANGEMENT DE BASE VERS MESURE
            
            while (Data.Collections.SerialBuffer.Count > 13)
            {
                Data.FromSensor.Measure obj = new Data.FromSensor.Measure();

                //DEBUT TRAME
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();

                obj.Serial = Data.Collections.SerialBuffer.Dequeue();
                obj.Serial <<= 8;
                obj.Serial += Data.Collections.SerialBuffer.Dequeue();
      
                obj.ID = Data.Collections.SerialBuffer.Dequeue();
                obj.Type = Data.Collections.SerialBuffer.Dequeue();
                obj.BinaryData = Data.Collections.SerialBuffer.Dequeue();
                obj.BinaryData <<= 8;
                obj.BinaryData += Data.Collections.SerialBuffer.Dequeue();
                //bit shift to left 
                obj.Checksum = Data.Collections.SerialBuffer.Dequeue();


                // ENLEVE LES 3 DERNIERS ELEMENTS DE LA QUEUE LIST (FIN TRAME)
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();

                //checksum???
                ObjToList(obj, dt, dg, combobox);
            }
                        
            // SI IL A TROUVER LE DEBUT DE TRAMME
        }

      
        /// <summary>
        /// cette methode ajoute les premieres mesures au debut de lancement du programme
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="dt"></param>
        /// <param name="dg"></param>
        /// <param name="comboBox"></param>
        internal static void ObjToList(Data.FromSensor.Measure obj, DataTable dt, DataGridView dg, ComboBox comboBox)
        {
            string type = get_type_name(obj.Type);
            //Data.Collections.ObjectList.Add(obj);
            //si le grid view est vide
            if (Data.Collections.ObjectList.Count == 0) 
            {
                Data.Collections.ObjectList.Add(obj);
                if (obj.config_status)
                {

                    dt.Rows.Add(new object[] { obj.ID, get_config_status(obj.config_status), get_type_name(obj.Type), (int)obj.ConvertedData + get_unite(obj), obj.time + "s", obj.time > obj.AlarmMaxPeriod ? "Outdated" : getStatus(obj.ConvertedData, obj.CriticalMin, obj.WarningMin, obj.WarningMax, obj.CriticalMax) });
                }
                else
                {
                    dt.Rows.Add(new object[] { obj.ID, get_config_status(obj.config_status), get_type_name(obj.Type), (int)obj.ConvertedData + get_unite(obj), obj.time + "s", "-" });
                }
                comboBox.Items.Add(obj.ID);
            }
            else
            {
                //sinon on cherche dans le tab si le id existe deja
                bool pas_trouve = true;

                foreach (FromSensor.Measure item in Data.Collections.ObjectList) 
                {
                    if (item.ID == obj.ID)
                    {
                        item.BinaryData = obj.BinaryData;
                        convert_data(item);
                        item.time=0;
                        item.outdated = false;
                        pas_trouve = false;
                    }
                
                }
                //si pas trouver alors on creer un nouveau item 
                if (pas_trouve) 
                {
                    comboBox.Items.Add(obj.ID);
                    if (obj.config_status)
                    {
                        dt.Rows.Add(new object[] { obj.ID, get_config_status(obj.config_status), get_type_name(obj.Type), (int)obj.ConvertedData + get_unite(obj), obj.time + "s", obj.time > obj.AlarmMaxPeriod ? "Outdated" : getStatus(obj.ConvertedData, obj.CriticalMin, obj.WarningMin, obj.WarningMax, obj.CriticalMax) });
                    }
                    else
                    {
                        dt.Rows.Add(new object[] { obj.ID, get_config_status(obj.config_status), get_type_name(obj.Type), (int)obj.ConvertedData + get_unite(obj), obj.time + "s", "-" });
                    }
                    //Console.WriteLine(obj.ID);
                    Data.Collections.ObjectList.Add(obj);
                }
            }
            
            update_data_table(dt);
            dg.DataSource = dt;
        }

        public static string get_unite(FromSensor.Measure obj)
        {
            if (obj.Type == 0)
            {
                return " alarme";
            }
            if (obj.Type == 1)
            {
                return " ppm";
            }
            if (obj.Type == 2)
            {
                return " °C";
            }
            if (obj.Type == 3)
            {
                return " %";
            }

            return "error";
        }

        /// <summary>
        /// cette methode mets a jour le tableau principal
        /// </summary>
        /// <param name="dt"></param>
        private static void update_data_table(DataTable dt)
        {
            dt.Rows.Clear(); 
            foreach (FromSensor.Measure obj in Data.Collections.ObjectList)
            {
                if (obj.config_status)
                {
                    dt.Rows.Add(new object[] { obj.ID, get_config_status(obj.config_status), get_type_name(obj.Type), (int)obj.ConvertedData + get_unite(obj), obj.time + "s", obj.time > obj.AlarmMaxPeriod ? "Outdated" : getStatus(obj.ConvertedData, obj.CriticalMin, obj.WarningMin, obj.WarningMax, obj.CriticalMax) });
                }
                else
                {
                    dt.Rows.Add(new object[] { obj.ID, get_config_status(obj.config_status), get_type_name(obj.Type), (int)obj.ConvertedData + get_unite(obj), obj.time + "s", "-" });
                }

            }

        }

        private static void convert_data(FromSensor.Measure obj)
        {
            obj.ConvertedData = (Int16)(((double)obj.BinaryData/65535)*(obj.HighLimit-obj.LowLimit)+obj.LowLimit);

        }
        private static string get_config_status(bool stat) 
        {
            if (stat)
            {
                return "Done";
            }
            else
            {
                return "Not Done";
            }
        }
        /// <summary>
        /// Cette methode permet de ajouter les valuers max et min d'une mesure
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mesure"></param>
        public static void change_min_max(int id, FromSensor.Measure mesure)
        {
            foreach (FromSensor.Measure item in Data.Collections.ObjectList)
            {
                if (item.ID.ToString() == id.ToString())
                {
                    item.HighLimit = mesure.HighLimit;  
                    item.LowLimit = mesure.LowLimit;
                }
            }
        }
        /// <summary>
        /// Cette methode permet de configuer une alarme et mettre le config staus a true
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mesure"></param>
        public static void configAlarm(int id, FromSensor.Measure mesure)
        {

            foreach (FromSensor.Measure item in Data.Collections.ObjectList)
            {
                if (item.ID.ToString() == id.ToString())
                {
                    item.WarningMin = mesure.WarningMin;
                    item.WarningMax = mesure.WarningMax;
                    item.CriticalMin = mesure.CriticalMin;  
                    item.CriticalMax = mesure.CriticalMax;  
                    item.AlarmMaxPeriod = mesure.AlarmMaxPeriod;
                    item.config_status = true;
                }
            }
        }

        /// <summary>
        /// Cette methode mets a jour le graphique 
        /// </summary>
        /// <param name="comboBox"></param>
        public static void update_graph(ComboBox comboBox )
        {
            if ( comboBox.Text != "")
            {
                foreach (FromSensor.Measure obj in Data.Collections.ObjectList)
                {
                    if (obj.ID.ToString() == comboBox.Text && obj.config_status)
                    {
                        //Console.WriteLine(obj.ID.ToString() + "/" + comboBox.Text);
                        //il faut save la deriere donnees
                        if (last_data_used!=obj.ConvertedData)
                        {
                            last_data_used=obj.ConvertedData;
                        }
                        GraphsControl.GraphUpdate(last_data_used, obj.Type, obj.LowLimit, obj.HighLimit, obj.CriticalMin, obj.WarningMin, obj.WarningMax, obj.CriticalMax);
                    }
                    
                
                }
                
            }
        }

        public static string get_type_name(byte b)
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
        //ON DOIT FAIRE UNE DUPICATION DE LA METHODE CAR ON SE TROUVE DANS UNE CLASSE STATIC
        public static string getStatus(double data, int cMin, int wMin, int wMax, int cMax)
        {
            if (data <= cMin)
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
            else if (data >= cMax)
            {
                return "too high";
            }
            return "";
        }
    }
}
