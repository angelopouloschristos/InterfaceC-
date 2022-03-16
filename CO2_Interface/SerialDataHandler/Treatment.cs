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
            while(  (Data.Collections.SerialBuffer.ElementAt(0) != 0x55)  &&
                    (Data.Collections.SerialBuffer.ElementAt(1) != 0x55)  &&
                    (Data.Collections.SerialBuffer.ElementAt(2) != 0xAA) &&
                    (Data.Collections.SerialBuffer.Count > 3)) Data.Collections.SerialBuffer.Dequeue();

            Data.FromSensor.Base obj = new Data.FromSensor.Base(0, 0, 0, 0, 0);

            while (Data.Collections.SerialBuffer.Count > 13)
            {
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

                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();

                ObjToList(obj, dt, dg);
            }
                        
            // SI IL A TROUVER LE DEBUT DE TRAMME
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
