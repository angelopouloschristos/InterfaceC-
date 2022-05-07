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
        public static DataTable AlarmData = new DataTable("alarm");
        internal static DataTable Users = new DataTable();
        internal static DataTable Permissions = new DataTable();
        
        internal class Columns
        {
            //changer les noms des colonnes
            //internal static DataColumn Serial = new DataColumn("Serial");
            internal static DataColumn ID = new DataColumn("ID");
            internal static DataColumn Config_status = new DataColumn("Config Status");
            internal static DataColumn Type = new DataColumn("Type"); //0-alarme 1-CO2 2-Temp 3-Hum
            internal static DataColumn BinaryData = new DataColumn("Data"); // 2 octets
            internal static DataColumn Last_updated = new DataColumn("Last Updated"); // 2 octets
            internal static DataColumn Alarm = new DataColumn("Alarm"); 


            //Alarm table
            internal static DataColumn ID_alarm = new DataColumn("ID");
            internal static DataColumn Type_alarm = new DataColumn("Type");
            internal static DataColumn Critical_min = new DataColumn("Critical Min");
            internal static DataColumn Warning_min = new DataColumn("Warning Min");
            internal static DataColumn Warning_max = new DataColumn("Warning Max");
            internal static DataColumn Criitical_max = new DataColumn("Criitical Max");
            internal static DataColumn Status = new DataColumn("Status");

            //Users table
            internal static DataColumn ID_user = new DataColumn("ID");
            internal static DataColumn user_name = new DataColumn("Name");
            internal static DataColumn user_password = new DataColumn("Password");
            internal static DataColumn Access_id = new DataColumn("Access ID");

            //permissions
            internal static DataColumn ID_access = new DataColumn("ID");
            internal static DataColumn name = new DataColumn("Rights");
            internal static DataColumn create_id = new DataColumn("Allow Create ID");
            internal static DataColumn destroy_id = new DataColumn("Allow Destroy ID");
            internal static DataColumn config_alarm = new DataColumn("Allow Config Alarm");
            internal static DataColumn create_user = new DataColumn("User Creation");




        }
    }
   
}
