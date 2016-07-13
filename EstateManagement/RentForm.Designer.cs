namespace EstateManagement
{
    partial class RentForm
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
            this.dgvRent = new System.Windows.Forms.DataGridView();
            this.retBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.srchBtn = new System.Windows.Forms.Button();
            this.txtSrch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRent
            // 
            this.dgvRent.AllowUserToAddRows = false;
            this.dgvRent.AllowUserToDeleteRows = false;
            this.dgvRent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRent.Location = new System.Drawing.Point(12, 68);
            this.dgvRent.Name = "dgvRent";
            this.dgvRent.ReadOnly = true;
            this.dgvRent.RowTemplate.Height = 23;
            this.dgvRent.Size = new System.Drawing.Size(391, 133);
            this.dgvRent.TabIndex = 0;
            // 
            // retBtn
            // 
            this.retBtn.Location = new System.Drawing.Point(74, 274);
            this.retBtn.Name = "retBtn";
            this.retBtn.Size = new System.Drawing.Size(75, 23);
            this.retBtn.TabIndex = 1;
            this.retBtn.Text = "归还";
            this.retBtn.UseVisualStyleBackColor = true;
            this.retBtn.Click += new System.EventHandler(this.retBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(258, 274);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 2;
            this.quitBtn.Text = "退出";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // srchBtn
            // 
            this.srchBtn.Location = new System.Drawing.Point(289, 28);
            this.srchBtn.Name = "srchBtn";
            this.srchBtn.Size = new System.Drawing.Size(75, 23);
            this.srchBtn.TabIndex = 3;
            this.srchBtn.Text = "搜索";
            this.srchBtn.UseVisualStyleBackColor = true;
            this.srchBtn.Click += new System.EventHandler(this.srchBtn_Click);
            // 
            // txtSrch
            // 
            this.txtSrch.Location = new System.Drawing.Point(168, 30);
            this.txtSrch.Name = "txtSrch";
            this.txtSrch.Size = new System.Drawing.Size(100, 21);
            this.txtSrch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "根据编号搜索";
            // 
            // returnDate
            // 
            this.returnDate.Location = new System.Drawing.Point(102, 225);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(200, 21);
            this.returnDate.TabIndex = 6;
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 339);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSrch);
            this.Controls.Add(this.srchBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.retBtn);
            this.Controls.Add(this.dgvRent);
            this.Name = "RentForm";
            this.Text = "RentForm";
            this.Load += new System.EventHandler(this.RentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRent;
        private System.Windows.Forms.Button retBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button srchBtn;
        private System.Windows.Forms.TextBox txtSrch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker returnDate;
    }
}