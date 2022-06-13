using LoginRegis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO2_Interface
{
    public static class Logger
    {
        


        public static void WriteLogTxt(string message) {

            string filePath = Directory.GetCurrentDirectory();
            filePath = filePath+"\\log.txt";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{DateTime.Now} : {message}");
            }
        }

        public static void WriteLogAccess(string message)
        {
            oCenter oC = new oCenter();

            string filePath = Directory.GetCurrentDirectory();
            filePath = filePath + "\\login_regis.accdb";

            DataSet dsAction = new DataSet("Sample");
            string sSqlSave = "SELECT * FROM Log ";
            dsAction = oC.ShowData(sSqlSave, "Log", dsAction);
            DataRow dr = dsAction.Tables["Log"].NewRow();
            dr["Blabla"] = DateTime.Now.ToString();
            dr["Message"] = message;

            dsAction.Tables["Log"].Rows.Add(dr);
            oC.ReturnAda.Update(dsAction, "Log");

        }

        public static void WriteLogCsv(string message)
        {


            var fileContent = string.Empty;
            fileContent +=DateTime.Now + ";"+message+"\r\n";
            

            string filePath = Directory.GetCurrentDirectory();
            filePath = filePath + "\\log.csv";

            File.AppendAllText(filePath, fileContent);



        }


    }
}
