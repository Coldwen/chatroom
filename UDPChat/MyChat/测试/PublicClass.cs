using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;//引用IP地址

namespace 测试
{
    class PublicClass
    {
        public static int loginID;//记录登录用户ID
        public static string loginName = "";//记录登录用户名
        public static int friendID;//用来获取好友的ID
        public static IPAddress IP = IPAddress.Parse("127.0.0.1");
        public static string strIP = "127.0.0.1";//通讯IP地址
    }
}
