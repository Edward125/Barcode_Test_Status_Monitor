﻿namespace Barcode_Test_Status_Monitor
{
    partial class frmSetting
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rabDay830 = new System.Windows.Forms.RadioButton();
            this.rabDay800 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rab1 = new System.Windows.Forms.RadioButton();
            this.rab0 = new System.Windows.Forms.RadioButton();
            this.txtFileExtension = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFileFrontFlag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combPassFlag = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWebService = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTestlogPath = new System.Windows.Forms.TextBox();
            this.txtAutoLookLogPath = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtFileExtension);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFileFrontFlag);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combPassFlag);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtWebService);
            this.groupBox1.Controls.Add(this.lblNote);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTestlogPath);
            this.groupBox1.Controls.Add(this.txtAutoLookLogPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rabDay830);
            this.groupBox3.Controls.Add(this.rabDay800);
            this.groupBox3.Location = new System.Drawing.Point(35, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 49);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Start End Time";
            // 
            // rabDay830
            // 
            this.rabDay830.AutoSize = true;
            this.rabDay830.Location = new System.Drawing.Point(178, 22);
            this.rabDay830.Name = "rabDay830";
            this.rabDay830.Size = new System.Drawing.Size(90, 21);
            this.rabDay830.TabIndex = 2;
            this.rabDay830.TabStop = true;
            this.rabDay830.Text = "0:00~08:30";
            this.rabDay830.UseVisualStyleBackColor = true;
            // 
            // rabDay800
            // 
            this.rabDay800.AutoSize = true;
            this.rabDay800.Location = new System.Drawing.Point(23, 22);
            this.rabDay800.Name = "rabDay800";
            this.rabDay800.Size = new System.Drawing.Size(90, 21);
            this.rabDay800.TabIndex = 2;
            this.rabDay800.TabStop = true;
            this.rabDay800.Text = "0:00~08:00";
            this.rabDay800.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rab1);
            this.groupBox2.Controls.Add(this.rab0);
            this.groupBox2.Location = new System.Drawing.Point(213, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 48);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faon Faoff Base";
            // 
            // rab1
            // 
            this.rab1.AutoSize = true;
            this.rab1.Location = new System.Drawing.Point(111, 21);
            this.rab1.Name = "rab1";
            this.rab1.Size = new System.Drawing.Size(36, 21);
            this.rab1.TabIndex = 1;
            this.rab1.TabStop = true;
            this.rab1.Text = "1 ";
            this.rab1.UseVisualStyleBackColor = true;
            // 
            // rab0
            // 
            this.rab0.AutoSize = true;
            this.rab0.Location = new System.Drawing.Point(13, 20);
            this.rab0.Name = "rab0";
            this.rab0.Size = new System.Drawing.Size(36, 21);
            this.rab0.TabIndex = 0;
            this.rab0.TabStop = true;
            this.rab0.Text = "0 ";
            this.rab0.UseVisualStyleBackColor = true;
            // 
            // txtFileExtension
            // 
            this.txtFileExtension.Location = new System.Drawing.Point(129, 186);
            this.txtFileExtension.Name = "txtFileExtension";
            this.txtFileExtension.Size = new System.Drawing.Size(78, 25);
            this.txtFileExtension.TabIndex = 13;
            this.txtFileExtension.Text = ".log";
            this.toolTip1.SetToolTip(this.txtFileExtension, "Dbclick to select the AutoLookLogPath");
            this.txtFileExtension.TextChanged += new System.EventHandler(this.txtFileExtension_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "File Extension";
            // 
            // txtFileFrontFlag
            // 
            this.txtFileFrontFlag.Location = new System.Drawing.Point(308, 139);
            this.txtFileFrontFlag.Name = "txtFileFrontFlag";
            this.txtFileFrontFlag.Size = new System.Drawing.Size(121, 25);
            this.txtFileFrontFlag.TabIndex = 11;
            this.txtFileFrontFlag.Text = "Log";
            this.toolTip1.SetToolTip(this.txtFileFrontFlag, "Dbclick to select the AutoLookLogPath");
            this.txtFileFrontFlag.TextChanged += new System.EventHandler(this.txtFileFrontFlag_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "FileFrontFlag";
            // 
            // combPassFlag
            // 
            this.combPassFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combPassFlag.FormattingEnabled = true;
            this.combPassFlag.Items.AddRange(new object[] {
            "0000",
            "PASS",
            "OK"});
            this.combPassFlag.Location = new System.Drawing.Point(129, 142);
            this.combPassFlag.Name = "combPassFlag";
            this.combPassFlag.Size = new System.Drawing.Size(76, 25);
            this.combPassFlag.TabIndex = 9;
            this.combPassFlag.SelectedIndexChanged += new System.EventHandler(this.combPassFlag_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pass Flag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "WebService";
            // 
            // txtWebService
            // 
            this.txtWebService.Location = new System.Drawing.Point(128, 108);
            this.txtWebService.Name = "txtWebService";
            this.txtWebService.Size = new System.Drawing.Size(364, 25);
            this.txtWebService.TabIndex = 6;
            this.txtWebService.Text = "http://10.62.201.100/Tester.WebService/WebService.asmx";
            this.toolTip1.SetToolTip(this.txtWebService, "Dbclick to select the AutoLookLogPath");
            this.txtWebService.TextChanged += new System.EventHandler(this.txtWebService_TextChanged);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNote.Location = new System.Drawing.Point(73, 85);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(320, 17);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "更换机种时,请注意路径是否正确,特别是TestlogPath";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "TestlogPath";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "AutoLookLogPath";
            // 
            // txtTestlogPath
            // 
            this.txtTestlogPath.Location = new System.Drawing.Point(129, 55);
            this.txtTestlogPath.Name = "txtTestlogPath";
            this.txtTestlogPath.Size = new System.Drawing.Size(363, 25);
            this.txtTestlogPath.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtTestlogPath, "Dbclick to select the Testlog Path");
            this.txtTestlogPath.TextChanged += new System.EventHandler(this.txtTestlogPath_TextChanged);
            this.txtTestlogPath.DoubleClick += new System.EventHandler(this.txtTestlogPath_DoubleClick);
            // 
            // txtAutoLookLogPath
            // 
            this.txtAutoLookLogPath.Location = new System.Drawing.Point(128, 29);
            this.txtAutoLookLogPath.Name = "txtAutoLookLogPath";
            this.txtAutoLookLogPath.Size = new System.Drawing.Size(364, 25);
            this.txtAutoLookLogPath.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtAutoLookLogPath, "Dbclick to select the AutoLookLogPath");
            this.txtAutoLookLogPath.TextChanged += new System.EventHandler(this.txtAutoLookLogPath_TextChanged);
            this.txtAutoLookLogPath.DoubleClick += new System.EventHandler(this.txtAutoLookLogPath_DoubleClick);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 315);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSetting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTestlogPath;
        private System.Windows.Forms.TextBox txtAutoLookLogPath;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWebService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFileFrontFlag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combPassFlag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFileExtension;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rab1;
        private System.Windows.Forms.RadioButton rab0;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rabDay830;
        private System.Windows.Forms.RadioButton rabDay800;
    }
}

