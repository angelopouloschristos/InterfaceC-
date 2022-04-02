using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO2_Interface.Data
{
    internal class FromSensor
    {
        //Structure de un message 
        internal class Base
        {
            internal byte ID;
            internal UInt32 BinaryData;
            internal UInt16 Serial;
            internal byte Type;
            internal int time;
            internal UInt32 Checksum;
            internal bool outdated;
            internal bool config_status;
            internal Base(byte serial,byte id, byte type,  UInt32 data,UInt32 cs)
            {
                Serial = serial;
                //id du octet
                ID = id;
                //data a decoder
                BinaryData = data;
                //nombres de bytes --> checksum
                //type de mesure
                Type = type;
                Checksum = cs;
                //il doit se incrementer tout seul
                time = 0;
                outdated = false;
                config_status = false;
            }
        }
        internal class Measure : Base
        {
            internal Int32 LowLimit;
            internal Int32 HighLimit;
            internal double ConvertedData;
            internal UInt32 AlarmMaxPeriod;
            internal Int32 WarningMin;         //User Alarm
            internal Int32 CriticalMin; 
            internal Int32 WarningMax;         //User Alarm
            internal Int32 CriticalMax;

            internal Measure() : base(0, 0, 0, 0,0)
            {
                LowLimit = 0;
                HighLimit = 0;
                ConvertedData = 0;
                AlarmMaxPeriod = 0;
                WarningMin = 0;
                CriticalMin = 0;
                WarningMax = 0;
                CriticalMax = 0;
            }
        }
    }
}
