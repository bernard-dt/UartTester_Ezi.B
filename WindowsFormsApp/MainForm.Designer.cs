using System;

namespace UartTester
{
    partial class fmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.rtDispAscii = new System.Windows.Forms.RichTextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.PortsEntry = new System.Windows.Forms.ListBox();
            this.cbHex = new System.Windows.Forms.CheckBox();
            this.gbPort = new System.Windows.Forms.GroupBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.cbDtrEnable = new System.Windows.Forms.CheckBox();
            this.btModeSSC = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btClearAscii = new System.Windows.Forms.Button();
            this.SerialNumber = new System.Windows.Forms.RichTextBox();
            this.gbCmdLists = new System.Windows.Forms.GroupBox();
            this.btCmdWr = new System.Windows.Forms.Button();
            this.cbListOfCmd = new System.Windows.Forms.ComboBox();
            this.btReadInfo = new System.Windows.Forms.Button();
            this.btRomUpgrade = new System.Windows.Forms.Button();
            this.btSerialNo_W = new System.Windows.Forms.Button();
            this.btDisFlag = new System.Windows.Forms.Button();
            this.btClearFls = new System.Windows.Forms.Button();
            this.btRecodeFls = new System.Windows.Forms.Button();
            this.btEnaFlag = new System.Windows.Forms.Button();
            this.gbCmdItems = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbGaugeCenter = new System.Windows.Forms.TextBox();
            this.tbGaugeMax = new System.Windows.Forms.TextBox();
            this.btAmpGauge = new System.Windows.Forms.Button();
            this.tbGaugeMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAmpGain = new System.Windows.Forms.Button();
            this.cbMediumSupport = new System.Windows.Forms.CheckBox();
            this.tbAmpGainM = new System.Windows.Forms.TextBox();
            this.tbAmpGainF = new System.Windows.Forms.TextBox();
            this.tbAmpGainC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbUZP = new System.Windows.Forms.RichTextBox();
            this.btUZP = new System.Windows.Forms.Button();
            this.tbVal8 = new System.Windows.Forms.TextBox();
            this.tbVal9 = new System.Windows.Forms.TextBox();
            this.btCustomDebug = new System.Windows.Forms.Button();
            this.tbVal7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btResortRead = new System.Windows.Forms.Button();
            this.gbDevTools = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btIncrease = new System.Windows.Forms.Button();
            this.rtbPulse = new System.Windows.Forms.RichTextBox();
            this.btDecrease = new System.Windows.Forms.Button();
            this.lbServoState = new System.Windows.Forms.Label();
            this.btServoToggle = new System.Windows.Forms.Button();
            this.btNull1 = new System.Windows.Forms.Button();
            this.btAutoVerify = new System.Windows.Forms.Button();
            this.btAutoMeasure = new System.Windows.Forms.Button();
            this.rtbEziPort = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btResortRecord = new System.Windows.Forms.Button();
            this.btResortClean = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRebootOpt = new System.Windows.Forms.CheckBox();
            this.tbPeriod = new System.Windows.Forms.TextBox();
            this.pnAngleOpt = new System.Windows.Forms.Panel();
            this.cbNewL = new System.Windows.Forms.CheckBox();
            this.tbDegree = new System.Windows.Forms.TextBox();
            this.cbAngleDiff = new System.Windows.Forms.CheckBox();
            this.btStopAngleData = new System.Windows.Forms.Button();
            this.btAngleData = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbHeader = new System.Windows.Forms.CheckBox();
            this.btWrAscii = new System.Windows.Forms.Button();
            this.AsciiText = new System.Windows.Forms.RichTextBox();
            this.btSaveLog = new System.Windows.Forms.Button();
            this.btReboot = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btMeasureCAA = new System.Windows.Forms.Button();
            this.btMode_Medium = new System.Windows.Forms.Button();
            this.tMode_Coarse = new System.Windows.Forms.Button();
            this.btMode_Fine = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbListOfBundle = new System.Windows.Forms.ComboBox();
            this.btCalcDbgData = new System.Windows.Forms.Button();
            this.btReadAmp = new System.Windows.Forms.Button();
            this.btReadStorage = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbListOfFlag = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btMTRomUpdate = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsPortStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbFW_Upgrade = new System.Windows.Forms.GroupBox();
            this.btReadAngleInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbPort.SuspendLayout();
            this.gbCmdLists.SuspendLayout();
            this.gbCmdItems.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbDevTools.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnAngleOpt.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbFW_Upgrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialPort
            // 
            this.SerialPort.BaudRate = 115200;
            this.SerialPort.DtrEnable = true;
            this.SerialPort.PortName = "Empty";
            this.SerialPort.ReadBufferSize = 200000;
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // rtDispAscii
            // 
            this.rtDispAscii.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtDispAscii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtDispAscii.EnableAutoDragDrop = true;
            this.rtDispAscii.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtDispAscii.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtDispAscii.Location = new System.Drawing.Point(3, 27);
            this.rtDispAscii.Name = "rtDispAscii";
            this.rtDispAscii.ReadOnly = true;
            this.rtDispAscii.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtDispAscii.Size = new System.Drawing.Size(510, 572);
            this.rtDispAscii.TabIndex = 0;
            this.rtDispAscii.Text = "";
            // 
            // btOpen
            // 
            this.btOpen.BackColor = System.Drawing.Color.Gold;
            this.btOpen.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpen.ForeColor = System.Drawing.Color.Black;
            this.btOpen.Location = new System.Drawing.Point(91, 97);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(76, 45);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = false;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // PortsEntry
            // 
            this.PortsEntry.BackColor = System.Drawing.SystemColors.Menu;
            this.PortsEntry.ColumnWidth = 1;
            this.PortsEntry.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortsEntry.ForeColor = System.Drawing.Color.SeaGreen;
            this.PortsEntry.FormattingEnabled = true;
            this.PortsEntry.ItemHeight = 15;
            this.PortsEntry.Location = new System.Drawing.Point(7, 17);
            this.PortsEntry.Name = "PortsEntry";
            this.PortsEntry.Size = new System.Drawing.Size(80, 124);
            this.PortsEntry.TabIndex = 3;
            this.PortsEntry.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.PortsEntry.DoubleClick += new System.EventHandler(this.btOpen_Click);
            // 
            // cbHex
            // 
            this.cbHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbHex.AutoSize = true;
            this.cbHex.BackColor = System.Drawing.Color.Gray;
            this.cbHex.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbHex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbHex.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHex.ForeColor = System.Drawing.Color.LavenderBlush;
            this.cbHex.Location = new System.Drawing.Point(15, 581);
            this.cbHex.Name = "cbHex";
            this.cbHex.Size = new System.Drawing.Size(107, 21);
            this.cbHex.TabIndex = 6;
            this.cbHex.Text = "  Hex Type Print";
            this.cbHex.UseVisualStyleBackColor = false;
            this.cbHex.CheckedChanged += new System.EventHandler(this.cbHex_CheckedChanged);
            // 
            // gbPort
            // 
            this.gbPort.BackColor = System.Drawing.Color.SlateGray;
            this.gbPort.Controls.Add(this.cbBaudRate);
            this.gbPort.Controls.Add(this.btRefresh);
            this.gbPort.Controls.Add(this.PortsEntry);
            this.gbPort.Controls.Add(this.btOpen);
            this.gbPort.Controls.Add(this.cbDtrEnable);
            this.gbPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbPort.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPort.ForeColor = System.Drawing.Color.MediumBlue;
            this.gbPort.Location = new System.Drawing.Point(522, 481);
            this.gbPort.Name = "gbPort";
            this.gbPort.Size = new System.Drawing.Size(171, 146);
            this.gbPort.TabIndex = 7;
            this.gbPort.TabStop = false;
            this.gbPort.Text = " Ports Config";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.BackColor = System.Drawing.SystemColors.Menu;
            this.cbBaudRate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "    9600 bps",
            "  19200 bps",
            "  38400 bps",
            "115200 bps"});
            this.cbBaudRate.Location = new System.Drawing.Point(92, 38);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(75, 24);
            this.cbBaudRate.TabIndex = 3;
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.PaleGreen;
            this.btRefresh.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.ForeColor = System.Drawing.Color.Black;
            this.btRefresh.Location = new System.Drawing.Point(91, 65);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(76, 32);
            this.btRefresh.TabIndex = 19;
            this.btRefresh.Text = "Renewal";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // cbDtrEnable
            // 
            this.cbDtrEnable.AutoSize = true;
            this.cbDtrEnable.Checked = true;
            this.cbDtrEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDtrEnable.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDtrEnable.Location = new System.Drawing.Point(99, 18);
            this.cbDtrEnable.Name = "cbDtrEnable";
            this.cbDtrEnable.Size = new System.Drawing.Size(65, 19);
            this.cbDtrEnable.TabIndex = 27;
            this.cbDtrEnable.Text = "DtrEnable";
            this.cbDtrEnable.UseVisualStyleBackColor = true;
            // 
            // btModeSSC
            // 
            this.btModeSSC.BackColor = System.Drawing.Color.Plum;
            this.btModeSSC.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModeSSC.ForeColor = System.Drawing.Color.Black;
            this.btModeSSC.Location = new System.Drawing.Point(86, 15);
            this.btModeSSC.Name = "btModeSSC";
            this.btModeSSC.Size = new System.Drawing.Size(76, 40);
            this.btModeSSC.TabIndex = 20;
            this.btModeSSC.Text = "BiSS mode";
            this.btModeSSC.UseVisualStyleBackColor = false;
            this.btModeSSC.Click += new System.EventHandler(this.btModeSSC_Click);
            // 
            // btClearAscii
            // 
            this.btClearAscii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btClearAscii.BackColor = System.Drawing.Color.Transparent;
            this.btClearAscii.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClearAscii.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClearAscii.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btClearAscii.Location = new System.Drawing.Point(151, 581);
            this.btClearAscii.Name = "btClearAscii";
            this.btClearAscii.Size = new System.Drawing.Size(361, 22);
            this.btClearAscii.TabIndex = 11;
            this.btClearAscii.Text = "Reset Screen";
            this.btClearAscii.UseVisualStyleBackColor = false;
            this.btClearAscii.Click += new System.EventHandler(this.btClearAscii_Click);
            // 
            // SerialNumber
            // 
            this.SerialNumber.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumber.Location = new System.Drawing.Point(8, 19);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(75, 22);
            this.SerialNumber.TabIndex = 13;
            this.SerialNumber.Text = "";
            // 
            // gbCmdLists
            // 
            this.gbCmdLists.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gbCmdLists.Controls.Add(this.btCmdWr);
            this.gbCmdLists.Controls.Add(this.cbListOfCmd);
            this.gbCmdLists.Enabled = false;
            this.gbCmdLists.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCmdLists.ForeColor = System.Drawing.Color.MediumBlue;
            this.gbCmdLists.Location = new System.Drawing.Point(522, 258);
            this.gbCmdLists.Name = "gbCmdLists";
            this.gbCmdLists.Size = new System.Drawing.Size(172, 78);
            this.gbCmdLists.TabIndex = 16;
            this.gbCmdLists.TabStop = false;
            this.gbCmdLists.Text = "Setup Items List";
            // 
            // btCmdWr
            // 
            this.btCmdWr.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCmdWr.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCmdWr.ForeColor = System.Drawing.Color.LightYellow;
            this.btCmdWr.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCmdWr.Location = new System.Drawing.Point(11, 42);
            this.btCmdWr.Name = "btCmdWr";
            this.btCmdWr.Size = new System.Drawing.Size(153, 32);
            this.btCmdWr.TabIndex = 0;
            this.btCmdWr.Text = "Setup Selection";
            this.btCmdWr.UseVisualStyleBackColor = false;
            this.btCmdWr.Click += new System.EventHandler(this.btCmdWr_Click);
            // 
            // cbListOfCmd
            // 
            this.cbListOfCmd.AllowDrop = true;
            this.cbListOfCmd.CausesValidation = false;
            this.cbListOfCmd.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListOfCmd.FormattingEnabled = true;
            this.cbListOfCmd.IntegralHeight = false;
            this.cbListOfCmd.Items.AddRange(new object[] {
            " Read Information  ",
            " W_EA(0) ",
            " W_EA(1) ",
            " W_Adjustable CW (0)",
            " W_Adjustable CCW (1)",
            " W_Protocol - SSI (0)",
            " W_Protocol - BiSS (1) ",
            " W_Bits - 17bists (0) ",
            " W_Bits - 18bists (1)",
            " W_Bits - 19bists (2)",
            " W_Bits - 20bists (3)",
            " W_Bits - 21bists (4)",
            " W_Compense - OFF (0) ",
            " W_Compense - ON (1) ",
            " W_Compense - Custom (2)",
            " D_CONFIG_CLEAR",
            " D_USER_CLEAR",
            " R_BIT(BuiltInTest)",
            " R_Model Group",
            " R_EA",
            " R_Compense",
            " D_RESORT_STUB_1\t",
            " D_RESORT_STUB_2",
            " D_RESORT_STUB_3\t",
            " D_RESORT_STUB_4\t",
            " R_Model Name",
            " R_Version",
            " R_Serial No.",
            " R_Resolution"});
            this.cbListOfCmd.Location = new System.Drawing.Point(13, 15);
            this.cbListOfCmd.MaxDropDownItems = 40;
            this.cbListOfCmd.Name = "cbListOfCmd";
            this.cbListOfCmd.Size = new System.Drawing.Size(149, 23);
            this.cbListOfCmd.TabIndex = 17;
            this.cbListOfCmd.Tag = "";
            this.cbListOfCmd.Text = "  Select Items";
            this.cbListOfCmd.SelectedIndexChanged += new System.EventHandler(this.cbListOfCmd_SelectedIndexChanged);
            // 
            // btReadInfo
            // 
            this.btReadInfo.BackColor = System.Drawing.Color.Lime;
            this.btReadInfo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReadInfo.ForeColor = System.Drawing.Color.Black;
            this.btReadInfo.Location = new System.Drawing.Point(7, 56);
            this.btReadInfo.Name = "btReadInfo";
            this.btReadInfo.Size = new System.Drawing.Size(76, 40);
            this.btReadInfo.TabIndex = 20;
            this.btReadInfo.Text = "Read Info.";
            this.btReadInfo.UseVisualStyleBackColor = false;
            this.btReadInfo.Click += new System.EventHandler(this.btReadInfo_Click);
            // 
            // btRomUpgrade
            // 
            this.btRomUpgrade.BackColor = System.Drawing.Color.Yellow;
            this.btRomUpgrade.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRomUpgrade.ForeColor = System.Drawing.Color.Black;
            this.btRomUpgrade.Location = new System.Drawing.Point(87, 56);
            this.btRomUpgrade.Name = "btRomUpgrade";
            this.btRomUpgrade.Size = new System.Drawing.Size(76, 40);
            this.btRomUpgrade.TabIndex = 0;
            this.btRomUpgrade.Text = "Update Rom";
            this.btRomUpgrade.UseVisualStyleBackColor = false;
            this.btRomUpgrade.Click += new System.EventHandler(this.btRomUpgrade_Click);
            // 
            // btSerialNo_W
            // 
            this.btSerialNo_W.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btSerialNo_W.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSerialNo_W.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSerialNo_W.Location = new System.Drawing.Point(90, 16);
            this.btSerialNo_W.Name = "btSerialNo_W";
            this.btSerialNo_W.Size = new System.Drawing.Size(78, 28);
            this.btSerialNo_W.TabIndex = 0;
            this.btSerialNo_W.Text = "▶ Setup S/N";
            this.btSerialNo_W.UseVisualStyleBackColor = false;
            this.btSerialNo_W.Click += new System.EventHandler(this.btSerialNo_W_Click);
            // 
            // btDisFlag
            // 
            this.btDisFlag.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisFlag.Location = new System.Drawing.Point(71, 41);
            this.btDisFlag.Name = "btDisFlag";
            this.btDisFlag.Size = new System.Drawing.Size(60, 30);
            this.btDisFlag.TabIndex = 0;
            this.btDisFlag.Text = "Off";
            this.btDisFlag.UseVisualStyleBackColor = true;
            this.btDisFlag.Click += new System.EventHandler(this.btDisFlag_Click);
            // 
            // btClearFls
            // 
            this.btClearFls.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClearFls.ForeColor = System.Drawing.Color.Black;
            this.btClearFls.Location = new System.Drawing.Point(72, 86);
            this.btClearFls.Name = "btClearFls";
            this.btClearFls.Size = new System.Drawing.Size(60, 30);
            this.btClearFls.TabIndex = 0;
            this.btClearFls.Text = "Clean";
            this.btClearFls.UseVisualStyleBackColor = true;
            this.btClearFls.Click += new System.EventHandler(this.btClearFls_Click);
            // 
            // btRecodeFls
            // 
            this.btRecodeFls.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecodeFls.ForeColor = System.Drawing.Color.Crimson;
            this.btRecodeFls.Location = new System.Drawing.Point(7, 86);
            this.btRecodeFls.Name = "btRecodeFls";
            this.btRecodeFls.Size = new System.Drawing.Size(60, 30);
            this.btRecodeFls.TabIndex = 0;
            this.btRecodeFls.Text = "Record";
            this.btRecodeFls.UseVisualStyleBackColor = true;
            this.btRecodeFls.Click += new System.EventHandler(this.btRecodeFls_Click);
            // 
            // btEnaFlag
            // 
            this.btEnaFlag.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnaFlag.ForeColor = System.Drawing.Color.Crimson;
            this.btEnaFlag.Location = new System.Drawing.Point(9, 41);
            this.btEnaFlag.Name = "btEnaFlag";
            this.btEnaFlag.Size = new System.Drawing.Size(60, 30);
            this.btEnaFlag.TabIndex = 0;
            this.btEnaFlag.Text = "On";
            this.btEnaFlag.UseVisualStyleBackColor = true;
            this.btEnaFlag.Click += new System.EventHandler(this.btEnaFlag_Click);
            // 
            // gbCmdItems
            // 
            this.gbCmdItems.BackColor = System.Drawing.Color.SandyBrown;
            this.gbCmdItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbCmdItems.Controls.Add(this.panel3);
            this.gbCmdItems.Controls.Add(this.panel1);
            this.gbCmdItems.Controls.Add(this.rtbUZP);
            this.gbCmdItems.Controls.Add(this.btUZP);
            this.gbCmdItems.Controls.Add(this.SerialNumber);
            this.gbCmdItems.Controls.Add(this.btSerialNo_W);
            this.gbCmdItems.Enabled = false;
            this.gbCmdItems.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCmdItems.ForeColor = System.Drawing.Color.MediumBlue;
            this.gbCmdItems.Location = new System.Drawing.Point(521, 20);
            this.gbCmdItems.Name = "gbCmdItems";
            this.gbCmdItems.Size = new System.Drawing.Size(172, 235);
            this.gbCmdItems.TabIndex = 1;
            this.gbCmdItems.TabStop = false;
            this.gbCmdItems.Text = "Setup Items";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tomato;
            this.panel3.Controls.Add(this.tbGaugeCenter);
            this.panel3.Controls.Add(this.tbGaugeMax);
            this.panel3.Controls.Add(this.btAmpGauge);
            this.panel3.Controls.Add(this.tbGaugeMin);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(8, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 74);
            this.panel3.TabIndex = 31;
            // 
            // tbGaugeCenter
            // 
            this.tbGaugeCenter.Location = new System.Drawing.Point(61, 18);
            this.tbGaugeCenter.Name = "tbGaugeCenter";
            this.tbGaugeCenter.Size = new System.Drawing.Size(40, 20);
            this.tbGaugeCenter.TabIndex = 30;
            this.tbGaugeCenter.Text = "0";
            this.tbGaugeCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGaugeMax
            // 
            this.tbGaugeMax.Location = new System.Drawing.Point(110, 18);
            this.tbGaugeMax.Name = "tbGaugeMax";
            this.tbGaugeMax.Size = new System.Drawing.Size(40, 20);
            this.tbGaugeMax.TabIndex = 31;
            this.tbGaugeMax.Text = "0";
            this.tbGaugeMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAmpGauge
            // 
            this.btAmpGauge.BackColor = System.Drawing.Color.Coral;
            this.btAmpGauge.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAmpGauge.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btAmpGauge.Location = new System.Drawing.Point(8, 41);
            this.btAmpGauge.Name = "btAmpGauge";
            this.btAmpGauge.Size = new System.Drawing.Size(146, 30);
            this.btAmpGauge.TabIndex = 15;
            this.btAmpGauge.Text = "▶  Setup [ AMP GAUGE ]";
            this.btAmpGauge.UseVisualStyleBackColor = false;
            this.btAmpGauge.Click += new System.EventHandler(this.btAmpGauge_Click);
            // 
            // tbGaugeMin
            // 
            this.tbGaugeMin.Location = new System.Drawing.Point(10, 18);
            this.tbGaugeMin.Name = "tbGaugeMin";
            this.tbGaugeMin.Size = new System.Drawing.Size(40, 20);
            this.tbGaugeMin.TabIndex = 29;
            this.tbGaugeMin.Text = "0";
            this.tbGaugeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(9, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "[ Min ]      [ Center ]     [ Max ]";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.btAmpGain);
            this.panel1.Controls.Add(this.cbMediumSupport);
            this.panel1.Controls.Add(this.tbAmpGainM);
            this.panel1.Controls.Add(this.tbAmpGainF);
            this.panel1.Controls.Add(this.tbAmpGainC);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(7, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 74);
            this.panel1.TabIndex = 26;
            // 
            // btAmpGain
            // 
            this.btAmpGain.BackColor = System.Drawing.Color.Chocolate;
            this.btAmpGain.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAmpGain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btAmpGain.Location = new System.Drawing.Point(8, 40);
            this.btAmpGain.Name = "btAmpGain";
            this.btAmpGain.Size = new System.Drawing.Size(146, 30);
            this.btAmpGain.TabIndex = 14;
            this.btAmpGain.Text = "▶ Setup [ AMP GAIN  ]";
            this.btAmpGain.UseVisualStyleBackColor = false;
            this.btAmpGain.Click += new System.EventHandler(this.btAmpGain_Click);
            // 
            // cbMediumSupport
            // 
            this.cbMediumSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMediumSupport.AutoSize = true;
            this.cbMediumSupport.BackColor = System.Drawing.Color.Black;
            this.cbMediumSupport.Checked = true;
            this.cbMediumSupport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMediumSupport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbMediumSupport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbMediumSupport.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMediumSupport.ForeColor = System.Drawing.Color.LavenderBlush;
            this.cbMediumSupport.Location = new System.Drawing.Point(109, 47);
            this.cbMediumSupport.Name = "cbMediumSupport";
            this.cbMediumSupport.Size = new System.Drawing.Size(40, 20);
            this.cbMediumSupport.TabIndex = 6;
            this.cbMediumSupport.Text = "M";
            this.cbMediumSupport.UseVisualStyleBackColor = false;
            // 
            // tbAmpGainM
            // 
            this.tbAmpGainM.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmpGainM.Location = new System.Drawing.Point(60, 17);
            this.tbAmpGainM.Name = "tbAmpGainM";
            this.tbAmpGainM.Size = new System.Drawing.Size(40, 21);
            this.tbAmpGainM.TabIndex = 27;
            this.tbAmpGainM.Text = "0";
            this.tbAmpGainM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAmpGainF
            // 
            this.tbAmpGainF.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmpGainF.Location = new System.Drawing.Point(110, 17);
            this.tbAmpGainF.Name = "tbAmpGainF";
            this.tbAmpGainF.Size = new System.Drawing.Size(40, 21);
            this.tbAmpGainF.TabIndex = 28;
            this.tbAmpGainF.Text = "0";
            this.tbAmpGainF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAmpGainC
            // 
            this.tbAmpGainC.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmpGainC.Location = new System.Drawing.Point(10, 17);
            this.tbAmpGainC.Name = "tbAmpGainC";
            this.tbAmpGainC.Size = new System.Drawing.Size(40, 21);
            this.tbAmpGainC.TabIndex = 26;
            this.tbAmpGainC.Text = "0";
            this.tbAmpGainC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "[Coarse]    [Medium]    [Fine]";
            // 
            // rtbUZP
            // 
            this.rtbUZP.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbUZP.Location = new System.Drawing.Point(8, 47);
            this.rtbUZP.Name = "rtbUZP";
            this.rtbUZP.Size = new System.Drawing.Size(75, 22);
            this.rtbUZP.TabIndex = 18;
            this.rtbUZP.Text = "";
            // 
            // btUZP
            // 
            this.btUZP.BackColor = System.Drawing.Color.DarkViolet;
            this.btUZP.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUZP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btUZP.Location = new System.Drawing.Point(90, 44);
            this.btUZP.Name = "btUZP";
            this.btUZP.Size = new System.Drawing.Size(78, 28);
            this.btUZP.TabIndex = 15;
            this.btUZP.Text = "▶ Setup UZP";
            this.btUZP.UseVisualStyleBackColor = false;
            this.btUZP.Click += new System.EventHandler(this.btUZP_Click);
            // 
            // tbVal8
            // 
            this.tbVal8.Location = new System.Drawing.Point(50, 32);
            this.tbVal8.Name = "tbVal8";
            this.tbVal8.Size = new System.Drawing.Size(40, 21);
            this.tbVal8.TabIndex = 30;
            // 
            // tbVal9
            // 
            this.tbVal9.Location = new System.Drawing.Point(94, 32);
            this.tbVal9.Name = "tbVal9";
            this.tbVal9.Size = new System.Drawing.Size(40, 21);
            this.tbVal9.TabIndex = 29;
            // 
            // btCustomDebug
            // 
            this.btCustomDebug.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCustomDebug.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCustomDebug.ForeColor = System.Drawing.Color.Lime;
            this.btCustomDebug.Location = new System.Drawing.Point(7, 55);
            this.btCustomDebug.Name = "btCustomDebug";
            this.btCustomDebug.Size = new System.Drawing.Size(128, 30);
            this.btCustomDebug.TabIndex = 15;
            this.btCustomDebug.Text = "Write \"Custom Debug\"";
            this.btCustomDebug.UseVisualStyleBackColor = false;
            this.btCustomDebug.Click += new System.EventHandler(this.btCustomDebug_Click);
            // 
            // tbVal7
            // 
            this.tbVal7.Location = new System.Drawing.Point(5, 32);
            this.tbVal7.Name = "tbVal7";
            this.tbVal7.Size = new System.Drawing.Size(40, 21);
            this.tbVal7.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "[Val 7]     [Val 8]     [Val 9]";
            // 
            // btResortRead
            // 
            this.btResortRead.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btResortRead.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResortRead.ForeColor = System.Drawing.Color.Blue;
            this.btResortRead.Location = new System.Drawing.Point(1, 18);
            this.btResortRead.Name = "btResortRead";
            this.btResortRead.Size = new System.Drawing.Size(44, 58);
            this.btResortRead.TabIndex = 21;
            this.btResortRead.Text = "Read";
            this.btResortRead.UseVisualStyleBackColor = false;
            this.btResortRead.Click += new System.EventHandler(this.btResort_Click);
            // 
            // gbDevTools
            // 
            this.gbDevTools.BackColor = System.Drawing.Color.Silver;
            this.gbDevTools.Controls.Add(this.groupBox1);
            this.gbDevTools.Controls.Add(this.groupBox3);
            this.gbDevTools.Controls.Add(this.groupBox7);
            this.gbDevTools.Controls.Add(this.groupBox8);
            this.gbDevTools.Controls.Add(this.groupBox4);
            this.gbDevTools.Enabled = false;
            this.gbDevTools.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDevTools.Location = new System.Drawing.Point(700, 22);
            this.gbDevTools.Name = "gbDevTools";
            this.gbDevTools.Size = new System.Drawing.Size(150, 603);
            this.gbDevTools.TabIndex = 22;
            this.gbDevTools.TabStop = false;
            this.gbDevTools.Text = "DEV Tools";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Khaki;
            this.groupBox5.Controls.Add(this.btIncrease);
            this.groupBox5.Controls.Add(this.rtbPulse);
            this.groupBox5.Controls.Add(this.btDecrease);
            this.groupBox5.Controls.Add(this.lbServoState);
            this.groupBox5.Controls.Add(this.btServoToggle);
            this.groupBox5.Controls.Add(this.btNull1);
            this.groupBox5.Controls.Add(this.btAutoVerify);
            this.groupBox5.Controls.Add(this.btAutoMeasure);
            this.groupBox5.Controls.Add(this.rtbEziPort);
            this.groupBox5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(1026, 175);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(136, 251);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Servo Control";
            // 
            // btIncrease
            // 
            this.btIncrease.Location = new System.Drawing.Point(94, 203);
            this.btIncrease.Name = "btIncrease";
            this.btIncrease.Size = new System.Drawing.Size(38, 37);
            this.btIncrease.TabIndex = 40;
            this.btIncrease.Text = "▶";
            this.btIncrease.UseVisualStyleBackColor = true;
            this.btIncrease.Click += new System.EventHandler(this.btIncrease_Click);
            // 
            // rtbPulse
            // 
            this.rtbPulse.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPulse.Location = new System.Drawing.Point(48, 207);
            this.rtbPulse.Multiline = false;
            this.rtbPulse.Name = "rtbPulse";
            this.rtbPulse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbPulse.Size = new System.Drawing.Size(41, 28);
            this.rtbPulse.TabIndex = 39;
            this.rtbPulse.Text = "1000";
            // 
            // btDecrease
            // 
            this.btDecrease.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDecrease.Location = new System.Drawing.Point(6, 203);
            this.btDecrease.Name = "btDecrease";
            this.btDecrease.Size = new System.Drawing.Size(38, 37);
            this.btDecrease.TabIndex = 38;
            this.btDecrease.Text = "◀";
            this.btDecrease.UseVisualStyleBackColor = true;
            this.btDecrease.Click += new System.EventHandler(this.btDecrease_Click);
            // 
            // lbServoState
            // 
            this.lbServoState.AutoSize = true;
            this.lbServoState.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServoState.ForeColor = System.Drawing.Color.Gray;
            this.lbServoState.Location = new System.Drawing.Point(13, 52);
            this.lbServoState.Name = "lbServoState";
            this.lbServoState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbServoState.Size = new System.Drawing.Size(106, 15);
            this.lbServoState.TabIndex = 37;
            this.lbServoState.Text = "Servo State :  OFF";
            // 
            // btServoToggle
            // 
            this.btServoToggle.BackColor = System.Drawing.Color.Cornsilk;
            this.btServoToggle.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServoToggle.ForeColor = System.Drawing.Color.Green;
            this.btServoToggle.Location = new System.Drawing.Point(5, 71);
            this.btServoToggle.Name = "btServoToggle";
            this.btServoToggle.Size = new System.Drawing.Size(128, 37);
            this.btServoToggle.TabIndex = 34;
            this.btServoToggle.Text = "Servo On/Off";
            this.btServoToggle.UseVisualStyleBackColor = false;
            this.btServoToggle.Click += new System.EventHandler(this.btServoToggle_Click);
            // 
            // btNull1
            // 
            this.btNull1.BackColor = System.Drawing.Color.FloralWhite;
            this.btNull1.Enabled = false;
            this.btNull1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNull1.ForeColor = System.Drawing.Color.Blue;
            this.btNull1.Location = new System.Drawing.Point(7, 17);
            this.btNull1.Name = "btNull1";
            this.btNull1.Size = new System.Drawing.Size(83, 32);
            this.btNull1.TabIndex = 36;
            this.btNull1.Text = "Ezi Port";
            this.btNull1.UseVisualStyleBackColor = false;
            // 
            // btAutoVerify
            // 
            this.btAutoVerify.BackColor = System.Drawing.Color.Cornsilk;
            this.btAutoVerify.Enabled = false;
            this.btAutoVerify.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAutoVerify.ForeColor = System.Drawing.Color.Blue;
            this.btAutoVerify.Location = new System.Drawing.Point(5, 148);
            this.btAutoVerify.Name = "btAutoVerify";
            this.btAutoVerify.Size = new System.Drawing.Size(128, 37);
            this.btAutoVerify.TabIndex = 34;
            this.btAutoVerify.Text = "Auto Verify";
            this.btAutoVerify.UseVisualStyleBackColor = false;
            this.btAutoVerify.Click += new System.EventHandler(this.btAutoVerify_Click);
            // 
            // btAutoMeasure
            // 
            this.btAutoMeasure.BackColor = System.Drawing.Color.Cornsilk;
            this.btAutoMeasure.Enabled = false;
            this.btAutoMeasure.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAutoMeasure.ForeColor = System.Drawing.Color.Crimson;
            this.btAutoMeasure.Location = new System.Drawing.Point(5, 109);
            this.btAutoMeasure.Name = "btAutoMeasure";
            this.btAutoMeasure.Size = new System.Drawing.Size(128, 37);
            this.btAutoMeasure.TabIndex = 34;
            this.btAutoMeasure.Text = "◆ Auto Measure";
            this.btAutoMeasure.UseVisualStyleBackColor = false;
            this.btAutoMeasure.Click += new System.EventHandler(this.btAutoMeasure_Click);
            // 
            // rtbEziPort
            // 
            this.rtbEziPort.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEziPort.Location = new System.Drawing.Point(96, 19);
            this.rtbEziPort.Multiline = false;
            this.rtbEziPort.Name = "rtbEziPort";
            this.rtbEziPort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbEziPort.Size = new System.Drawing.Size(32, 28);
            this.rtbEziPort.TabIndex = 35;
            this.rtbEziPort.Text = "9";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Bisque;
            this.groupBox2.Controls.Add(this.btResortRecord);
            this.groupBox2.Controls.Add(this.btResortClean);
            this.groupBox2.Controls.Add(this.btResortRead);
            this.groupBox2.Location = new System.Drawing.Point(854, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 82);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESORT (Log)";
            // 
            // btResortRecord
            // 
            this.btResortRecord.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResortRecord.ForeColor = System.Drawing.Color.Crimson;
            this.btResortRecord.Location = new System.Drawing.Point(44, 18);
            this.btResortRecord.Name = "btResortRecord";
            this.btResortRecord.Size = new System.Drawing.Size(48, 58);
            this.btResortRecord.TabIndex = 22;
            this.btResortRecord.Text = "Record";
            this.btResortRecord.UseVisualStyleBackColor = true;
            this.btResortRecord.Click += new System.EventHandler(this.btResortRecord_Click);
            // 
            // btResortClean
            // 
            this.btResortClean.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResortClean.ForeColor = System.Drawing.Color.Black;
            this.btResortClean.Location = new System.Drawing.Point(91, 18);
            this.btResortClean.Name = "btResortClean";
            this.btResortClean.Size = new System.Drawing.Size(44, 58);
            this.btResortClean.TabIndex = 0;
            this.btResortClean.Text = "Clean";
            this.btResortClean.UseVisualStyleBackColor = true;
            this.btResortClean.Click += new System.EventHandler(this.btResortClean_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbRebootOpt);
            this.groupBox1.Controls.Add(this.tbPeriod);
            this.groupBox1.Controls.Add(this.pnAngleOpt);
            this.groupBox1.Controls.Add(this.btStopAngleData);
            this.groupBox1.Controls.Add(this.btAngleData);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 140);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Angle data (reboot)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Period (ms)";
            // 
            // cbRebootOpt
            // 
            this.cbRebootOpt.AutoSize = true;
            this.cbRebootOpt.Location = new System.Drawing.Point(7, 16);
            this.cbRebootOpt.Name = "cbRebootOpt";
            this.cbRebootOpt.Size = new System.Drawing.Size(120, 19);
            this.cbRebootOpt.TabIndex = 28;
            this.cbRebootOpt.Text = "Need Reboot ( 5sec )";
            this.cbRebootOpt.UseVisualStyleBackColor = true;
            this.cbRebootOpt.CheckedChanged += new System.EventHandler(this.cbRebootOption_CheckedChanged);
            // 
            // tbPeriod
            // 
            this.tbPeriod.Location = new System.Drawing.Point(75, 81);
            this.tbPeriod.Name = "tbPeriod";
            this.tbPeriod.Size = new System.Drawing.Size(50, 20);
            this.tbPeriod.TabIndex = 25;
            this.tbPeriod.Text = "500";
            this.tbPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnAngleOpt
            // 
            this.pnAngleOpt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnAngleOpt.Controls.Add(this.cbNewL);
            this.pnAngleOpt.Controls.Add(this.tbDegree);
            this.pnAngleOpt.Controls.Add(this.cbAngleDiff);
            this.pnAngleOpt.Enabled = false;
            this.pnAngleOpt.Location = new System.Drawing.Point(7, 34);
            this.pnAngleOpt.Name = "pnAngleOpt";
            this.pnAngleOpt.Size = new System.Drawing.Size(124, 44);
            this.pnAngleOpt.TabIndex = 27;
            // 
            // cbNewL
            // 
            this.cbNewL.AutoSize = true;
            this.cbNewL.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNewL.Location = new System.Drawing.Point(3, 24);
            this.cbNewL.Name = "cbNewL";
            this.cbNewL.Size = new System.Drawing.Size(66, 19);
            this.cbNewL.TabIndex = 24;
            this.cbNewL.Text = "New Line";
            this.cbNewL.UseVisualStyleBackColor = true;
            // 
            // tbDegree
            // 
            this.tbDegree.Location = new System.Drawing.Point(76, 5);
            this.tbDegree.Name = "tbDegree";
            this.tbDegree.Size = new System.Drawing.Size(43, 20);
            this.tbDegree.TabIndex = 25;
            // 
            // cbAngleDiff
            // 
            this.cbAngleDiff.AutoSize = true;
            this.cbAngleDiff.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAngleDiff.Location = new System.Drawing.Point(3, 4);
            this.cbAngleDiff.Name = "cbAngleDiff";
            this.cbAngleDiff.Size = new System.Drawing.Size(66, 19);
            this.cbAngleDiff.TabIndex = 24;
            this.cbAngleDiff.Text = "Angle (1º)";
            this.cbAngleDiff.UseVisualStyleBackColor = true;
            // 
            // btStopAngleData
            // 
            this.btStopAngleData.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStopAngleData.ForeColor = System.Drawing.Color.Black;
            this.btStopAngleData.Location = new System.Drawing.Point(72, 103);
            this.btStopAngleData.Name = "btStopAngleData";
            this.btStopAngleData.Size = new System.Drawing.Size(60, 33);
            this.btStopAngleData.TabIndex = 23;
            this.btStopAngleData.Text = "Stop";
            this.btStopAngleData.UseVisualStyleBackColor = true;
            this.btStopAngleData.Click += new System.EventHandler(this.btStopAngleData_Click);
            // 
            // btAngleData
            // 
            this.btAngleData.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAngleData.ForeColor = System.Drawing.Color.Crimson;
            this.btAngleData.Location = new System.Drawing.Point(7, 103);
            this.btAngleData.Name = "btAngleData";
            this.btAngleData.Size = new System.Drawing.Size(60, 33);
            this.btAngleData.TabIndex = 23;
            this.btAngleData.Text = "Start";
            this.btAngleData.UseVisualStyleBackColor = true;
            this.btAngleData.Click += new System.EventHandler(this.btAngleData_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox7.Controls.Add(this.cbHeader);
            this.groupBox7.Controls.Add(this.btWrAscii);
            this.groupBox7.Controls.Add(this.AsciiText);
            this.groupBox7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(6, 526);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(136, 73);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Send ASCII Commnad";
            // 
            // cbHeader
            // 
            this.cbHeader.AutoSize = true;
            this.cbHeader.Checked = true;
            this.cbHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHeader.Location = new System.Drawing.Point(38, 17);
            this.cbHeader.Name = "cbHeader";
            this.cbHeader.Size = new System.Drawing.Size(95, 19);
            this.cbHeader.TabIndex = 28;
            this.cbHeader.Text = "Include Header";
            this.cbHeader.UseVisualStyleBackColor = true;
            // 
            // btWrAscii
            // 
            this.btWrAscii.BackColor = System.Drawing.Color.DarkGray;
            this.btWrAscii.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWrAscii.ForeColor = System.Drawing.Color.MediumBlue;
            this.btWrAscii.Location = new System.Drawing.Point(75, 36);
            this.btWrAscii.Name = "btWrAscii";
            this.btWrAscii.Size = new System.Drawing.Size(58, 34);
            this.btWrAscii.TabIndex = 0;
            this.btWrAscii.Text = "Send";
            this.btWrAscii.UseVisualStyleBackColor = false;
            this.btWrAscii.Click += new System.EventHandler(this.btWrAscii_Click);
            // 
            // AsciiText
            // 
            this.AsciiText.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsciiText.Location = new System.Drawing.Point(5, 39);
            this.AsciiText.Multiline = false;
            this.AsciiText.Name = "AsciiText";
            this.AsciiText.Size = new System.Drawing.Size(64, 28);
            this.AsciiText.TabIndex = 13;
            this.AsciiText.Text = "";
            // 
            // btSaveLog
            // 
            this.btSaveLog.BackColor = System.Drawing.Color.Goldenrod;
            this.btSaveLog.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btSaveLog.Location = new System.Drawing.Point(7, 15);
            this.btSaveLog.Name = "btSaveLog";
            this.btSaveLog.Size = new System.Drawing.Size(76, 40);
            this.btSaveLog.TabIndex = 21;
            this.btSaveLog.Text = "Save Screen";
            this.btSaveLog.UseVisualStyleBackColor = false;
            this.btSaveLog.Click += new System.EventHandler(this.btSaveLog_Click);
            // 
            // btReboot
            // 
            this.btReboot.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btReboot.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReboot.ForeColor = System.Drawing.Color.Red;
            this.btReboot.Location = new System.Drawing.Point(87, 96);
            this.btReboot.Name = "btReboot";
            this.btReboot.Size = new System.Drawing.Size(76, 40);
            this.btReboot.TabIndex = 20;
            this.btReboot.Text = "REBOOT";
            this.btReboot.UseVisualStyleBackColor = false;
            this.btReboot.Click += new System.EventHandler(this.btReboot_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Controls.Add(this.btMeasureCAA);
            this.groupBox3.Controls.Add(this.btMode_Medium);
            this.groupBox3.Controls.Add(this.tMode_Coarse);
            this.groupBox3.Controls.Add(this.btMode_Fine);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 143);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mode Selection";
            // 
            // btMeasureCAA
            // 
            this.btMeasureCAA.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btMeasureCAA.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMeasureCAA.ForeColor = System.Drawing.Color.Blue;
            this.btMeasureCAA.Location = new System.Drawing.Point(10, 109);
            this.btMeasureCAA.Name = "btMeasureCAA";
            this.btMeasureCAA.Size = new System.Drawing.Size(115, 28);
            this.btMeasureCAA.TabIndex = 0;
            this.btMeasureCAA.Text = "Measure CAA";
            this.btMeasureCAA.UseVisualStyleBackColor = false;
            this.btMeasureCAA.Click += new System.EventHandler(this.btMeasureCAA_Click);
            // 
            // btMode_Medium
            // 
            this.btMode_Medium.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMode_Medium.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btMode_Medium.Location = new System.Drawing.Point(10, 78);
            this.btMode_Medium.Name = "btMode_Medium";
            this.btMode_Medium.Size = new System.Drawing.Size(115, 28);
            this.btMode_Medium.TabIndex = 0;
            this.btMode_Medium.Text = "Medium";
            this.btMode_Medium.UseVisualStyleBackColor = true;
            this.btMode_Medium.Click += new System.EventHandler(this.btMode_Medium_Click);
            // 
            // tMode_Coarse
            // 
            this.tMode_Coarse.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMode_Coarse.ForeColor = System.Drawing.Color.Green;
            this.tMode_Coarse.Location = new System.Drawing.Point(10, 47);
            this.tMode_Coarse.Name = "tMode_Coarse";
            this.tMode_Coarse.Size = new System.Drawing.Size(115, 28);
            this.tMode_Coarse.TabIndex = 0;
            this.tMode_Coarse.Text = "Coarse";
            this.tMode_Coarse.UseVisualStyleBackColor = true;
            this.tMode_Coarse.Click += new System.EventHandler(this.tMode_Coarse_Click);
            // 
            // btMode_Fine
            // 
            this.btMode_Fine.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMode_Fine.ForeColor = System.Drawing.Color.Crimson;
            this.btMode_Fine.Location = new System.Drawing.Point(10, 16);
            this.btMode_Fine.Name = "btMode_Fine";
            this.btMode_Fine.Size = new System.Drawing.Size(115, 28);
            this.btMode_Fine.TabIndex = 0;
            this.btMode_Fine.Text = "Fine";
            this.btMode_Fine.UseVisualStyleBackColor = true;
            this.btMode_Fine.Click += new System.EventHandler(this.btMode_Fine_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox8.Controls.Add(this.cbListOfBundle);
            this.groupBox8.Controls.Add(this.btCalcDbgData);
            this.groupBox8.Controls.Add(this.btReadAmp);
            this.groupBox8.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(6, 166);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(140, 77);
            this.groupBox8.TabIndex = 26;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Read Bulk (Fixed Mem)";
            // 
            // cbListOfBundle
            // 
            this.cbListOfBundle.FormattingEnabled = true;
            this.cbListOfBundle.Items.AddRange(new object[] {
            "1",
            "2",
            "4"});
            this.cbListOfBundle.Location = new System.Drawing.Point(9, 18);
            this.cbListOfBundle.Name = "cbListOfBundle";
            this.cbListOfBundle.Size = new System.Drawing.Size(118, 23);
            this.cbListOfBundle.TabIndex = 23;
            // 
            // btCalcDbgData
            // 
            this.btCalcDbgData.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcDbgData.ForeColor = System.Drawing.Color.Crimson;
            this.btCalcDbgData.Location = new System.Drawing.Point(69, 42);
            this.btCalcDbgData.Name = "btCalcDbgData";
            this.btCalcDbgData.Size = new System.Drawing.Size(58, 33);
            this.btCalcDbgData.TabIndex = 22;
            this.btCalcDbgData.Text = "Calc";
            this.btCalcDbgData.UseVisualStyleBackColor = true;
            this.btCalcDbgData.Click += new System.EventHandler(this.btCalcDbgData_Click);
            // 
            // btReadAmp
            // 
            this.btReadAmp.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReadAmp.ForeColor = System.Drawing.Color.Blue;
            this.btReadAmp.Location = new System.Drawing.Point(8, 42);
            this.btReadAmp.Name = "btReadAmp";
            this.btReadAmp.Size = new System.Drawing.Size(58, 33);
            this.btReadAmp.TabIndex = 22;
            this.btReadAmp.Text = "Copy";
            this.btReadAmp.UseVisualStyleBackColor = true;
            this.btReadAmp.Click += new System.EventHandler(this.btReadDbgData_Click);
            // 
            // btReadStorage
            // 
            this.btReadStorage.BackColor = System.Drawing.Color.DarkKhaki;
            this.btReadStorage.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReadStorage.ForeColor = System.Drawing.Color.Blue;
            this.btReadStorage.Location = new System.Drawing.Point(855, 588);
            this.btReadStorage.Name = "btReadStorage";
            this.btReadStorage.Size = new System.Drawing.Size(128, 33);
            this.btReadStorage.TabIndex = 21;
            this.btReadStorage.Text = "Read Storage";
            this.btReadStorage.UseVisualStyleBackColor = false;
            this.btReadStorage.Click += new System.EventHandler(this.btReadStorage_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox6.Controls.Add(this.cbListOfFlag);
            this.groupBox6.Controls.Add(this.btDisFlag);
            this.groupBox6.Controls.Add(this.btEnaFlag);
            this.groupBox6.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(854, 156);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(140, 76);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Debug Volatile Value";
            // 
            // cbListOfFlag
            // 
            this.cbListOfFlag.FormattingEnabled = true;
            this.cbListOfFlag.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbListOfFlag.Location = new System.Drawing.Point(10, 16);
            this.cbListOfFlag.Name = "cbListOfFlag";
            this.cbListOfFlag.Size = new System.Drawing.Size(118, 23);
            this.cbListOfFlag.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox4.Controls.Add(this.btClearFls);
            this.groupBox4.Controls.Add(this.btRecodeFls);
            this.groupBox4.Controls.Add(this.tbVal8);
            this.groupBox4.Controls.Add(this.tbVal9);
            this.groupBox4.Controls.Add(this.tbVal7);
            this.groupBox4.Controls.Add(this.btCustomDebug);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(4, 391);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(140, 120);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control Flash Value";
            // 
            // btMTRomUpdate
            // 
            this.btMTRomUpdate.BackColor = System.Drawing.Color.Silver;
            this.btMTRomUpdate.Enabled = false;
            this.btMTRomUpdate.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMTRomUpdate.ForeColor = System.Drawing.Color.Blue;
            this.btMTRomUpdate.Location = new System.Drawing.Point(857, 549);
            this.btMTRomUpdate.Name = "btMTRomUpdate";
            this.btMTRomUpdate.Size = new System.Drawing.Size(128, 33);
            this.btMTRomUpdate.TabIndex = 0;
            this.btMTRomUpdate.Text = "SubRom Update";
            this.btMTRomUpdate.UseVisualStyleBackColor = false;
            this.btMTRomUpdate.Click += new System.EventHandler(this.btMTRomUpdate_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPortStatus,
            this.tsDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 630);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1199, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsPortStatus
            // 
            this.tsPortStatus.ActiveLinkColor = System.Drawing.Color.White;
            this.tsPortStatus.BackColor = System.Drawing.Color.SlateGray;
            this.tsPortStatus.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsPortStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsPortStatus.Name = "tsPortStatus";
            this.tsPortStatus.Padding = new System.Windows.Forms.Padding(200, 0, 200, 0);
            this.tsPortStatus.Size = new System.Drawing.Size(462, 17);
            this.tsPortStatus.Text = "Port Closed";
            // 
            // tsDate
            // 
            this.tsDate.ActiveLinkColor = System.Drawing.Color.White;
            this.tsDate.BackColor = System.Drawing.Color.SlateGray;
            this.tsDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsDate.Name = "tsDate";
            this.tsDate.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.tsDate.Size = new System.Drawing.Size(156, 17);
            this.tsDate.Text = "MM-dd HH:mm:ss";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.cbHex);
            this.panel2.Controls.Add(this.btClearAscii);
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 606);
            this.panel2.TabIndex = 31;
            // 
            // gbFW_Upgrade
            // 
            this.gbFW_Upgrade.BackColor = System.Drawing.Color.Gold;
            this.gbFW_Upgrade.Controls.Add(this.btSaveLog);
            this.gbFW_Upgrade.Controls.Add(this.btModeSSC);
            this.gbFW_Upgrade.Controls.Add(this.btReadInfo);
            this.gbFW_Upgrade.Controls.Add(this.btReboot);
            this.gbFW_Upgrade.Controls.Add(this.btReadAngleInfo);
            this.gbFW_Upgrade.Controls.Add(this.btRomUpgrade);
            this.gbFW_Upgrade.Enabled = false;
            this.gbFW_Upgrade.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFW_Upgrade.ForeColor = System.Drawing.Color.MediumBlue;
            this.gbFW_Upgrade.Location = new System.Drawing.Point(523, 339);
            this.gbFW_Upgrade.Name = "gbFW_Upgrade";
            this.gbFW_Upgrade.Size = new System.Drawing.Size(172, 138);
            this.gbFW_Upgrade.TabIndex = 32;
            this.gbFW_Upgrade.TabStop = false;
            this.gbFW_Upgrade.Text = "Controls";
            // 
            // btReadAngleInfo
            // 
            this.btReadAngleInfo.BackColor = System.Drawing.Color.Aqua;
            this.btReadAngleInfo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReadAngleInfo.ForeColor = System.Drawing.Color.Black;
            this.btReadAngleInfo.Location = new System.Drawing.Point(7, 96);
            this.btReadAngleInfo.Name = "btReadAngleInfo";
            this.btReadAngleInfo.Size = new System.Drawing.Size(76, 40);
            this.btReadAngleInfo.TabIndex = 20;
            this.btReadAngleInfo.Text = "Read Angle";
            this.btReadAngleInfo.UseVisualStyleBackColor = false;
            this.btReadAngleInfo.Click += new System.EventHandler(this.btReadAngleInfo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btClearAscii;
            this.ClientSize = new System.Drawing.Size(1199, 652);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btMTRomUpdate);
            this.Controls.Add(this.btReadStorage);
            this.Controls.Add(this.gbFW_Upgrade);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.gbCmdLists);
            this.Controls.Add(this.rtDispAscii);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbCmdItems);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbPort);
            this.Controls.Add(this.gbDevTools);
            this.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fmMain";
            this.Text = "UART Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPort.ResumeLayout(false);
            this.gbPort.PerformLayout();
            this.gbCmdLists.ResumeLayout(false);
            this.gbCmdItems.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDevTools.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnAngleOpt.ResumeLayout(false);
            this.pnAngleOpt.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbFW_Upgrade.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.RichTextBox rtDispAscii;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.ListBox PortsEntry;
        private System.Windows.Forms.CheckBox cbHex;
        private System.Windows.Forms.GroupBox gbPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btClearAscii;
        private System.Windows.Forms.RichTextBox SerialNumber;
        private System.Windows.Forms.GroupBox gbCmdLists;
        private System.Windows.Forms.Button btDisFlag;
        private System.Windows.Forms.Button btSerialNo_W;
        private System.Windows.Forms.Button btEnaFlag;
        private System.Windows.Forms.Button btRomUpgrade;
        private System.Windows.Forms.GroupBox gbCmdItems;
        private System.Windows.Forms.Button btRecodeFls;
        private System.Windows.Forms.Button btClearFls;
        private System.Windows.Forms.ComboBox cbListOfCmd;
        private System.Windows.Forms.Button btCmdWr;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btReadInfo;
        private System.Windows.Forms.Button btResortRead;
        private System.Windows.Forms.GroupBox gbDevTools;
        private System.Windows.Forms.Button btReadAmp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsDate;
        private System.Windows.Forms.ToolStripStatusLabel tsPortStatus;
        private System.Windows.Forms.Button btUZP;
        private System.Windows.Forms.RichTextBox rtbUZP;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbVal8;
        private System.Windows.Forms.TextBox tbVal9;
        private System.Windows.Forms.TextBox tbVal7;
        private System.Windows.Forms.TextBox tbAmpGainF;
        private System.Windows.Forms.TextBox tbAmpGainC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAmpGain;
        private System.Windows.Forms.Button btCustomDebug;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btStopAngleData;
        private System.Windows.Forms.Button btAngleData;
        private System.Windows.Forms.CheckBox cbAngleDiff;
        private System.Windows.Forms.TextBox tbDegree;
        private System.Windows.Forms.CheckBox cbNewL;
        private System.Windows.Forms.Button btModeSSC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btResortRecord;
        private System.Windows.Forms.Button btResortClean;
        private System.Windows.Forms.TextBox tbAmpGainM;
        private System.Windows.Forms.CheckBox cbMediumSupport;
        private System.Windows.Forms.ComboBox cbListOfBundle;
        private System.Windows.Forms.ComboBox cbListOfFlag;
        private System.Windows.Forms.Button btCalcDbgData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbGaugeCenter;
        private System.Windows.Forms.TextBox tbGaugeMax;
        private System.Windows.Forms.Button btAmpGauge;
        private System.Windows.Forms.TextBox tbGaugeMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btMTRomUpdate;
        private System.Windows.Forms.GroupBox gbFW_Upgrade;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.CheckBox cbDtrEnable;
        private System.Windows.Forms.Button btSaveLog;
        private System.Windows.Forms.Button btReadStorage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btMode_Medium;
        private System.Windows.Forms.Button tMode_Coarse;
        private System.Windows.Forms.Button btMode_Fine;
        private System.Windows.Forms.Panel pnAngleOpt;
        private System.Windows.Forms.CheckBox cbRebootOpt;
        private System.Windows.Forms.Button btReboot;
        private System.Windows.Forms.Button btMeasureCAA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPeriod;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox cbHeader;
        private System.Windows.Forms.Button btWrAscii;
        private System.Windows.Forms.RichTextBox AsciiText;
        private System.Windows.Forms.Button btReadAngleInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btServoToggle;
        private System.Windows.Forms.Button btAutoMeasure;
        private System.Windows.Forms.RichTextBox rtbEziPort;
        private System.Windows.Forms.Button btNull1;
        private System.Windows.Forms.Label lbServoState;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox rtbPulse;
        private System.Windows.Forms.Button btDecrease;
        private System.Windows.Forms.Button btIncrease;
        private System.Windows.Forms.Button btAutoVerify;
    }
}

