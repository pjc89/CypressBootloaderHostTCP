namespace UARTBootloaderHost
{
    partial class UIForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIpAddress = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.txtPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileNameTB = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.bootloadButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_StatusLog = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP ADDRESS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.DisplayMember = "1";
            this.txtIpAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIpAddress.FormattingEnabled = true;
            this.txtIpAddress.Location = new System.Drawing.Point(226, 66);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(156, 30);
            this.txtIpAddress.TabIndex = 2;
            this.txtIpAddress.Text = "192.168.4.1";
            this.txtIpAddress.SelectedIndexChanged += new System.EventHandler(this.comPortComboBox_SelectedIndexChanged);
            this.txtIpAddress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comPortComboBox_MouseDown);
            // 
            // txtPort
            // 
            this.txtPort.DisplayMember = "4";
            this.txtPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.FormattingEnabled = true;
            this.txtPort.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.txtPort.Location = new System.Drawing.Point(524, 66);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(154, 30);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "9000";
            this.txtPort.SelectedIndexChanged += new System.EventHandler(this.baudComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "PORT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.cyacd";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // FileNameTB
            // 
            this.FileNameTB.AcceptsTab = true;
            this.FileNameTB.Location = new System.Drawing.Point(20, 151);
            this.FileNameTB.Name = "FileNameTB";
            this.FileNameTB.ReadOnly = true;
            this.FileNameTB.Size = new System.Drawing.Size(474, 26);
            this.FileNameTB.TabIndex = 9;
            // 
            // browseButton
            // 
            this.browseButton.AutoSize = true;
            this.browseButton.Location = new System.Drawing.Point(518, 146);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(142, 38);
            this.browseButton.TabIndex = 10;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // bootloadButton
            // 
            this.bootloadButton.AutoSize = true;
            this.bootloadButton.Location = new System.Drawing.Point(226, 197);
            this.bootloadButton.Name = "bootloadButton";
            this.bootloadButton.Size = new System.Drawing.Size(142, 38);
            this.bootloadButton.TabIndex = 11;
            this.bootloadButton.Text = "Bootload";
            this.bootloadButton.UseVisualStyleBackColor = true;
            this.bootloadButton.Click += new System.EventHandler(this.Bootload_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(741, 32);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar1
            // 
            this.progressBar1.Margin = new System.Windows.Forms.Padding(10, 3, 1, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(642, 26);
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Step 1: Select Ip Addess and Port";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(460, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Step 2: Select a Bootloadable File and Click Bootload";
            // 
            // textBox_StatusLog
            // 
            this.textBox_StatusLog.BackColor = System.Drawing.Color.White;
            this.textBox_StatusLog.Location = new System.Drawing.Point(18, 254);
            this.textBox_StatusLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_StatusLog.Multiline = true;
            this.textBox_StatusLog.Name = "textBox_StatusLog";
            this.textBox_StatusLog.ReadOnly = true;
            this.textBox_StatusLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_StatusLog.Size = new System.Drawing.Size(640, 244);
            this.textBox_StatusLog.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Status Log";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // UIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(741, 557);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_StatusLog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FileNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIpAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bootloadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(50, 0);
            this.MaximizeBox = false;
            this.Name = "UIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UART Bootloader Host TCP Application by Orange Tech Rev 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UIForm_FormClosing);
            this.Load += new System.EventHandler(this.UIForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtIpAddress;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox FileNameTB;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button bootloadButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_StatusLog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

