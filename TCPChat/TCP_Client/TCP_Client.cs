using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;//引用Socket
using System.Threading;//引入多线程
using System.Net;//引用IP地址
using System.IO;//输入输出

namespace TCP_Client
{
    public partial class TCP_Client : Form
    {
        public TCP_Client()
        {
            InitializeComponent();
        }
        //公共属性
        Socket socketSend;
        private void btnStart_Click(object sender, EventArgs e)
        {
            try//凡是设计到网络的问题都最好try catch
            {
                //创建负责连接的Socket
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(txtServer.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
                ////获得要连接的远程服务器应用程序的IP地址和端口号
                socketSend.Connect(point);
                ShowMsg("连接成功！");

                //开启一个新线程不停的接收客户端发送的消息
                Thread th = new Thread(Recive);
                th.IsBackground = true;
                th.Start(socketSend);
            }
            catch 
            {
              
            }
        }

        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");//向文本框加信息
        }

        //客户端给服务器发送消息
        private void btnSend_Click(object sender, EventArgs e)
        {
            string str = txtMsg.Text.Trim();
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
            socketSend.Send(buffer);
        }

        //服务器端不停的接收客户端发送来的数据
        void Recive(Object o)
        {
            //Socket socketSend = o as Socket;//因为socketSend已经写在外面了
            while (true)
            {
                try
                {
                    //客户端连接成功后，服务器应该接收客户端发来的消息
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int r = socketSend.Receive(buffer);//实际接收到的有效字节数
                    //如果没有这个判断，客户端关闭会一直发空字节
                    if (r == 0)
                    {
                        break;
                    }
                    //表示发送文字消息
                    if (buffer[0] == 0)
                    {
                         string str = Encoding.UTF8.GetString(buffer, 1, r-1);//因为第一位是标记位
                         ShowMsg(socketSend.RemoteEndPoint + "：" + str);
                    }
                    else if (buffer[0] == 1)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.InitialDirectory = @"E:\学习\大三下\软件开发【嵌入式】\夏季学期实践";
                        sfd.Title = "请选择要保存的文件";
                        sfd.Filter = "所有文件|*.txt";
                        sfd.ShowDialog(this);

                        string path = sfd.FileName;
                        using (FileStream fsWrite = new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write))
                        {
                            fsWrite.Write(buffer, 1, r - 1);
                        }
                        MessageBox.Show("发送成功！");
                    }
                    else if (buffer[0] == 2)
                    {
                        Vibration();
                        //ZD();
                    }
                    
                }
                catch //发生异常的情况
                {
                }
            }
        }

        //震动的方法
        void ZD()
        {
            for (int i = 0; i < 500; i++)
            {
                this.Location = new Point(200, 200);
                this.Location = new Point(280, 280);
            }
        }

        private void Vibration()
        {
            Point pOld = this.Location;//原来的位置
            int radius = 3;//半径
            for (int n = 0; n < 3; n++) //旋转圈数
            {
                //右半圆逆时针
                for (int i = -radius; i <= radius; i++)
                {
                    int x = Convert.ToInt32(Math.Sqrt(radius * radius - i * i));
                    int y = -i;

                    this.Location = new Point(pOld.X + x, pOld.Y + y);
                    Thread.Sleep(10);
                }
                //左半圆逆时针
                for (int j = radius; j >= -radius; j--)
                {
                    int x = -Convert.ToInt32(Math.Sqrt(radius * radius - j * j));
                    int y = -j;

                    this.Location = new Point(pOld.X + x, pOld.Y + y);
                    Thread.Sleep(10);
                }
            }
            //抖动完成，恢复原来位置
            this.Location = pOld;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //取消跨线程的检查
            Control.CheckForIllegalCrossThreadCalls = false;
        }

    }
}
