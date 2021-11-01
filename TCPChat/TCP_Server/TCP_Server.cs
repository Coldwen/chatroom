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
using System.IO;//输入输出，文件操作

namespace TCP
{
    public partial class form : Form
    {
        //公共属性
        //说明:在传递債息的时候，会在需要传递的信息前面加一个字符来标识传递的是不同的信息
        // 0:表示传递的是字符串信息
        // 1:表示传递的是文件信息
        // 2:表示的是震动

        //负责通讯的socket
        Socket socketSend;
        //用来存放连接服务的IP地址和端口号对应的Socket
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();//将远程连接的客户端的IP地址和Socket存入集合中
    
        public form()
        {
            InitializeComponent();
        }

        //开始监听的按钮
        private void btnStart_Click(object sender, EventArgs e)
        {
            //创建一个负责监听的Socket
            Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //创建IP地址和端口号对象
            //IPAddress ip = IPAddress.Any;//Any表示IP地址变化服务端地址也会跟着变化，是0.0.0.0
            IPAddress ip = IPAddress.Parse(txtServer.Text);//这种是IP地址写死了
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
            //让负责监听的Socket绑定IP地址和端口号
            socketWatch.Bind(point);
            ShowMsg("监听成功！");
            //设置监听队列：在某个时间点能连入服务端的最大数量，超过最大就排队
            socketWatch.Listen(10);

            //为什么要创建线程去运行呢，因为Accept方法会阻碍主线程的运行【看socketSend的定义：Socket socketSend = socketWatch.Accept();】
            Thread th = new Thread(Listen);
            th.IsBackground = true;
            th.Start(socketWatch);
        }
        
        //等待客户端的连接并且创建与之通信用到Socket
        void Listen(Object o)//被线程所执行的函数有参数必须是Object
        {
            Socket socketWatch = o as Socket;//as是类型转换，转换成功返回对象，不成功返回null
            //负责监听的Socker来接受客户端的连接，等待客户端的连接，并且创建一个负责通信的Socket
            //每一个客户端都为它创建一个socket连接
            while (true)
            {
                try
                {
                    
                    //负责通信的socket是，负责监听的socketWatch调用了Accept（接收客户端的连接）方法来的
                    socketSend = socketWatch.Accept();//只能一个客户端连接，为了不卡死主线程要写到线程里调用
                    //将远程连接的客户端的IP地址和Socket存入集合中
                    dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    //将远程连接的客户端的IP地址和端口号存储下拉框中
                    cboUsers.Items.Add(socketSend.RemoteEndPoint.ToString());
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + "连接成功！");

                    //开启一个新线程不停的接收客户端发送的消息
                    Thread th = new Thread(Recive);
                    th.IsBackground = true;
                    th.Start(socketSend);
                }
                catch 
                {
                }

            }
            
        }


        //服务器端不停的接收客户端发送来的数据
        void Recive(Object o)
        {
            Socket socketSend = o as Socket;
            while (true)
            {
                try
                {
                    //客户端连接成功后，服务器应该接收客户端发来的消息
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int r = socketSend.Receive(buffer);//实际接收到的有效字节数
                    if (r != 0)//如果没有这个判断，客户端关闭会一直发空字节
                    {
                        string str = Encoding.UTF8.GetString(buffer, 0, r);
                        ShowMsg(socketSend.RemoteEndPoint + "：" + str);
                    }
                }
                catch //发生异常的情况
                {
                }
                
                
            }
        }

        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");//向文本框加信息
        }

        private void form_Load(object sender, EventArgs e)
        {
            //取消跨线程的检查
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        //服务端给客户端发送消息
        private void btnSend_Click(object sender, EventArgs e)
        {
            string str = txtMsg.Text.Trim();
            //如果传送不同类型的消息，比如文件。可以在要传递的字节数组前面都加上一个字节做为标识，0：文字，1：文件，2：震动
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);

            List<byte> list = new List<byte>();
            list.Add(0);//集合第一位为0
            list.AddRange(buffer);//将集合添加到list末尾

            //将泛型集合转换为数组
            byte[] newBuffer = list.ToArray();//将list复制到新数组里

            //获得用户在下拉框中选中的IP地址，没有IP地址发不了消息
            if (cboUsers.Text == "")
            {
                MessageBox.Show("请在下拉框选择要发送消息的客户端！");
            }
            else
            {
                string ip = cboUsers.SelectedItem.ToString();
                dicSocket[ip].Send(newBuffer);
                //socketSend.Send(buffer);//也可以用
            }
        }

        //选择要发送的文件
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"E:\学习\大三下\软件开发【嵌入式】\夏季学期实践";//给个初始目录
            ofd.Title = "请选择要发送的文件";
            ofd.Filter = "所有文件|*.*"; //文件筛选器
            ofd.ShowDialog();
            txtPath.Text = ofd.FileName;
    
        }

        //发送文件
        private void button4_Click(object sender, EventArgs e)
        {
            //判断是否选择了要发送的客户端
            if (cboUsers.SelectedItem == null)
            {
                MessageBox.Show("请选择要发送的客户端");
                return;
            }
            
            string path = txtPath.Text;
            //构造读取文件流对象，读取选择的文件
            using(FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                //构建一个新的集合，将第一位设为1：表示发送文件
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newBuffer = list.ToArray();
                //获得用户选择的IP地址
                //dicSocket[cboUsers.SelectedItem.ToString()].Send(newBuffer, 0, r+1, SocketFlags.None);//多了一位标记位
                socketSend.Send(newBuffer, 0, r + 1, SocketFlags.None);//上面也可以用
                //目前发的是小文件5MB以下，大文件会涉及到断点续传
            }
        }

        //第二种发送发文件时，大文件
        /// <summary>
        /// 发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            //判断是否选择了要发送的客户端
            if (cboUsers.SelectedItem == null)
            {
                MessageBox.Show("请选择要发送的客户端");
                return;
            }
            Socket socketSend = dicSocket[cboUsers.SelectedItem.ToString()];
            if (socketSend == null)
            {
                MessageBox.Show("请选择要发送的客户端");
                return;
            }
            string filePath = txtPath.Text;
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("请选择文件");
                return;
            }
            Thread td = new Thread(SendBigFile);
            td.IsBackground = true;
            td.Start();

        }

        /// <summary>
        /// 大文件断点传送
        /// </summary>
        private void SendBigFile()
        {
            string filePath = txtPath.Text;
            Socket socketSend = dicSocket[cboUsers.SelectedItem.ToString()];
            try
            {
                //读取选择的文件
                using (FileStream fsRead = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    //1. 第一步：发送一个包，表示文件的长度，让客户端知道后续要接收几个包来重新组织成一个文件
                    long length = fsRead.Length;
                    byte[] byteLength = Encoding.UTF8.GetBytes(length.ToString());
                    //获得发送的信息时候，在数组前面加上一个字节 1
                    List<byte> list = new List<byte>();
                    list.Add(1);
                    list.AddRange(byteLength);
                    socketSend.Send(list.ToArray()); //
                    //2. 第二步：每次发送一个4KB的包，如果文件较大，则会拆分为多个包
                    byte[] buffer = new byte[1024 * 1024];
                    long send = 0; //发送的字节数                   
                    while (true)  //大文件断点多次传输
                    {
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        if (r == 0)
                        {
                            break;
                        }
                        socketSend.Send(buffer, 0, r, SocketFlags.None);
                        send += r;
                        ShowMsg(string.Format("{0}: 已发送：{1}/{2}", socketSend.RemoteEndPoint, send, length));
                    }
                    ShowMsg("发送完成");
                    txtPath.Text = "";
                }
            }
            catch
            {

            }
        }

        //发送震动
        private void btnZD_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = new byte[1];
                buffer[0] = 2;
                //获得用户选择的IP地址
                dicSocket[cboUsers.SelectedItem.ToString()].Send(buffer);
            }
            catch 
            {

                MessageBox.Show("请选择要发送震动的客户端！");
            }
        }

    }
}
