using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Web.Services;
using System.Diagnostics;




namespace Barcode_Test_Status_Monitor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        PCB_WEB.WebService  ws = new PCB_WEB.WebService ();

        //public delegate bool CheckWebServerCaller(string website); //定义代理
        //static CheckWebServerCaller cwc = new  CheckWebServerCaller (checkWebService);
        //static IAsyncResult result = cwc.BeginInvoke(Param.Webservice, null, null);
        //bool checkWebResult = cwc.EndInvoke(result);//接收结果
        /// <summary>
        /// 初始化INI文件
        /// </summary>      
        /// <param name="iniFilePath">ini所在的文件位置</param>
        public static void CreateIni(string iniFilePath)
        {
            FileStream iniStram = File.Create(iniFilePath);
            iniStram.Close();

            IniFile.IniWriteValue("SysConfig", "Version", Application.ProductVersion.ToString(), iniFilePath);
            IniFile.IniWriteValue("SysConfig", "WebService", Param.Webservice , iniFilePath);
            IniFile.IniWriteValue("SysConfig", "AutoLookLogPath", Param.AutoLookLogPath, iniFilePath);
            IniFile.IniWriteValue("SysConfig", "TestLogPath", Param.TestlogPath, iniFilePath);
            IniFile.IniWriteValue("SysConfig", "PassFlag", Param.PassFlag, iniFilePath);
            IniFile.IniWriteValue("SysConfig", "FileFrontFlag", Param.FileFrontFlag, iniFilePath);
            IniFile.IniWriteValue("SysConfig", "FaonFaoffBase", Param.FaonFaoffBase, iniFilePath);
            IniFile.IniWriteValue("SysConfig", "FileExtension", Param.FileExtension, iniFilePath);
            IniFile.IniWriteValue("SysConfig", "StartEndTime", Param.StartEndTime.ToString(), iniFilePath);
        }

        /// <summary>
        /// 从系统ini获取配置参数 
        /// </summary>
        /// <param name="iniFilePath">ini所在的文件位置</param>
        public static void GetConfigValue(string iniFilePath)
        {
            Param.Webservice = IniFile.IniReadValue("SysConfig", "WebService", iniFilePath).Trim();
            Param.AutoLookLogPath = IniFile.IniReadValue("SysConfig", "AutoLookLogPath", iniFilePath).Trim();
            Param.TestlogPath = IniFile.IniReadValue("SysConfig", "TestlogPath", iniFilePath).Trim();
            Param.PassFlag = IniFile.IniReadValue("SysConfig", "PassFlag", iniFilePath).Trim().ToUpper();
            Param.FileFrontFlag = IniFile.IniReadValue("SysConfig", "FileFrontFlag", iniFilePath).Trim();
            Param.FaonFaoffBase = IniFile.IniReadValue("SysConfig", "FaonFaoffBase", iniFilePath).Trim();
            Param.FileExtension = IniFile.IniReadValue("SysConfig", "FileExtension", iniFilePath).Trim();
            //(Colors)Enum.Parse(typeof(Colors), "Red")            
            Param.StartEndTime =(StartEndTimeType )Enum.Parse (typeof (StartEndTimeType ),IniFile.IniReadValue("SysConfig", "StartEndTime", iniFilePath)) ;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //
            if (!Directory.Exists(Param.AppFoler))
                Directory.CreateDirectory(Param.AppFoler);
            if (!Directory.Exists(Param.TempFoler))
                Directory.CreateDirectory(Param.TempFoler);
            //
            if (!File.Exists(Param.IniFile))
                CreateIni(Param.IniFile);
            else
                GetConfigValue(Param.IniFile);

            lblWatcherPath.Text = "监控路径:" + Param.TestlogPath;
            lblWeb.Text = "当前WebService:" + Param.Webservice;



        }






        private void initFileSystemWatcher(FileSystemWatcher fsw)
        {
            fsw.IncludeSubdirectories = false;
           // fsw.EnableRaisingEvents = false;
            fsw.Path = Param.TestlogPath;
            fsw.Filter = Param.FileFrontFlag + "*" + Param.FileExtension;
            fsw.NotifyFilter = NotifyFilters.LastWrite;
            //MessageBox.Show(fsw.Filter);

        }

        private void fswTestlog_Changed(object sender, FileSystemEventArgs e)
        {

            Delay(200);
            updateMsg(lstStatus, "Detect File " + e.ChangeType +":" + e.FullPath);
            updateMsg(lstStatus, "The file name is:" + e.Name);
            //



        }


        private  void updateMsg(ListBox listbox, string message)
        {
            if (listbox.Items.Count > 1024)
            {
                //listbox.Items.Clear();
                listbox.Items.RemoveAt(0);
            }
            //SkinListBoxItem item = new SkinListBoxItem();
            string item = string.Empty;
            item = DateTime.Now.ToString("HH:mm:ss") + "->" + @message;

            this.Invoke((EventHandler)(delegate
            {
                listbox.Items.Add(item);
            }));

      
            if (listbox.Items.Count > 1)
            {
                listbox.TopIndex = listbox.Items.Count - 1;
                listbox.SetSelected(listbox.Items.Count - 1, true);
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Form f = new frmSetting();
            f.ShowDialog();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Param.TestlogPath.Trim()))
            {
                MessageBox.Show("TestlogPath 不能为空,请点击'Setting'按钮设置路径", "TestlogPath Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkWebService(Param.Webservice))
                return;

            //Task<bool> task = Task.Factory.StartNew<bool>(() => checkWebService(Param.Webservice));
            //bool checkWebResult = task.Result;

            //if (!checkWebResult)
            //    return;


            initFileSystemWatcher(fswTestlog);
            updateMsg(lstStatus, "监控路径:" + @Param.TestlogPath);
            updateMsg(lstStatus, "监控以" + @Param.FileFrontFlag + "开头，以" + @Param.FileExtension + "为扩展名的文件");

            //
            fswTestlog.EnableRaisingEvents = true;

            updateMsg(lstStatus, "开始监控");
        }



        #region WebService


        /// <summary>
        /// 檢測WebService的可連通性,可連通返回true，不可連通，返回false
        /// </summary>
        /// <param name="website">WebService的地址</param>
        /// <returns>可連通返回true，不可連通返回false</returns>
        public   bool checkWebService(string website)
        {
            Stopwatch sw = new Stopwatch();
            TimeSpan ts = new TimeSpan();
            sw.Start();           
            updateMsg (lstStatus,"Start Check WebService");
            //SubFunction.saveLog(Param.logType.SYSLOG.ToString(), "Check Web Service");
            ws.Url = Param.Webservice ;
            try
            {
                Application.DoEvents();
                ws.Discover();
            }
            catch (Exception e)
            {
                sw.Stop();
                ts = sw.Elapsed;               
                updateMsg (lstStatus ,"Can't connect WebService,Used time(ms):" + ts.Milliseconds);
                updateMsg (lstStatus ,e.Message );

               // SubFunction.saveLog(Param.logType.SYSLOG.ToString(), "Check Web Service NG,Used time(ms):" + ts.Milliseconds + "\r\n" + "Message:".PadLeft(24) + e.Message);
         
                return false;
            }
            sw.Stop();
            ts = sw.Elapsed;
            //SubFunction.updateMessage(lstStatusCommand, "Check Web Service OK,Used time(ms):" + ts.Milliseconds);
            updateMsg (lstStatus ,"Connect WebService success,Used time(ms):" + ts.Milliseconds);
            //SubFunction.saveLog(Param.logType.SYSLOG.ToString(), "Check Web Service OK,Used time(ms):" + ts.Milliseconds);
            return true;
        }


        /// <summary>
        /// 檢查USN站別是否在當前站別,在為true，不在為false
        /// </summary>
        /// <param name="usn">條碼</param>
        /// <param name="stage">站別</param>
        /// <returns>在當前站別為true，不在當前站別為false</returns>
        private  bool checkStage(string usn, string stage)
        {

            //  checkWebService(web_Site);

            Stopwatch sw = new Stopwatch();
            TimeSpan ts = new TimeSpan();
            sw.Start();
            //SubFunction.updateMessage(lstStatusCommand, "SFCS:" + usn + ",Stage:" + stage);
            updateMsg(lstStatus, "SFCS:" + usn + ",Stage:" + stage);
           // SubFunction.saveLog(Param.logType.SYSLOG.ToString(), "SFCS:" + usn + ",Stage:" + stage);
            string result = ws.CheckRoute(usn, stage);
            sw.Stop();
            ts = sw.Elapsed;
            if (result.ToUpper() == "OK")
            {
               // SubFunction.updateMessage(lstStatusCommand, result + "Used time(ms):" + ts.Milliseconds);
                updateMsg(lstStatus, result + "Used time(ms):" + ts.Milliseconds);
              //  SubFunction.saveLog(Param.logType.SYSLOG.ToString(), "usn:" + usn + "->" + stage);

                return true;
            }
            else
            {
               // SubFunction.updateMessage(lstStatusCommand, result + "Used time(ms):" + ts.Milliseconds);
                updateMsg(lstStatus, result + "Used time(ms):" + ts.Milliseconds);
               //SubFunction.saveLog(Param.logType.SYSLOG.ToString(), result + "Used time(ms):" + ts.Milliseconds);
               // SubFunction.saveLog(Param.logType.SYSLOG.ToString(), result + "Used time(ms):" + ts.Milliseconds);
                return false;
            }
        }



        #endregion

        #region 延時子程式

        /// <summary>
        /// 延時子程序
        /// </summary>
        /// <param name="interval">延時的時間，單位毫秒</param>
        private void Delay(double interval)
        {
            DateTime time = DateTime.Now;
            double span = interval * 10000;
            while (DateTime.Now.Ticks - time.Ticks < span)
            {
                Application.DoEvents();
            }

        }

        #endregion

        #region 分析log

        private bool CreateTempLogFile(string logFile)
        {
            string tempFile = logFile + ".temp";
            if (File.Exists(tempFile))
            {
                try
                {
                    File.Delete(tempFile);
                    File.Copy(logFile, tempFile, true);
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }


            return true;


        }
        
        private void AnalyzeLog(string beforeFile, string aferFile)
        {

            


        }


        #endregion
    }
}
