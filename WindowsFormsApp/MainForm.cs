
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using EziMotorApps;
using TextBox = System.Windows.Forms.TextBox;
using Button = System.Windows.Forms.Button;
using Label = System.Windows.Forms.Label;

namespace UartTester
{
    public delegate void serialPortRead(string str1);
    delegate void fnSetTextBoxCallback(int contents);
    //DateTime currentTime;
    
    partial class fmMain : System.Windows.Forms.Form
    {
        string VERSION = "1.6.4.14";
        int UNDEFINED = 0xFFFF1;
        private int incorrectAttempts = 0;        
        System.Windows.Forms.Timer timer_date;
        System.Windows.Forms.Timer timer_angleStr;
        System.Windows.Forms.Timer timer_angleDat;

        const int BUFF_LOOP = 40;
        const int BUFF_LEN = 1024 * 2;
        const int MaxCount = 1024 * 1024;
        const int MaxScrollCount = 60;
        const int MaxNewLineAngleData = 500;
        const int AngleStringTimer = 5000;
        const int AngleDataTimer = 5000;

        byte[][] _array = new byte[BUFF_LOOP][];
        private StringBuilder receivedData = new StringBuilder();
        private const string pws = "@7638";
        byte[] arrChangeMode = { 0xa4, 0xb4, 0x03, 0x01, 0x01, 0x02 };
        byte[] arrAngleStr = { 0xa4, 0xb4, 0x07, 0xF0, 0x05, 0x00, 0x00, 0x00, 0x00, 0xF5 };
        byte[] arrAngleDat = { 0xa4, 0xb4, 0x07, 0xF0, 0x06, 0x00, 0x00, 0x00, 0x00, 0xF6 };    
        byte[] arrReboot = { 0xa4, 0xb4, 0x03, 0x0C, 0x20, 0x2C };

        EziMotorService EziSvc;
        EziMotorControl EziCntl;

        int ulCurCount;
        int ulOpenState;
        int ulscrollCount;
        int ulCmdIdx;
        int inIdx = 0;
        int outIdx = 0;
        const int MaxOfArray = 29;
        bool fDataReceive;
        int slAnglePrev;
        int gulNewLine;
        int gulNewLineDisp;


        byte[,] arrCmd = new byte[MaxOfArray, 10]
        {
            {0xA4, 0xB4, 0x03, 0x02, 0x01, 0x03, 0x00, 0x00, 0x00, 0x00},   /*  R_INFORM  */            
            {0xA4, 0xB4, 0x07, 0x0C, 0x11, 0x00, 0x00, 0x00, 0x00, 0x1D},   /*  W_EA(0)  */
            {0xA4, 0xB4, 0x07, 0x0C, 0x11, 0x00, 0x00, 0x00, 0x01, 0x1E},   /*  W_EA(1)  */
            {0xA4, 0xB4, 0x04, 0x09, 0x02, 0x00, 0x0B, 0x00, 0x00, 0x00},   /*  W_Dir(0) cw  */
            {0xA4, 0xB4, 0x04, 0x09, 0x02, 0x01, 0x0C, 0x00, 0x00, 0x00},   /*  W_Dir(1) ccw  */            
            {0xA4, 0xB4, 0x07, 0x0B, 0x11, 0x00, 0x00, 0x00, 0x00, 0x1C},   /*  W_Proto(0) SSI  */
            {0xA4, 0xB4, 0x07, 0x0B, 0x11, 0x00, 0x00, 0x00, 0x01, 0x1D},   /*  W_Proto(1) BiSS  */            
            {0xA4, 0xB4, 0x07, 0x0B, 0x12, 0x00, 0x00, 0x00, 0x00, 0x1D},   /*  W_Bits(0) 17bists  */
            {0xA4, 0xB4, 0x07, 0x0B, 0x12, 0x00, 0x00, 0x00, 0x01, 0x1E},   /*  W_Bits(1) 18bists  */
            {0xA4, 0xB4, 0x07, 0x0B, 0x12, 0x00, 0x00, 0x00, 0x02, 0x1F},   /*  W_Bits(2) 19bists  */
            {0xA4, 0xB4, 0x07, 0x0B, 0x12, 0x00, 0x00, 0x00, 0x03, 0x20},   /*  W_Bits(3) 20bists  */
            {0xA4, 0xB4, 0x07, 0x0B, 0x12, 0x00, 0x00, 0x00, 0x04, 0x21},   /*  W_Bits(4) 21bists  */            
            {0xA4, 0xB4, 0x07, 0x0C, 0x13, 0x00, 0x00, 0x00, 0x00, 0x1F},   /*  W_Compense(0)  */
            {0xA4, 0xB4, 0x07, 0x0C, 0x13, 0x00, 0x00, 0x00, 0x01, 0x20},   /*  W_Compense(1)  */
            {0xA4, 0xB4, 0x07, 0x0C, 0x13, 0x00, 0x00, 0x00, 0x02, 0x21},   /*  W_Compense(2)  */
            {0xA4, 0xB4, 0x03, 0xF0, 0x10, 0x00, 0x00, 0x00, 0x02, 0x21},   /*  D_CONFIG_CLEAR */
            {0xA4, 0xB4, 0x03, 0xF0, 0x11, 0x01, 0x00, 0x00, 0x02, 0x21},   /*  D_USER_CLEAR  */
            {0xA4, 0xB4, 0x03, 0x08, 0x01, 0x09, 0x00, 0x00, 0x00, 0x00},   /*  R_BIT(BuiltInTest) */
            {0xA4, 0xB4, 0x03, 0x02, 0x06, 0x08, 0x00, 0x00, 0x00, 0x00},   /*  R_모델그룹  */
            {0xA4, 0xB4, 0x03, 0x02, 0x07, 0x09, 0x00, 0x00, 0x00, 0x00},   /*  R_EA */
            {0xA4, 0xB4, 0x03, 0x02, 0x08, 0x0A, 0x00, 0x00, 0x00, 0x00},   /*  R_Compense  */
            {0xA4, 0xB4, 0x03, 0xF0, 0xF3, 0xE3, 0x00, 0x00, 0x00, 0x00},   /*  W_RESORT_STUB_1  */   
            {0xA4, 0xB4, 0x03, 0xF0, 0xF4, 0xE4, 0x00, 0x00, 0x00, 0x00},   /*  W_RESORT_STUB_2  */   
            {0xA4, 0xB4, 0x03, 0xF0, 0xF5, 0xE5, 0x00, 0x00, 0x00, 0x00},   /*  W_RESORT_STUB_3  */   
            {0xA4, 0xB4, 0x03, 0xF0, 0xF6, 0xE6, 0x00, 0x00, 0x00, 0x00},   /*  W_RESORT_STUB_4  */   
            {0xA4, 0xB4, 0x03, 0x02, 0x02, 0x04, 0x00, 0x00, 0x00, 0x00},   /*  R_INFORM_NAME  */   
            {0xA4, 0xB4, 0x03, 0x02, 0x03, 0x05, 0x00, 0x00, 0x00, 0x00},   /*  R_INFORM_VERSION  */   
            {0xA4, 0xB4, 0x03, 0x02, 0x04, 0x06, 0x00, 0x00, 0x00, 0x00},   /*  R_INFORM_SERIAL  */   
            {0xA4, 0xB4, 0x03, 0x02, 0x05, 0x07, 0x00, 0x00, 0x00, 0x00},   /*  R_INFORM_RES  */   
        };

        BlockingCollection<string> _dataQueue = new BlockingCollection<string>();
        string[] portCollect = System.IO.Ports.SerialPort.GetPortNames();
        private static Mutex mutex = new Mutex();
        private MenuStrip menuStrip;


        public void MainForm()
        {
            // MenuStrip 초기화
            menuStrip = new MenuStrip();

            // 메뉴 항목 생성
            //var fileMenuItem = new ToolStripMenuItem("File");
            //var editMenuItem = new ToolStripMenuItem("Edit");
            var helpMenuItem = new ToolStripMenuItem("Help");

            // 서브 메뉴 항목 추가 (File -> Open, Exit)
            var openMenuItem = new ToolStripMenuItem("Open");

            var aboutMenuItem = new ToolStripMenuItem("About");
            aboutMenuItem.Click += AboutMenuItem_Click;

            var adminMenuItem = new ToolStripMenuItem("Admin");
            adminMenuItem.Click += AdminMenuItem_Click;

            // "Edit" 메뉴에 서브 항목 추가
            // "Help" 메뉴에 서브 항목 추가
            helpMenuItem.DropDownItems.Add(aboutMenuItem);
            helpMenuItem.DropDownItems.Add(adminMenuItem);

            // 메뉴에 항목을 추가
            //menuStrip.Items.Add(fileMenuItem);
            //menuStrip.Items.Add(editMenuItem);
            menuStrip.Items.Add(helpMenuItem);

            // 메뉴를 폼에 추가
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);

            // 폼 속성 설정
            this.Text = "WinForms Menu Example";
            this.Size = new System.Drawing.Size(400, 300);
        }
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("For developing Apps thru UART : " + VERSION);
            sb.AppendLine("xxx@globaldefense.co.kr");

            MessageBox.Show(sb.ToString());
        }
        private void AdminMenuItem_Click(object sender, EventArgs e)
        {
            string enteredPassword = PromptForPassword();
            if (enteredPassword == pws)
            {
                //MessageBox.Show("Password Correct! Access Granted.");
                incorrectAttempts = 0;  // 비밀번호가 맞으면 틀린 횟수 리셋
                fmMain.ActiveForm.AutoSize = true;
            }
            else
            {
                incorrectAttempts++;
                if (incorrectAttempts < 5)
                {
                    MessageBox.Show($"Incorrect Password! {incorrectAttempts} Failed");
                }
                else
                {
                    MessageBox.Show("Exceeded limited attempts");
                    // 추가적인 처리 (예: 메뉴 비활성화, 프로그램 종료 등) 가능
                }
            }
        }
#if true
        private string PromptForPassword(string title = "인증 필요", string message = "비밀번호를 입력하세요")
        {
            using (var dialog = new PasswordDialog(title, message))
            {
                return dialog.ShowDialog() == DialogResult.OK ? dialog.Password : string.Empty;
            }
        }

        public sealed class PasswordDialog : Form
        {
            public string Password => _passwordBox.Text;

            private readonly TextBox _passwordBox;
            private readonly Button _okButton;
            private readonly Button _cancelButton;

            public PasswordDialog(string title = "Enter Password", string message = "비밀번호를 입력하세요")
            {
                // ── Form 설정 ──────────────────────────────────────────
                Text = title;
                FormBorderStyle = FormBorderStyle.FixedDialog;
                StartPosition = FormStartPosition.CenterParent;
                ClientSize = new Size(360, 160);
                MaximizeBox = false;
                MinimizeBox = false;
                ShowInTaskbar = false;
                Padding = new Padding(20);

                // ── 안내 레이블 ────────────────────────────────────────
                var label = new System.Windows.Forms.Label
                {
                    Text = message,
                    AutoSize = false,
                    Dock = DockStyle.Top,
                    Height = 30,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Segoe UI", 9.5f)
                };

                // ── 비밀번호 입력 ──────────────────────────────────────
                _passwordBox = new System.Windows.Forms.TextBox
                {
                    PasswordChar = '●',
                    Dock = DockStyle.Top,
                    Height = 30,
                    Font = new Font("Segoe UI", 10f),
                    Margin = new Padding(0, 0, 0, 10)
                };

                // ── 버튼 패널 ──────────────────────────────────────────
                _okButton = new System.Windows.Forms.Button
                {
                    Text = "확인",
                    DialogResult = DialogResult.OK,
                    Width = 90,
                    Height = 32,
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Right
                };

                _cancelButton = new System.Windows.Forms.Button
                {
                    Text = "취소",
                    DialogResult = DialogResult.Cancel,
                    Width = 90,
                    Height = 32,
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Right
                };

                var buttonPanel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Bottom,
                    Height = 45,
                    FlowDirection = FlowDirection.RightToLeft,
                    Padding = new Padding(0, 6, 0, 0)
                };

                buttonPanel.Controls.AddRange(new Control[] { _cancelButton, _okButton });

                // ── 레이아웃 조립 ──────────────────────────────────────
                var contentPanel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(0, 5, 0, 0) };
                contentPanel.Controls.Add(_passwordBox);
                contentPanel.Controls.Add(label);

                Controls.Add(contentPanel);
                Controls.Add(buttonPanel);

                // ── 키보드 & 기본 버튼 ────────────────────────────────
                AcceptButton = _okButton;
                CancelButton = _cancelButton;

                // Enter 키 → 확인
                _passwordBox.KeyDown += (_, e) =>
                {
                    if (e.KeyCode == Keys.Enter) { DialogResult = DialogResult.OK; Close(); }
                };
            }

            // 폼이 열릴 때 비밀번호 입력란에 포커스
            protected override void OnShown(EventArgs e)
            {
                base.OnShown(e);
                _passwordBox.Focus();
            }
        }
#else
        private string PromptForPassword()
        {
            // 사용자로부터 비밀번호를 입력받는 InputBox를 사용 (간단한 사용자 입력 처리)
            using (var inputForm = new Form())
            {
                inputForm.Text = "Enter Password";
                var passwordBox = new System.Windows.Forms.TextBox { PasswordChar = '*', Dock = DockStyle.Fill };
                var okButton = new System.Windows.Forms.Button { Text = "OK", Dock = DockStyle.Bottom };
                inputForm.Controls.Add(passwordBox);
                inputForm.Controls.Add(okButton);
                okButton.Click += (sender, e) => inputForm.DialogResult = DialogResult.OK;

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    return passwordBox.Text;
                }
                return string.Empty;  // 취소 버튼 눌렀을 때 빈 문자열 반환
            }
        }
#endif

        public fmMain()
        {
            MainForm();

            ulOpenState = 0;
            ulCurCount = 0;
            InitializeComponent();

            this.Text = this.Text + " "+ VERSION;

            Thread thread1 = new Thread(ProcessData_Thread);
            thread1.IsBackground = true;
            thread1.Start();

            EziSvc = new EziMotorService(0);
            EziCntl = new EziMotorControl(EziSvc, SerialPort);

            for (int i = 0; i < BUFF_LOOP; i++)
            {
                _array[i] = new byte[BUFF_LEN];
            }


            foreach (string str in portCollect)
            {
                Console.WriteLine(str);
                PortsEntry.Items.Add(str);
            }

            cbListOfCmd.SelectedIndex = 0;
            cbListOfBundle.SelectedIndex = 0;
            cbListOfFlag.SelectedIndex = 0;
            cbBaudRate.SelectedIndex = 3;

            timer_date = new System.Windows.Forms.Timer();
            timer_date.Interval = 1000;
            timer_date.Tick += DisplayTime;
            timer_date.Start();

            timer_angleStr = new System.Windows.Forms.Timer();
            timer_angleStr.Interval = AngleStringTimer;
            timer_angleStr.Tick += Timer_AngleString;
            
            timer_angleDat = new System.Windows.Forms.Timer();
            timer_angleDat.Interval = AngleDataTimer;
            timer_angleDat.Tick += Timer_AngleData;
        }

        private async void DisplayTime(object sender, EventArgs e)
        {
            tsDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        void WritetoDisp(int size)
        {
            int count = 0 ;
            int ulRefresh = 0;

            if (ulOpenState == 0)
            {
                ulCurCount = 0;
                return;
            }

            if (cbHex.Checked)
            {
                for (int i = 0; i < size; i++)
                {
                    receivedData.Append(string.Format("{0:x2} ", _array[outIdx][i]));
                }
                ulCurCount += size;
                ulscrollCount += size;
                if (ulCurCount > MaxCount)
                {
                    ulCurCount = size;
                    //rtDispAscii.Text = null;
                    rtDispAscii.Clear();
                }                
                rtDispAscii.AppendText(receivedData.ToString());
                if (ulscrollCount > MaxScrollCount)
                {
                    rtDispAscii.ScrollToCaret();
                    ulscrollCount = 0;
                }
                receivedData.Clear();
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    if (_array[outIdx][i] == 10)
                    {
                        ulRefresh = 1;
                    }
                    else if ((32 > _array[outIdx][i]) || (_array[outIdx][i] > 126))
                    {
                        continue;
                    }
                    count++;
                    receivedData.Append(string.Format("{0:c}", (char)_array[outIdx][i]));
                }
                ulCurCount += count;
                ulscrollCount += count;
                if (ulCurCount > MaxCount)
                {
                    ulCurCount = count;
                    //rtDispAscii.Text = null;
                    rtDispAscii.Clear();
                }
                if (count != 0)
                {
                    rtDispAscii.AppendText(receivedData.ToString());
                    if ((ulscrollCount > MaxScrollCount) || (ulRefresh == 1))
                    {
                        rtDispAscii.ScrollToCaret();
                        ulscrollCount = 0;
                    }                    
                }
                receivedData.Clear();
            }
            outIdx++;
            outIdx = outIdx % BUFF_LOOP;
        }

        void ProcessData_Thread()
        {
            int value;


            foreach (var data in _dataQueue.GetConsumingEnumerable())
            {
                int.TryParse(data, out value);
                //WritetoDisp(value);

                mutex.WaitOne();
                this.Invoke(new fnSetTextBoxCallback(WritetoDisp), new object[] { value });
                mutex.ReleaseMutex();
                //this.Invoke(new fnSetTextBoxCallback(fmMain.WritetoDisp(array,value)));
                //Console.WriteLine("Processing data in worker thread...");
                //Console.WriteLine(data);
            }

        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Console.WriteLine("Event happen !!");
            int size,read_size,remaining_size;
            string str;
            fDataReceive = true;

            try
            {
                if (ulOpenState == 0)
                {
                    fDataReceive = false;
                    return;
                }

                size = SerialPort.BytesToRead;

                remaining_size = size;    
                while (remaining_size > 0)
                {
                    read_size = Math.Min(remaining_size, BUFF_LEN);
                    remaining_size = remaining_size - read_size;
                    SerialPort.Read(_array[inIdx], 0, read_size);

                    inIdx++;
                    inIdx = inIdx % BUFF_LOOP;

                    str = read_size.ToString();

                    _dataQueue.Add(str);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            fDataReceive = false;
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            btOpen.Enabled = false;

            try
            {
                if (ulOpenState == 0)   // To Open
                {
                    if (cbDtrEnable.Checked == true)
                    {
                        SerialPort.DtrEnable = true;
                    }
                    else
                    {
                        SerialPort.DtrEnable = false;
                    }

                    if (SerialPort.PortName != "Empty")
                    {
                        ulOpenState = 1;
                        switch(cbBaudRate.SelectedIndex)
                        {
                            case 0:
                                SerialPort.BaudRate = 9600;
                                break;
                            case 1:
                                SerialPort.BaudRate = 19200;
                                break;
                            case 2:
                                SerialPort.BaudRate = 38400;
                                break;
                            case 3:
                                SerialPort.BaudRate = 115200;
                                break;
                        }

                        SerialPort.Open();
                        btOpen.Text = "■ Disconn.";
                        tsPortStatus.Text = "      Connected  :  " + SerialPort.BaudRate + " bps";
                        tsPortStatus.BackColor = System.Drawing.Color.RoyalBlue;
                        tsDate.BackColor = System.Drawing.Color.RoyalBlue;
                        gbPort.BackColor = System.Drawing.Color.RoyalBlue;
                        btOpen.BackColor = System.Drawing.Color.Gold;


                        gbCmdLists.Enabled = true;
                        gbDevTools.Enabled = true;
                        gbCmdItems.Enabled = true;
                        gbFW_Upgrade.Enabled = true;
                        btModeSSC.Enabled = true;

                        btRefresh.Enabled = false;
                        cbBaudRate.Enabled = false;
                        PortsEntry.Enabled = false;
                        

                        cbListOfCmd.SelectedIndex = 0;
                        ulCmdIdx = 0;
                        SerialNumber.Text = "";

                        byte[] array = { 0xa4, 0xb4, 0x03, 0x01, 0x01, 0x02 };     // Mode change Req
                        SerialPort.Write(array, 0, array.Length);
                    }
                }
                else    // To Close
                {
                    ulOpenState = 0;

                    //SerialPort.DtrEnable = false;
                    SerialPort.DiscardInBuffer();
                    SerialPort.DiscardOutBuffer();

                    while (fDataReceive == true)
                    {
                        Thread.Sleep(10);
                    }

                    if (timer_angleStr.Enabled)
                    {
                        timer_angleStr.Stop();
                    }
                    if (timer_angleDat.Enabled)
                    {
                        this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
                        timer_angleDat.Stop();
                    }

                    SerialPort.Close();
                       
                    btOpen.Text = "▶ Connect";
                    tsPortStatus.Text = "Not Connected            ";
                    tsPortStatus.BackColor = System.Drawing.Color.SlateGray;
                    tsDate.BackColor = System.Drawing.Color.SlateGray;
                    gbPort.BackColor = System.Drawing.Color.SlateGray;  //RoyalBlue
                    btOpen.BackColor = System.Drawing.Color.Wheat;

                    gbCmdLists.Enabled = false;
                    gbDevTools.Enabled = false;
                    gbCmdItems.Enabled = false;
                    gbFW_Upgrade.Enabled = false;
                    btModeSSC.Enabled = false;

                    PortsEntry.Enabled = true;
                    btRefresh.Enabled = true;
                    cbBaudRate.Enabled = true;

                    /* buffer chain initialize */
                    BlockingCollection<string> _dataQueue = new BlockingCollection<string>();
                    inIdx = 0;
                    outIdx = 0;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            btOpen.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((!SerialPort.IsOpen) && (PortsEntry.SelectedItem != null))
            {
                SerialPort.PortName = PortsEntry.SelectedItem.ToString();
            }
        }

        private void btClearAscii_Click(object sender, EventArgs e)
        {
            //rtDispAscii.Text = null;
            rtDispAscii.Clear();
        }

        private void btReadAngleInfo_Click(object sender, EventArgs e)   // btChangeMode
        {
            byte[] array = { 0xa4, 0xb4, 0x03, 0xF0, 0x14, 0x04 };     // Mode UART
            SerialPort.Write(array, 0, array.Length);
        }

        private void btModeSSC_Click(object sender, EventArgs e)   // btChangeMode
        {
            byte[] array = { 0xa4, 0xb4, 0x03, 0x01, 0x02, 0x03 };     // Mode SSC
            SerialPort.Write(array, 0, array.Length);
        }

        private void WriteDebugFlag(int flag)
        {
            byte[] array = { 0xa4, 0xb4, 0x07, 0xF0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            
            // DBG_PRINT Ena
            int flagIdx = 0, idx = 0;
            byte chksum = 0;
            flagIdx = int.Parse(cbListOfFlag.Text);

            byte[] buf1 = BitConverter.GetBytes(flagIdx);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buf1);
            }
            chksum += (byte)0xF0;
            if (flag == 1)
            {
                chksum += (byte)0x03;
                array[4] = (byte)0x03;

            }
            else
            {
                chksum += (byte)0x04;
                array[4] = (byte)0x04;
            }

            idx = 5;
            for (int i = 0; i < 4; i++)
            {
                chksum += buf1[i];
                array[idx++] = buf1[i];
            }

            array[idx] = chksum;

            SerialPort.Write(array, 0, array.Length);
        }


        private void btEnaFlag_Click(object sender, EventArgs e) //btEnaDebug
        {
            WriteDebugFlag(1);
        }
        private void btDisFlag_Click(object sender, EventArgs e)  //btDisDebug
        {
            WriteDebugFlag(0);
        }
        private void btSerialNo_W_Click(object sender, EventArgs e)
        {
            int idx = 0;
            byte serial_len, len;
            byte[] array = new byte[40];
            byte checksum = 0;
            byte[] serialNo = new byte[20];

            serialNo = System.Text.Encoding.Default.GetBytes(SerialNumber.Text);
            serial_len = (byte)SerialNumber.Text.Length;

            array[idx++] = (byte)0xa4;
            array[idx++] = (byte)0xb4;
            len = (byte)(serial_len + 3);
            array[idx++] = (byte)len;
            array[idx++] = (byte)0x0C;
            array[idx++] = (byte)0x12;
            checksum = 0;
            checksum += (byte)0x0C;
            checksum += (byte)0x12;
            for (int i = 0; i < serial_len; i++)
            {
                checksum += serialNo[i];
                array[idx++] = (serialNo[i]);
            }
            array[idx++] = checksum;
            SerialPort.Write(array, 0, len + 3);
        }

        private void btWrAscii_Click(object sender, EventArgs e)
        {
            if(cbHeader.Checked == true)
            {
                int idx = 0;
                byte ascii_len, len;
                byte[] array = new byte[45];
                byte checksum = 0;
                byte[] ascii = new byte[40];

                ascii = System.Text.Encoding.Default.GetBytes(AsciiText.Text);
                ascii_len = (byte)AsciiText.Text.Length;

                array[idx++] = (byte)0xa4;
                array[idx++] = (byte)0xb4;
                len = (byte)(ascii_len + 3);
                array[idx++] = (byte)len;
                array[idx++] = (byte)0xF1;
                array[idx++] = (byte)0x01;
                checksum = 0;
                checksum += (byte)0xF1;
                checksum += (byte)0x01;
                for (int i = 0; i < ascii_len; i++)
                {
                    checksum += ascii[i];
                    array[idx++] = (ascii[i]);
                }
                array[idx++] = checksum;
                SerialPort.Write(array, 0, len + 3);
            }
            else
            {
                byte[] array = new byte[60];
                array = System.Text.Encoding.Default.GetBytes(AsciiText.Text);
                SerialPort.Write(array, 0, array.Length);
            }
        }

        private void Infor_R_Click(object sender, EventArgs e)
        {
            byte[] array2 = { 0xa4, 0xb4, 0x03, 0x02, 0x01, 0x03 };      // Information Req
            SerialPort.Write(array2, 0, array2.Length);
        }

        private void btMeasureCAA_Click(object sender, EventArgs e)
        {
            byte[] array2 = { 0xa4, 0xb4, 0x03, 0xF0, 0x13, 0x3 };
            SerialPort.Write(array2, 0, array2.Length);
        }

        private void btMTRomUpdate_Click(object sender, EventArgs e)
        {
            string strICD = "$Efw";
            int idx, remaining;
            uint u32CsTx = 0, u32CsRx;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // CSV 파일 필터 설정
                //openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"; // 필터를 CSV 파일만 선택 가능하게 설정
                openFileDialog.Title = "Select *.bin Rom file";

                // 파일 선택 시
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    try
                    {
                        FileInfo fileInfo = new FileInfo(filePath);
                        long fileSize = fileInfo.Length;
                        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                        {
                            byte[] buffer = new byte[fileSize];
                            fs.Read(buffer, 0, (int)fileSize);

                            for (int i = 0; i < fileSize; i++)
                            {
                                u32CsTx += buffer[i];
                            }

                            byte[] array1 = System.Text.Encoding.UTF8.GetBytes(strICD);
                            SerialPort.Write(array1, 0, array1.Length);

                            // send size
                            byte[] array2 = BitConverter.GetBytes((int)fileSize);
                            Array.Reverse(array2);
                            SerialPort.Write(array2, 0, 4);

                            byte[] array3 = BitConverter.GetBytes((int)u32CsTx);
                            Array.Reverse(array3);
                            SerialPort.Write(array3, 0, 4);


                            // 한 바이트씩 처리
                            idx = 0;
                            remaining = (int)fileSize;
                            while (true)
                            {
                                if (remaining > 500)
                                {
                                    SerialPort.Write(buffer, idx, 500);
                                    idx += 500;
                                    remaining -= 500;
                                }
                                else
                                {
                                    SerialPort.Write(buffer, idx, remaining);
                                    break;
                                }
                                Thread.Sleep(10);
                            }
                        }                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error happen during opening file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    
                }
            }


        }


        private void btRomUpgrade_Click(object sender, EventArgs e)
        {
            byte[] array2 = { 0xa4, 0xb4, 0x03, 0x0a, 0x01, 0x0b };      // ROM download
            SerialPort.Write(array2, 0, array2.Length);

            // Stop Background service 
            if (timer_angleStr.Enabled)
            {
                timer_angleStr.Stop();
            }
            if (timer_angleDat.Enabled)
            {
                this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
                timer_angleDat.Stop();
            }

            try
            {
                if (ulOpenState == 1)
                {
                    ulOpenState = 0;

                    Thread.Sleep(10);

                    //SerialPort.DtrEnable = false;
                    SerialPort.DiscardInBuffer();
                    SerialPort.DiscardOutBuffer();

                    Thread.Sleep(1000);

                    SerialPort.Close();

                    btOpen.Text = "▷ Connect";
                    tsPortStatus.Text = "Not Connected";
                    tsPortStatus.BackColor = System.Drawing.Color.SlateGray;
                    tsDate.BackColor = System.Drawing.Color.SlateGray;
                    gbPort.BackColor = System.Drawing.Color.SlateGray;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            gbCmdLists.Enabled = false;
            gbDevTools.Enabled = false;
            gbCmdItems.Enabled = false;

            gbFW_Upgrade.Enabled = false;
            btModeSSC.Enabled = false;

            PortsEntry.Enabled = true;
            btRefresh.Enabled = true;
        }

        private void bBits_R_Click(object sender, EventArgs e)
        {
            //byte[] array = { 0xa4, 0xb4, 0x03, 0x0B, 0x02, 0x0D };     // Protocol Bits Read 17 : 00, 18 : 01, 19 : 02
            byte[] array = { 0xa4, 0xb4, 0x03, 0x09, 0x01, 0x0a };     // Direction Read 0x09 , 0x01
            SerialPort.Write(array, 0, array.Length);
        }
        private void bBit_W_Click(object sender, EventArgs e)
        {
            // Protocol Bits Write 17 : 00, 18 : 01, 19 : 02
            //byte[] array = { 0xa4, 0xb4, 0x07, 0x0B, 0x12, 0x00, 0x00, 0x00, 0x02, 0x1F };
            byte[] array = { 0xa4, 0xb4, 0x04, 0x09, 0x02, 0x00, 0x0b };  // Direction Write 0x09, 0x02 , 0x00(default) or 0x01(inv)
            SerialPort.Write(array, 0, array.Length);
        }

        private void bEA_R_Click(object sender, EventArgs e)
        {
            byte[] array = { 0xa4, 0xb4, 0x03, 0x02, 0x07, 0x09 };      // EA Req
            SerialPort.Write(array, 0, array.Length);
        }

        private void bEA_W_Click(object sender, EventArgs e)
        {
            //byte[] array = { 0xa4, 0xb4, 0x07, 0x0C, 0x11, 0x00, 0x00, 0x00, 0x00, 0x1D };      // EA Write
            byte[] array = { 0xa4, 0xb4, 0x04, 0x09, 0x02, 0x01, 0x0C };  // Direction Write 0x09, 0x02 , 0x00(default) or 0x01(inv)
            SerialPort.Write(array, 0, array.Length);
        }

        private void bModelGroupR_Click(object sender, EventArgs e)
        {
            byte[] array = { 0xa4, 0xb4, 0x03, 0x02, 0x06, 0x08 };      // Model Group Req
            SerialPort.Write(array, 0, array.Length);
        }

        private void bProtocol_R_Click(object sender, EventArgs e)
        {
            byte[] array = { 0xa4, 0xb4, 0x03, 0x0B, 0x01, 0x0C };    // Protocol Type Read
            SerialPort.Write(array, 0, array.Length);
        }

        private void Proto_W_Click(object sender, EventArgs e)
        {
            byte[] array = { 0xa4, 0xb4, 0x07, 0x0B, 0x11, 0x00, 0x00, 0x00, 0x01, 0x1d };    // Protocol Type Write 0x00 SSI, 0x01 BiSS-C
            SerialPort.Write(array, 0, array.Length);
        }
        private void btRecodeFls_Click(object sender, EventArgs e)
        {
            byte[] array = { 0xa4, 0xb4, 0x03, 0xF0, 0x01, 0xF1 };                               // DBG_PRINT Dis
            SerialPort.Write(array, 0, array.Length);
        }

        private void btClearFls_Click(object sender, EventArgs e)
        {
            byte[] array = { 0xa4, 0xb4, 0x03, 0xF0, 0x02, 0xF2 };                               // DBG_PRINT Dis
            SerialPort.Write(array, 0, array.Length);
        }

        private void setIdxAndSize(int ulIdx, int ulSize, byte[] array)
        {
            byte chksum = 0;
            byte[] buf1 = BitConverter.GetBytes(ulIdx);
            byte[] buf2 = BitConverter.GetBytes(ulSize);
            int idx = 0;

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buf1);
                Array.Reverse(buf2);
            }
            chksum += (byte)0xF0;
            chksum += (byte)0x06;

            idx = 5;
            for (int i = 0; i < 4; i++)
            {
                chksum += buf1[i];
                array[idx++] = buf1[i];
            }
            for (int i = 0; i < 4; i++)
            {
                chksum += buf2[i];
                array[idx++] = buf2[i];
            }
            array[idx] = chksum;
        }
#if false
        private void btSendVal_Click(object sender, EventArgs e)
        {
            byte[] array = { 0xa4, 0xb4, 0xb, 0xF0, 0x06, 0x00,0x00,0x00,0x00,0x00, 0x00, 0x00, 0x00,0x00 };
            // check if it is number;
            string input2 = tbVal.Text;
            if (int.TryParse(input, out int num1))
            {
                if (int.TryParse(input2, out int num2))
                {
                    setIdxAndSize(num1,num2,array);
                    SerialPort.Write(array, 0, array.Length);
                }
            }            
        }
#endif

        private void cbListOfCmd_SelectedIndexChanged(object sender, EventArgs e)
        {
            ulCmdIdx = cbListOfCmd.SelectedIndex;
        }

        private void btCmdWr_Click(object sender, EventArgs e)
        {
            byte length;
            byte[] array = {0xa4, 0xb4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            length = arrCmd[ulCmdIdx, 2];

            for (int i = 2; i <= length+2; i++)
            {
                array[i] = arrCmd[ulCmdIdx, i];
            }
            SerialPort.Write(array, 0, length + 3);
        }

        void ModeChanged(int value)        
        {
            //rtDispAscii.Text = null;
            rtDispAscii.Clear();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            PortsEntry.SelectedItem = null;
            portCollect = System.IO.Ports.SerialPort.GetPortNames();
            PortsEntry.Items.Clear();
            foreach (string str in portCollect)
            {
                PortsEntry.Items.Add(str);
            }
            SerialPort.PortName = "Empty";
        }

        private void btReadInfo_Click(object sender, EventArgs e)
        {
            byte[] array1 = { 0xa4, 0xb4, 0x03, 0x01, 0x01, 0x02 };     // Mode UART
            SerialPort.Write(array1, 0, array1.Length);
            
            Thread.Sleep(10);

            byte[] array = { 0xA4, 0xB4, 0x03, 0xF0, 0x07, 0xF7 };
            SerialPort.Write(array, 0, array.Length);
        }


        private void cbHex_CheckedChanged(object sender, EventArgs e)
        {
            int value;
            value = 0;
            this.Invoke(new fnSetTextBoxCallback(ModeChanged), new object[] { value });
        }

        private void btCalcDbgData_Click(object sender, EventArgs e)
        {
            byte[] array = { 0xA4, 0xB4, 0x03, 0xF0, 0x09, 0xF9 };
            SerialPort.Write(array, 0, array.Length);
        }

        private void btReadDbgData_Click(object sender, EventArgs e)
        {
            int size;         
            const int READ_SIZE = 8000 * 4;
            string str1;
            int bundle;

            byte[] ampdata = new byte[READ_SIZE];
            int byteRead = 0;
            int actual_size;

            str1 = cbListOfBundle.Text;
            bundle = int.Parse(str1);
#if true
            this.SerialPort.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);

            byte[] arrayM = { 0xa4, 0xb4, 0x03, 0x01, 0x01, 0x02 };     // Mode change Req
            SerialPort.Write(arrayM, 0, arrayM.Length);

            byte[] array = { 0xA4, 0xB4, 0x03, 0xF0, 0x08, 0xF8 };
            SerialPort.Write(array, 0, array.Length);


            while (byteRead < READ_SIZE)
            {
                size = SerialPort.BytesToRead;
                byte[] temp = new byte[size];

                actual_size = SerialPort.Read(temp, 0, size);

                Array.Copy(temp, 0, ampdata, byteRead, actual_size);

                byteRead += actual_size;                
            }


            string directoryPath = @"D:\Data\Data_Bulk";
            string fileName = "Bulk_" + str1 + "_" + DateTime.Now.ToString("MMddHHmmss") + ".csv";
            string filePath = Path.Combine(directoryPath, fileName);

            int newline;
            newline = 0;
            using (StreamWriter fstream = new StreamWriter(filePath))
            {
                
               // 바이트를 4바이트씩 처리
                for (int i = 0; i < ampdata.Length; i += 4)
                {
                    // 4바이트씩 읽어서 integer로 변환
                    int value = BitConverter.ToInt32(ampdata, i);

                    // integer 값을 string으로 변환하여 CSV 파일에 기록
                    fstream.Write(value.ToString());
                    newline++;
                    newline %= bundle;
                    if(newline != 0 )
                    {
                        fstream.Write(",");
                    }
                    else
                    {
                        fstream.Write("\r\n");
                    }
                }
            }
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            MessageBox.Show($"Read successfully [ fixed size : {READ_SIZE} ]");
#endif
        }

        private void AngleString(object sender, EventArgs e)
        {
            int period;
            if (int.TryParse(tbPeriod.Text, out period))
            {
                timer_angleStr.Interval = period;
                timer_angleStr.Start();
            }
            else
            {
                MessageBox.Show("Input Number !!");
            }
        }
        private void btAngleData_Click(object sender, EventArgs e)
        {
            if (cbRebootOpt.Checked == true)
            {
                slAnglePrev = UNDEFINED;
                gulNewLine = 0;
                timer_angleDat.Start();
            }
            else
            {
                AngleString(sender, e);
            }
            cbRebootOpt.Enabled = false;
            pnAngleOpt.Enabled = false;
        }

        private void StopAngleString(object sender, EventArgs e)
        {
            if (timer_angleStr.Enabled)
            {
                timer_angleStr.Stop();
            }
        }

        private void btStopAngleData_Click(object sender, EventArgs e)
        {
            if (cbRebootOpt.Checked == true)
            {
                if (timer_angleDat.Enabled)
                {
                    timer_angleDat.Stop();
                }
            }
            else
            {
                StopAngleString(sender, e);
            }
            cbRebootOpt.Enabled = true;
            if (cbRebootOpt.Checked == true)
            {
                pnAngleOpt.Enabled = true;
            }
        }

        // Running angle string printing request
        private async void Timer_AngleString(object sender, EventArgs e)
        {
            SerialPort.Write(arrChangeMode, 0, arrChangeMode.Length);
            
            SerialPort.Write(arrAngleStr, 0, arrAngleStr.Length);

            await System.Threading.Tasks.Task.Delay(1000);

            //SerialPort.Write(arrReboot, 0, arrReboot.Length);          

        }
        private async void Timer_AngleData(object sender, EventArgs e)
        {
            byte[] arrayAngle = new byte[4];
            float f32Angle;
            int byteRead = 0, actual_size = 0, slAngle;
            int size;
            bool fFail = false;
            
            byte[] tempBuf = new byte[64];

            SerialPort.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            SerialPort.Write(arrChangeMode, 0, arrChangeMode.Length);

            await System.Threading.Tasks.Task.Delay(500);
            while (true)
            {
                size = SerialPort.BytesToRead;
                if (size > 0)
                {
                    if (size < tempBuf.Length)
                        SerialPort.Read(tempBuf, 0, size);
                    else
                        SerialPort.Read(tempBuf, 0, tempBuf.Length);
                    await System.Threading.Tasks.Task.Delay(50);
                }
                else
                {
                    break;
                }
            }

            SerialPort.Write(arrAngleDat, 0, arrAngleDat.Length);

            while (byteRead < 4)
            {
                actual_size = SerialPort.BytesToRead;

                if (4 < byteRead + actual_size)
                    actual_size = 4 - byteRead;
                actual_size = SerialPort.Read(arrayAngle, byteRead, actual_size);

                byteRead += actual_size;
            }
#if false
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(arrayAngle);
            }
#endif
            string str;
            slAngle = BitConverter.ToInt32(arrayAngle, 0);
            if (slAngle >= 360000)
            {
                slAngle = slAngle / 360000;
                str = " Error code : 0x" + slAngle.ToString("X");
            }
            else
            {
                f32Angle = slAngle / (1000.0f);
                str = f32Angle.ToString("000.000");
            }

            if (cbNewL.Checked)
            {
                rtDispAscii.AppendText(str);
                if (gulNewLine++ % 5 == 4)
                {
                    rtDispAscii.AppendText(", " + Environment.NewLine);
                    gulNewLineDisp++;
                    rtDispAscii.ScrollToCaret();
                }
                else
                    rtDispAscii.AppendText(", ");
            }
            else
            {
                rtDispAscii.AppendText(Environment.NewLine);
                rtDispAscii.AppendText(str);
                gulNewLineDisp++;
                rtDispAscii.ScrollToCaret();
            }

            if (cbAngleDiff.Checked)
            {
                if (slAnglePrev != UNDEFINED)
                {
                    int s32diff = Math.Abs(slAngle - slAnglePrev);
                    int number;

                    if (!string.IsNullOrWhiteSpace(tbDegree.Text) && int.TryParse(tbDegree.Text, out number))
                    {
                        if ((s32diff < Int32.Parse(tbDegree.Text) * 1000) ||
                            ((s32diff > (360000 - (Int32.Parse(tbDegree.Text) * 1000))) && (s32diff < 360000)))
                        {
                            fFail = false;
                        }
                        else
                        {
                            fFail = true;
                        }
                    }
                }
                slAnglePrev = slAngle;
            }

            if (fFail)
            {
                rtDispAscii.AppendText(Environment.NewLine);
                rtDispAscii.AppendText("Angle diff exceeds the set value("+ tbDegree.Text+")");
                rtDispAscii.AppendText(Environment.NewLine);
                if (timer_angleDat.Enabled)
                {
                    SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
                    timer_angleDat.Stop();
                }
            }
            else
            {
                SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
                SerialPort.Write(arrReboot, 0, arrReboot.Length);
                if (gulNewLineDisp > MaxNewLineAngleData)
                {
                    rtDispAscii.Clear();
                    gulNewLineDisp = 0;
                }                              
            }
        }

        private void btAmpGain_Click(object sender, EventArgs e)
        {
            int ulVal, idx;
            byte bCsum;
            byte[] array = new byte[128];
            byte[] buf1 = new byte[4];
            byte[] buf2 = new byte[4];
            byte[] buf3 = new byte[4];

            ulVal = Int32.Parse(tbAmpGainC.Text);
            buf1 = BitConverter.GetBytes(ulVal);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buf1);
            }
            ulVal = Int32.Parse(tbAmpGainF.Text);
            buf2 = BitConverter.GetBytes(ulVal);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buf2);
            }
            ulVal = Int32.Parse(tbAmpGainM.Text);
            buf3 = BitConverter.GetBytes(ulVal);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buf3);
            }

            idx = 0;

            bCsum = 0;
            array[idx++] = 0xA4;
            array[idx++] = 0xB4;

            //array[idx++] = 11;
            idx++;         // length written after filling data completely

            array[idx++] = 0x06;
            bCsum += 0x06;
            array[idx++] = 0x02;
            bCsum += 0x02;
            foreach (byte dat in buf1)
            {
                array[idx++] = dat;
                bCsum += dat;
            }
            foreach (byte dat in buf2)
            {
                array[idx++] = dat;
                bCsum += dat;
            }

            if (cbMediumSupport.Checked == true) // considering Medium
            {
                foreach (byte dat in buf3)
                {
                    array[idx++] = dat;
                    bCsum += dat;
                }
            }

            array[idx] = bCsum;

            // length written after filling data completely
            array[2] = (byte)(idx-2);  

            SerialPort.Write(array, 0, array[2]+3);
        }

        private void btAmpGauge_Click(object sender, EventArgs e)
        {
            int ulVal, idx, ulCsum;
            byte bCsum;
            byte[] array = new byte[18];
            byte[] buf1 = new byte[4];
            byte[] buf2 = new byte[4];
            byte[] buf3 = new byte[4];

            ulVal = Int32.Parse(tbGaugeMin.Text);
            buf1 = BitConverter.GetBytes(ulVal);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buf1);
            }
            ulVal = Int32.Parse(tbGaugeMax.Text);
            buf2 = BitConverter.GetBytes(ulVal);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buf2);
            }
            ulVal = Int32.Parse(tbGaugeCenter.Text);
            buf3 = BitConverter.GetBytes(ulVal);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buf3);
            }

            idx = 0;
            bCsum = 0;

            array[idx++] = 0xA4;
            array[idx++] = 0xB4;
            array[idx++] = 15;
            array[idx++] = 0x06;
            bCsum += 0x06;
            array[idx++] = 0x04;
            bCsum += 0x04;
            foreach (byte dat in buf1)
            {
                array[idx++] = dat;
                bCsum += dat;
            }
            foreach (byte dat in buf2)
            {
                array[idx++] = dat;
                bCsum += dat;
            }
            foreach (byte dat in buf3)
            {
                array[idx++] = dat;
                bCsum += dat;
            }
            array[idx] = bCsum;

            SerialPort.Write(array, 0, array.Length);

        }

        private void btCustomDebug_Click(object sender, EventArgs e)
        {
            int ulVal, idx, ulCsum;
            byte bCsum;
            byte[] array = new byte[18];
            byte[] buf1 = new byte[4];
            byte[] buf2 = new byte[4];
            byte[] buf3 = new byte[4];

            ulVal = Int32.Parse(tbVal7.Text);
            buf1 = BitConverter.GetBytes(ulVal);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buf1);
            }
            ulVal = Int32.Parse(tbVal8.Text);
            buf2 = BitConverter.GetBytes(ulVal);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buf2);
            }
            ulVal = Int32.Parse(tbVal9.Text);
            buf3 = BitConverter.GetBytes(ulVal);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buf3);
            }

            idx = 0;
            bCsum = 0;

            array[idx++] = 0xA4;
            array[idx++] = 0xB4;
            array[idx++] = 15;
            array[idx++] = 0xF0;
            bCsum += 0xF0;
            array[idx++] = 0x12;
            bCsum += 0x12;
            foreach (byte dat in buf1)
            {
                array[idx++] = dat;
                bCsum += dat;
            }
            foreach (byte dat in buf2)
            {
                array[idx++] = dat;
                bCsum += dat;
            }
            foreach (byte dat in buf3)
            {
                array[idx++] = dat;
                bCsum += dat;
            }
            array[idx] = bCsum;

            SerialPort.Write(array, 0, array.Length);

        }

        private void btUZP_Click(object sender, EventArgs e)
        {
            int idx, ulCsum;
            uint ulVal;
            double dVal;
            byte bCsum;
            byte[] array = new byte[10];
            byte[] buf = new byte[4];

            dVal = double.Parse(rtbUZP.Text);
            ulVal = (uint)(dVal * 100000);
            ulVal %= 36000000;
            buf = BitConverter.GetBytes(ulVal);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(buf);
            }
            idx = 0;
            bCsum = 0;
            array[idx++] = 0xA4;
            array[idx++] = 0xB4;
            array[idx++] = 7;
            array[idx++] = 0x05;
            bCsum += 0x05;
            array[idx++] = 0x02;
            bCsum += 0x02;            
            foreach (byte dat in buf)
            {
                array[idx++] = dat;
                bCsum += dat;
            }
            array[idx] = bCsum;

            SerialPort.Write(array, 0, array.Length);
        }

        private void btResort_Click(object sender, EventArgs e)
        {
            int size;
            int READ_SIZE = 4;
            byte[] tempsize = new byte[READ_SIZE];
            int read_size;


            int byteRead = 0;
            int actual_size;

            this.SerialPort.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            
            
            SerialPort.Write(arrChangeMode, 0, arrChangeMode.Length);
            
                      
            System.Threading.Thread.Sleep(800);

            // consume garbadge data
            while (true)
            {
                size = SerialPort.BytesToRead;
                if (size != 0)
                {
                    byte[] temp = new byte[size];
                    actual_size = SerialPort.Read(temp, 0, size);
                }
                else
                {
                    break;
                }
                System.Threading.Thread.Sleep(50);
            }

           
            byte[] array = { 0xA4, 0xB4, 0x03, 0xF0, 0xF0, 0xE0 };
            SerialPort.Write(array, 0, array.Length);

#if true

            byteRead = 0;
            while (byteRead < READ_SIZE)
            {
                size = SerialPort.BytesToRead;
                if(size + byteRead > READ_SIZE)
                {
                    size = READ_SIZE - byteRead;
                }

                byte[] temp = new byte[size];

                actual_size = SerialPort.Read(temp, 0, size);

                Array.Copy(temp, 0, tempsize, byteRead, actual_size);

                byteRead += actual_size;
            }
            read_size = BitConverter.ToInt32(tempsize, 0);

            byteRead = 0;
            byte[] resort_bin = new byte[read_size];

            while (byteRead < read_size)
            {
                size = SerialPort.BytesToRead;
                byte[] temp = new byte[size];

                actual_size = SerialPort.Read(temp, 0, size);

                Array.Copy(temp, 0, resort_bin, byteRead, actual_size);

                byteRead += actual_size;
            }

            string directoryPath = @"D:\Data\RESORT";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            string fileName = $"RS_{DateTime.Now:yyyyMMdd_HHmmss}.bin";
            string filePath = Path.Combine(directoryPath, fileName);
            
            
            //write binary type
            using (FileStream fstream = new FileStream(filePath, FileMode.Append))
            {           
                for (int i = 0; i < resort_bin.Length; i++)
                {
                    fstream.WriteByte(resort_bin[i]);
                }
            }
#endif
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            MessageBox.Show($"Read successfully [ dynamic size : {read_size}( {read_size.ToString("X")} ) ]");

        }

        private void btResortRecord_Click(object sender, EventArgs e)
        {
            byte[] array = { 0xA4, 0xB4, 0x03, 0xF0, 0xF1, 0xE1 };
            SerialPort.Write(array, 0, array.Length);
        }

        private void btResortClean_Click(object sender, EventArgs e)
        {
            byte[] array = { 0xa4, 0xb4, 0x03, 0xF0, 0xF2, 0xE2 };                         
            SerialPort.Write(array, 0, array.Length);
        }

        private void btSaveLog_Click(object sender, EventArgs e)
        {
            string directoryPath = @"D:\Data\UartLog";
            string fileName = "log_" + DateTime.Now.ToString("MMddHHmmss") + ".txt";
            string filePath = Path.Combine(directoryPath, fileName);

            File.WriteAllText(filePath, rtDispAscii.Text);
        }

        private void btReadStorage_Click(object sender, EventArgs e)
        {
            int size;
            int READ_SIZE = 4;
            byte[] tempsize = new byte[READ_SIZE];
            int read_size;


            int byteRead = 0;
            int actual_size;

            this.SerialPort.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);


            SerialPort.Write(arrChangeMode, 0, arrChangeMode.Length);


            System.Threading.Thread.Sleep(800);

            // consume garbadge data
            while (true)
            {
                size = SerialPort.BytesToRead;
                if (size != 0)
                {
                    byte[] temp = new byte[size];
                    actual_size = SerialPort.Read(temp, 0, size);
                }
                else
                {
                    break;
                }
                System.Threading.Thread.Sleep(50);
            }

            string data = "#HA";
            byte[] array = Encoding.ASCII.GetBytes(data);
            SerialPort.Write(array, 0, array.Length);

            byteRead = 0;
            while (byteRead < READ_SIZE)
            {
                size = SerialPort.BytesToRead;
                if (size + byteRead > READ_SIZE)
                {
                    size = READ_SIZE - byteRead;
                }

                byte[] temp = new byte[size];

                actual_size = SerialPort.Read(temp, 0, size);

                Array.Copy(temp, 0, tempsize, byteRead, actual_size);

                byteRead += actual_size;
            }
            read_size = BitConverter.ToInt32(tempsize, 0);


            byteRead = 0;
            byte[] storage = new byte[read_size];

            while (byteRead < read_size)
            {
                size = SerialPort.BytesToRead;
                byte[] temp = new byte[size];

                actual_size = SerialPort.Read(temp, 0, size);

                Array.Copy(temp, 0, storage, byteRead, actual_size);

                byteRead += actual_size;
            }

            string directoryPath = @"D:\Data\Storage";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            string fileName = $"Sto_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
            string filePath = Path.Combine(directoryPath, fileName);


            //write binary type
            using (StreamWriter fstream = new StreamWriter(filePath))
            {
                int data_order;
                // 바이트를 4바이트씩 처리
                for (int i = 0; i < storage.Length; i += 4)
                {
                    // 4바이트씩 읽어서 integer로 변환
                    int value = BitConverter.ToInt32(storage, i);

                    // integer 값을 string으로 변환하여 CSV 파일에 기록
                    data_order = (i / 4)+ 1;
                    fstream.WriteLine($"{data_order:D6},{value}");
                    //fstream.Write(data_order.ToString("D6"));
                    //fstream.Write(",");
                    //fstream.WriteLine(value.ToString());
                    
                    //fstream.Write("\r\n");

                }
            }
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            MessageBox.Show($"Read successfully [ dynamic size : {read_size}( {read_size.ToString("X")} ) ]");

        }

        private void cbHeader_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btMode_Fine_Click(object sender, EventArgs e)
        {
            byte[] array = { 0xa4, 0xb4, 0x03, 0x03, 0x04, 0x07 };                               // DBG_PRINT Dis
            SerialPort.Write(array, 0, array.Length);
        }

        private void tMode_Coarse_Click(object sender, EventArgs e)
        {
            byte[] array = { 0xa4, 0xb4, 0x03, 0x03, 0x03, 0x06 };                               // DBG_PRINT Dis
            SerialPort.Write(array, 0, array.Length);
        }

        private void btMode_Medium_Click(object sender, EventArgs e)
        {
            byte[] array = { 0xa4, 0xb4, 0x03, 0x03, 0x06, 0x09 };                               // DBG_PRINT Dis
            SerialPort.Write(array, 0, array.Length);
        }

        private void cbRebootOption_CheckedChanged(object sender, EventArgs e)
        {
            pnAngleOpt.Enabled = cbRebootOpt.Checked;
        }

        private void btReboot_Click(object sender, EventArgs e)
        {
            byte[] array = { 0xa4, 0xb4, 0x03, 0x0C, 0x20, 0x2C };                               // DBG_PRINT Dis
            SerialPort.Write(array, 0, array.Length);
        }

        private void btServoOnOff_Click(object sender, EventArgs e)
        {
            bool bRet;

            
            bRet = EziSvc.Connect(byte.Parse(rtbEziPort.Text),115200);

            if (bRet)
            {
                lbServoState.ForeColor = System.Drawing.Color.Crimson;
                lbServoState.Text = "STATE : [ ON ]";
                btAutoMeasure.Enabled = true;
                btAutoVerify.Enabled = true;
                btServoOnOff.Text = "   ■ Servo Off";
            }
            else
            {
                lbServoState.ForeColor = System.Drawing.Color.Gray;
                lbServoState.Text = "STATE : [ OFF ]";
                btAutoMeasure.Enabled = false;
                btAutoVerify.Enabled = false;
                btServoOnOff.Text = "   ▶ Servo On";
            }
        }

        private void btServoOFF_Click(object sender, EventArgs e)
        {
            EziSvc.Disconnect();
            lbServoState.ForeColor = System.Drawing.Color.Gray;
            lbServoState.Text = "STATE : [ OFF ]";
        }

        private void btAutoMeasure_Click(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                EziCntl.EziAutoMeasure_Start();
            }
            else
            {
                MessageBox.Show("Open Servo port !! ");
            }
        }
        private void btAutoVerify_Click(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                EziCntl.EziAutoVerify_Start();
            }
            else
            {
                MessageBox.Show("Open Servo port !! ");
            }
        }

        private void btIncrease_Click(object sender, EventArgs e)
        {
            int pulse;

            pulse = int.Parse(rtbPulse.Text);
            EziCntl.EziMoveIncrease(pulse);
        }

        private void btDecrease_Click(object sender, EventArgs e)
        {
            int pulse;

            pulse = int.Parse(rtbPulse.Text);
            EziCntl.EziMoveDecrease(pulse);
        }

        private void lbCleanScreen_Click(object sender, EventArgs e)
        {
            rtDispAscii.Clear();
        }

        private void lbSaveScreen_Click(object sender, EventArgs e)
        {
            string directoryPath = @"D:\Data\UartLog";
            string fileName = "log_" + DateTime.Now.ToString("MMddHHmmss") + ".txt";
            string filePath = Path.Combine(directoryPath, fileName);

            File.WriteAllText(filePath, rtDispAscii.Text);
        }
    }    
}
