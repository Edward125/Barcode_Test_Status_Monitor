using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Barcode_Test_Status_Monitor
{
    public partial class frmSetting : Form
    {


        #region 参数

        string exeName = "Barcode SFCS Test Status Monitor";


        #endregion
        public frmSetting()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text  = exeName + ",Ver:" + Application.ProductVersion;
            LoadData2UI();
        }

        private void txtTestlogPath_DoubleClick(object sender, EventArgs e)
        {
            openFolder(txtTestlogPath);
        }

        private void txtAutoLookLogPath_DoubleClick(object sender, EventArgs e)
        {
            openFolder(txtAutoLookLogPath);
            if (string.IsNullOrEmpty (txtAutoLookLogPath.Text .Trim()))
                return;
            else
            {
                string inipath = txtAutoLookLogPath.Text.Trim() + @"\path.ini";
                if (System.IO.File.Exists(inipath))
                {
                    string line = string.Empty;
                    string boardpath = string.Empty;
                    
                   StreamReader sr = new StreamReader(inipath);
                   while (!sr.EndOfStream )
                   {
                       line = sr.ReadLine();
                       if (!line.StartsWith("!"))
                       {
                           if (line.ToUpper ().Contains ("#BoardPath#".ToUpper ()))
                           {
                               boardpath = line.Replace("#BoardPath#:", "");
                               Param.TestlogPath = boardpath + @"testlog\";
                               txtTestlogPath.Text = Param.TestlogPath;
                           
                           }
                       }
                   }
                   sr.Close();
                    
                }

            }
        }


        private void LoadData2UI()
        {
            this.txtAutoLookLogPath.Text = Param.AutoLookLogPath.Trim();
            this.txtTestlogPath.Text = Param.TestlogPath.Trim();
            this.txtWebService.Text = Param.Webservice.Trim();
            this.combPassFlag.Text = Param.PassFlag.ToUpper().Trim();
            this.txtFileFrontFlag.Text = Param.FileFrontFlag.Trim();
            this.txtFileExtension.Text = Param.FileExtension.Trim();
            if (Param.FaonFaoffBase == "0")
                rab0.Checked = true;
            if (Param.FaonFaoffBase == "1")
                rab1.Checked = true;
            if (Param.StartEndTime == StartEndTimeType.Day830)
                rabDay830.Checked = true;
            if (Param.StartEndTime == StartEndTimeType.Day800)
                rabDay800.Checked = true;
            //
            rab0.Text = "0 " + Param.PassFlag;
            rab1.Text = "1 " + Param.PassFlag;
        }

        private void combPassFlag_SelectedIndexChanged(object sender, EventArgs e)
        {
            Param.PassFlag = combPassFlag.Text.Trim().ToUpper();
            IniFile.IniWriteValue("SysConfig", "PassFlag", Param.PassFlag, Param.IniFile);
            //
            rab0.Text = "0 " + Param.PassFlag;
            rab1.Text = "1 " + Param.PassFlag;
        }

        private void openFolder(TextBox textbox)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                textbox.Text = fbd.SelectedPath;
        
        }

        private void txtAutoLookLogPath_TextChanged(object sender, EventArgs e)
        {
            Param.AutoLookLogPath = this.txtAutoLookLogPath.Text.Trim();
            IniFile.IniWriteValue("SysConfig", "AutoLookLogPath", Param.AutoLookLogPath, Param.IniFile);
        }

        private void txtTestlogPath_TextChanged(object sender, EventArgs e)
        {
            Param.TestlogPath = this.txtTestlogPath.Text.Trim();
            IniFile.IniWriteValue("SysConfig", "TestlogPath", Param.TestlogPath, Param.IniFile);
        }

        private void txtWebService_TextChanged(object sender, EventArgs e)
        {
            Param.Webservice = this.txtWebService.Text.Trim();
            IniFile.IniWriteValue("SysConfig", "WebService", Param.Webservice, Param.IniFile);
        }

        private void txtFileFrontFlag_TextChanged(object sender, EventArgs e)
        {
            Param.FileFrontFlag = this.txtFileFrontFlag.Text.Trim();
            IniFile.IniWriteValue("SysConfig", "FileFrontFlag", Param.FileFrontFlag, Param.IniFile);
        }

        private void txtFileExtension_TextChanged(object sender, EventArgs e)
        {
            if (!txtFileExtension.Text.Trim().StartsWith("."))
                txtFileExtension.Text = "." + txtFileExtension.Text.Trim();
            IniFile.IniWriteValue("SysConfig", "FileExtension", Param.FileExtension, Param.IniFile);
               
        }

    }
}
