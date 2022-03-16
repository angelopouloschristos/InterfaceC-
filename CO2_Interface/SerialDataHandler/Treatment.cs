using System.Windows.Forms;
using System.Data;
using System;
using System.Linq;

namespace CO2_Interface.SerialDataHandler
{
    internal static partial class Reception
    {
        //elle est appele dans mainForm
        static byte[] debut_trame = {0x55, 0x55,0xAA};
        static byte[] fin_trame = { 0xAA,0xAA,0x55};
        static byte[] verif_trame ;
        static bool found;
        internal static void DataTreatment(DataTable dt, DataGridView dg)
        {

            //regarde la taille de la queue list
            int BytesNbr = Data.Collections.SerialBuffer.Count;    // Fix value to avoid changes in for loop
            verif_trame = new byte[3];

            //MessageBox.Show(found.ToString());
            found = false;
            BytesNbr = found_start(BytesNbr);
            //creation de l'objet de data mesure
            //[85 85 170] id type Nbrbytes data checksum[170 170 85]
            if (BytesNbr> 14)
            {
                verif_trame[0]= Data.Collections.SerialBuffer.Dequeue();
                if (debut_trame[0]==verif_trame[0])
                {
                    //MessageBox.Show("ok1");
                    verif_trame[1]= Data.Collections.SerialBuffer.Dequeue();
                    if (debut_trame[1] == verif_trame[1])
                    {
                        //MessageBox.Show("ok2");
                        verif_trame[2] = Data.Collections.SerialBuffer.Dequeue();
                        if (debut_trame[2] == verif_trame[2])
                        {
                            //MessageBox.Show("found all");
                            found = true;
                        }
                    }
                }
            }
            //MessageBox.Show(found.ToString());
            if (found)
            {
                Data.FromSensor.Base obj = new Data.FromSensor.Base(0,0,0,0,0);

                for (int i = 0; i < BytesNbr; i++)
                {
                    //The following data's shall be extracted from Queue List
                    if (Data.Collections.SerialBuffer.Count > 6)
                    {
                        byte serial1 = Data.Collections.SerialBuffer.Dequeue();
                        byte serial2 = Data.Collections.SerialBuffer.Dequeue();
                        obj.Serial = (byte)((UInt16)(serial1<< 8) + (UInt16)serial2);
                        Console.WriteLine(obj.Serial.ToString());
                        obj.ID = Data.Collections.SerialBuffer.Dequeue();
                        obj.Type = Data.Collections.SerialBuffer.Dequeue();
                        obj.BinaryData = Data.Collections.SerialBuffer.Dequeue();
                        //bit shift to left 
                        obj.Checksum = Data.Collections.SerialBuffer.Dequeue();
                    }
                    //This part shall be modified once rules have been defined 
                }
                verif_trame = new byte[fin_trame.Length];
                bool error = true;
                verif_trame[0] = Data.Collections.SerialBuffer.Dequeue();
                if (fin_trame[0] == verif_trame[0])
                {
                    //MessageBox.Show("ok1");
                    verif_trame[1] = Data.Collections.SerialBuffer.Dequeue();
                    if (fin_trame[1] == verif_trame[1])
                    {
                        //MessageBox.Show("ok2");
                        verif_trame[2] = Data.Collections.SerialBuffer.Dequeue();
                        if (fin_trame[2] == verif_trame[2])
                        {
                            error= false;
                            //MessageBox.Show("fin trame trouve");
                        }
                    }
                }
                //si il y a pas de erreur pour check fin trame
                if (!error )
                {
                    ObjToList(obj, dt, dg);
                    //checksum okk
                    if (obj.Type+  obj.BinaryData==obj.Checksum)
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Error checksum");
                    }
                    
                }
                //++ on doit verifier le checksum sinon alert error et on ajoute pas
                
                //+++++ fin de trame  [170 170 85]


            }
        }

        private static int found_start(int bytesNbr)
        {
            while (Data.Collections.SerialBuffer.Dequeue()!=85 &&
               Data.Collections.SerialBuffer.Dequeue() != 85 &&
               Data.Collections.SerialBuffer.Dequeue() != 170 && bytesNbr >4) 
            {
                bytesNbr--;
            }
            return bytesNbr;
        }

        internal static void ObjToList(Data.FromSensor.Base obj, DataTable dt, DataGridView dg)
        {
            
            
            Data.Collections.ObjectList.Add(obj);
            //insersion dans la table d'affichage 
            // [85 85 170] id type Nbrbytes data checksum [170 170 85]
            

            //si le tab est vide
            if (dt.Rows.Count == 0) 
            {
                dt.Rows.Add(new object[] { obj.Serial,obj.ID, obj.Type,  obj.BinaryData ,obj.Checksum});
            }
            else
            {
                //sinon on cherche dans le tab si le id existe deja
                bool pas_trouve = true;
                DataRow[] foundAuthors = dt.Select("ID = '" + obj.ID + "'");
                if (foundAuthors.Length != 0)
                {
                    //recherche quel index
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if ((string)dt.Rows[i]["ID"] ==obj.ID.ToString())
                        {
                            dt.Rows[i]["Data"] = obj.BinaryData;
                        }
                    }
                    pas_trouve = false;
                }
                //si pas trouver alors on creer un nouveau item 
                if (pas_trouve) 
                {
                    dt.Rows.Add(new object[] { obj.Serial, obj.ID, obj.Type,  obj.BinaryData, obj.Checksum });
                }
            }
            
            dg.DataSource = dt;
        }
        

        
    }
}
