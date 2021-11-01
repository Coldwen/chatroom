using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//操控输入输出的
using System.Data.SqlClient;//操作数据库
using System.Net.Sockets;//引用Socket
using System.Threading;//引入多线程
using System.Net;//引用IP地址
using System.Diagnostics;  //Process 

namespace 测试
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        public FormMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//取消跨线程
        }

        //公共属性【初始化信息】
        DataOperator dataOper = new DataOperator();//创建数据操作类的对象
        private int top = 0;//当前消息气泡起始位置
        private int height = 0;//当前消息气泡高度
        int InlineNum = 0;//在线好友数
        int OfflineNum = 0;//离线好友数

        Socket server;

        #region 初始化信息，用户头像、好友列表
        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化信息
            //获取用户头像、用户名
            ReadByDataBase2(PublicClass.loginID, HeadPicture);
            this.Text = PublicClass.loginName;
            //FormMain formMain = new FormMain();
            //formMain.Text = PublicClass.loginName;

            //获取好友列表
            FriendsMethod();
            treeViewMune.ExpandAll();
            //因为初始化有两个根结点：在线好友、离线好友
            if (treeViewMune.Nodes.Count > 2)
            {
                treeViewMune.SelectedNode = treeViewMune.Nodes[0].Nodes[0];//默认选择第一个在线好友
            }
            //txtLocalPort.Text = Convert.ToString(PublicClass.loginID);//测试，看下登录用户的帐号

            //登录即开启监听
            MonitorMethod();
        }
        
        //刷新好友列表
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FriendsMethod();
        }
        #endregion

        #region 初始化信息，用户头像、好友列表的方法
        //获取好友列表；如果想要树节点显示好友头像的话，将好友的头像填入imageList，一一绑定
        private void FriendsMethod()
        {
            InlineNum = 0;
            treeViewMune.Nodes.Clear();//清空树节点

            //获取在线好友的昵称
            TreeNode tnControlInline = new TreeNode("    在线好友");//根结点
            string sqlInline = string.Format("select * from tb_User,tb_Friend where HostID='{0}' and FriendID=tb_User.ID and Flag=1", PublicClass.loginID);
            SqlDataReader readerInline = dataOper.GetDataReader(sqlInline);
            while (readerInline.Read())//每次只一条条读
            {
                string FriendsInline = readerInline["NickName"].ToString().Trim();
                tnControlInline.Nodes.Add(FriendsInline);//添加子节点，在哪个节点后面加节点就是这个节点的子节点
                tnControlInline.Nodes[InlineNum].Tag = readerInline["ID"].ToString().Trim(); ;//利用标签写进好友ID
                InlineNum++;
            }
            treeViewMune.Nodes.Add(tnControlInline);
            //string a= treeViewMune.Nodes[0].Nodes[0].Tag.ToString();//获得选择结点的Tag
            //MessageBox.Show(a);
            
            //获取离线好友的昵称
            TreeNode tnControlOffline = new TreeNode("    离线好友");//根结点
            tnControlOffline.Tag = "你好";
            string sqlOffline = string.Format("select * from tb_User,tb_Friend where HostID='{0}' and FriendID=tb_User.ID and Flag=0", PublicClass.loginID);
            SqlDataReader readerOffline = dataOper.GetDataReader(sqlOffline);
            while (readerOffline.Read())//每次只一条条读
            {
                string FriendsInline = readerOffline["NickName"].ToString().Trim();
                tnControlOffline.Nodes.Add(FriendsInline);//添加子节点，在哪个节点后面加节点就是这个节点的子节点
                tnControlOffline.Nodes[OfflineNum].Tag = readerOffline["ID"].ToString().Trim(); ;//利用标签写进好友ID
                OfflineNum++;
            }
            treeViewMune.Nodes.Add(tnControlOffline);

            treeViewMune.ExpandAll();//展开所有列表
        }

        //将用户ID填入，指定PictuerBox为索引的图片
        private void ReadByDataBase2(int num, PictureBox Pic)
        {
            //方法一
            string sql = string.Format("select photo from tb_User where ID='{0}'", num);
            SqlDataReader dataReader = dataOper.GetDataReader(sql);
            while (dataReader.Read())
            {
                //读取图片的字节数组
                byte[] byteImage = (byte[])dataReader["photo"];
                //将字节数组转换为内存流
                MemoryStream ms = new MemoryStream(byteImage);
                //将图片流转成图片
                Pic.Image = Image.FromStream(ms);

            }

            //方法二，不用参数，不调用封装数据库的类
            //SqlConnection con = new SqlConnection(conString);//创建数据库连接对象,连接到数据库
            ////string temp = Convert.ToString(PublicClass.loginID);
            //string sql = string.Format("select photo from tb_User where ID='{0}'", PublicClass.loginID);
            //SqlCommand command = new SqlCommand(sql, con);//指定要执行的SQL语句
            //con.Open();
            //sdr = command.ExecuteReader();
            //while (sdr.Read())
            //{
            //    //以下三句是重点
            //    //读取图片的字节数组
            //    byte[] byteImage = (byte[])sdr["photo"];
            //    //将字节数组装换成内存流
            //    MemoryStream ms = new MemoryStream(byteImage);
            //    //将图片流转换成图片
            //    pictureBoxShow.Image = Image.FromStream(ms);
            //}
            //con.Close();
        }

        //从数据库中读取头像
        private void ReadByDataBase1()
        {
            //方法一
            string sql = string.Format("select photo from tb_User where ID='{0}'", PublicClass.loginID);
            SqlDataReader dataReader = dataOper.GetDataReader(sql);
            while (dataReader.Read())
            {
                //读取图片的字节数组
                byte[] byteImage = (byte[])dataReader["photo"];
                //将字节数组转换为内存流
                MemoryStream ms = new MemoryStream(byteImage);
                //将图片流转成图片
                HeadPicture.Image = Image.FromStream(ms);

            }

            //方法二
            //SqlConnection con = new SqlConnection(conString);//创建数据库连接对象,连接到数据库
            ////string temp = Convert.ToString(PublicClass.loginID);
            //string sql = string.Format("select photo from tb_User where ID='{0}'", PublicClass.loginID);
            //SqlCommand command = new SqlCommand(sql, con);//指定要执行的SQL语句
            //con.Open();
            //sdr = command.ExecuteReader();
            //while (sdr.Read())
            //{
            //    //以下三句是重点
            //    //读取图片的字节数组
            //    byte[] byteImage = (byte[])sdr["photo"];
            //    //将字节数组装换成内存流
            //    MemoryStream ms = new MemoryStream(byteImage);
            //    //将图片流转换成图片
            //    pictureBoxShow.Image = Image.FromStream(ms);
            //}
            //con.Close();
        }
        #endregion

        #region 在画布上画消息气泡
        /// <summary>
        /// 显示接收消息
        /// </summary>
        /// <param name="model"></param>
        private void AddReceiveMessage(string content)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { AddReceiveMessage(content); }));
                return;
            }
            Item item = new Item();
            item.messageType = Item.MessageType.receive;
            item.SetWeChatContent(content);

            //计算高度
            item.Top = top + height;
            top = item.Top;
            height = item.HEIGHT;

            //滚动条移动最上方，重新计算气泡在panel的位置，是画在画布上面的
            panelReceiveMessage.AutoScrollPosition = new Point(0, 0);
            panelReceiveMessage.Controls.Add(item);
        }

        // <summary>
        /// 更新界面，显示发送消息
        /// </summary>
        private void AddSendMessage(string content)
        {
            //在某个线程上创建的控件不能成为在另一个线程上创建的控件的父级
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { AddSendMessage(content); }));
                return;
            }
            Item item = new Item();
            item.messageType = Item.MessageType.send;
            item.SetWeChatContent(content);
            item.Top = top + height;
            item.Left = 370 - item.WIDTH;

            top = item.Top;
            height = item.HEIGHT;
            panelReceiveMessage.AutoScrollPosition = new Point(0, 0);
            panelReceiveMessage.Controls.Add(item);
        }
        #endregion

        //个人信息设置
        private void tsbtnInfo_Click(object sender, EventArgs e)
        {
            FormPersonalData fPersonalData = new FormPersonalData();
            fPersonalData.Show();
        }

        //在选择对应好友的对话框
        private void treeViewMune_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewMune.SelectedNode.Level == 1)//选择在线的好友或者离线的好友,即使想和该好友通讯
            {
                //获得好友昵称
                labelFriendName.Text = treeViewMune.SelectedNode.Text;
                PublicClass.friendID = Convert.ToInt32(treeViewMune.SelectedNode.Tag.ToString().Trim());
                //txtDestPort.Text = treeViewMune.SelectedNode.Tag.ToString().Trim();//好友帐号填充到端口号，测试

                //清空消息画布里面的气泡
                panelReceiveMessage.Controls.Clear();
                //重新定义气泡高度
                top = 0;//当前消息气泡起始位置
                height = 0;//当前消息气泡高度
            }
        }

        #region 通信，向对方发送消息、文件、震动
        //发送文件
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            EndPoint point = new IPEndPoint(PublicClass.IP, PublicClass.friendID);

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"E:\图片";//给个初始目录
            ofd.Title = "请选择要发送的文件";
            ofd.Filter = "所有文件|*.*"; //文件筛选器
            ofd.ShowDialog();

            string path = ofd.FileName;
            //构造读取文件流对象，读取选择的文件
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                //构建一个新的集合，将第一位设为1：表示发送文件
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newBuffer = list.ToArray();
                //获得用户选择的IP地址
                server.SendTo(newBuffer, 0, r + 1, SocketFlags.None, point);//多了一位标记位
                //server.SendTo(buffer, point);
                //目前发的是小文件5MB以下，大文件会涉及到断点续传
            }
        }

        #endregion


        private void MonitorMethod()
        {
            //1.创建服务器端电话
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //2.创建手机卡
            IPAddress iP = PublicClass.IP;
            IPEndPoint endPoint = new IPEndPoint(iP, PublicClass.loginID);//本机监听信息的端口号，即本用户帐号
            //3.将电话卡插进电话中(绑定端口号和IP)
            server.Bind(endPoint);
            //txtLog.AppendText("服务器已经成功开启!\r\n");//测试文本，之前创了一个RichTextBox作为打印测试
            //开启接收消息线程
            Thread t = new Thread(ReciveMsg);
            t.IsBackground = true;
            t.Start();
        }

        /// <summary>
        /// 向特定ip的主机的端口发送数据
        /// </summary>te
        void SendMsg()
        {
            //string hostName = Dns.GetHostName();   //获取本机名
            //IPHostEntry localhost = Dns.GetHostEntry(hostName);   //获取IPv6地址
            //IPAddress localaddr = localhost.AddressList[0];

            //EndPoint point = new IPEndPoint(IPAddress.Parse("127.0.0.1"), PublicClass.friendID);
            EndPoint point = new IPEndPoint(PublicClass.IP, PublicClass.friendID);
            string msg = txtSend.Text.Trim();

            //如果传送不同类型的消息，比如文件。可以在要传递的字节数组前面都加上一个字节做为标识，0：文字，1：文件，2：震动
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(msg);
            List<byte> list = new List<byte>();
            list.Add(0);//集合第一位为0
            list.AddRange(buffer);//将集合添加到list末尾
            //将泛型集合转换为数组
            byte[] newBuffer = list.ToArray();//将list复制到新数组里
            server.SendTo(newBuffer, point);
            //server.SendTo(Encoding.UTF8.GetBytes(Convert.ToString(newBuffer)), point);
        }
        /// <summary>
        /// 接收发送给本机ip对应端口号的数据
        /// </summary>
        void ReciveMsg()
        {
            while (true)
            {
                EndPoint point = new IPEndPoint(IPAddress.Any, 0);//用来保存发送方的ip和端口号
                byte[] buffer = new byte[1024 * 1024 *2];
                int length=0;
                try
                {
                    length = server.ReceiveFrom(buffer, ref point);//接收数据报
                }
                catch 
                {
                    MessageBox.Show("好友未上线！");
                }
                
                //如果没有这个判断，客户端关闭会一直发空字节
                if (length == 0)
                {
                    break;
                }
                //表示发送文字消息
                if (buffer[0] == 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 1, length - 1);
                    //txtLog.AppendText(point.ToString() + "：" + message + "\r\n");//测试文本
                    AddReceiveMessage(message);
                }
                else if (buffer[0] == 1)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.InitialDirectory = @"E:\图片";
                    sfd.Title = "请选择要保存的文件";
                    sfd.Filter = "所有文件|*.txt";
                    sfd.ShowDialog(this);

                    string path = sfd.FileName;
                    using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        fsWrite.Write(buffer, 1, length - 1);
                    }
                    MessageBox.Show("发送成功！");
                }
                else if (buffer[0] == 2)
                {
                    Vibration();
                }

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtSend.Text != "")
            {
                //开启发送消息线程
                Thread t2 = new Thread(SendMsg);
                t2.Start();
                AddSendMessage(txtSend.Text);
            }
            
        }

        //发送震动
        private void btnSendVibration_Click(object sender, EventArgs e)
        {
            EndPoint point = new IPEndPoint(PublicClass.IP, PublicClass.friendID);
            byte[] buffer = new byte[1];
            buffer[0] = 2;

           server.SendTo(buffer, point);

           Vibration();//自己窗口也抖
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

        //关闭窗口，好友下线
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataOper.ExecSQLResult("update tb_User set Flag=0 where ID=" + PublicClass.loginID);
        }
    }
}
