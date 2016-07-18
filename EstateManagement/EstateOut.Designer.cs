namespace EstateManagement
{
    partial class EstateOut
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
            this.outDate = new System.Windows.Forms.DateTimePicker();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.txtComm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comUser = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.outBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.SuspendLayout();
            // 
            // outDate
            // 
            this.outDate.Location = new System.Drawing.Point(116, 57);
            this.outDate.Name = "outDate";
            this.outDate.Size = new System.Drawing.Size(143, 21);
            this.outDate.TabIndex = 0;
            // 
            // txtUsage
            // 
            this.txtUsage.Location = new System.Drawing.Point(135, 185);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(100, 21);
            this.txtUsage.TabIndex = 2;
            // 
            // txtComm
            // 
            this.txtComm.Location = new System.Drawing.Point(135, 247);
            this.txtComm.Name = "txtComm";
            this.txtComm.Size = new System.Drawing.Size(100, 21);
            this.txtComm.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "领用日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "用途";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "备注";
            // 
            // comUser
            // 
            this.comUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comUser.FormattingEnabled = true;
            this.comUser.Location = new System.Drawing.Point(135, 122);
            this.comUser.Name = "comUser";
            this.comUser.Size = new System.Drawing.Size(100, 20);
            this.comUser.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "用户";
            // 
            // outBtn
            // 
            this.outBtn.Location = new System.Drawing.Point(51, 323);
            this.outBtn.Name = "outBtn";
            this.outBtn.Size = new System.Drawing.Size(75, 23);
            this.outBtn.TabIndex = 11;
            this.outBtn.Text = "出租";
            this.outBtn.UseVisualStyleBackColor = true;
            this.outBtn.Click += new System.EventHandler(this.outBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(150, 322);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
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
            // EstateOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 394);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.outBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComm);
            this.Controls.Add(this.txtUsage);
            this.Controls.Add(this.outDate);
            this.Name = "EstateOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "资产出租";
            this.Load += new System.EventHandler(this.EstateOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker outDate;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.TextBox txtComm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button outBtn;
        private System.Windows.Forms.Button cancelBtn;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}