﻿namespace EstateManagement
{
    partial class ChangePassword
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
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtPwdCon = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(92, 54);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Size = new System.Drawing.Size(100, 21);
            this.txtOldPwd.TabIndex = 0;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(92, 99);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(100, 21);
            this.txtNewPwd.TabIndex = 1;
            // 
            // txtPwdCon
            // 
            this.txtPwdCon.Location = new System.Drawing.Point(92, 139);
            this.txtPwdCon.Name = "txtPwdCon";
            this.txtPwdCon.Size = new System.Drawing.Size(100, 21);
            this.txtPwdCon.TabIndex = 2;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(92, 210);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "确认";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "旧密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "确认密码";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.txtPwdCon);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtOldPwd);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtPwdCon;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}