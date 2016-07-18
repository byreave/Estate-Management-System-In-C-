namespace EstateManagement
{
    partial class EstateManage
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
            this.dgvEstate = new System.Windows.Forms.DataGridView();
            this.estAddBtn = new System.Windows.Forms.Button();
            this.estEditBtn = new System.Windows.Forms.Button();
            this.estDelBtn = new System.Windows.Forms.Button();
            this.usrAddBtn = new System.Windows.Forms.Button();
            this.usrEditBtn = new System.Windows.Forms.Button();
            this.usrDelBtn = new System.Windows.Forms.Button();
            this.outBtn = new System.Windows.Forms.Button();
            this.retBtn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.txtSrch = new System.Windows.Forms.TextBox();
            this.comSrchType = new System.Windows.Forms.ComboBox();
            this.srchBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.estTab = new System.Windows.Forms.TabPage();
            this.usrTab = new System.Windows.Forms.TabPage();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.typeBtn = new System.Windows.Forms.Button();
            this.refBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.extBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstate)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.estTab.SuspendLayout();
            this.usrTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEstate
            // 
            this.dgvEstate.AllowUserToAddRows = false;
            this.dgvEstate.AllowUserToDeleteRows = false;
            this.dgvEstate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstate.Location = new System.Drawing.Point(3, 3);
            this.dgvEstate.MultiSelect = false;
            this.dgvEstate.Name = "dgvEstate";
            this.dgvEstate.ReadOnly = true;
            this.dgvEstate.RowTemplate.Height = 23;
            this.dgvEstate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstate.Size = new System.Drawing.Size(622, 141);
            this.dgvEstate.TabIndex = 0;
            // 
            // estAddBtn
            // 
            this.estAddBtn.Location = new System.Drawing.Point(34, 30);
            this.estAddBtn.Name = "estAddBtn";
            this.estAddBtn.Size = new System.Drawing.Size(75, 23);
            this.estAddBtn.TabIndex = 4;
            this.estAddBtn.Text = "添加资产";
            this.estAddBtn.UseVisualStyleBackColor = true;
            this.estAddBtn.Click += new System.EventHandler(this.estAddBtn_Click);
            // 
            // estEditBtn
            // 
            this.estEditBtn.Location = new System.Drawing.Point(34, 70);
            this.estEditBtn.Name = "estEditBtn";
            this.estEditBtn.Size = new System.Drawing.Size(75, 23);
            this.estEditBtn.TabIndex = 5;
            this.estEditBtn.Text = "编辑信息";
            this.estEditBtn.UseVisualStyleBackColor = true;
            this.estEditBtn.Click += new System.EventHandler(this.estEditBtn_Click);
            // 
            // estDelBtn
            // 
            this.estDelBtn.Location = new System.Drawing.Point(34, 110);
            this.estDelBtn.Name = "estDelBtn";
            this.estDelBtn.Size = new System.Drawing.Size(75, 23);
            this.estDelBtn.TabIndex = 6;
            this.estDelBtn.Text = "删除资产";
            this.estDelBtn.UseVisualStyleBackColor = true;
            this.estDelBtn.Click += new System.EventHandler(this.estDelBtn_Click);
            // 
            // usrAddBtn
            // 
            this.usrAddBtn.Location = new System.Drawing.Point(32, 30);
            this.usrAddBtn.Name = "usrAddBtn";
            this.usrAddBtn.Size = new System.Drawing.Size(75, 23);
            this.usrAddBtn.TabIndex = 7;
            this.usrAddBtn.Text = "添加人员";
            this.usrAddBtn.UseVisualStyleBackColor = true;
            this.usrAddBtn.Click += new System.EventHandler(this.usrAddBtn_Click);
            // 
            // usrEditBtn
            // 
            this.usrEditBtn.Location = new System.Drawing.Point(32, 70);
            this.usrEditBtn.Name = "usrEditBtn";
            this.usrEditBtn.Size = new System.Drawing.Size(75, 23);
            this.usrEditBtn.TabIndex = 8;
            this.usrEditBtn.Text = "编辑信息";
            this.usrEditBtn.UseVisualStyleBackColor = true;
            this.usrEditBtn.Click += new System.EventHandler(this.usrEditBtn_Click);
            // 
            // usrDelBtn
            // 
            this.usrDelBtn.Location = new System.Drawing.Point(32, 110);
            this.usrDelBtn.Name = "usrDelBtn";
            this.usrDelBtn.Size = new System.Drawing.Size(75, 23);
            this.usrDelBtn.TabIndex = 9;
            this.usrDelBtn.Text = "删除人员";
            this.usrDelBtn.UseVisualStyleBackColor = true;
            this.usrDelBtn.Click += new System.EventHandler(this.usrDelBtn_Click);
            // 
            // outBtn
            // 
            this.outBtn.Location = new System.Drawing.Point(39, 40);
            this.outBtn.Name = "outBtn";
            this.outBtn.Size = new System.Drawing.Size(75, 23);
            this.outBtn.TabIndex = 10;
            this.outBtn.Text = "资产出租";
            this.outBtn.UseVisualStyleBackColor = true;
            this.outBtn.Click += new System.EventHandler(this.outBtn_Click);
            // 
            // retBtn
            // 
            this.retBtn.Location = new System.Drawing.Point(39, 82);
            this.retBtn.Name = "retBtn";
            this.retBtn.Size = new System.Drawing.Size(75, 23);
            this.retBtn.TabIndex = 11;
            this.retBtn.Text = "出租信息";
            this.retBtn.UseVisualStyleBackColor = true;
            this.retBtn.Click += new System.EventHandler(this.retBtn_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(39, 124);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "归还记录";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // txtSrch
            // 
            this.txtSrch.Location = new System.Drawing.Point(15, 42);
            this.txtSrch.Name = "txtSrch";
            this.txtSrch.Size = new System.Drawing.Size(93, 21);
            this.txtSrch.TabIndex = 13;
            // 
            // comSrchType
            // 
            this.comSrchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comSrchType.FormattingEnabled = true;
            this.comSrchType.Items.AddRange(new object[] {
            "按照大类搜索",
            "按照小类搜索",
            "按照人员搜索",
            "按照资产编号"});
            this.comSrchType.Location = new System.Drawing.Point(15, 83);
            this.comSrchType.Name = "comSrchType";
            this.comSrchType.Size = new System.Drawing.Size(93, 20);
            this.comSrchType.TabIndex = 14;
            this.comSrchType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // srchBtn
            // 
            this.srchBtn.Location = new System.Drawing.Point(15, 123);
            this.srchBtn.Name = "srchBtn";
            this.srchBtn.Size = new System.Drawing.Size(93, 23);
            this.srchBtn.TabIndex = 15;
            this.srchBtn.Text = "搜索";
            this.srchBtn.UseVisualStyleBackColor = true;
            this.srchBtn.Click += new System.EventHandler(this.srchBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.estTab);
            this.tabControl1.Controls.Add(this.usrTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 173);
            this.tabControl1.TabIndex = 16;
            // 
            // estTab
            // 
            this.estTab.Controls.Add(this.dgvEstate);
            this.estTab.Location = new System.Drawing.Point(4, 22);
            this.estTab.Name = "estTab";
            this.estTab.Padding = new System.Windows.Forms.Padding(3);
            this.estTab.Size = new System.Drawing.Size(628, 147);
            this.estTab.TabIndex = 0;
            this.estTab.Text = "资产";
            this.estTab.UseVisualStyleBackColor = true;
            // 
            // usrTab
            // 
            this.usrTab.Controls.Add(this.dgvUser);
            this.usrTab.Location = new System.Drawing.Point(4, 22);
            this.usrTab.Name = "usrTab";
            this.usrTab.Padding = new System.Windows.Forms.Padding(3);
            this.usrTab.Size = new System.Drawing.Size(628, 147);
            this.usrTab.TabIndex = 1;
            this.usrTab.Text = "人员";
            this.usrTab.UseVisualStyleBackColor = true;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(3, 3);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowTemplate.Height = 23;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(619, 141);
            this.dgvUser.TabIndex = 0;
            // 
            // typeBtn
            // 
            this.typeBtn.Location = new System.Drawing.Point(34, 150);
            this.typeBtn.Name = "typeBtn";
            this.typeBtn.Size = new System.Drawing.Size(75, 23);
            this.typeBtn.TabIndex = 17;
            this.typeBtn.Text = "查看分类";
            this.typeBtn.UseVisualStyleBackColor = true;
            this.typeBtn.Click += new System.EventHandler(this.typeBtn_Click);
            // 
            // refBtn
            // 
            this.refBtn.Location = new System.Drawing.Point(442, 427);
            this.refBtn.Name = "refBtn";
            this.refBtn.Size = new System.Drawing.Size(75, 23);
            this.refBtn.TabIndex = 18;
            this.refBtn.Text = "刷新";
            this.refBtn.UseVisualStyleBackColor = true;
            this.refBtn.Click += new System.EventHandler(this.refBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(32, 150);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(75, 23);
            this.changeBtn.TabIndex = 19;
            this.changeBtn.Text = "修改密码";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.estAddBtn);
            this.groupBox1.Controls.Add(this.estEditBtn);
            this.groupBox1.Controls.Add(this.typeBtn);
            this.groupBox1.Controls.Add(this.estDelBtn);
            this.groupBox1.Location = new System.Drawing.Point(9, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 191);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "资产管理";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.changeBtn);
            this.groupBox2.Controls.Add(this.usrAddBtn);
            this.groupBox2.Controls.Add(this.usrEditBtn);
            this.groupBox2.Controls.Add(this.usrDelBtn);
            this.groupBox2.Location = new System.Drawing.Point(178, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 191);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "人员管理";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.retBtn);
            this.groupBox3.Controls.Add(this.outBtn);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Location = new System.Drawing.Point(349, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 191);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "交互操作";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSrch);
            this.groupBox4.Controls.Add(this.comSrchType);
            this.groupBox4.Controls.Add(this.srchBtn);
            this.groupBox4.Location = new System.Drawing.Point(523, 212);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(125, 191);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "搜索";
            // 
            // extBtn
            // 
            this.extBtn.Location = new System.Drawing.Point(538, 426);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(75, 23);
            this.extBtn.TabIndex = 24;
            this.extBtn.Text = "退出";
            this.extBtn.UseVisualStyleBackColor = true;
            this.extBtn.Click += new System.EventHandler(this.extBtn_Click);
            // 
            // EstateManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 477);
            this.Controls.Add(this.extBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.refBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "EstateManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstateManage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EstateManage_FormClosing);
            this.Load += new System.EventHandler(this.EstateManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstate)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.estTab.ResumeLayout(false);
            this.usrTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstate;
        private System.Windows.Forms.Button estAddBtn;
        private System.Windows.Forms.Button estEditBtn;
        private System.Windows.Forms.Button estDelBtn;
        private System.Windows.Forms.Button usrAddBtn;
        private System.Windows.Forms.Button usrEditBtn;
        private System.Windows.Forms.Button usrDelBtn;
        private System.Windows.Forms.Button outBtn;
        private System.Windows.Forms.Button retBtn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox txtSrch;
        private System.Windows.Forms.ComboBox comSrchType;
        private System.Windows.Forms.Button srchBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage estTab;
        private System.Windows.Forms.TabPage usrTab;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button typeBtn;
        private System.Windows.Forms.Button refBtn;
        private System.Windows.Forms.Button changeBtn;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button extBtn;
    }
}