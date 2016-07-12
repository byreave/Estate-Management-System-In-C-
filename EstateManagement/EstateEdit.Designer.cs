namespace EstateManagement
{
    partial class EstateEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtComm = new System.Windows.Forms.TextBox();
            this.comStatus = new System.Windows.Forms.ComboBox();
            this.purDate = new System.Windows.Forms.DateTimePicker();
            this.comType = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "类别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "型号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "价值";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "购买日期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "状态";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "备注";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 7;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(117, 129);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 21);
            this.txtModel.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(117, 170);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 9;
            // 
            // txtComm
            // 
            this.txtComm.Location = new System.Drawing.Point(117, 328);
            this.txtComm.Name = "txtComm";
            this.txtComm.Size = new System.Drawing.Size(121, 21);
            this.txtComm.TabIndex = 10;
            // 
            // comStatus
            // 
            this.comStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comStatus.FormattingEnabled = true;
            this.comStatus.Items.AddRange(new object[] {
            "正常",
            "维修",
            "报废"});
            this.comStatus.Location = new System.Drawing.Point(117, 271);
            this.comStatus.Name = "comStatus";
            this.comStatus.Size = new System.Drawing.Size(100, 20);
            this.comStatus.TabIndex = 11;
            // 
            // purDate
            // 
            this.purDate.Location = new System.Drawing.Point(117, 220);
            this.purDate.Name = "purDate";
            this.purDate.Size = new System.Drawing.Size(121, 21);
            this.purDate.TabIndex = 12;
            // 
            // comType
            // 
            this.comType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comType.FormattingEnabled = true;
            this.comType.Location = new System.Drawing.Point(117, 84);
            this.comType.Name = "comType";
            this.comType.Size = new System.Drawing.Size(100, 20);
            this.comType.TabIndex = 13;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(46, 399);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "确定";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // cancleBtn
            // 
            this.cancleBtn.Location = new System.Drawing.Point(163, 399);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.Size = new System.Drawing.Size(75, 23);
            this.cancleBtn.TabIndex = 15;
            this.cancleBtn.Text = "取消";
            this.cancleBtn.UseVisualStyleBackColor = true;
            // 
            // EstateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 457);
            this.Controls.Add(this.cancleBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.comType);
            this.Controls.Add(this.purDate);
            this.Controls.Add(this.comStatus);
            this.Controls.Add(this.txtComm);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EstateEdit";
            this.Text = "EstateEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtComm;
        private System.Windows.Forms.ComboBox comStatus;
        private System.Windows.Forms.DateTimePicker purDate;
        private System.Windows.Forms.ComboBox comType;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancleBtn;
    }
}