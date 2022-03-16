﻿using System;
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
            internal byte NbrBytes;
            internal byte Type;
            internal byte Checksum;
            internal Base(byte id, byte type, byte nbrbytes, UInt32 data,byte cs)
            {
                //id du octet
                ID = id;
                //data a decoder
                BinaryData = data;
                //nombres de bytes --> checksum
                NbrBytes = nbrbytes;
                //type de mesure
                Type = type;
                Checksum = cs;
            }
        }
        internal class Measure : Base
        {
            internal Int32 LowLimit;
            internal Int32 HighLimit;
            internal Int32 ConvertedData;
            internal UInt32 AlarmMaxPeriod;
            internal static class AlarmMin
            {
                internal static Int32 Warning;         //User Alarm
                internal static Int32 Critical;         //User Alarm
            }
            internal static class AlarmMax
            {
                internal static Int32 Warning;         //User Alarm
                internal static Int32 Critical;         //User Alarm
            }
            internal Measure() : base(0, 0, 0, 0,0)
            {
                LowLimit = 0;
                HighLimit = 0;
                ConvertedData = 0;
                AlarmMaxPeriod = 0;
                AlarmMin.Warning = 0;
                AlarmMin.Critical = 0;
                AlarmMax.Warning = 0;
                AlarmMax.Critical = 0;
            }
        }
    }
}