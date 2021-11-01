namespace 测试
{
    partial class FormLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtxtID = new System.Windows.Forms.ComboBox();
            this.linklblReg = new System.Windows.Forms.LinkLabel();
            this.cboxRemember = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.Location = new System.Drawing.Point(128, 195);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(194, 30);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(68, 284);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(254, 38);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(68, 144);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "帐号";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(68, 200);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 20);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SketchFlow Print", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 74);
            this.label1.TabIndex = 8;
            this.label1.Text = "Weclome";
            // 
            // cbtxtID
            // 
            this.cbtxtID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbtxtID.FormattingEnabled = true;
            this.cbtxtID.Location = new System.Drawing.Point(128, 140);
            this.cbtxtID.Name = "cbtxtID";
            this.cbtxtID.Size = new System.Drawing.Size(194, 28);
            this.cbtxtID.TabIndex = 10;
            this.cbtxtID.TextChanged += new System.EventHandler(this.cbtxtID_TextChanged);
            this.cbtxtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbtxtID_KeyPress);
            // 
            // linklblReg
            // 
            this.linklblReg.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.linklblReg.AutoSize = true;
            this.linklblReg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.linklblReg.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linklblReg.LinkColor = System.Drawing.Color.DimGray;
            this.linklblReg.Location = new System.Drawing.Point(255, 248);
            this.linklblReg.Name = "linklblReg";
            this.linklblReg.Size = new System.Drawing.Size(67, 15);
            this.linklblReg.TabIndex = 13;
            this.linklblReg.TabStop = true;
            this.linklblReg.Text = "注册账户";
            this.linklblReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblReg_LinkClicked);
            // 
            // cboxRemember
            // 
            this.cboxRemember.AutoSize = true;
            this.cboxRemember.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboxRemember.Location = new System.Drawing.Point(69, 247);
            this.cboxRemember.Name = "cboxRemember";
            this.cboxRemember.Size = new System.Drawing.Size(89, 19);
            this.cboxRemember.TabIndex = 14;
            this.cboxRemember.Text = "记住密码";
            this.cboxRemember.UseVisualStyleBackColor = true;
            // 
            // F_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(396, 356);
            this.Controls.Add(this.cboxRemember);
            this.Controls.Add(this.linklblReg);
            this.Controls.Add(this.cbtxtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Name = "F_Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnLogin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtxtID;
        private System.Windows.Forms.LinkLabel linklblReg;
        private System.Windows.Forms.CheckBox cboxRemember;


    }
}

