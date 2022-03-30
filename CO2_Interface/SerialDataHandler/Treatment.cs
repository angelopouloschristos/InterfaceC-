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
        public static uint last_data_used = 0; 


        internal static void DataTreatment(DataTable dt, DataGridView dg,ComboBox combobox)
        {

            //CHECK LE DEBUT DE TRAMME ET ENLEVE LES 3 PREMIERS ELEMENTS DE LA QUEUE LIST
            while (  (Data.Collections.SerialBuffer.ElementAt(0) != 0x55)  &&
                    (Data.Collections.SerialBuffer.ElementAt(1) != 0x55)  &&
                    (Data.Collections.SerialBuffer.ElementAt(2) != 0xAA) &&
                    (Data.Collections.SerialBuffer.Count > 3)) Data.Collections.SerialBuffer.Dequeue();
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

      

        internal static void ObjToList(Data.FromSensor.Measure obj, DataTable dt, DataGridView dg, ComboBox comboBox)
        {
            string type = get_type_name(obj.Type);
            //Data.Collections.ObjectList.Add(obj);
            //si le grid view est vide
            if (Data.Collections.ObjectList.Count == 0) 
            {
                Data.Collections.ObjectList.Add(obj);
                dt.Rows.Add(new object[] { obj.Serial,obj.ID, type,  obj.ConvertedData, obj.time ,obj.Checksum});
            }
            else
            {
                //sinon on cherche dans le tab si le id existe deja
                bool pas_trouve = true;
                foreach (FromSensor.Measure item in Data.Collections.ObjectList) 
                {
                    if (item.ID == obj.ID)
                    {
                        convert_data(obj);

                        item.ConvertedData = obj.ConvertedData;
                        item.time=0;
                        pas_trouve = false;
                    }
                
                }
                //si pas trouver alors on creer un nouveau item 
                if (pas_trouve) 
                {
                    //obj.Lowe
                    
                    comboBox.Items.Add(obj.ID);
                    dt.Rows.Add(new object[] { obj.Serial, obj.ID, type,  obj.ConvertedData,obj.time ,obj.Checksum });
                    //Console.WriteLine(obj.ID);
                    Data.Collections.ObjectList.Add(obj);
                }
            }

            update_data_table(dt);
            dg.DataSource = dt;
            update_graph(comboBox, obj);
        }

        private static void update_data_table(DataTable dt)
        {
            
            dt.Rows.Clear(); 
            foreach (FromSensor.Measure obj in Data.Collections.ObjectList)
            {
                dt.Rows.Add(new object[] { obj.Serial, obj.ID, get_type_name(obj.Type), obj.ConvertedData, obj.time, obj.Checksum });
     
            }
            
        }

        private static void convert_data(FromSensor.Measure obj)
        {
            if (obj.LowLimit!=0  && obj.HighLimit!=0)
            {
                obj.ConvertedData = (Int32)(obj.BinaryData/65535)*(obj.HighLimit-obj.LowLimit)+obj.LowLimit;
                
            }
        }
        public static void change_min_max(int id, int min, int max) 
        {
            //Console.WriteLine(id + "/" + min + "/" + max);


            //on recois la valeur  depuis mainform
            foreach (FromSensor.Measure item in Data.Collections.ObjectList)
            {
                
                Console.WriteLine(item.ID + "/" );

                if (item.ID.ToString() == id.ToString())
                {
                   
                    item.LowLimit = min;
                    item.HighLimit = max;
                    //Console.WriteLine(item.LowLimit + "/" + item.HighLimit + "/" + item.ConvertedData);
                }
            }
        }

        private static void update_graph(ComboBox comboBox, Data.FromSensor.Base obj )
        {
            if (/*current_control == "graph" &&*/ comboBox.Text != "")
            {
                
                if (obj.ID.ToString() == comboBox.Text /*&& item.Type==(byte)1*/)
                {
                    //Console.WriteLine(obj.ID.ToString() + "/" + comboBox.Text);
                    //il faut save la deriere donnees
                    if (last_data_used!=obj.BinaryData)
                    {
                        last_data_used=obj.BinaryData;
                    }
                    
                }
                GraphsControl.GraphUpdate(last_data_used);
                
            }
        }

        private static string get_type_name(byte b)
        {
            if (b==0)
            {
                return "alarme";
            }
            if (b==1)
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
