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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstate)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.estTab.SuspendLayout();
            this.usrTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstate
            // 
            this.dgvEstate.AllowUserToAddRows = false;
            this.dgvEstate.AllowUserToDeleteRows = false;
            this.dgvEstate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstate.Location = new System.Drawing.Point(3, 3);
            this.dgvEstate.Name = "dgvEstate";
            this.dgvEstate.ReadOnly = true;
            this.dgvEstate.RowTemplate.Height = 23;
            this.dgvEstate.Size = new System.Drawing.Size(541, 141);
            this.dgvEstate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "资产管理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "人员管理";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "交互操作";
            // 
            // estAddBtn
            // 
            this.estAddBtn.Location = new System.Drawing.Point(61, 258);
            this.estAddBtn.Name = "estAddBtn";
            this.estAddBtn.Size = new System.Drawing.Size(75, 23);
            this.estAddBtn.TabIndex = 4;
            this.estAddBtn.Text = "添加资产";
            this.estAddBtn.UseVisualStyleBackColor = true;
            this.estAddBtn.Click += new System.EventHandler(this.estAddBtn_Click);
            // 
            // estEditBtn
            // 
            this.estEditBtn.Location = new System.Drawing.Point(61, 302);
            this.estEditBtn.Name = "estEditBtn";
            this.estEditBtn.Size = new System.Drawing.Size(75, 23);
            this.estEditBtn.TabIndex = 5;
            this.estEditBtn.Text = "编辑信息";
            this.estEditBtn.UseVisualStyleBackColor = true;
            this.estEditBtn.Click += new System.EventHandler(this.estEditBtn_Click);
            // 
            // estDelBtn
            // 
            this.estDelBtn.Location = new System.Drawing.Point(61, 342);
            this.estDelBtn.Name = "estDelBtn";
            this.estDelBtn.Size = new System.Drawing.Size(75, 23);
            this.estDelBtn.TabIndex = 6;
            this.estDelBtn.Text = "删除资产";
            this.estDelBtn.UseVisualStyleBackColor = true;
            this.estDelBtn.Click += new System.EventHandler(this.estDelBtn_Click);
            // 
            // usrAddBtn
            // 
            this.usrAddBtn.Location = new System.Drawing.Point(260, 258);
            this.usrAddBtn.Name = "usrAddBtn";
            this.usrAddBtn.Size = new System.Drawing.Size(75, 23);
            this.usrAddBtn.TabIndex = 7;
            this.usrAddBtn.Text = "添加人员";
            this.usrAddBtn.UseVisualStyleBackColor = true;
            this.usrAddBtn.Click += new System.EventHandler(this.usrAddBtn_Click);
            // 
            // usrEditBtn
            // 
            this.usrEditBtn.Location = new System.Drawing.Point(260, 302);
            this.usrEditBtn.Name = "usrEditBtn";
            this.usrEditBtn.Size = new System.Drawing.Size(75, 23);
            this.usrEditBtn.TabIndex = 8;
            this.usrEditBtn.Text = "编辑信息";
            this.usrEditBtn.UseVisualStyleBackColor = true;
            this.usrEditBtn.Click += new System.EventHandler(this.usrEditBtn_Click);
            // 
            // usrDelBtn
            // 
            this.usrDelBtn.Location = new System.Drawing.Point(260, 342);
            this.usrDelBtn.Name = "usrDelBtn";
            this.usrDelBtn.Size = new System.Drawing.Size(75, 23);
            this.usrDelBtn.TabIndex = 9;
            this.usrDelBtn.Text = "删除人员";
            this.usrDelBtn.UseVisualStyleBackColor = true;
            this.usrDelBtn.Click += new System.EventHandler(this.usrDelBtn_Click);
            // 
            // outBtn
            // 
            this.outBtn.Location = new System.Drawing.Point(446, 258);
            this.outBtn.Name = "outBtn";
            this.outBtn.Size = new System.Drawing.Size(75, 23);
            this.outBtn.TabIndex = 10;
            this.outBtn.Text = "资产出租";
            this.outBtn.UseVisualStyleBackColor = true;
            this.outBtn.Click += new System.EventHandler(this.outBtn_Click);
            // 
            // retBtn
            // 
            this.retBtn.Location = new System.Drawing.Point(446, 302);
            this.retBtn.Name = "retBtn";
            this.retBtn.Size = new System.Drawing.Size(89, 23);
            this.retBtn.TabIndex = 11;
            this.retBtn.Text = "查看出租信息";
            this.retBtn.UseVisualStyleBackColor = true;
            this.retBtn.Click += new System.EventHandler(this.retBtn_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(446, 342);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "查看归还记录";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // txtSrch
            // 
            this.txtSrch.Location = new System.Drawing.Point(270, 15);
            this.txtSrch.Name = "txtSrch";
            this.txtSrch.Size = new System.Drawing.Size(100, 21);
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
            this.comSrchType.Location = new System.Drawing.Point(398, 15);
            this.comSrchType.Name = "comSrchType";
            this.comSrchType.Size = new System.Drawing.Size(87, 20);
            this.comSrchType.TabIndex = 14;
            this.comSrchType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // srchBtn
            // 
            this.srchBtn.Location = new System.Drawing.Point(492, 15);
            this.srchBtn.Name = "srchBtn";
            this.srchBtn.Size = new System.Drawing.Size(75, 23);
            this.srchBtn.TabIndex = 15;
            this.srchBtn.Text = "搜索";
            this.srchBtn.UseVisualStyleBackColor = true;
            this.srchBtn.Click += new System.EventHandler(this.srchBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.estTab);
            this.tabControl1.Controls.Add(this.usrTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 173);
            this.tabControl1.TabIndex = 16;
            // 
            // estTab
            // 
            this.estTab.Controls.Add(this.dgvEstate);
            this.estTab.Location = new System.Drawing.Point(4, 22);
            this.estTab.Name = "estTab";
            this.estTab.Padding = new System.Windows.Forms.Padding(3);
            this.estTab.Size = new System.Drawing.Size(547, 147);
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
            this.usrTab.Size = new System.Drawing.Size(547, 147);
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
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowTemplate.Height = 23;
            this.dgvUser.Size = new System.Drawing.Size(541, 141);
            this.dgvUser.TabIndex = 0;
            // 
            // typeBtn
            // 
            this.typeBtn.Location = new System.Drawing.Point(61, 379);
            this.typeBtn.Name = "typeBtn";
            this.typeBtn.Size = new System.Drawing.Size(75, 23);
            this.typeBtn.TabIndex = 17;
            this.typeBtn.Text = "查看分类";
            this.typeBtn.UseVisualStyleBackColor = true;
            this.typeBtn.Click += new System.EventHandler(this.typeBtn_Click);
            // 
            // refBtn
            // 
            this.refBtn.Location = new System.Drawing.Point(171, 15);
            this.refBtn.Name = "refBtn";
            this.refBtn.Size = new System.Drawing.Size(75, 23);
            this.refBtn.TabIndex = 18;
            this.refBtn.Text = "刷新";
            this.refBtn.UseVisualStyleBackColor = true;
            this.refBtn.Click += new System.EventHandler(this.refBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(260, 379);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(75, 23);
            this.changeBtn.TabIndex = 19;
            this.changeBtn.Text = "修改密码";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // EstateManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 414);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.refBtn);
            this.Controls.Add(this.typeBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.srchBtn);
            this.Controls.Add(this.comSrchType);
            this.Controls.Add(this.txtSrch);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.retBtn);
            this.Controls.Add(this.outBtn);
            this.Controls.Add(this.usrDelBtn);
            this.Controls.Add(this.usrEditBtn);
            this.Controls.Add(this.usrAddBtn);
            this.Controls.Add(this.estDelBtn);
            this.Controls.Add(this.estEditBtn);
            this.Controls.Add(this.estAddBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EstateManage";
            this.Text = "EstateManage";
            this.Load += new System.EventHandler(this.EstateManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstate)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.estTab.ResumeLayout(false);
            this.usrTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
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
    }
}