using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls;
using HZH_Controls.Controls;
using HZH_Controls.Forms;
using CCWin;

namespace 测试
{
    public partial class FormLogin :  MetroFramework.Forms.MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        DataOperator dataOper = new DataOperator();//创建数据操作类的对象

        private void Form1_Load(object sender, EventArgs e)
        {
            //先填充帐号下拉框的内容，这些是记住密码的用户
            string sql = string.Format("select ID from tb_User where Remember=1");
            DataSet ds = dataOper.GetDataSet(sql);//将结果存到数据集ds中
            if (ds.Tables[0].Rows.Count > 0)    //判断是否有记住密码的用户
            {
                //填充帐号下拉框
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cbtxtID.Items.Add(ds.Tables[0].Rows[i][0]);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbtxtID.Text == "")
            {
                MessageBox.Show("请输入帐号后再登录");
            }
            else if (txtPwd.Text == "")
            {
                MessageBox.Show("请输入密码后再登录");
            }
            else
            {
                //如果用户列表有这个用户返回1，否则返回0
                string sql = string.Format("select count(*) from tb_User where ID='{0}' and Pwd='{1}'",cbtxtID.Text,txtPwd.Text);
                string sqlNickName = string.Format("select NickName from tb_User where ID='{0}' and Pwd='{1}'", cbtxtID.Text, txtPwd.Text);
                DataSet ds = dataOper.GetDataSet(sqlNickName);//查询结果存储到数据集中
                int num = dataOper.ExecSQL(sql);//是否有找到该用户
                if (num == 1)   //登录成功
                {
                    PublicClass.loginID = int.Parse(cbtxtID.Text.Trim());//记录登录的用户ID
                    PublicClass.loginName = ds.Tables[0].Rows[0][0].ToString().Trim();//记录登录的用户名
                    //MessageBox.Show(PublicClass.loginName);
                    //MessageBox.Show("登录成功！");
                    if (cboxRemember.Checked)
                    {
                        //记住密码
                        dataOper.ExecSQLResult("update tb_User set Remember=1 where ID=" + int.Parse(cbtxtID.Text.Trim()));
                        //将账号添加到cbtxtID下拉框里
                        cbtxtID.Items.Add(int.Parse(cbtxtID.Text.Trim()));
                    }
                    else
                    {
                        //不记住密码
                        dataOper.ExecSQLResult("update tb_User set Remember=0 where ID=" + Convert.ToInt32(cbtxtID.Text.Trim()));
                    }
                        
                }
                else
                {
                    MessageBox.Show("登陆失败！帐号或密码错误！");
                }
                dataOper.ExecSQLResult("update tb_User set Flag=1 where ID=" + int.Parse(cbtxtID.Text.Trim()));//设置在线状态，Flag为1在线，0离线
                FormMain frmMain = new FormMain();//创建主窗体对象
                frmMain = new FormMain();//创建主窗体对象
                frmMain.Show();  //显示主窗体
                this.Visible = false;  //隐藏登录主窗体
            }
        }

        private void cbtxtID_TextChanged(object sender, EventArgs e)
        {
            //根据帐号查询其密码、记住密码的值
            string sql = "select Pwd from tb_User where Remember=1 and ID=" + Convert.ToInt32(cbtxtID.Text.Trim());
            //int strPwd = dataOper.ExecSQL(sql);//ExecSQL只能返回第一行第一列的int数值
            DataSet ds = dataOper.GetDataSet(sql);//查询结果存储到数据集中
            if (ds.Tables[0].Rows.Count > 0)//判断是否存在该用户
            {
                txtPwd.Text = ds.Tables[0].Rows[0][0].ToString().Trim();
                cboxRemember.Checked = true;//因为是记住密码的用户所以自动框选
            }
        }

        //判断是否在用户账号文本框中按下回车键
        private void cbtxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == '\r') || (e.KeyChar == '\b'))//判断是否为数字
                e.Handled = false;//在控件中显示该字符
            else
                e.Handled = true;//取消在控件中显示该字符
        }

        //判断是否在密码文本框中按下回车键
        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')//判断是否按下回车键
                btnLogin_Click(sender, e);//使登录按钮获得鼠标焦点
        }

        //注册帐号
        private void linklblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister fRegister = new FormRegister();
            fRegister.Show();
        }

    }
}
