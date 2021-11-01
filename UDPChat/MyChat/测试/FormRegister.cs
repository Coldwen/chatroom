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
using System.Data.SqlClient;//操控数据库

namespace 测试
{
    public partial class FormRegister : MetroFramework.Forms.MetroForm
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        //公共属性
        const int Teams = 12;
        string[] KCList = new string[Teams];//作为分隔填充星座
        DataOperator dataOper = new DataOperator();//创建数据操作类的对象
        private string conString = "Data Source=LAPTOP-QCDFOB09;Initial Catalog=db_MyChat;Integrated Security=True";

        private void F_Register_Load(object sender, EventArgs e)
        {
            //设置星座和血型的默认值
            cboxStar.SelectedIndex = 0;
            cboxBloodType.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtNickName.Text.Trim() == "" || txtNickName.Text.Length > 20)
            {
                MessageBox.Show("昵称输入有误！不能为空且少于10字。", "提示");
                txtNickName.Focus();//定位鼠标焦点
                return;//就不会执行下面的语句了
            }
             if (txtAge.Text.Trim() == "")//验证年龄
            {
                 MessageBox.Show("请输入年龄", "提示");
                 txtAge.Focus();//定位鼠标焦点
                 return;//就不会执行下面的语句了
            }
             if (txtPwd.Text.Trim() == "")//验证密码
             {
                 MessageBox.Show("请输入密码！", "提示");
                 txtPwd.Focus();
                 return;
             }
             if (txtPwdAgain.Text.Trim() == "")//验证确认密码
             {
                 MessageBox.Show("请输入确认密码！", "提示");
                 txtPwdAgain.Focus();
                 return;
             }
             if (txtPwd.Text.Trim() != txtPwdAgain.Text.Trim())//验证两次密码是否一致
             {
                 MessageBox.Show("两次输入的密码不一样！", "提示");
                 txtPwdAgain.Focus();
                 return;
             }

             int myNum = 0;//申请的账号
             string message;//弹出的消息
             string sex = rbtnMale.Checked ? rbtnMale.Text : rbtnFemale.Text;//获得选中的性别
             string sql = string.Format("insert into tb_User(Pwd, NickName, Sex, Age, Name, Star, BloodType) values('{0}','{1}','{2}',{3},'{4}','{5}','{6}')",
                 txtPwd.Text.Trim(), txtNickName.Text.Trim(), sex, int.Parse(txtAge.Text.Trim()), txtName.Text.Trim(), cboxStar.Text, cboxBloodType.Text);
             int result = dataOper.ExecSQLResult(sql);
             if (result == 1)
             {
                 sql = "select ID from tb_User";//查询新增加的记录的标识号即注册账号
                 DataSet ds = dataOper.GetDataSet(sql);//查询结果存储到数据集中
                 int numCouunt = ds.Tables[0].Rows.Count;//新增数据后的账号总数
                 myNum = Convert.ToInt32(ds.Tables[0].Rows[numCouunt - 1][0].ToString().Trim());
                 message = string.Format("注册成功！你的账号是：" + myNum);
             }
             else
             {
                 message = "注册失败，请重试！";
             }
             MessageBox.Show(message, "注册结果");
             this.Close();//关闭当前窗体
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picture_Click(object sender, EventArgs e)
        {
            //第一步从文件中取图片
            OpenFileDialog openFileDialog = new OpenFileDialog();//创建打开文件的对象
            //openFileDialog.InitialDirectory = @"D:\picture";  //设置打开文件的初始路径
            openFileDialog.RestoreDirectory = true;             //还原对话框在关闭前的目录路径
            openFileDialog.Filter = " pic(*.png)|*.png|所有文件(*.*)|*.*";//文件显示筛选条件
            //第二步获得图片的二进制数byteImage，将以二进制流的形式存放到数据库
            if (openFileDialog.ShowDialog() == DialogResult.OK) //已经选好图片了，按下确认
            {
                //获得图片的二进制数byteImage
                Stream s = openFileDialog.OpenFile();//创建文件打开对象的对象流
                picture.Load(openFileDialog.FileName);//获得指定图像的URL并显示图像
                int length = (int)(s.Length);//获得要存放的图像流的长度
                byte[] byteImage = new byte[length];//图像将以二进制流的形式存放到数据库
                s.Read(byteImage, 0, length);
                s.Close();


                //将byteImage图片的信息存放到数据库
                SqlConnection con = new SqlConnection(conString);//创建数据库连接对象,连接到数据库
                string sql = string.Format("update tb_User set photo=@image where ID='{0}'", PublicClass.loginID);
                SqlCommand command = new SqlCommand(sql, con);//指定要执行的SQL语句
                command.Parameters.Add("@image", SqlDbType.Image);
                command.Parameters["@image"].Value = byteImage;

                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
