using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Edward;
using System.Media;
using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace GetBarcodeServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region 防止屏幕闪烁
        protected override CreateParams CreateParams
        {
            get
            {

                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }

        }
        #endregion


        #region 判断网络连接
        //导入判断网络是否连接的 .dll  
        [DllImport("wininet.dll", EntryPoint = "InternetGetConnectedState")]
        //判断网络状况的方法,返回值true为连接，false为未连接  
        public extern static bool InternetGetConnectedState(out int conState, int reder);

        #endregion

        public static string IniFilePath = @".\SysConfig.ini";
        public static string WebService = "http://10.62.201.121/Basic.WebService/WebService.asmx";
        public static string UseWeb = "1";
        public static string IP1 = "";
        public static string UseIP1 = "1";
        public static string Port1 = "";
        public static string IP2 = "";
        public static string Port2 = "";
        public static string UseIP2 = "1";
        public static string IP3 = "";
        public static string Port3 = "";
        public static string UseIP3 = "1";
        public static string IP4 = "";
        public static string Port4 = "";
        public static string UseIP4 = "1";
        public int lstmsg_max = 100;
        public static int BarcodeList = 2;
        public  List<string> Barcode = new List<string>();

        FA_Basic.WebService ws = new FA_Basic.WebService();

       public enum SoundType
        {
            OK,
            NG
        }

        #region 參數

        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists(@".\MacOS.ssk"))
                skinEngine1.SkinFile = @".\MacOS.ssk";
            if (!File.Exists(IniFilePath))
                createIniFile(IniFilePath);
            readIniValue(IniFilePath);
            LoadUI();
            this.Text = "Get Barcode Server,Ver:" + Application.ProductVersion + "(20210709)";



        }


        #region INI

        public enum IniSection
        {
            SysConfig,
            NetSet,
            Testset
        }


        /// <summary>
        /// create ini file
        /// </summary>
        /// <param name="inifilepath">ini file path </param>
        public static void createIniFile(string inifilepath)
        {
            IniFile.CreateIniFile(inifilepath);
            //File.SetAttributes(inifilepath, FileAttributes.Hidden);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "WebService", WebService, inifilepath);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "UseWeb", UseWeb, inifilepath);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "IP1", IP1, inifilepath);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "Port1", Port1, inifilepath);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "UseIP1", UseIP1, inifilepath);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "IP2", IP2, inifilepath);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "Port2", Port2, inifilepath);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "UseIP2", UseIP2, inifilepath);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "IP3", IP3, inifilepath);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "Port3", Port3, inifilepath);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "UseIP3", UseIP3, inifilepath);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "IP4", IP4, inifilepath);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "Port4", Port4, inifilepath);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "UseIP4", UseIP4, inifilepath);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "BarcodeList", BarcodeList.ToString(), inifilepath);



        }


        /// <summary>
        /// read ini file value 
        /// </summary>
        /// <param name="inifilepath">ini file path</param>
        public static void readIniValue(string inifilepath)
        {

            WebService = IniFile.IniReadValue(IniSection.SysConfig.ToString(), "WebService", inifilepath);
            UseWeb = IniFile.IniReadValue(IniSection.SysConfig.ToString(), "UseWeb", inifilepath);
            IP1 = IniFile.IniReadValue(IniSection.SysConfig.ToString(), "IP1", inifilepath);
            Port1 = IniFile.IniReadValue(IniSection.SysConfig.ToString(), "Port1", inifilepath);
            UseIP1 = IniFile.IniReadValue(IniSection.SysConfig.ToString(), "UseIP1", inifilepath);
            IP2 = IniFile.IniReadValue(IniSection.SysConfig.ToString(), "IP2", inifilepath);
            Port2 = IniFile.IniReadValue(IniSection.SysConfig.ToString(), "Port2", inifilepath);
            UseIP2 = IniFile.IniReadValue(IniSection.SysConfig.ToString(), "UseIP2", inifilepath);
            IP3 = IniFile.IniReadValue(IniSection.SysConfig.ToString(), "IP3", inifilepath);
            Port3 = IniFile.IniReadValue(IniSection.SysConfig.ToString(), "Port3", inifilepath);
            UseIP3 = IniFile.IniReadValue(IniSection.SysConfig.ToString(), "UseIP3", inifilepath);
            IP4 = IniFile.IniReadValue(IniSection.SysConfig.ToString(), "IP4", inifilepath);
            Port4 = IniFile.IniReadValue(IniSection.SysConfig.ToString(), "Port4", inifilepath);
            UseIP4 = IniFile.IniReadValue(IniSection.SysConfig.ToString(), "UseIP4", inifilepath);
            try
            {
                BarcodeList = Convert.ToInt16(IniFile.IniReadValue(IniSection.SysConfig.ToString(), "BarcodeList", inifilepath));
            }
            catch (Exception)
            {

                BarcodeList = 2;
                
            }


        }


        #endregion

        private void LoadUI()
        {
            txtWebService.Text = WebService;
            chkUseWeb.Checked = ChkStringValue(UseWeb);
            chkUseIP1.Checked = ChkStringValue(UseIP1);
            chkUseIP2.Checked = ChkStringValue(UseIP2);
            chkUseIP3.Checked = ChkStringValue(UseIP3);
            chkUseIP4.Checked = ChkStringValue(UseIP4);
            txtIP1.Text = IP1;
            txtPort1.Text = Port1;
            txtIP2.Text = IP2;
            txtPort2.Text = Port2;
            txtIP3.Text = IP3;
            txtPort3.Text = Port3;
            txtIP4.Text = IP4;
            txtPort4.Text = Port4;
            txtBarcodeList.Text = BarcodeList.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool ChkStringValue(string str)
        {
            if (str == "1")
                return true;
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bol"></param>
        /// <returns></returns>
        private string ChkBoolToString(bool bol)
        {
            if (bol)
                return "1";
            else
                return "0";
        }

        private void chkUseWeb_CheckedChanged(object sender, EventArgs e)
        {
            UseWeb = ChkBoolToString(chkUseWeb.Checked);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "UseWeb", UseWeb, IniFilePath);
        }

        private void chkUseIP1_CheckedChanged(object sender, EventArgs e)
        {
            UseIP1 = ChkBoolToString(chkUseIP1.Checked);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "UseIP1", UseIP1, IniFilePath);
        }

        private void chkUseIP2_CheckedChanged(object sender, EventArgs e)
        {
            UseIP2 = ChkBoolToString(chkUseIP2.Checked);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "UseIP2", UseIP2, IniFilePath);
        }

        private void chkUseIP3_CheckedChanged(object sender, EventArgs e)
        {
            UseIP3 = ChkBoolToString(chkUseIP3.Checked);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "UseIP3", UseIP3, IniFilePath);
        }

        private void chkUseIP4_CheckedChanged(object sender, EventArgs e)
        {
            UseIP4 = ChkBoolToString(chkUseIP4.Checked);
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "UseIP4", UseIP4, IniFilePath);
        }

        private void txtWebService_TextChanged(object sender, EventArgs e)
        {
            WebService = txtWebService.Text.Trim();
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "WebService", WebService, IniFilePath);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="SType"></param>
        public void ShowSound(SoundType SType)
        {
            switch (SType)
            {
                case SoundType.OK:
                    if (File.Exists(@".\OK.WAV"))
                    {
                        System.Media.SoundPlayer sp = new SoundPlayer();
                        sp.SoundLocation = @".\OK.WAV";
                        sp.PlaySync();
                    }
                    break;
                case SoundType.NG:
                    if (File.Exists(@".\NG.WAV"))
                    {
                        System.Media.SoundPlayer sp = new SoundPlayer();
                        sp.SoundLocation = @".\NG.WAV";
                        sp.PlaySync();
                    }
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public void ShowMessage(string msg)
        {
            if (msg != "")
            {
                this.Invoke((EventHandler)(delegate
                {
                    lstbox.Items.Add(DateTime.Now.ToString("yyyyMMddHHmmss").Substring (4,10) + "->" + msg);
                    lstbox.SelectedIndex = lstbox.Items.Count - 1;
                    if (lstbox.Items.Count > lstmsg_max)
                        lstbox.Items.RemoveAt(0);
                }
                  ));


            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Msg"></param>
        private void RecordMsg(string Msg)
        {
            string str = DateTime.Now.ToString("yyyyMMdd") + ".LOG";

            string Folder = @".\LOG";
            if (!Directory.Exists(Folder))
                Directory.CreateDirectory(Folder);
            StreamWriter sw = new StreamWriter(Folder + @"\" + str, true);
            sw.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmss") + "->" + Msg);
            sw.Close();
   
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chkbox"></param>
        /// <param name="SendMsg"></param>
        private bool  SendMessage(CheckBox chkbox, string IP,string Port,string SendMsg)
        {

            bool flag = false;
            if (chkbox.Checked)
            {
                Stopwatch sw = new Stopwatch();
                TimeSpan ts = new TimeSpan();
                sw.Start();
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(IP), Convert.ToInt16(Port));
                try
                {
                    socket.Connect(remoteEP);
                    socket.Send(Encoding.Unicode.GetBytes(SendMsg));
                    this.ShowSound(SoundType.OK);
                    flag = true;
                    RecordMsg("Send IP:" + IP + ",Port:" + Port + ",SN:" + SendMsg +" is OK");
                }
                catch (Exception ex)
                {
                    this.ShowMessage(ex.Message);
                    RecordMsg("Send IP:" + IP + ",Port:" + Port + ",SN:" + SendMsg +" is NG.");
                    this.RecordMsg(ex.Message);
                    this.ShowSound(SoundType.NG);
                    flag = false;
                }
                finally
                {
                    socket.Close();
                }
                sw.Stop();
                ShowMessage("Send to " + IP + " UsedTime(ms)" + ts.Milliseconds);
                RecordMsg("Send to " + IP + " UsedTime(ms)" + ts.Milliseconds);
              
            }

            return flag;

        }

 

        private void btnStart_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    AppStart();
                }
                catch (Exception)
                {
                }
            });

        }



        private void AppStart()
        {

            //判断网络
            int connstate = -1;
            if (!InternetGetConnectedState(out connstate, 0))
            {
                MessageBox.Show("当前电脑未连入网络,请确认后重试", "网络错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (chkUseIP1.Checked)
            {
                if ((string.IsNullOrEmpty(IP1) || (string.IsNullOrEmpty(Port1))))
                {
                    MessageBox.Show("IP1 or Port1 is empty,pls input and retry，", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (chkUseIP2.Checked)
            {
                if ((string.IsNullOrEmpty(IP2) || (string.IsNullOrEmpty(Port2))))
                {
                    MessageBox.Show("IP2 or Port2 is empty,pls input and retry，", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (chkUseIP3.Checked)
            {
                if ((string.IsNullOrEmpty(IP3) || (string.IsNullOrEmpty(Port3))))
                {
                    MessageBox.Show("IP3 or Port3 is empty,pls input and retry，", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (chkUseIP4.Checked)
            {
                if ((string.IsNullOrEmpty(IP4) || (string.IsNullOrEmpty(Port4))))
                {
                    MessageBox.Show("IP4 or Port4 is empty,pls input and retry，", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            if (UseWeb == "1")
            {
                Stopwatch sw = new Stopwatch();
                TimeSpan ts = new TimeSpan();
                sw.Start();
                ws.Url = WebService;
                try
                {
                    ws.Discover();
                    sw.Stop();
                    ts = sw.Elapsed;
                    ShowMessage("Connect Webservice OK,UsedTime:(ms)" + ts.Milliseconds);
                }
                catch (Exception ex)
                {
                    sw.Stop();
                    ts = sw.Elapsed;
                    ShowMessage(ex.Message);
                    ShowMessage("Connect Webservice NG,UsedTime:(ms)" + ts.Milliseconds);
                    RecordMsg(ex.Message);
                    RecordMsg("Connect Webservice NG,UsedTime:(ms)" + ts.Milliseconds);

                    return;
                }
            }

            CtrlStart();
            

           
        }

        private void txtSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (e.KeyChar == 13)
            {

                string input = txtSN.Text.Trim().ToUpper();
                txtSN.Text = "";
                if ((input != "") & Regex.IsMatch(input, "^[A-Z0-9]+$"))
                {

                    if (!CheckBarcodeInBarcodeList(input ))
                    {
                        if (BarcodeList > 1)
                        {
                            if ((Barcode.Count + 1) == BarcodeList)
                                Barcode.RemoveAt(0);
                        }
                        if (BarcodeList == 1 || BarcodeList == 0)
                        {
                            if (Barcode.Count == 1)
                                Barcode.RemoveAt(0);
                        }
                           
                        Barcode.Add(input);

                        if (UseWeb == "1")
                        {
                            Stopwatch sw = new Stopwatch();
                            TimeSpan ts = new TimeSpan();
                            sw.Start();
                            string result = ws.ChkRoute(input, "AI");
                            if (result.ToLower().Contains("not exist"))
                            {
                                ShowMessage(input + " is not exist in SFCS.");
                                RecordMsg(input + ":" + result);
                                sw.Stop();
                                ShowMessage("ChkRouter,UsedTime(ms):" + ts.Milliseconds);
                                return;
                            }
                            if (result.ToLower().Contains("already storein"))
                            {
                                ShowMessage(input + " is already SotreIn.");
                                RecordMsg(input + ":" + result);
                                sw.Stop();
                                ShowMessage("ChkRouter,UsedTime(ms):" + ts.Milliseconds);
                                return;
                            }
                        }

                        Task.Factory.StartNew(() =>
                        {
                            try
                            {
                                SendMessage(chkUseIP1, IP1, Port1, input);
                            }
                            catch (Exception)
                            {
                            }
                        });
                        Task.Factory.StartNew(() =>
                        {
                            try
                            {
                                SendMessage(chkUseIP2, IP2, Port2, input);
                            }
                            catch (Exception)
                            {
                            }
                        });
                        Task.Factory.StartNew(() =>
                        {
                            try
                            {
                                SendMessage(chkUseIP3, IP3, Port3, input);
                            }
                            catch (Exception)
                            {
                            }
                        });
                        Task.Factory.StartNew(() =>
                        {
                            try
                            {
                                SendMessage(chkUseIP4, IP4, Port4, input);
                            }
                            catch (Exception)
                            {
                            }
                        });
                        this.ShowMessage("Barcode: " + input);
                    }
                }
            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private  bool CheckBarcodeInBarcodeList(string input)
        {
            if (BarcodeList == 1 || BarcodeList == 0)
                return false;

            if (Barcode.Contains(input))
            {
                ShowMessage("在當前" + (Barcode.Count + 1) + "個條碼内有重複條碼.");
                RecordMsg ("在當前" + (Barcode.Count + 1) + "個條碼内有重複條碼.");
                ShowMessage ("系統設置在" + BarcodeList + "個條碼内不能有重複條碼.");
                RecordMsg("系統設置在" + BarcodeList + "個條碼内不能用重複.");    
         
               return true;
            }
           else
                return false;
        }





        private void txtIP1_TextChanged(object sender, EventArgs e)
        {
            IP1 = txtIP1.Text.Trim();
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "IP1", IP1, IniFilePath);
        }

        private void txtIP2_TextChanged(object sender, EventArgs e)
        {
            IP2 = txtIP2.Text.Trim();
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "IP2", IP2, IniFilePath);
        }

        private void txtIP3_TextChanged(object sender, EventArgs e)
        {
            IP3 = txtIP3.Text.Trim();
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "IP3", IP3, IniFilePath);
        }

        private void txtIP4_TextChanged(object sender, EventArgs e)
        {
            IP4 = txtIP4.Text.Trim();
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "IP4", IP4, IniFilePath);
        }

        private void txtPort1_TextChanged(object sender, EventArgs e)
        {
            Port1 = txtPort1.Text.Trim();
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "Port1", Port1, IniFilePath);
        }

        private void txtPort2_TextChanged(object sender, EventArgs e)
        {
            Port2 = txtPort2.Text.Trim();
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "Port2", Port2, IniFilePath);
        }

        private void txtPort3_TextChanged(object sender, EventArgs e)
        {
            Port3 = txtPort3.Text.Trim();
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "Port3", Port3, IniFilePath);
        }

        private void txtPort4_TextChanged(object sender, EventArgs e)
        {
            Port4 = txtPort4.Text.Trim();
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "Port4", Port4, IniFilePath);
        }


        private void CtrlStart()
        {
            this.Invoke((EventHandler)(delegate
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                txtWebService.Enabled = false;
                txtIP1.Enabled = false;
                txtPort1.Enabled = false;
                txtIP2.Enabled = false;
                txtPort2.Enabled = false;
                txtIP3.Enabled = false;
                txtPort3.Enabled = false;
                txtIP4.Enabled = false;
                txtPort4.Enabled = false;
                txtWebService.Enabled = false;
                chkUseWeb.Enabled = false;
                chkUseIP1.Enabled = false;
                chkUseIP2.Enabled = false;
                chkUseIP3.Enabled = false;
                chkUseIP4.Enabled = false;
                txtSN.Enabled = true;
                txtBarcodeList.ReadOnly = true;
            }));
           



        }

        private void CtrlStop()
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            txtWebService.Enabled = true;
            txtIP1.Enabled = true;
            txtPort1.Enabled = true;
            txtIP2.Enabled = true;
            txtPort2.Enabled = true;
            txtIP3.Enabled = true;
            txtPort3.Enabled = true;
            txtIP4.Enabled = true;
            txtPort4.Enabled = true;
            txtWebService.Enabled = true;
            chkUseWeb.Enabled = true;
            chkUseIP1.Enabled = true;
            chkUseIP2.Enabled = true;
            chkUseIP3.Enabled = true;
            chkUseIP4.Enabled = true;
            txtSN.Enabled = false;
            txtBarcodeList.ReadOnly = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            CtrlStop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnStart.Enabled)
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;

        }

        private void lstbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstbox_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(lstbox.SelectedItem.ToString());
            
        }

        private void btnClearBarcode_Click(object sender, EventArgs e)
        {
            if (Barcode.Count > 0)
            {
                ShowMessage("當前系統條碼" + Barcode.Count + "個,手動點擊清除");
                Barcode.Clear();
            }
           
        }

        private void txtBarcodeList_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BarcodeList = Convert.ToInt16(txtBarcodeList.Text.Trim());
                IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "BarcodeList", BarcodeList.ToString(), IniFilePath);
            }
            catch (Exception)
            {

                BarcodeList = 2;
                txtBarcodeList.Text = "2";
                txtBarcodeList.Focus();
                txtBarcodeList.SelectAll();
               
            }
            finally
            {
                IniFile.IniWriteValue(IniSection.SysConfig.ToString(), "BarcodeList", BarcodeList.ToString(), IniFilePath);
            }
            
        }

        private void txtBarcodeList_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitInputOnlyNumber(sender, e);
        }

        private void LimitInputOnlyNumber( object sender ,KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPort1_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitInputOnlyNumber(sender, e);
        }

        private void txtPort2_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitInputOnlyNumber(sender, e);
        }

        private void txtPort3_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitInputOnlyNumber(sender, e);
        }

        private void txtPort4_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitInputOnlyNumber(sender, e);
        }


    }
}
