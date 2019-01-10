using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        SerialPort sp = null;       //声明一个串口类
        bool isOpen = false;        //打开串口标志位
        bool isSetProperty = false; //属性设置标志位
        bool isHex = false;         //十六进制显示标志位
        public Form1()
        {
            InitializeComponent();
        }

   

        #region 程序加载时，初始化部分
        private void Form1_Load(object sender, EventArgs e)
        {
            //UI初始化
            this.bgbox.SendToBack();
            this.btnCom.Parent = this.bgbox;
            this.btnCom.BackColor = Color.Transparent;
           this.btnCom.BringToFront();

           this.lblgo.Parent = this.bgbox;
           this.lblgo.BackColor = Color.Transparent;
           this.lblgo.BringToFront();
           lblgo.Text = "一切就绪！整装待发！";
           lblgo.ForeColor = Color.Red;

           this.lbl7.Parent = this.bgbox;
           this.lbl7.BackColor = Color.Transparent;
           this.lbl7.BringToFront();

           this.btnOpenCom1.Parent = this.bgbox;
           this.btnOpenCom1.BackColor = Color.Transparent;
           this.btnOpenCom1.BringToFront();

           this.btnSend1.Parent = this.bgbox;
           this.btnSend1.BackColor = Color.Transparent;
           this.btnSend1.BringToFront();

           this.btnCleanData1.Parent = this.bgbox;
           this.btnCleanData1.BackColor = Color.Transparent;
           this.btnCleanData1.BringToFront();

           this.gbox.Parent = this.bgbox;
           this.gbox.BackColor = Color.Transparent;
           this.gbox.BringToFront();

           this.pBox.Parent = this.bgbox;
           this.pBox.BackColor = Color.Transparent;
           this.pBox.BringToFront();

           //this.tbxRecvData.Parent = this.bgbox;
           //this.tbxRecvData.BackColor = Color.Transparent;
           //this.tbxRecvData.BringToFront();
           
      
      
            Control.CheckForIllegalCrossThreadCalls = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MinimizeBox = false;
            for (int i = 0; i < 10; i++)      //最大支持到串口10
            {
                cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
                 
            }
            cbxCOMPort.SelectedIndex = 0;
            //列出常用的波特率
            cbxBaudRate.Items.Add(110);
            cbxBaudRate.Items.Add(300);
            cbxBaudRate.Items.Add(600);
            cbxBaudRate.Items.Add(1200);
            cbxBaudRate.Items.Add(2400);
            cbxBaudRate.Items.Add(4800);
            cbxBaudRate.Items.Add(9600);
            cbxBaudRate.Items.Add(14400);
            cbxBaudRate.Items.Add(19200);
            cbxBaudRate.Items.Add(38400);
            cbxBaudRate.Items.Add(43000);
            cbxBaudRate.Items.Add(56000);
            cbxBaudRate.Items.Add(57600);
            cbxBaudRate.Items.Add(115200);
            cbxBaudRate.Items.Add(128000);
            cbxBaudRate.Items.Add(256000);
            cbxBaudRate.SelectedIndex = 5;
            //列出停止位
            cbxStopBits.Items.Add(0);
            cbxStopBits.Items.Add(1);
            cbxStopBits.Items.Add(1.5);
            cbxStopBits.Items.Add(2);
            cbxStopBits.SelectedIndex = 1;
            //列出数据位
            cbxDataBits.Items.Add(8);
            cbxDataBits.Items.Add(7);
            cbxDataBits.Items.Add(6);
            cbxDataBits.Items.Add(5);
            cbxDataBits.SelectedIndex = 0;
            //列出奇偶校验位
            cbxParity.Items.Add("无");
            cbxParity.Items.Add("奇校验");
            cbxParity.Items.Add("偶校验");
            cbxParity.SelectedIndex = 0;
            //默认为char显示
            rbnChar.Checked = true;
        }
        #endregion



        #region 当点击串口检测图片时，执行这一段代码
        //按钮的动态特效
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            btnCom.Image = zhy.Properties.Resources.sm3;
        }
        private void btnCom_MouseLeave(object sender, EventArgs e)
        { 
                btnCom.Image = zhy.Properties.Resources.sm1;

        }
        private void btnCom_MouseUp(object sender, MouseEventArgs e)
        {
            btnCom.Image = zhy.Properties.Resources.sm3;
        }
        //点击按钮时执行串口检测
        private void btnCom_MouseDown(object sender, MouseEventArgs e)
        {
            //创建一个线程，来处理串口检测问题
            btnCom.Image = zhy.Properties.Resources.sm2;
            Thread th6 = new Thread(CheckCOM1);
            th6.IsBackground = true;
            th6.Start();

        }
        private void btnCom_Click_1(object sender, EventArgs e)//单击图片
        {

        }
        void CheckCOM1()
        {
            bool comExistence = false;
            cbxCOMPort.Items.Clear();//清除当前串口号中的所有串口名称
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();

                    if (i != 0)
                    {
                        cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
                        comExistence = true;
                    }
                }
                catch (Exception)
                {
                    continue;

                }
            }
            if (comExistence)
            {
                cbxCOMPort.SelectedIndex = 0;    //使ListBox显示第一个添加的索引
                lblgo.ForeColor = Color.Black;
                lblgo.Text = "检测成功，请选择对应的串口号！";
                pBox.Image = zhy.Properties.Resources.b;
                lbl7.Text = "选串口打开！";
            }
            else
            {
                lblgo.ForeColor = Color.Blue;
                lblgo.Text = "检测失败，请检查线路连接！";
                pBox.Image = zhy.Properties.Resources.r;
                lbl7.Text = "猜你没插线？";
            }
        }

        #endregion

        private bool CheckPortSetting()        //检查串口是否设置
        {
            if (cbxCOMPort.Text.Trim() == "") return false;
            if (cbxBaudRate.Text.Trim() == "") return false;
            if (cbxDataBits.Text.Trim() == "") return false;
            if (cbxParity.Text.Trim() == "") return false;
            if (cbxStopBits.Text.Trim() == "") return false;
            return true;
        }
        private bool CheckSendData()
        {
            if (tbxSendData.Text.Trim() == "") return false;
            return true;
        }
        private void SetPortProperty()        //设置串口的属性
        {
            sp = new SerialPort();
            sp.PortName = cbxCOMPort.Text.Trim();//设置串口名
            sp.BaudRate =Convert.ToInt32(cbxBaudRate.Text.Trim());//设置串口的波特率
            float f = Convert.ToSingle(cbxStopBits.Text.Trim());  //设置停止位
            if (f == 0)
            {
                sp.StopBits = StopBits.None;

            }
            else if (f == 1)
            {
                sp.StopBits = StopBits.One;
 
            }
            else if (f == 1.5)
            {
                sp.StopBits = StopBits.OnePointFive;
            }
            else if (f == 2)
            {
                sp.StopBits=StopBits.Two;
            }
            else
            {
                sp.StopBits=StopBits.One;
            }


            sp.DataBits=Convert.ToInt16(cbxDataBits.Text.Trim());//设置数据位

            string s=cbxParity.Text.Trim();            //设置奇偶校验位
            if(s.CompareTo("无")==0)
            {
                sp.Parity=Parity.None;
            }
            else if(s.CompareTo("奇校验")==0)
            {
                sp.Parity=Parity.Odd;
            }
            else if (s.CompareTo("偶校验") == 0)
            {
                sp.Parity = Parity.Even;
            }
            else
            {
                sp.Parity = Parity.None;
            }


            sp.ReadTimeout = -1;//设置读取超时时间

            sp.RtsEnable = true;
            
            //定义数据接收（DataRecieved）事件，当串口收到数据后触发事件
            sp.DataReceived+=new SerialDataReceivedEventHandler(sp_DataReceived);
            if (rbnHex.Checked)
            {
                isHex = true;
            }
            else
            {
                isHex = false;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        #region  当点击发送数据图片按钮时候，执行这一段代码
        private void btnSend1_Click(object sender, EventArgs e)
        {
        }
        private void btnSend1_MouseEnter(object sender, EventArgs e)
        {
            btnSend1.Image = zhy.Properties.Resources.fs3;
        }
        private void btnSend1_MouseLeave(object sender, EventArgs e)
        {
            btnSend1.Image = zhy.Properties.Resources.fs1;
        }
        private void btnSend1_MouseUp(object sender, MouseEventArgs e)
        {
            btnSend1.Image = zhy.Properties.Resources.fs3;
        }

        private void btnSend1_MouseDown(object sender, MouseEventArgs e)
        {
            btnSend1.Image = zhy.Properties.Resources.fs2;
            Thread th7 = new Thread(Send1);
            th7.IsBackground = true;
            th7.Start();
            lblgo.ForeColor = Color.Black;
            lblgo.Text = "数据发送成功！";
            pBox.Image = zhy.Properties.Resources.b;
            lbl7.Text = "情报已发出！";

        }
        void Send1()
        {
            if (isOpen)       //写串口数据
            {
                try
                {
                    sp.WriteLine(tbxSendData.Text);
                }
                catch (Exception)
                {
                    lblgo.ForeColor = Color.Blue;
                    lblgo.Text = "数据发送出错，请检查线路！";
                    pBox.Image = zhy.Properties.Resources.g;
                    lbl7.Text = "这是肿么了？";
                    return;
                }
            }
            else
            {
                lblgo.ForeColor = Color.Blue;
                lblgo.Text = "串口没有打开，请先点击串口检测！";
                pBox.Image = zhy.Properties.Resources.g;
                lbl7.Text = "你是不是傻？";
                return;
            }
            if (!CheckSendData())       //检测要发送的数据
            {
                lblgo.ForeColor = Color.Blue;
                lblgo.Text = "请输入要发送的数据！";
                pBox.Image = zhy.Properties.Resources.r;
                lbl7.Text = "别发空白的！";
                return;
            }

        }

        #endregion


        #region   当打开按钮或者关闭按钮的图片被按下时
        //对按钮的动态反应事件
        private void btnOpenCom1_MouseEnter(object sender, EventArgs e)
        {
            if (isOpen)
            {
                btnOpenCom1.Image = zhy.Properties.Resources._22;
            }
            else
            {
                btnOpenCom1.Image = zhy.Properties.Resources._11;
            }

        }
        private void btnOpenCom1_MouseLeave(object sender, EventArgs e)
        {
            if (isOpen)
            {
                btnOpenCom1.Image = zhy.Properties.Resources._2;
            }
            else
            {
                btnOpenCom1.Image = zhy.Properties.Resources._1;
            }

        }
        private void btnOpenCom1_MouseDown(object sender, MouseEventArgs e)
        {
            btnOpenCom1.Image = zhy.Properties.Resources._3;
        }
        //按下的时候
        private void btnOpenCom1_Click(object sender, EventArgs e)
        {
            //创建新线程执行打开串口
            Thread th4 = new Thread(OpenCom1);
            th4.IsBackground = true;
            th4.Start();

        }

        void OpenCom1()
        {
            if (isOpen == false)
            {
                if (!CheckPortSetting())         //检测串口设置
                {
                    lblgo.ForeColor = Color.Blue;
                    lblgo.Text = "串口未选择，请先选择串口！";
                    return;
                }

                if (!isSetProperty)             //串口未设置则设置串口
                {
                    SetPortProperty();
                    isSetProperty = true;
                }


                try        //打开串口
                {
                    sp.Open();
                    isOpen = true;

                    btnOpenCom1.Image = zhy.Properties.Resources._2;


                    //串口打开后则相应的串口设置按钮则不能再用
                    cbxCOMPort.Enabled = false;
                    cbxBaudRate.Enabled = false;
                    cbxDataBits.Enabled = false;
                    cbxParity.Enabled = false;
                    cbxStopBits.Enabled = false;
                    rbnChar.Enabled = false;
                    rbnHex.Enabled = false;
                    lblgo.ForeColor = Color.Black;
                    lblgo.Text = "串口打开成功！";
                    pBox.Image = zhy.Properties.Resources.g;
                    lbl7.Text = "发数据去吧！";
                    while (isOpen) ;
                }
                catch (Exception)
                {
                    //打开串口失败后，相应标志位取消
                    isSetProperty = false;
                    isOpen = false;
                    lblgo.ForeColor = Color.Blue;
                    lblgo.Text = "串口号无效或被占用！请重新选择！";
                    pBox.Image = zhy.Properties.Resources.g;
                    lbl7.Text = "我去，什么鬼？";
                }
            }
            else
            {
                try       //关闭串口
                {
                    sp.Close();
                    isOpen = false;
                    isSetProperty = false;
      
                    btnOpenCom1.Image = zhy.Properties.Resources._1;


                    //关闭串口之后，串口设置选项又可以继续使用
                    cbxCOMPort.Enabled = true;
                    cbxBaudRate.Enabled = true;
                    cbxDataBits.Enabled = true;
                    cbxParity.Enabled = true;
                    cbxStopBits.Enabled = true;
                    rbnChar.Enabled = true;
                    rbnHex.Enabled = true;
                    lblgo.Text = "串口关闭成功！";
                    pBox.Image = zhy.Properties.Resources.g;
                    lbl7.Text = "串口该关了！";
                }
                catch (Exception)
                {
                    lblgo.ForeColor = Color.Blue;
                    lblgo.Text = "关闭串口时发生错误！";
                    
                    pBox.Image = zhy.Properties.Resources.g;
                    lbl7.Text = "我去，什么鬼？";
                }
            }

        }
        #endregion

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(100);       //延时100ms等待接收完数据
            //this.Invoke就是跨线程访问ui的方法
            this.Invoke((EventHandler)(delegate
            {
                try
                {
                    if (isHex == false)
                    {
                        ShowMsg(sp.ReadExisting());
                        // tbxRecvData.Text += sp.ReadLine();
                    }
                    else
                    {
                        Byte[] ReceivedData = new Byte[sp.BytesToRead];
                        sp.Read(ReceivedData, 0, ReceivedData.Length);
                        String RecvDataText = null;
                        for (int i = 0; i < ReceivedData.Length - 1; i++)
                        {
                            RecvDataText += ("0x" + ReceivedData[i].ToString("X2") + "");
                        }
                        //ShowMsg(RecvDataText);
                        tbxRecvData.Text += RecvDataText;
                    }
                    sp.DiscardInBuffer();   //丢弃接收缓冲区数据
                }
                catch
                { }
         
            }));
                          
        }
        void ShowMsg(string str)
        {
            tbxRecvData.Text = tbxRecvData.Text + str + "\r\n";
            tbxRecvData.ScrollToCaret();
            tbxRecvData.Focus();
            tbxRecvData.Select(tbxRecvData.Text.Length,0);
            tbxRecvData.ScrollToCaret();
        }

        #region  当点击清除数据时候，执行这一段代码。
        private void btnCleanData1_MouseEnter(object sender, EventArgs e)
        {
            btnCleanData1.Image = zhy.Properties.Resources.qc3;
        }


        private void btnCleanData1_MouseLeave(object sender, EventArgs e)
        {
            btnCleanData1.Image = zhy.Properties.Resources.qc1;
        }

        private void btnCleanData1_MouseUp(object sender, MouseEventArgs e)
        {
            btnCleanData1.Image = zhy.Properties.Resources.qc3;
        }

        private void btnCleanData1_MouseDown(object sender, MouseEventArgs e)
        {
            btnCleanData1.Image = zhy.Properties.Resources.qc2;
            tbxRecvData.Text = "";
            tbxSendData.Text = "";
            lblgo.ForeColor = Color.Black;
            lblgo.Text = "数据清除完成！";
            pBox.Image = zhy.Properties.Resources.y;
            lbl7.Text = "证据已销毁！";
        }

        #endregion























    }
}
