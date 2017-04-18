using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Barcode_Test_Status_Monitor
{
    class Param
    {
        public static string Webservice = @"http://10.62.201.100/Tester.WebService/WebService.asmx"; //default
        public static string AutoLookLogPath = string.Empty;
        public static string TestlogPath = string.Empty;
        public static string PassFlag = "0000";//default
        public static string FileFrontFlag = "log";
        public static string FaonFaoffBase = "0";//default 
       // public static string StartEndTime = "1";//default
        public static string FileExtension = ".log";//default
        public static StartEndTimeType StartEndTime = StartEndTimeType.Day830;

        //
        public static string AppFoler = Application.StartupPath + @"\BarcodeTestMonitor";
        public static string IniFile = AppFoler + @"\Config.ini";
        public static LogType Log = LogType.SystemLog; //default
        public static string TempFoler = AppFoler + @"\Temp";



    }


    class Sub
    {

    }

    enum StartEndTimeType
    {
        Day800,
        Day830
    }

    enum LogType
    {
        SystemLog,        //系统事件发生记录log
        SqlTempLog,       //无法连接到数据库时,需要上传到数据库的本地log
        BarcodeUploadLog  //检测到上抛未成功,手动上抛的log
    }
}