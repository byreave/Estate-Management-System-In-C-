namespace EstateManagement
{
    partial class ReturnRecord
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
            this.dgvReturn = new System.Windows.Forms.DataGridView();
            this.srchBtn = new System.Windows.Forms.Button();
            this.txtSrch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.refBtn = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReturn
            // 
            this.dgvReturn.AllowUserToAddRows = false;
            this.dgvReturn.AllowUserToDeleteRows = false;
            this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturn.Location = new System.Drawing.Point(13, 49);
            this.dgvReturn.Name = "dgvReturn";
            this.dgvReturn.ReadOnly = true;
            this.dgvReturn.RowTemplate.Height = 23;
            this.dgvReturn.Size = new System.Drawing.Size(380, 176);
            this.dgvReturn.TabIndex = 0;
            // 
            // srchBtn
            // 
            this.srchBtn.Location = new System.Drawing.Point(278, 12);
            this.srchBtn.Name = "srchBtn";
            this.srchBtn.Size = new System.Drawing.Size(75, 23);
            this.srchBtn.TabIndex = 1;
            this.srchBtn.Text = "搜索";
            this.srchBtn.UseVisualStyleBackColor = true;
            this.srchBtn.Click += new System.EventHandler(this.srchBtn_Click);
            // 
            // txtSrch
            // 
            this.txtSrch.Location = new System.Drawing.Point(160, 14);
            this.txtSrch.Name = "txtSrch";
            this.txtSrch.Size = new System.Drawing.Size(100, 21);
            this.txtSrch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "根据资产编号搜索";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(226, 249);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "关闭";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // refBtn
            // 
            this.refBtn.Location = new System.Drawing.Point(77, 249);
            this.refBtn.Name = "refBtn";
            this.refBtn.Size = new System.Drawing.Size(75, 23);
            this.refBtn.TabIndex = 5;
            this.refBtn.Text = "刷新";
            this.refBtn.UseVisualStyleBackColor = true;
            this.refBtn.Click += new System.EventHandler(this.refBtn_Click);
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
            // ReturnRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 295);
            this.Controls.Add(this.refBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSrch);
            this.Controls.Add(this.srchBtn);
            this.Controls.Add(this.dgvReturn);
            this.Name = "ReturnRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnRecord";
            this.Load += new System.EventHandler(this.ReturnRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReturn;
        private System.Windows.Forms.Button srchBtn;
        private System.Windows.Forms.TextBox txtSrch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button refBtn;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}