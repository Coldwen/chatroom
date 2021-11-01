namespace 测试
{
    partial class FormPersonalData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonalData));
            this.ucSplitLine_H1 = new HZH_Controls.Controls.UCSplitLine_H();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxBloodType = new System.Windows.Forms.ComboBox();
            this.cboxStar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabInformation = new System.Windows.Forms.TabControl();
            this.tabPersonalInfo = new System.Windows.Forms.TabPage();
            this.labelID = new System.Windows.Forms.Label();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPasswordSet = new System.Windows.Forms.TabPage();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPwdAgain = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnModifyPwd = new System.Windows.Forms.Button();
            this.btnModifyInfo = new System.Windows.Forms.Button();
            this.txtSign = new System.Windows.Forms.TextBox();
            this.txtNickName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            this.tabInformation.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            this.tabPasswordSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucSplitLine_H1
            // 
            this.ucSplitLine_H1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSplitLine_H1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ucSplitLine_H1.Location = new System.Drawing.Point(10, 150);
            this.ucSplitLine_H1.Name = "ucSplitLine_H1";
            this.ucSplitLine_H1.Size = new System.Drawing.Size(355, 2);
            this.ucSplitLine_H1.TabIndex = 0;
            this.ucSplitLine_H1.TabStop = false;
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShow.Image")));
            this.pictureBoxShow.Location = new System.Drawing.Point(23, 39);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(98, 91);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShow.TabIndex = 1;
            this.pictureBoxShow.TabStop = false;
            this.pictureBoxShow.Click += new System.EventHandler(this.pictureBoxImage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "帐号";
            // 
            // cboxBloodType
            // 
            this.cboxBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBloodType.FormattingEnabled = true;
            this.cboxBloodType.Items.AddRange(new object[] {
            "A型",
            "B型",
            "O型",
            "AB型"});
            this.cboxBloodType.Location = new System.Drawing.Point(87, 193);
            this.cboxBloodType.Name = "cboxBloodType";
            this.cboxBloodType.Size = new System.Drawing.Size(218, 23);
            this.cboxBloodType.TabIndex = 25;
            // 
            // cboxStar
            // 
            this.cboxStar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStar.FormattingEnabled = true;
            this.cboxStar.Items.AddRange(new object[] {
            "白羊座",
            "金牛座",
            "双子座",
            "巨蟹座",
            "狮子座",
            "处女座",
            "天秤座",
            "天蝎座",
            "射手座",
            "摩羯座",
            "水瓶座",
            "双鱼座"});
            this.cboxStar.Location = new System.Drawing.Point(87, 146);
            this.cboxStar.Name = "cboxStar";
            this.cboxStar.Size = new System.Drawing.Size(218, 23);
            this.cboxStar.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "血型";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 241);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 25);
            this.txtName.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "真实姓名";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "星座";
            // 
            // tabInformation
            // 
            this.tabInformation.Controls.Add(this.tabPersonalInfo);
            this.tabInformation.Controls.Add(this.tabPasswordSet);
            this.tabInformation.Location = new System.Drawing.Point(23, 167);
            this.tabInformation.Name = "tabInformation";
            this.tabInformation.SelectedIndex = 0;
            this.tabInformation.Size = new System.Drawing.Size(338, 375);
            this.tabInformation.TabIndex = 33;
            // 
            // tabPersonalInfo
            // 
            this.tabPersonalInfo.Controls.Add(this.btnModifyInfo);
            this.tabPersonalInfo.Controls.Add(this.labelID);
            this.tabPersonalInfo.Controls.Add(this.rbtnFemale);
            this.tabPersonalInfo.Controls.Add(this.txtAge);
            this.tabPersonalInfo.Controls.Add(this.rbtnMale);
            this.tabPersonalInfo.Controls.Add(this.label3);
            this.tabPersonalInfo.Controls.Add(this.label8);
            this.tabPersonalInfo.Controls.Add(this.label4);
            this.tabPersonalInfo.Controls.Add(this.label7);
            this.tabPersonalInfo.Controls.Add(this.label5);
            this.tabPersonalInfo.Controls.Add(this.txtName);
            this.tabPersonalInfo.Controls.Add(this.label6);
            this.tabPersonalInfo.Controls.Add(this.cboxBloodType);
            this.tabPersonalInfo.Controls.Add(this.cboxStar);
            this.tabPersonalInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPersonalInfo.Name = "tabPersonalInfo";
            this.tabPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonalInfo.Size = new System.Drawing.Size(330, 346);
            this.tabPersonalInfo.TabIndex = 0;
            this.tabPersonalInfo.Text = "基本信息设置";
            this.tabPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelID.Location = new System.Drawing.Point(84, 27);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(63, 15);
            this.labelID.TabIndex = 39;
            this.labelID.Text = "labelID";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(262, 107);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(43, 19);
            this.rbtnFemale.TabIndex = 38;
            this.rbtnFemale.Text = "女";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(87, 58);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(218, 25);
            this.txtAge.TabIndex = 35;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(87, 107);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(43, 19);
            this.rbtnMale.TabIndex = 37;
            this.rbtnMale.Text = "男";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "性别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "年龄";
            // 
            // tabPasswordSet
            // 
            this.tabPasswordSet.Controls.Add(this.txtOldPwd);
            this.tabPasswordSet.Controls.Add(this.btnModifyPwd);
            this.tabPasswordSet.Controls.Add(this.label11);
            this.tabPasswordSet.Controls.Add(this.txtPwdAgain);
            this.tabPasswordSet.Controls.Add(this.label9);
            this.tabPasswordSet.Controls.Add(this.txtNewPwd);
            this.tabPasswordSet.Controls.Add(this.label10);
            this.tabPasswordSet.Location = new System.Drawing.Point(4, 25);
            this.tabPasswordSet.Name = "tabPasswordSet";
            this.tabPasswordSet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPasswordSet.Size = new System.Drawing.Size(330, 346);
            this.tabPasswordSet.TabIndex = 1;
            this.tabPasswordSet.Text = "安全设置";
            this.tabPasswordSet.UseVisualStyleBackColor = true;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(86, 29);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Size = new System.Drawing.Size(219, 25);
            this.txtOldPwd.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "原密码";
            // 
            // txtPwdAgain
            // 
            this.txtPwdAgain.Location = new System.Drawing.Point(86, 136);
            this.txtPwdAgain.Name = "txtPwdAgain";
            this.txtPwdAgain.PasswordChar = '*';
            this.txtPwdAgain.Size = new System.Drawing.Size(219, 25);
            this.txtPwdAgain.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "确认密码";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(86, 81);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(219, 25);
            this.txtNewPwd.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "密码";
            // 
            // btnModifyPwd
            // 
            this.btnModifyPwd.Location = new System.Drawing.Point(118, 293);
            this.btnModifyPwd.Name = "btnModifyPwd";
            this.btnModifyPwd.Size = new System.Drawing.Size(82, 34);
            this.btnModifyPwd.TabIndex = 34;
            this.btnModifyPwd.Text = "确认修改";
            this.btnModifyPwd.UseVisualStyleBackColor = true;
            this.btnModifyPwd.Click += new System.EventHandler(this.btnModifyPwd_Click);
            // 
            // btnModifyInfo
            // 
            this.btnModifyInfo.Location = new System.Drawing.Point(118, 294);
            this.btnModifyInfo.Name = "btnModifyInfo";
            this.btnModifyInfo.Size = new System.Drawing.Size(82, 34);
            this.btnModifyInfo.TabIndex = 40;
            this.btnModifyInfo.Text = "确认修改";
            this.btnModifyInfo.UseVisualStyleBackColor = true;
            this.btnModifyInfo.Click += new System.EventHandler(this.btnModifyInfo_Click);
            // 
            // txtSign
            // 
            this.txtSign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSign.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtSign.Location = new System.Drawing.Point(145, 101);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(209, 18);
            this.txtSign.TabIndex = 34;
            this.txtSign.Text = "txtSign";
            // 
            // txtNickName
            // 
            this.txtNickName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNickName.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNickName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNickName.Location = new System.Drawing.Point(148, 51);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(206, 33);
            this.txtNickName.TabIndex = 35;
            this.txtNickName.Text = "txtNickName";
            // 
            // F_PersonalData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 560);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.tabInformation);
            this.Controls.Add(this.pictureBoxShow);
            this.Controls.Add(this.ucSplitLine_H1);
            this.Name = "F_PersonalData";
            this.Load += new System.EventHandler(this.F_PersonalData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            this.tabInformation.ResumeLayout(false);
            this.tabPersonalInfo.ResumeLayout(false);
            this.tabPersonalInfo.PerformLayout();
            this.tabPasswordSet.ResumeLayout(false);
            this.tabPasswordSet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCSplitLine_H ucSplitLine_H1;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxBloodType;
        private System.Windows.Forms.ComboBox cboxStar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabInformation;
        private System.Windows.Forms.TabPage tabPersonalInfo;
        private System.Windows.Forms.TabPage tabPasswordSet;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPwdAgain;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnModifyPwd;
        private System.Windows.Forms.Button btnModifyInfo;
        private System.Windows.Forms.TextBox txtSign;
        private System.Windows.Forms.TextBox txtNickName;
    }
}