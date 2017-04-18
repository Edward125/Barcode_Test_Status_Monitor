namespace Barcode_Test_Status_Monitor
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fswTestlog = new System.IO.FileSystemWatcher();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBarcode = new System.Windows.Forms.ListBox();
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblWeb = new System.Windows.Forms.Label();
            this.lblWatcherPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fswTestlog)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fswTestlog
            // 
            this.fswTestlog.EnableRaisingEvents = true;
            this.fswTestlog.SynchronizingObject = this;
            this.fswTestlog.Changed += new System.IO.FileSystemEventHandler(this.fswTestlog_Changed);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBarcode);
            this.groupBox1.Controls.Add(this.lstStatus);
            this.groupBox1.Location = new System.Drawing.Point(27, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 440);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lstBarcode
            // 
            this.lstBarcode.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBarcode.FormattingEnabled = true;
            this.lstBarcode.ItemHeight = 14;
            this.lstBarcode.Location = new System.Drawing.Point(6, 202);
            this.lstBarcode.Name = "lstBarcode";
            this.lstBarcode.Size = new System.Drawing.Size(624, 228);
            this.lstBarcode.TabIndex = 3;
            // 
            // lstStatus
            // 
            this.lstStatus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStatus.FormattingEnabled = true;
            this.lstStatus.ItemHeight = 14;
            this.lstStatus.Location = new System.Drawing.Point(6, 24);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(624, 172);
            this.lstStatus.TabIndex = 2;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(569, 24);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(53, 42);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(510, 24);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(53, 42);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Location = new System.Drawing.Point(440, 24);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(64, 42);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblWeb);
            this.groupBox2.Controls.Add(this.lblWatcherPath);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnSetting);
            this.groupBox2.Controls.Add(this.btnRun);
            this.groupBox2.Location = new System.Drawing.Point(27, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 79);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeb.Location = new System.Drawing.Point(17, 55);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(58, 14);
            this.lblWeb.TabIndex = 9;
            this.lblWeb.Text = "监控路径:";
            // 
            // lblWatcherPath
            // 
            this.lblWatcherPath.AutoSize = true;
            this.lblWatcherPath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatcherPath.Location = new System.Drawing.Point(17, 30);
            this.lblWatcherPath.Name = "lblWatcherPath";
            this.lblWatcherPath.Size = new System.Drawing.Size(58, 14);
            this.lblWatcherPath.TabIndex = 8;
            this.lblWatcherPath.Text = "监控路径:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 579);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fswTestlog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fswTestlog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBarcode;
        private System.Windows.Forms.ListBox lstStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblWatcherPath;
        private System.Windows.Forms.Label lblWeb;
    }
}