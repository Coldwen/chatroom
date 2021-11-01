namespace 测试
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeadPicture = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeViewMune = new HZH_Controls.Controls.TreeViewEx();
            this.panelSend = new System.Windows.Forms.Panel();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnSendVibration = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelFriendName = new System.Windows.Forms.Label();
            this.panelReceiveMessage = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPicture)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSend.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HeadPicture);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 533);
            this.panel1.TabIndex = 0;
            // 
            // HeadPicture
            // 
            this.HeadPicture.BackColor = System.Drawing.Color.Transparent;
            this.HeadPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeadPicture.Image = ((System.Drawing.Image)(resources.GetObject("HeadPicture.Image")));
            this.HeadPicture.Location = new System.Drawing.Point(16, 12);
            this.HeadPicture.Name = "HeadPicture";
            this.HeadPicture.Size = new System.Drawing.Size(40, 40);
            this.HeadPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeadPicture.TabIndex = 1;
            this.HeadPicture.TabStop = false;
            this.HeadPicture.Click += new System.EventHandler(this.tsbtnInfo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnInfo,
            this.toolStripButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip1.Location = new System.Drawing.Point(9, 55);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(40, 108);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnInfo
            // 
            this.tsbtnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInfo.Image")));
            this.tsbtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInfo.Name = "tsbtnInfo";
            this.tsbtnInfo.Size = new System.Drawing.Size(39, 39);
            this.tsbtnInfo.Text = "个人信息";
            this.tsbtnInfo.Click += new System.EventHandler(this.tsbtnInfo_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(39, 39);
            this.toolStripButton1.Text = "更新好友列表";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeViewMune);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(91, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 533);
            this.panel2.TabIndex = 1;
            // 
            // treeViewMune
            // 
            this.treeViewMune.BackColor = System.Drawing.Color.White;
            this.treeViewMune.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewMune.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewMune.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.treeViewMune.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewMune.FullRowSelect = true;
            this.treeViewMune.HideSelection = false;
            this.treeViewMune.IsShowByCustomModel = true;
            this.treeViewMune.IsShowTip = false;
            this.treeViewMune.ItemHeight = 50;
            this.treeViewMune.Location = new System.Drawing.Point(0, 0);
            this.treeViewMune.LstTips = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("treeViewMune.LstTips")));
            this.treeViewMune.Name = "treeViewMune";
            this.treeViewMune.NodeBackgroundColor = System.Drawing.Color.White;
            this.treeViewMune.NodeDownPic = ((System.Drawing.Image)(resources.GetObject("treeViewMune.NodeDownPic")));
            this.treeViewMune.NodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.treeViewMune.NodeHeight = 50;
            this.treeViewMune.NodeIsShowSplitLine = false;
            this.treeViewMune.NodeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.treeViewMune.NodeSelectedForeColor = System.Drawing.Color.Black;
            this.treeViewMune.NodeSplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.treeViewMune.NodeUpPic = ((System.Drawing.Image)(resources.GetObject("treeViewMune.NodeUpPic")));
            this.treeViewMune.ParentNodeCanSelect = true;
            this.treeViewMune.ShowLines = false;
            this.treeViewMune.ShowPlusMinus = false;
            this.treeViewMune.ShowRootLines = false;
            this.treeViewMune.Size = new System.Drawing.Size(178, 533);
            this.treeViewMune.TabIndex = 0;
            this.treeViewMune.TipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.treeViewMune.TipImage = ((System.Drawing.Image)(resources.GetObject("treeViewMune.TipImage")));
            this.treeViewMune.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMune_AfterSelect);
            // 
            // panelSend
            // 
            this.panelSend.BackColor = System.Drawing.Color.White;
            this.panelSend.Controls.Add(this.btnSendFile);
            this.panelSend.Controls.Add(this.btnSendVibration);
            this.panelSend.Controls.Add(this.btnSend);
            this.panelSend.Controls.Add(this.txtSend);
            this.panelSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSend.Location = new System.Drawing.Point(277, 396);
            this.panelSend.Name = "panelSend";
            this.panelSend.Size = new System.Drawing.Size(504, 197);
            this.panelSend.TabIndex = 2;
            // 
            // btnSendFile
            // 
            this.btnSendFile.BackColor = System.Drawing.Color.Transparent;
            this.btnSendFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendFile.BackgroundImage")));
            this.btnSendFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendFile.FlatAppearance.BorderSize = 0;
            this.btnSendFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendFile.Location = new System.Drawing.Point(23, 6);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(48, 41);
            this.btnSendFile.TabIndex = 4;
            this.btnSendFile.UseVisualStyleBackColor = false;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnSendVibration
            // 
            this.btnSendVibration.BackColor = System.Drawing.Color.Transparent;
            this.btnSendVibration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendVibration.BackgroundImage")));
            this.btnSendVibration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendVibration.FlatAppearance.BorderSize = 0;
            this.btnSendVibration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendVibration.Location = new System.Drawing.Point(77, 6);
            this.btnSendVibration.Name = "btnSendVibration";
            this.btnSendVibration.Size = new System.Drawing.Size(48, 38);
            this.btnSendVibration.TabIndex = 2;
            this.btnSendVibration.UseVisualStyleBackColor = false;
            this.btnSendVibration.Click += new System.EventHandler(this.btnSendVibration_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Location = new System.Drawing.Point(393, 156);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 29);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSend.BackColor = System.Drawing.Color.White;
            this.txtSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSend.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSend.Location = new System.Drawing.Point(3, 50);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(498, 100);
            this.txtSend.TabIndex = 2;
            this.txtSend.Text = "";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.labelFriendName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(277, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(504, 70);
            this.panel4.TabIndex = 3;
            // 
            // labelFriendName
            // 
            this.labelFriendName.AutoSize = true;
            this.labelFriendName.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFriendName.Location = new System.Drawing.Point(19, 22);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(85, 19);
            this.labelFriendName.TabIndex = 0;
            this.labelFriendName.Text = "好友名称";
            // 
            // panelReceiveMessage
            // 
            this.panelReceiveMessage.AutoScroll = true;
            this.panelReceiveMessage.BackColor = System.Drawing.Color.White;
            this.panelReceiveMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelReceiveMessage.Location = new System.Drawing.Point(277, 127);
            this.panelReceiveMessage.Name = "panelReceiveMessage";
            this.panelReceiveMessage.Size = new System.Drawing.Size(504, 269);
            this.panelReceiveMessage.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "003-girl.png");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 613);
            this.Controls.Add(this.panelReceiveMessage);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelSend);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "用户名";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPicture)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelSend.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSend;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelReceiveMessage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnInfo;
        private HZH_Controls.Controls.TreeViewEx treeViewMune;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox txtSend;
        private System.Windows.Forms.Label labelFriendName;
        private System.Windows.Forms.PictureBox HeadPicture;
        private System.Windows.Forms.Button btnSendVibration;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSendFile;

    }
}