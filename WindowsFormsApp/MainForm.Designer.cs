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
            this.label4 = new System.Windows.Forms.Label();
            this.tbGaugeCenter = new System.Windows.Forms.TextBox();
            this.tbGaugeMax = new System.Windows.Forms.TextBox();
            this.btAmpGauge = new System.Windows.Forms.Button();
            this.tbGaugeMin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAmpGain = new System.Windows.Forms.Button();
            this.cbMediumSupport = new System.Windows.Forms.CheckBox();
            this.tbAmpGainM = new System.Windows.Forms.TextBox();
            this.tbAmpGainF = new System.Windows.Forms.TextBox();
            this.tbAmpGainC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbMtCnt = new System.Windows.Forms.RichTextBox();
            this.rtbUZP = new System.Windows.Forms.RichTextBox();
            this.btMtCnt = new System.Windows.Forms.Button();
            this.btUZP = new System.Windows.Forms.Button();
            this.tbVal8 = new System.Windows.Forms.TextBox();
            this.tbVal9 = new System.Windows.Forms.TextBox();
            this.btCustomDebug = new System.Windows.Forms.Button();
            this.tbVal7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btResortRead = new System.Windows.Forms.Button();
            this.gbModeSelection = new System.Windows.Forms.GroupBox();
            this.btMode_Medium = new System.Windows.Forms.Button();
            this.tMode_Coarse = new System.Windows.Forms.Button();
            this.btMode_Fine = new System.Windows.Forms.Button();
            this.btReadAngleInfo = new System.Windows.Forms.Button();
            this.gbAsciiCmd = new System.Windows.Forms.GroupBox();
            this.cbHeader = new System.Windows.Forms.CheckBox();
            this.btWrAscii = new System.Windows.Forms.Button();
            this.AsciiText = new System.Windows.Forms.RichTextBox();
            this.gbReadBulk = new System.Windows.Forms.GroupBox();
            this.cbListOfBundle = new System.Windows.Forms.ComboBox();
            this.btCalcDbgData = new System.Windows.Forms.Button();
            this.btReadAmp = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbListOfFlag = new System.Windows.Forms.ComboBox();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.btReboot = new System.Windows.Forms.Button();
            this.btMeasureCAA = new System.Windows.Forms.Button();
            this.gbAngleData = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRebootOpt = new System.Windows.Forms.CheckBox();
            this.tbPeriod = new System.Windows.Forms.TextBox();
            this.pnAngleOpt = new System.Windows.Forms.Panel();
            this.cbNewL = new System.Windows.Forms.CheckBox();
            this.tbDegree = new System.Windows.Forms.TextBox();
            this.cbAngleDiff = new System.Windows.Forms.CheckBox();
            this.btStopAngleData = new System.Windows.Forms.Button();
            this.btAngleData = new System.Windows.Forms.Button();
            this.gbServoMotor = new System.Windows.Forms.GroupBox();
            this.btIncrease = new System.Windows.Forms.Button();
            this.rtbPulse = new System.Windows.Forms.RichTextBox();
            this.btDecrease = new System.Windows.Forms.Button();
            this.lbServoState = new System.Windows.Forms.Label();
            this.btServoOnOff = new System.Windows.Forms.Button();
            this.btAutoVerify = new System.Windows.Forms.Button();
            this.btAutoMeasure = new System.Windows.Forms.Button();
            this.rtbEziPort = new System.Windows.Forms.RichTextBox();
            this.gbResort = new System.Windows.Forms.GroupBox();
            this.btResortRecord = new System.Windows.Forms.Button();
            this.btResortClean = new System.Windows.Forms.Button();
            this.btReadStorage = new System.Windows.Forms.Button();
            this.btMTRomUpdate = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbSaveScreen = new System.Windows.Forms.Label();
            this.lbCleanScreen = new System.Windows.Forms.Label();
            this.tsPortStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsNull1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsNull2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbPort.SuspendLayout();
            this.gbCmdLists.SuspendLayout();
            this.gbCmdItems.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbModeSelection.SuspendLayout();
            this.gbAsciiCmd.SuspendLayout();
            this.gbReadBulk.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbControls.SuspendLayout();
            this.gbAngleData.SuspendLayout();
            this.pnAngleOpt.SuspendLayout();
            this.gbServoMotor.SuspendLayout();
            this.gbResort.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.rtDispAscii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtDispAscii.EnableAutoDragDrop = true;
            this.rtDispAscii.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtDispAscii.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtDispAscii.Location = new System.Drawing.Point(4, 27);
            this.rtDispAscii.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtDispAscii.Name = "rtDispAscii";
            this.rtDispAscii.ReadOnly = true;
            this.rtDispAscii.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtDispAscii.Size = new System.Drawing.Size(510, 578);
            this.rtDispAscii.TabIndex = 0;
            this.rtDispAscii.Text = "";
            // 
            // btOpen
            // 
            this.btOpen.BackColor = System.Drawing.Color.Chartreuse;
            this.btOpen.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpen.ForeColor = System.Drawing.Color.Black;
            this.btOpen.Location = new System.Drawing.Point(72, 94);
            this.btOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(65, 42);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "Connect";
            this.btOpen.UseVisualStyleBackColor = false;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // PortsEntry
            // 
            this.PortsEntry.BackColor = System.Drawing.SystemColors.Menu;
            this.PortsEntry.ColumnWidth = 1;
            this.PortsEntry.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortsEntry.ForeColor = System.Drawing.Color.SeaGreen;
            this.PortsEntry.FormattingEnabled = true;
            this.PortsEntry.ItemHeight = 16;
            this.PortsEntry.Location = new System.Drawing.Point(3, 17);
            this.PortsEntry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PortsEntry.Name = "PortsEntry";
            this.PortsEntry.Size = new System.Drawing.Size(68, 116);
            this.PortsEntry.TabIndex = 3;
            this.PortsEntry.SelectedIndexChanged += new System.EventHandler(this.PortsEntry_SelectedIndexChanged);
            this.PortsEntry.DoubleClick += new System.EventHandler(this.btOpen_Click);
            // 
            // cbHex
            // 
            this.cbHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbHex.AutoSize = true;
            this.cbHex.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbHex.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbHex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbHex.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHex.ForeColor = System.Drawing.Color.DeepPink;
            this.cbHex.Location = new System.Drawing.Point(12, 584);
            this.cbHex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbHex.Name = "cbHex";
            this.cbHex.Size = new System.Drawing.Size(114, 21);
            this.cbHex.TabIndex = 6;
            this.cbHex.Text = " Print HEX format";
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
            this.gbPort.Location = new System.Drawing.Point(662, 487);
            this.gbPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPort.Name = "gbPort";
            this.gbPort.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPort.Size = new System.Drawing.Size(140, 138);
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
            "  9600",
            " 19200",
            " 38400",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(72, 67);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(65, 24);
            this.cbBaudRate.TabIndex = 3;
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.Cyan;
            this.btRefresh.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.ForeColor = System.Drawing.Color.Black;
            this.btRefresh.Location = new System.Drawing.Point(72, 16);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(65, 30);
            this.btRefresh.TabIndex = 19;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // cbDtrEnable
            // 
            this.cbDtrEnable.AutoSize = true;
            this.cbDtrEnable.BackColor = System.Drawing.Color.Transparent;
            this.cbDtrEnable.Checked = true;
            this.cbDtrEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDtrEnable.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDtrEnable.ForeColor = System.Drawing.Color.Blue;
            this.cbDtrEnable.Location = new System.Drawing.Point(77, 48);
            this.cbDtrEnable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbDtrEnable.Name = "cbDtrEnable";
            this.cbDtrEnable.Size = new System.Drawing.Size(48, 19);
            this.cbDtrEnable.TabIndex = 27;
            this.cbDtrEnable.Text = "DtrEn";
            this.cbDtrEnable.UseVisualStyleBackColor = false;
            // 
            // btModeSSC
            // 
            this.btModeSSC.BackColor = System.Drawing.Color.Plum;
            this.btModeSSC.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModeSSC.ForeColor = System.Drawing.Color.Black;
            this.btModeSSC.Location = new System.Drawing.Point(71, 16);
            this.btModeSSC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btModeSSC.Name = "btModeSSC";
            this.btModeSSC.Size = new System.Drawing.Size(68, 40);
            this.btModeSSC.TabIndex = 20;
            this.btModeSSC.Text = "BiSS mode";
            this.btModeSSC.UseVisualStyleBackColor = false;
            this.btModeSSC.Click += new System.EventHandler(this.btModeSSC_Click);
            // 
            // SerialNumber
            // 
            this.SerialNumber.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumber.Location = new System.Drawing.Point(6, 19);
            this.SerialNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SerialNumber.Multiline = false;
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(63, 22);
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
            this.gbCmdLists.Location = new System.Drawing.Point(520, 278);
            this.gbCmdLists.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCmdLists.Name = "gbCmdLists";
            this.gbCmdLists.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCmdLists.Size = new System.Drawing.Size(140, 78);
            this.gbCmdLists.TabIndex = 16;
            this.gbCmdLists.TabStop = false;
            this.gbCmdLists.Text = "Setup Items List";
            // 
            // btCmdWr
            // 
            this.btCmdWr.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCmdWr.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCmdWr.ForeColor = System.Drawing.Color.LightYellow;
            this.btCmdWr.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCmdWr.Location = new System.Drawing.Point(5, 42);
            this.btCmdWr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btCmdWr.Name = "btCmdWr";
            this.btCmdWr.Size = new System.Drawing.Size(130, 30);
            this.btCmdWr.TabIndex = 0;
            this.btCmdWr.Text = "▶  Setup [ Item ]";
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
            this.cbListOfCmd.Location = new System.Drawing.Point(5, 15);
            this.cbListOfCmd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbListOfCmd.MaxDropDownItems = 40;
            this.cbListOfCmd.Name = "cbListOfCmd";
            this.cbListOfCmd.Size = new System.Drawing.Size(130, 23);
            this.cbListOfCmd.TabIndex = 17;
            this.cbListOfCmd.Tag = "";
            this.cbListOfCmd.Text = "  Select Items";
            this.cbListOfCmd.SelectedIndexChanged += new System.EventHandler(this.cbListOfCmd_SelectedIndexChanged);
            // 
            // btReadInfo
            // 
            this.btReadInfo.BackColor = System.Drawing.Color.Aqua;
            this.btReadInfo.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReadInfo.ForeColor = System.Drawing.Color.Blue;
            this.btReadInfo.Location = new System.Drawing.Point(70, 93);
            this.btReadInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btReadInfo.Name = "btReadInfo";
            this.btReadInfo.Size = new System.Drawing.Size(68, 40);
            this.btReadInfo.TabIndex = 20;
            this.btReadInfo.Text = "All Info";
            this.btReadInfo.UseVisualStyleBackColor = false;
            this.btReadInfo.Click += new System.EventHandler(this.btReadInfo_Click);
            // 
            // btRomUpgrade
            // 
            this.btRomUpgrade.BackColor = System.Drawing.Color.OrangeRed;
            this.btRomUpgrade.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRomUpgrade.ForeColor = System.Drawing.Color.White;
            this.btRomUpgrade.Location = new System.Drawing.Point(71, 54);
            this.btRomUpgrade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btRomUpgrade.Name = "btRomUpgrade";
            this.btRomUpgrade.Size = new System.Drawing.Size(68, 40);
            this.btRomUpgrade.TabIndex = 0;
            this.btRomUpgrade.Text = "Update";
            this.btRomUpgrade.UseVisualStyleBackColor = false;
            this.btRomUpgrade.Click += new System.EventHandler(this.btRomUpgrade_Click);
            // 
            // btSerialNo_W
            // 
            this.btSerialNo_W.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btSerialNo_W.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSerialNo_W.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSerialNo_W.Location = new System.Drawing.Point(73, 15);
            this.btSerialNo_W.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btSerialNo_W.Name = "btSerialNo_W";
            this.btSerialNo_W.Size = new System.Drawing.Size(65, 28);
            this.btSerialNo_W.TabIndex = 0;
            this.btSerialNo_W.Text = "▶ Set S/N";
            this.btSerialNo_W.UseVisualStyleBackColor = false;
            this.btSerialNo_W.Click += new System.EventHandler(this.btSerialNo_W_Click);
            // 
            // btDisFlag
            // 
            this.btDisFlag.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisFlag.Location = new System.Drawing.Point(70, 42);
            this.btDisFlag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btDisFlag.Name = "btDisFlag";
            this.btDisFlag.Size = new System.Drawing.Size(60, 28);
            this.btDisFlag.TabIndex = 0;
            this.btDisFlag.Text = "○ Off";
            this.btDisFlag.UseVisualStyleBackColor = true;
            this.btDisFlag.Click += new System.EventHandler(this.btDisFlag_Click);
            // 
            // btClearFls
            // 
            this.btClearFls.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClearFls.ForeColor = System.Drawing.Color.Black;
            this.btClearFls.Location = new System.Drawing.Point(72, 85);
            this.btClearFls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btClearFls.Name = "btClearFls";
            this.btClearFls.Size = new System.Drawing.Size(60, 28);
            this.btClearFls.TabIndex = 0;
            this.btClearFls.Text = "❌ Clean";
            this.btClearFls.UseVisualStyleBackColor = true;
            this.btClearFls.Click += new System.EventHandler(this.btClearFls_Click);
            // 
            // btRecodeFls
            // 
            this.btRecodeFls.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecodeFls.ForeColor = System.Drawing.Color.Crimson;
            this.btRecodeFls.Location = new System.Drawing.Point(7, 85);
            this.btRecodeFls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btRecodeFls.Name = "btRecodeFls";
            this.btRecodeFls.Size = new System.Drawing.Size(60, 28);
            this.btRecodeFls.TabIndex = 0;
            this.btRecodeFls.Text = "● Rec";
            this.btRecodeFls.UseVisualStyleBackColor = true;
            this.btRecodeFls.Click += new System.EventHandler(this.btRecodeFls_Click);
            // 
            // btEnaFlag
            // 
            this.btEnaFlag.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnaFlag.ForeColor = System.Drawing.Color.Crimson;
            this.btEnaFlag.Location = new System.Drawing.Point(7, 42);
            this.btEnaFlag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btEnaFlag.Name = "btEnaFlag";
            this.btEnaFlag.Size = new System.Drawing.Size(60, 28);
            this.btEnaFlag.TabIndex = 0;
            this.btEnaFlag.Text = "● On";
            this.btEnaFlag.UseVisualStyleBackColor = true;
            this.btEnaFlag.Click += new System.EventHandler(this.btEnaFlag_Click);
            // 
            // gbCmdItems
            // 
            this.gbCmdItems.BackColor = System.Drawing.Color.SandyBrown;
            this.gbCmdItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbCmdItems.Controls.Add(this.panel3);
            this.gbCmdItems.Controls.Add(this.panel1);
            this.gbCmdItems.Controls.Add(this.rtbMtCnt);
            this.gbCmdItems.Controls.Add(this.rtbUZP);
            this.gbCmdItems.Controls.Add(this.btMtCnt);
            this.gbCmdItems.Controls.Add(this.btUZP);
            this.gbCmdItems.Controls.Add(this.SerialNumber);
            this.gbCmdItems.Controls.Add(this.btSerialNo_W);
            this.gbCmdItems.Enabled = false;
            this.gbCmdItems.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCmdItems.ForeColor = System.Drawing.Color.MediumBlue;
            this.gbCmdItems.Location = new System.Drawing.Point(520, 20);
            this.gbCmdItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCmdItems.Name = "gbCmdItems";
            this.gbCmdItems.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCmdItems.Size = new System.Drawing.Size(140, 256);
            this.gbCmdItems.TabIndex = 1;
            this.gbCmdItems.TabStop = false;
            this.gbCmdItems.Text = "Setup Items";
            this.gbCmdItems.Enter += new System.EventHandler(this.gbCmdItems_Enter);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tomato;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbGaugeCenter);
            this.panel3.Controls.Add(this.tbGaugeMax);
            this.panel3.Controls.Add(this.btAmpGauge);
            this.panel3.Controls.Add(this.tbGaugeMin);
            this.panel3.Location = new System.Drawing.Point(5, 178);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 74);
            this.panel3.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "[Min]    [Center]    [Max]";
            // 
            // tbGaugeCenter
            // 
            this.tbGaugeCenter.Location = new System.Drawing.Point(48, 19);
            this.tbGaugeCenter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbGaugeCenter.Name = "tbGaugeCenter";
            this.tbGaugeCenter.Size = new System.Drawing.Size(36, 20);
            this.tbGaugeCenter.TabIndex = 30;
            this.tbGaugeCenter.Text = "500";
            this.tbGaugeCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGaugeMax
            // 
            this.tbGaugeMax.Location = new System.Drawing.Point(89, 19);
            this.tbGaugeMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbGaugeMax.Name = "tbGaugeMax";
            this.tbGaugeMax.Size = new System.Drawing.Size(36, 20);
            this.tbGaugeMax.TabIndex = 31;
            this.tbGaugeMax.Text = "600";
            this.tbGaugeMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAmpGauge
            // 
            this.btAmpGauge.BackColor = System.Drawing.Color.Coral;
            this.btAmpGauge.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAmpGauge.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btAmpGauge.Location = new System.Drawing.Point(2, 42);
            this.btAmpGauge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btAmpGauge.Name = "btAmpGauge";
            this.btAmpGauge.Size = new System.Drawing.Size(126, 30);
            this.btAmpGauge.TabIndex = 15;
            this.btAmpGauge.Text = "▶ Set [AMP GAUGE]";
            this.btAmpGauge.UseVisualStyleBackColor = false;
            this.btAmpGauge.Click += new System.EventHandler(this.btAmpGauge_Click);
            // 
            // tbGaugeMin
            // 
            this.tbGaugeMin.Location = new System.Drawing.Point(6, 19);
            this.tbGaugeMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbGaugeMin.Name = "tbGaugeMin";
            this.tbGaugeMin.Size = new System.Drawing.Size(36, 20);
            this.tbGaugeMin.TabIndex = 29;
            this.tbGaugeMin.Text = "400";
            this.tbGaugeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.panel1.Location = new System.Drawing.Point(5, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 74);
            this.panel1.TabIndex = 26;
            // 
            // btAmpGain
            // 
            this.btAmpGain.BackColor = System.Drawing.Color.Chocolate;
            this.btAmpGain.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAmpGain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btAmpGain.Location = new System.Drawing.Point(2, 42);
            this.btAmpGain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btAmpGain.Name = "btAmpGain";
            this.btAmpGain.Size = new System.Drawing.Size(126, 30);
            this.btAmpGain.TabIndex = 14;
            this.btAmpGain.Text = "▶ Set [AMP GAIN ]";
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
            this.cbMediumSupport.Location = new System.Drawing.Point(37, 47);
            this.cbMediumSupport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbMediumSupport.Name = "cbMediumSupport";
            this.cbMediumSupport.Size = new System.Drawing.Size(40, 20);
            this.cbMediumSupport.TabIndex = 6;
            this.cbMediumSupport.Text = "M";
            this.cbMediumSupport.UseVisualStyleBackColor = false;
            // 
            // tbAmpGainM
            // 
            this.tbAmpGainM.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmpGainM.Location = new System.Drawing.Point(46, 19);
            this.tbAmpGainM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbAmpGainM.Name = "tbAmpGainM";
            this.tbAmpGainM.Size = new System.Drawing.Size(36, 20);
            this.tbAmpGainM.TabIndex = 27;
            this.tbAmpGainM.Text = "70";
            this.tbAmpGainM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAmpGainF
            // 
            this.tbAmpGainF.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmpGainF.Location = new System.Drawing.Point(87, 19);
            this.tbAmpGainF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbAmpGainF.Name = "tbAmpGainF";
            this.tbAmpGainF.Size = new System.Drawing.Size(36, 20);
            this.tbAmpGainF.TabIndex = 28;
            this.tbAmpGainF.Text = "50";
            this.tbAmpGainF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAmpGainC
            // 
            this.tbAmpGainC.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmpGainC.Location = new System.Drawing.Point(5, 19);
            this.tbAmpGainC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbAmpGainC.Name = "tbAmpGainC";
            this.tbAmpGainC.Size = new System.Drawing.Size(36, 20);
            this.tbAmpGainC.TabIndex = 26;
            this.tbAmpGainC.Text = "70";
            this.tbAmpGainC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "[Coarse]  [Medium]  [Fine]";
            // 
            // rtbMtCnt
            // 
            this.rtbMtCnt.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMtCnt.Location = new System.Drawing.Point(7, 75);
            this.rtbMtCnt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbMtCnt.Multiline = false;
            this.rtbMtCnt.Name = "rtbMtCnt";
            this.rtbMtCnt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbMtCnt.Size = new System.Drawing.Size(63, 22);
            this.rtbMtCnt.TabIndex = 18;
            this.rtbMtCnt.Text = "0";
            // 
            // rtbUZP
            // 
            this.rtbUZP.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbUZP.Location = new System.Drawing.Point(6, 47);
            this.rtbUZP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbUZP.Multiline = false;
            this.rtbUZP.Name = "rtbUZP";
            this.rtbUZP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbUZP.Size = new System.Drawing.Size(63, 22);
            this.rtbUZP.TabIndex = 18;
            this.rtbUZP.Text = "0";
            // 
            // btMtCnt
            // 
            this.btMtCnt.BackColor = System.Drawing.Color.ForestGreen;
            this.btMtCnt.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMtCnt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btMtCnt.Location = new System.Drawing.Point(73, 72);
            this.btMtCnt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btMtCnt.Name = "btMtCnt";
            this.btMtCnt.Size = new System.Drawing.Size(65, 28);
            this.btMtCnt.TabIndex = 15;
            this.btMtCnt.Text = "▶ Set MT";
            this.btMtCnt.UseVisualStyleBackColor = false;
            this.btMtCnt.Click += new System.EventHandler(this.btMtCnt_Click);
            // 
            // btUZP
            // 
            this.btUZP.BackColor = System.Drawing.Color.DarkViolet;
            this.btUZP.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUZP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btUZP.Location = new System.Drawing.Point(73, 43);
            this.btUZP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btUZP.Name = "btUZP";
            this.btUZP.Size = new System.Drawing.Size(65, 28);
            this.btUZP.TabIndex = 15;
            this.btUZP.Text = "▶ Set UZP";
            this.btUZP.UseVisualStyleBackColor = false;
            this.btUZP.Click += new System.EventHandler(this.btUZP_Click);
            // 
            // tbVal8
            // 
            this.tbVal8.Location = new System.Drawing.Point(50, 32);
            this.tbVal8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbVal8.Name = "tbVal8";
            this.tbVal8.Size = new System.Drawing.Size(40, 21);
            this.tbVal8.TabIndex = 30;
            this.tbVal8.Text = "0";
            this.tbVal8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbVal9
            // 
            this.tbVal9.Location = new System.Drawing.Point(94, 32);
            this.tbVal9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbVal9.Name = "tbVal9";
            this.tbVal9.Size = new System.Drawing.Size(40, 21);
            this.tbVal9.TabIndex = 29;
            this.tbVal9.Text = "0";
            this.tbVal9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btCustomDebug
            // 
            this.btCustomDebug.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCustomDebug.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCustomDebug.ForeColor = System.Drawing.Color.Lime;
            this.btCustomDebug.Location = new System.Drawing.Point(7, 55);
            this.btCustomDebug.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btCustomDebug.Name = "btCustomDebug";
            this.btCustomDebug.Size = new System.Drawing.Size(128, 28);
            this.btCustomDebug.TabIndex = 15;
            this.btCustomDebug.Text = "▶ Set Flash Value";
            this.btCustomDebug.UseVisualStyleBackColor = false;
            this.btCustomDebug.Click += new System.EventHandler(this.btCustomDebug_Click);
            // 
            // tbVal7
            // 
            this.tbVal7.Location = new System.Drawing.Point(5, 32);
            this.tbVal7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbVal7.Name = "tbVal7";
            this.tbVal7.Size = new System.Drawing.Size(40, 21);
            this.tbVal7.TabIndex = 28;
            this.tbVal7.Text = "0";
            this.tbVal7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "[Val 7]     [Val 8]     [Val 9]";
            // 
            // btResortRead
            // 
            this.btResortRead.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btResortRead.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResortRead.ForeColor = System.Drawing.Color.Blue;
            this.btResortRead.Location = new System.Drawing.Point(1, 18);
            this.btResortRead.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btResortRead.Name = "btResortRead";
            this.btResortRead.Size = new System.Drawing.Size(46, 50);
            this.btResortRead.TabIndex = 21;
            this.btResortRead.Text = "✔ Read";
            this.btResortRead.UseVisualStyleBackColor = false;
            this.btResortRead.Click += new System.EventHandler(this.btResort_Click);
            // 
            // gbModeSelection
            // 
            this.gbModeSelection.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gbModeSelection.Controls.Add(this.btMode_Medium);
            this.gbModeSelection.Controls.Add(this.tMode_Coarse);
            this.gbModeSelection.Controls.Add(this.btMode_Fine);
            this.gbModeSelection.Enabled = false;
            this.gbModeSelection.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModeSelection.Location = new System.Drawing.Point(520, 357);
            this.gbModeSelection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbModeSelection.Name = "gbModeSelection";
            this.gbModeSelection.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbModeSelection.Size = new System.Drawing.Size(140, 62);
            this.gbModeSelection.TabIndex = 26;
            this.gbModeSelection.TabStop = false;
            this.gbModeSelection.Text = "Mode Selection";
            // 
            // btMode_Medium
            // 
            this.btMode_Medium.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMode_Medium.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btMode_Medium.Location = new System.Drawing.Point(49, 15);
            this.btMode_Medium.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btMode_Medium.Name = "btMode_Medium";
            this.btMode_Medium.Size = new System.Drawing.Size(42, 42);
            this.btMode_Medium.TabIndex = 0;
            this.btMode_Medium.Text = "▶ [M]";
            this.btMode_Medium.UseVisualStyleBackColor = true;
            this.btMode_Medium.Click += new System.EventHandler(this.btMode_Medium_Click);
            // 
            // tMode_Coarse
            // 
            this.tMode_Coarse.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMode_Coarse.ForeColor = System.Drawing.Color.Green;
            this.tMode_Coarse.Location = new System.Drawing.Point(4, 15);
            this.tMode_Coarse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tMode_Coarse.Name = "tMode_Coarse";
            this.tMode_Coarse.Size = new System.Drawing.Size(42, 42);
            this.tMode_Coarse.TabIndex = 0;
            this.tMode_Coarse.Text = "▶ [C]";
            this.tMode_Coarse.UseVisualStyleBackColor = true;
            this.tMode_Coarse.Click += new System.EventHandler(this.tMode_Coarse_Click);
            // 
            // btMode_Fine
            // 
            this.btMode_Fine.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMode_Fine.ForeColor = System.Drawing.Color.Crimson;
            this.btMode_Fine.Location = new System.Drawing.Point(95, 15);
            this.btMode_Fine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btMode_Fine.Name = "btMode_Fine";
            this.btMode_Fine.Size = new System.Drawing.Size(42, 42);
            this.btMode_Fine.TabIndex = 0;
            this.btMode_Fine.Text = "▶ [F]";
            this.btMode_Fine.UseVisualStyleBackColor = true;
            this.btMode_Fine.Click += new System.EventHandler(this.btMode_Fine_Click);
            // 
            // btReadAngleInfo
            // 
            this.btReadAngleInfo.BackColor = System.Drawing.Color.Yellow;
            this.btReadAngleInfo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReadAngleInfo.ForeColor = System.Drawing.Color.Black;
            this.btReadAngleInfo.Location = new System.Drawing.Point(2, 93);
            this.btReadAngleInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btReadAngleInfo.Name = "btReadAngleInfo";
            this.btReadAngleInfo.Size = new System.Drawing.Size(68, 40);
            this.btReadAngleInfo.TabIndex = 20;
            this.btReadAngleInfo.Text = "Angle";
            this.btReadAngleInfo.UseVisualStyleBackColor = false;
            this.btReadAngleInfo.Click += new System.EventHandler(this.btReadAngleInfo_Click);
            // 
            // gbAsciiCmd
            // 
            this.gbAsciiCmd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbAsciiCmd.Controls.Add(this.cbHeader);
            this.gbAsciiCmd.Controls.Add(this.btWrAscii);
            this.gbAsciiCmd.Controls.Add(this.AsciiText);
            this.gbAsciiCmd.Enabled = false;
            this.gbAsciiCmd.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAsciiCmd.Location = new System.Drawing.Point(520, 421);
            this.gbAsciiCmd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbAsciiCmd.Name = "gbAsciiCmd";
            this.gbAsciiCmd.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbAsciiCmd.Size = new System.Drawing.Size(140, 67);
            this.gbAsciiCmd.TabIndex = 25;
            this.gbAsciiCmd.TabStop = false;
            this.gbAsciiCmd.Text = "Send ASCII Commnad";
            // 
            // cbHeader
            // 
            this.cbHeader.AutoSize = true;
            this.cbHeader.Checked = true;
            this.cbHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHeader.Location = new System.Drawing.Point(38, 16);
            this.cbHeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.btWrAscii.Location = new System.Drawing.Point(75, 35);
            this.btWrAscii.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btWrAscii.Name = "btWrAscii";
            this.btWrAscii.Size = new System.Drawing.Size(59, 28);
            this.btWrAscii.TabIndex = 0;
            this.btWrAscii.Text = "Send";
            this.btWrAscii.UseVisualStyleBackColor = false;
            this.btWrAscii.Click += new System.EventHandler(this.btWrAscii_Click);
            // 
            // AsciiText
            // 
            this.AsciiText.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsciiText.Location = new System.Drawing.Point(5, 37);
            this.AsciiText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AsciiText.Multiline = false;
            this.AsciiText.Name = "AsciiText";
            this.AsciiText.Size = new System.Drawing.Size(63, 24);
            this.AsciiText.TabIndex = 13;
            this.AsciiText.Text = "";
            // 
            // gbReadBulk
            // 
            this.gbReadBulk.BackColor = System.Drawing.Color.RosyBrown;
            this.gbReadBulk.Controls.Add(this.cbListOfBundle);
            this.gbReadBulk.Controls.Add(this.btCalcDbgData);
            this.gbReadBulk.Controls.Add(this.btReadAmp);
            this.gbReadBulk.Enabled = false;
            this.gbReadBulk.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReadBulk.Location = new System.Drawing.Point(662, 412);
            this.gbReadBulk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbReadBulk.Name = "gbReadBulk";
            this.gbReadBulk.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbReadBulk.Size = new System.Drawing.Size(140, 73);
            this.gbReadBulk.TabIndex = 26;
            this.gbReadBulk.TabStop = false;
            this.gbReadBulk.Text = "Read Bulk (Fixed Mem)";
            // 
            // cbListOfBundle
            // 
            this.cbListOfBundle.FormattingEnabled = true;
            this.cbListOfBundle.Items.AddRange(new object[] {
            "1",
            "2",
            "4"});
            this.cbListOfBundle.Location = new System.Drawing.Point(8, 17);
            this.cbListOfBundle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbListOfBundle.Name = "cbListOfBundle";
            this.cbListOfBundle.Size = new System.Drawing.Size(123, 23);
            this.cbListOfBundle.TabIndex = 23;
            // 
            // btCalcDbgData
            // 
            this.btCalcDbgData.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcDbgData.ForeColor = System.Drawing.Color.Crimson;
            this.btCalcDbgData.Location = new System.Drawing.Point(72, 42);
            this.btCalcDbgData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btCalcDbgData.Name = "btCalcDbgData";
            this.btCalcDbgData.Size = new System.Drawing.Size(60, 28);
            this.btCalcDbgData.TabIndex = 22;
            this.btCalcDbgData.Text = "Calc σ";
            this.btCalcDbgData.UseVisualStyleBackColor = true;
            this.btCalcDbgData.Click += new System.EventHandler(this.btCalcDbgData_Click);
            // 
            // btReadAmp
            // 
            this.btReadAmp.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReadAmp.ForeColor = System.Drawing.Color.Blue;
            this.btReadAmp.Location = new System.Drawing.Point(7, 42);
            this.btReadAmp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btReadAmp.Name = "btReadAmp";
            this.btReadAmp.Size = new System.Drawing.Size(60, 28);
            this.btReadAmp.TabIndex = 22;
            this.btReadAmp.Text = "Copy";
            this.btReadAmp.UseVisualStyleBackColor = true;
            this.btReadAmp.Click += new System.EventHandler(this.btReadDbgData_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox4.Controls.Add(this.btClearFls);
            this.groupBox4.Controls.Add(this.btRecodeFls);
            this.groupBox4.Controls.Add(this.tbVal8);
            this.groupBox4.Controls.Add(this.tbVal9);
            this.groupBox4.Controls.Add(this.tbVal7);
            this.groupBox4.Controls.Add(this.btCustomDebug);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(818, 20);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(140, 119);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Debug Flash Value";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightPink;
            this.groupBox6.Controls.Add(this.cbListOfFlag);
            this.groupBox6.Controls.Add(this.btDisFlag);
            this.groupBox6.Controls.Add(this.btEnaFlag);
            this.groupBox6.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(818, 145);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(140, 73);
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
            this.cbListOfFlag.Location = new System.Drawing.Point(8, 17);
            this.cbListOfFlag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbListOfFlag.Name = "cbListOfFlag";
            this.cbListOfFlag.Size = new System.Drawing.Size(123, 23);
            this.cbListOfFlag.TabIndex = 1;
            // 
            // gbControls
            // 
            this.gbControls.BackColor = System.Drawing.Color.Gold;
            this.gbControls.Controls.Add(this.btModeSSC);
            this.gbControls.Controls.Add(this.btReadInfo);
            this.gbControls.Controls.Add(this.btReboot);
            this.gbControls.Controls.Add(this.btReadAngleInfo);
            this.gbControls.Controls.Add(this.btRomUpgrade);
            this.gbControls.Controls.Add(this.btMeasureCAA);
            this.gbControls.Enabled = false;
            this.gbControls.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControls.ForeColor = System.Drawing.Color.MediumBlue;
            this.gbControls.Location = new System.Drawing.Point(520, 490);
            this.gbControls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbControls.Name = "gbControls";
            this.gbControls.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbControls.Size = new System.Drawing.Size(140, 135);
            this.gbControls.TabIndex = 32;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // btReboot
            // 
            this.btReboot.BackColor = System.Drawing.Color.DarkOrange;
            this.btReboot.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReboot.ForeColor = System.Drawing.Color.White;
            this.btReboot.Location = new System.Drawing.Point(2, 54);
            this.btReboot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btReboot.Name = "btReboot";
            this.btReboot.Size = new System.Drawing.Size(68, 40);
            this.btReboot.TabIndex = 20;
            this.btReboot.Text = "Reboot";
            this.btReboot.UseVisualStyleBackColor = false;
            this.btReboot.Click += new System.EventHandler(this.btReboot_Click);
            // 
            // btMeasureCAA
            // 
            this.btMeasureCAA.BackColor = System.Drawing.Color.GreenYellow;
            this.btMeasureCAA.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMeasureCAA.ForeColor = System.Drawing.Color.Black;
            this.btMeasureCAA.Location = new System.Drawing.Point(2, 16);
            this.btMeasureCAA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btMeasureCAA.Name = "btMeasureCAA";
            this.btMeasureCAA.Size = new System.Drawing.Size(68, 40);
            this.btMeasureCAA.TabIndex = 0;
            this.btMeasureCAA.Text = "Calc CAA";
            this.btMeasureCAA.UseVisualStyleBackColor = false;
            this.btMeasureCAA.Click += new System.EventHandler(this.btMeasureCAA_Click);
            // 
            // gbAngleData
            // 
            this.gbAngleData.BackColor = System.Drawing.Color.YellowGreen;
            this.gbAngleData.Controls.Add(this.label3);
            this.gbAngleData.Controls.Add(this.cbRebootOpt);
            this.gbAngleData.Controls.Add(this.tbPeriod);
            this.gbAngleData.Controls.Add(this.pnAngleOpt);
            this.gbAngleData.Controls.Add(this.btStopAngleData);
            this.gbAngleData.Controls.Add(this.btAngleData);
            this.gbAngleData.Enabled = false;
            this.gbAngleData.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAngleData.Location = new System.Drawing.Point(662, 21);
            this.gbAngleData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbAngleData.Name = "gbAngleData";
            this.gbAngleData.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbAngleData.Size = new System.Drawing.Size(140, 142);
            this.gbAngleData.TabIndex = 26;
            this.gbAngleData.TabStop = false;
            this.gbAngleData.Text = "Angle data (reboot)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Period (ms)";
            // 
            // cbRebootOpt
            // 
            this.cbRebootOpt.AutoSize = true;
            this.cbRebootOpt.Location = new System.Drawing.Point(9, 16);
            this.cbRebootOpt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbRebootOpt.Name = "cbRebootOpt";
            this.cbRebootOpt.Size = new System.Drawing.Size(120, 19);
            this.cbRebootOpt.TabIndex = 28;
            this.cbRebootOpt.Text = "Need Reboot ( 5sec )";
            this.cbRebootOpt.UseVisualStyleBackColor = true;
            this.cbRebootOpt.CheckedChanged += new System.EventHandler(this.cbRebootOption_CheckedChanged);
            // 
            // tbPeriod
            // 
            this.tbPeriod.Location = new System.Drawing.Point(80, 83);
            this.tbPeriod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPeriod.Name = "tbPeriod";
            this.tbPeriod.Size = new System.Drawing.Size(50, 20);
            this.tbPeriod.TabIndex = 25;
            this.tbPeriod.Text = "500";
            this.tbPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnAngleOpt
            // 
            this.pnAngleOpt.BackColor = System.Drawing.Color.LightGreen;
            this.pnAngleOpt.Controls.Add(this.cbNewL);
            this.pnAngleOpt.Controls.Add(this.tbDegree);
            this.pnAngleOpt.Controls.Add(this.cbAngleDiff);
            this.pnAngleOpt.Enabled = false;
            this.pnAngleOpt.Location = new System.Drawing.Point(7, 35);
            this.pnAngleOpt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnAngleOpt.Name = "pnAngleOpt";
            this.pnAngleOpt.Size = new System.Drawing.Size(128, 44);
            this.pnAngleOpt.TabIndex = 27;
            // 
            // cbNewL
            // 
            this.cbNewL.AutoSize = true;
            this.cbNewL.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNewL.Location = new System.Drawing.Point(6, 24);
            this.cbNewL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbNewL.Name = "cbNewL";
            this.cbNewL.Size = new System.Drawing.Size(66, 19);
            this.cbNewL.TabIndex = 24;
            this.cbNewL.Text = "New Line";
            this.cbNewL.UseVisualStyleBackColor = true;
            // 
            // tbDegree
            // 
            this.tbDegree.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDegree.Location = new System.Drawing.Point(78, 4);
            this.tbDegree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDegree.Name = "tbDegree";
            this.tbDegree.Size = new System.Drawing.Size(42, 21);
            this.tbDegree.TabIndex = 25;
            // 
            // cbAngleDiff
            // 
            this.cbAngleDiff.AutoSize = true;
            this.cbAngleDiff.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAngleDiff.Location = new System.Drawing.Point(6, 4);
            this.cbAngleDiff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.btStopAngleData.Location = new System.Drawing.Point(73, 107);
            this.btStopAngleData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btStopAngleData.Name = "btStopAngleData";
            this.btStopAngleData.Size = new System.Drawing.Size(64, 31);
            this.btStopAngleData.TabIndex = 23;
            this.btStopAngleData.Text = "■ Stop";
            this.btStopAngleData.UseVisualStyleBackColor = true;
            this.btStopAngleData.Click += new System.EventHandler(this.btStopAngleData_Click);
            // 
            // btAngleData
            // 
            this.btAngleData.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAngleData.ForeColor = System.Drawing.Color.Crimson;
            this.btAngleData.Location = new System.Drawing.Point(4, 107);
            this.btAngleData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btAngleData.Name = "btAngleData";
            this.btAngleData.Size = new System.Drawing.Size(64, 31);
            this.btAngleData.TabIndex = 23;
            this.btAngleData.Text = "▶ Start";
            this.btAngleData.UseVisualStyleBackColor = true;
            this.btAngleData.Click += new System.EventHandler(this.btAngleData_Click);
            // 
            // gbServoMotor
            // 
            this.gbServoMotor.BackColor = System.Drawing.Color.Khaki;
            this.gbServoMotor.Controls.Add(this.btIncrease);
            this.gbServoMotor.Controls.Add(this.rtbPulse);
            this.gbServoMotor.Controls.Add(this.btDecrease);
            this.gbServoMotor.Controls.Add(this.lbServoState);
            this.gbServoMotor.Controls.Add(this.btServoOnOff);
            this.gbServoMotor.Controls.Add(this.btAutoVerify);
            this.gbServoMotor.Controls.Add(this.btAutoMeasure);
            this.gbServoMotor.Controls.Add(this.rtbEziPort);
            this.gbServoMotor.Enabled = false;
            this.gbServoMotor.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbServoMotor.Location = new System.Drawing.Point(662, 165);
            this.gbServoMotor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbServoMotor.Name = "gbServoMotor";
            this.gbServoMotor.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbServoMotor.Size = new System.Drawing.Size(140, 168);
            this.gbServoMotor.TabIndex = 38;
            this.gbServoMotor.TabStop = false;
            this.gbServoMotor.Text = "Servo Motor Control";
            // 
            // btIncrease
            // 
            this.btIncrease.Location = new System.Drawing.Point(94, 133);
            this.btIncrease.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btIncrease.Name = "btIncrease";
            this.btIncrease.Size = new System.Drawing.Size(38, 32);
            this.btIncrease.TabIndex = 40;
            this.btIncrease.Text = "▶";
            this.btIncrease.UseVisualStyleBackColor = true;
            this.btIncrease.Click += new System.EventHandler(this.btIncrease_Click);
            // 
            // rtbPulse
            // 
            this.rtbPulse.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPulse.Location = new System.Drawing.Point(48, 136);
            this.rtbPulse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbPulse.Multiline = false;
            this.rtbPulse.Name = "rtbPulse";
            this.rtbPulse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbPulse.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbPulse.Size = new System.Drawing.Size(41, 26);
            this.rtbPulse.TabIndex = 39;
            this.rtbPulse.Text = "1000";
            // 
            // btDecrease
            // 
            this.btDecrease.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDecrease.Location = new System.Drawing.Point(6, 133);
            this.btDecrease.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btDecrease.Name = "btDecrease";
            this.btDecrease.Size = new System.Drawing.Size(38, 32);
            this.btDecrease.TabIndex = 38;
            this.btDecrease.Text = "◀";
            this.btDecrease.UseVisualStyleBackColor = true;
            this.btDecrease.Click += new System.EventHandler(this.btDecrease_Click);
            // 
            // lbServoState
            // 
            this.lbServoState.AutoSize = true;
            this.lbServoState.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServoState.ForeColor = System.Drawing.Color.Gray;
            this.lbServoState.Location = new System.Drawing.Point(4, 22);
            this.lbServoState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbServoState.Name = "lbServoState";
            this.lbServoState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbServoState.Size = new System.Drawing.Size(83, 14);
            this.lbServoState.TabIndex = 37;
            this.lbServoState.Text = "STATE : [ OFF ]";
            // 
            // btServoOnOff
            // 
            this.btServoOnOff.BackColor = System.Drawing.Color.Cornsilk;
            this.btServoOnOff.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServoOnOff.ForeColor = System.Drawing.Color.Green;
            this.btServoOnOff.Location = new System.Drawing.Point(5, 43);
            this.btServoOnOff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btServoOnOff.Name = "btServoOnOff";
            this.btServoOnOff.Size = new System.Drawing.Size(128, 30);
            this.btServoOnOff.TabIndex = 34;
            this.btServoOnOff.Text = "    ▶ Servo On";
            this.btServoOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btServoOnOff.UseVisualStyleBackColor = false;
            this.btServoOnOff.Click += new System.EventHandler(this.btServoOnOff_Click);
            // 
            // btAutoVerify
            // 
            this.btAutoVerify.BackColor = System.Drawing.Color.Cornsilk;
            this.btAutoVerify.Enabled = false;
            this.btAutoVerify.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAutoVerify.ForeColor = System.Drawing.Color.Blue;
            this.btAutoVerify.Location = new System.Drawing.Point(5, 104);
            this.btAutoVerify.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btAutoVerify.Name = "btAutoVerify";
            this.btAutoVerify.Size = new System.Drawing.Size(128, 30);
            this.btAutoVerify.TabIndex = 34;
            this.btAutoVerify.Text = "   🛠 Auto Verify";
            this.btAutoVerify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAutoVerify.UseVisualStyleBackColor = false;
            this.btAutoVerify.Click += new System.EventHandler(this.btAutoVerify_Click);
            // 
            // btAutoMeasure
            // 
            this.btAutoMeasure.BackColor = System.Drawing.Color.Cornsilk;
            this.btAutoMeasure.Enabled = false;
            this.btAutoMeasure.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAutoMeasure.ForeColor = System.Drawing.Color.Crimson;
            this.btAutoMeasure.Location = new System.Drawing.Point(5, 74);
            this.btAutoMeasure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btAutoMeasure.Name = "btAutoMeasure";
            this.btAutoMeasure.Size = new System.Drawing.Size(128, 30);
            this.btAutoMeasure.TabIndex = 34;
            this.btAutoMeasure.Text = "   📊 Auto Measure";
            this.btAutoMeasure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAutoMeasure.UseVisualStyleBackColor = false;
            this.btAutoMeasure.Click += new System.EventHandler(this.btAutoMeasure_Click);
            // 
            // rtbEziPort
            // 
            this.rtbEziPort.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEziPort.Location = new System.Drawing.Point(96, 17);
            this.rtbEziPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbEziPort.Multiline = false;
            this.rtbEziPort.Name = "rtbEziPort";
            this.rtbEziPort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbEziPort.Size = new System.Drawing.Size(32, 24);
            this.rtbEziPort.TabIndex = 35;
            this.rtbEziPort.Text = "9";
            // 
            // gbResort
            // 
            this.gbResort.BackColor = System.Drawing.Color.Bisque;
            this.gbResort.Controls.Add(this.btResortRecord);
            this.gbResort.Controls.Add(this.btResortClean);
            this.gbResort.Controls.Add(this.btResortRead);
            this.gbResort.Enabled = false;
            this.gbResort.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResort.Location = new System.Drawing.Point(662, 335);
            this.gbResort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbResort.Name = "gbResort";
            this.gbResort.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbResort.Size = new System.Drawing.Size(140, 72);
            this.gbResort.TabIndex = 27;
            this.gbResort.TabStop = false;
            this.gbResort.Text = "RESORT (Log)";
            // 
            // btResortRecord
            // 
            this.btResortRecord.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResortRecord.ForeColor = System.Drawing.Color.Crimson;
            this.btResortRecord.Location = new System.Drawing.Point(46, 18);
            this.btResortRecord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btResortRecord.Name = "btResortRecord";
            this.btResortRecord.Size = new System.Drawing.Size(46, 50);
            this.btResortRecord.TabIndex = 22;
            this.btResortRecord.Text = "   ●    Rec";
            this.btResortRecord.UseVisualStyleBackColor = true;
            this.btResortRecord.Click += new System.EventHandler(this.btResortRecord_Click);
            // 
            // btResortClean
            // 
            this.btResortClean.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResortClean.ForeColor = System.Drawing.Color.Black;
            this.btResortClean.Location = new System.Drawing.Point(92, 18);
            this.btResortClean.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btResortClean.Name = "btResortClean";
            this.btResortClean.Size = new System.Drawing.Size(46, 50);
            this.btResortClean.TabIndex = 0;
            this.btResortClean.Text = "❌ Clean";
            this.btResortClean.UseVisualStyleBackColor = true;
            this.btResortClean.Click += new System.EventHandler(this.btResortClean_Click);
            // 
            // btReadStorage
            // 
            this.btReadStorage.BackColor = System.Drawing.Color.DarkKhaki;
            this.btReadStorage.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReadStorage.ForeColor = System.Drawing.Color.Blue;
            this.btReadStorage.Location = new System.Drawing.Point(818, 224);
            this.btReadStorage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btReadStorage.Name = "btReadStorage";
            this.btReadStorage.Size = new System.Drawing.Size(140, 33);
            this.btReadStorage.TabIndex = 21;
            this.btReadStorage.Text = "Read Storage";
            this.btReadStorage.UseVisualStyleBackColor = false;
            this.btReadStorage.Click += new System.EventHandler(this.btReadStorage_Click);
            // 
            // btMTRomUpdate
            // 
            this.btMTRomUpdate.BackColor = System.Drawing.Color.Silver;
            this.btMTRomUpdate.Enabled = false;
            this.btMTRomUpdate.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMTRomUpdate.ForeColor = System.Drawing.Color.Blue;
            this.btMTRomUpdate.Location = new System.Drawing.Point(818, 262);
            this.btMTRomUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btMTRomUpdate.Name = "btMTRomUpdate";
            this.btMTRomUpdate.Size = new System.Drawing.Size(140, 33);
            this.btMTRomUpdate.TabIndex = 0;
            this.btMTRomUpdate.Text = "SubRom Update";
            this.btMTRomUpdate.UseVisualStyleBackColor = false;
            this.btMTRomUpdate.Click += new System.EventHandler(this.btMTRomUpdate_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.lbSaveScreen);
            this.panel2.Controls.Add(this.lbCleanScreen);
            this.panel2.Controls.Add(this.cbHex);
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 606);
            this.panel2.TabIndex = 31;
            // 
            // lbSaveScreen
            // 
            this.lbSaveScreen.AutoSize = true;
            this.lbSaveScreen.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbSaveScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSaveScreen.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaveScreen.ForeColor = System.Drawing.Color.Firebrick;
            this.lbSaveScreen.Location = new System.Drawing.Point(261, 585);
            this.lbSaveScreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSaveScreen.Name = "lbSaveScreen";
            this.lbSaveScreen.Size = new System.Drawing.Size(125, 18);
            this.lbSaveScreen.TabIndex = 39;
            this.lbSaveScreen.Text = "        ▶▶  Save Screen  ";
            this.lbSaveScreen.Click += new System.EventHandler(this.lbSaveScreen_Click);
            // 
            // lbCleanScreen
            // 
            this.lbCleanScreen.AutoSize = true;
            this.lbCleanScreen.BackColor = System.Drawing.Color.LightCoral;
            this.lbCleanScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCleanScreen.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCleanScreen.Location = new System.Drawing.Point(387, 585);
            this.lbCleanScreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCleanScreen.Name = "lbCleanScreen";
            this.lbCleanScreen.Size = new System.Drawing.Size(128, 18);
            this.lbCleanScreen.TabIndex = 40;
            this.lbCleanScreen.Text = "      X  Clean Screen         ";
            this.lbCleanScreen.Click += new System.EventHandler(this.lbCleanScreen_Click);
            // 
            // tsPortStatus
            // 
            this.tsPortStatus.ActiveLinkColor = System.Drawing.Color.White;
            this.tsPortStatus.BackColor = System.Drawing.Color.SlateGray;
            this.tsPortStatus.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsPortStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsPortStatus.Name = "tsPortStatus";
            this.tsPortStatus.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsPortStatus.Size = new System.Drawing.Size(148, 17);
            this.tsPortStatus.Text = "      Not Connected               ";
            this.tsPortStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsDate
            // 
            this.tsDate.ActiveLinkColor = System.Drawing.Color.White;
            this.tsDate.BackColor = System.Drawing.Color.SlateGray;
            this.tsDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsDate.Name = "tsDate";
            this.tsDate.Padding = new System.Windows.Forms.Padding(240, 0, 160, 0);
            this.tsDate.Size = new System.Drawing.Size(510, 17);
            this.tsDate.Text = "MM-dd HH:mm:ss       ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDate,
            this.tsPortStatus,
            this.tsNull1,
            this.tsNull2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 626);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(809, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsNull1
            // 
            this.tsNull1.ActiveLinkColor = System.Drawing.Color.White;
            this.tsNull1.BackColor = System.Drawing.Color.SlateGray;
            this.tsNull1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsNull1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsNull1.Name = "tsNull1";
            this.tsNull1.Padding = new System.Windows.Forms.Padding(55, 0, 50, 0);
            this.tsNull1.Size = new System.Drawing.Size(133, 17);
            this.tsNull1.Text = "       ";
            this.tsNull1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsNull2
            // 
            this.tsNull2.ActiveLinkColor = System.Drawing.Color.White;
            this.tsNull2.BackColor = System.Drawing.Color.SlateGray;
            this.tsNull2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsNull2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsNull2.Name = "tsNull2";
            this.tsNull2.Padding = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.tsNull2.Size = new System.Drawing.Size(148, 16);
            this.tsNull2.Text = "       ";
            this.tsNull2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(809, 648);
            this.Controls.Add(this.gbAsciiCmd);
            this.Controls.Add(this.gbAngleData);
            this.Controls.Add(this.gbReadBulk);
            this.Controls.Add(this.gbResort);
            this.Controls.Add(this.gbModeSelection);
            this.Controls.Add(this.gbServoMotor);
            this.Controls.Add(this.btMTRomUpdate);
            this.Controls.Add(this.btReadStorage);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.gbCmdLists);
            this.Controls.Add(this.rtDispAscii);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbCmdItems);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbPort);
            this.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.gbModeSelection.ResumeLayout(false);
            this.gbAsciiCmd.ResumeLayout(false);
            this.gbAsciiCmd.PerformLayout();
            this.gbReadBulk.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.gbControls.ResumeLayout(false);
            this.gbAngleData.ResumeLayout(false);
            this.gbAngleData.PerformLayout();
            this.pnAngleOpt.ResumeLayout(false);
            this.pnAngleOpt.PerformLayout();
            this.gbServoMotor.ResumeLayout(false);
            this.gbServoMotor.PerformLayout();
            this.gbResort.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btReadAmp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btUZP;
        private System.Windows.Forms.RichTextBox rtbUZP;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox gbReadBulk;
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
        private System.Windows.Forms.GroupBox gbAngleData;
        private System.Windows.Forms.Button btStopAngleData;
        private System.Windows.Forms.Button btAngleData;
        private System.Windows.Forms.CheckBox cbAngleDiff;
        private System.Windows.Forms.TextBox tbDegree;
        private System.Windows.Forms.CheckBox cbNewL;
        private System.Windows.Forms.Button btModeSSC;
        private System.Windows.Forms.GroupBox gbResort;
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
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.CheckBox cbDtrEnable;
        private System.Windows.Forms.Button btReadStorage;
        private System.Windows.Forms.GroupBox gbModeSelection;
        private System.Windows.Forms.Button btMode_Medium;
        private System.Windows.Forms.Button tMode_Coarse;
        private System.Windows.Forms.Button btMode_Fine;
        private System.Windows.Forms.Panel pnAngleOpt;
        private System.Windows.Forms.CheckBox cbRebootOpt;
        private System.Windows.Forms.Button btReboot;
        private System.Windows.Forms.Button btMeasureCAA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPeriod;
        private System.Windows.Forms.GroupBox gbAsciiCmd;
        private System.Windows.Forms.CheckBox cbHeader;
        private System.Windows.Forms.Button btWrAscii;
        private System.Windows.Forms.RichTextBox AsciiText;
        private System.Windows.Forms.Button btReadAngleInfo;
        private System.Windows.Forms.Button btServoOnOff;
        private System.Windows.Forms.Button btAutoMeasure;
        private System.Windows.Forms.RichTextBox rtbEziPort;
        private System.Windows.Forms.Label lbServoState;
        private System.Windows.Forms.GroupBox gbServoMotor;
        private System.Windows.Forms.RichTextBox rtbPulse;
        private System.Windows.Forms.Button btDecrease;
        private System.Windows.Forms.Button btIncrease;
        private System.Windows.Forms.Button btAutoVerify;
        private System.Windows.Forms.Label lbCleanScreen;
        private System.Windows.Forms.Label lbSaveScreen;
        private System.Windows.Forms.ToolStripStatusLabel tsPortStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsDate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsNull1;
        private System.Windows.Forms.ToolStripStatusLabel tsNull2;
        private System.Windows.Forms.RichTextBox rtbMtCnt;
        private System.Windows.Forms.Button btMtCnt;
    }
}

