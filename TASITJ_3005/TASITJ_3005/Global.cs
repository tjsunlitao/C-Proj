 using HslCommunication;
using HslCommunication.Profinet.Siemens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading;

namespace TASITJ_3005
{
    public sealed class Global
    {
        public static string PLC_IP_Adress;
        public static string Produce_name;
        public static string Produce_type;
        public static string Kistler_ProNum;
        public static string Produce_Remarks;
        public static string KistlerDataReadAddress1;
        public static string KistlerDataReadAddress2;
        public static string KistlerDataTargetAddress1;
        public static string KistlerDataTargetAddress2;

        public static DataTable dt_kistler1;
        public static DataTable dt_kistler2;
        public static DataTable dt;

        public static SiemensS7Net siemensTcpNet;
        public static OperateResult connect;

        public static Thread t1;
    }
}
