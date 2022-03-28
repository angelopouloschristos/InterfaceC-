using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace CO2_Interface.Data
{
    internal class Tables
    {
        internal static DataTable DataFromSensor = new DataTable();
        internal class Columns
        {
            //changer les noms des colonnes
            internal static DataColumn Serial = new DataColumn("Serial");
            internal static DataColumn ID = new DataColumn("ID");
            internal static DataColumn Type = new DataColumn("Type"); //0-alarme 1-CO2 2-Temp 3-Hum
            internal static DataColumn BinaryData = new DataColumn("Data"); // 2 octets
            internal static DataColumn Last_updated = new DataColumn("Last Updated"); // 2 octets

            internal static DataColumn Checksum = new DataColumn("Checksum");
            
            
        }
    }
   
}
