using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace 测试
{
    public partial class FormPersonalData : MetroFramework.Forms.MetroForm
    {
        public FormPersonalData()
        {
            InitializeComponent();
        }

        DataOperator dataOper = new DataOperator();//创建数据操作类的对象
        private string conString = "Data Source=LAPTOP-QCDFOB09;Initial Catalog=db_MyChat;Integrated Security=True";
        SqlDataReader sdr;

        private void F_PersonalData_Load(object sender, EventArgs e)
        {
            //从数据库中读取头像
            ReadByDataBase();
            //信息初始化
            InfoShowMethod();
            

        }

        //信息初始化
        private void InfoShowMethod()
        {
            //信息初始化
            string sql = string.Format("select * from tb_User where ID='{0}'", PublicClass.loginID);
            DataSet ds = dataOper.GetDataSet(sql);//将结果存到数据集ds中
            txtNickName.Text = ds.Tables[0].Rows[0]["NickName"].ToString().Trim();//昵称
            txtSign.Text = ds.Tables[0].Rows[0]["Sign"].ToString().Trim();
            labelID.Text = ds.Tables[0].Rows[0]["ID"].ToString().Trim();
            txtAge.Text = ds.Tables[0].Rows[0]["Age"].ToString().Trim();
            if (ds.Tables[0].Rows[0]["Sex"].ToString().Trim() == "男")
            {
                rbtnMale.Checked = true;
            }
            else
            {
                rbtnFemale.Checked = true;
            }
            cboxStar.Text = ds.Tables[0].Rows[0]["Star"].ToString().Trim();
            //cboxBloodType.Text = ds.Tables[0].Rows[0]["BloodType"].ToString().Trim();//方法一
            string strBlood = ds.Tables[0].Rows[0]["BloodType"].ToString().Trim();
            cboxBloodType.SelectedIndex = cboxBloodType.Items.IndexOf(strBlood);//方法二
            txtName.Text = ds.Tables[0].Rows[0]["Name"].ToString().Trim();
        }

        //点击图片进行修改
        private void pictureBoxImage_Click(object sender, EventArgs e)
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
                pictureBoxShow.Load(openFileDialog.FileName);//获得指定图像的URL并显示图像
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

        //从数据库中读取头像
        private void ReadByDataBase()
        {
            SqlConnection con = new SqlConnection(conString);//创建数据库连接对象,连接到数据库
            //string temp = Convert.ToString(PublicClass.loginID);
            string sql = string.Format("select photo from tb_User where ID='{0}'", PublicClass.loginID);
            SqlCommand command = new SqlCommand(sql, con);//指定要执行的SQL语句
            con.Open();
            
                sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    //以下三句是重点
                    //读取图片的字节数组
                    byte[] byteImage = (byte[])sdr["photo"];
                    //将字节数组装换成内存流
                    MemoryStream ms = new MemoryStream(byteImage);
                    //将图片流转换成图片
                    pictureBoxShow.Image = Image.FromStream(ms);
                }
            
            
            con.Close();
        }

        //修改信息
        private void btnModifyInfo_Click(object sender, EventArgs e)
        {
            string strSex;
            if (rbtnMale.Checked)
            {
                strSex = "男";
            }
            else
            {
                strSex = "女";
            }

            string sqlUpdata = string.Format("update tb_User set NickName='{0}', Sign='{1}', Age='{2}', Sex='{3}', Star='{4}', BloodType='{5}', Name='{6}' where ID='{7}'",
                txtNickName.Text.Trim(), txtSign.Text.Trim(), txtAge.Text.Trim(), strSex, cboxStar.Text.Trim(), cboxBloodType.Text.Trim(), txtName.Text.Trim(),PublicClass.loginID);
            if (dataOper.ExecSQLResult(sqlUpdata) != 0)
            {
                MessageBox.Show("修改信息成功！");
            }
        }

        //修改密码
        private void btnModifyPwd_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from tb_User where ID='{0}'", PublicClass.loginID);
            DataSet ds = dataOper.GetDataSet(sql);//将结果存到数据集ds中
            string strOldPwd = ds.Tables[0].Rows[0]["Pwd"].ToString().Trim();//原密码
            if (strOldPwd != txtOldPwd.Text.Trim())
            {
                MessageBox.Show("修改失败，原密码错误！");
            }
            else if (strOldPwd == txtNewPwd.Text.Trim())
            {
                MessageBox.Show("修改失败，新密码和原密码不能一样！");
            }
            else if (txtNewPwd.Text.Trim() != txtPwdAgain.Text.Trim())
            {
                MessageBox.Show("修改失败，新密码和确认密码不同！");
            }
            else
            {
                string sqlUpdata2 = string.Format("update tb_User set Pwd='{0}' where ID='{1}'", txtNewPwd.Text.Trim(), PublicClass.loginID);
                if (dataOper.ExecSQLResult(sqlUpdata2) != 0)
                {
                    MessageBox.Show("修改密码成功！");
                }
            }
        }
    }
}
