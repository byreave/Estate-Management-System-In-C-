namespace EstateManagement
{
    partial class TypeManager
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
            this.dgvTypeA = new System.Windows.Forms.DataGridView();
            this.dgvTypeB = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeAAddBtn = new System.Windows.Forms.Button();
            this.TypeBAddBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comTypeB = new System.Windows.Forms.ComboBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTypeA
            // 
            this.dgvTypeA.AllowUserToAddRows = false;
            this.dgvTypeA.AllowUserToDeleteRows = false;
            this.dgvTypeA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTypeA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypeA.Location = new System.Drawing.Point(13, 44);
            this.dgvTypeA.MultiSelect = false;
            this.dgvTypeA.Name = "dgvTypeA";
            this.dgvTypeA.ReadOnly = true;
            this.dgvTypeA.RowTemplate.Height = 23;
            this.dgvTypeA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTypeA.Size = new System.Drawing.Size(175, 150);
            this.dgvTypeA.TabIndex = 0;
            this.dgvTypeA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTypeA_CellClick);
            // 
            // dgvTypeB
            // 
            this.dgvTypeB.AllowUserToAddRows = false;
            this.dgvTypeB.AllowUserToDeleteRows = false;
            this.dgvTypeB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTypeB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypeB.Location = new System.Drawing.Point(194, 44);
            this.dgvTypeB.MultiSelect = false;
            this.dgvTypeB.Name = "dgvTypeB";
            this.dgvTypeB.ReadOnly = true;
            this.dgvTypeB.RowTemplate.Height = 23;
            this.dgvTypeB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTypeB.Size = new System.Drawing.Size(224, 150);
            this.dgvTypeB.TabIndex = 1;
            this.dgvTypeB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "大类";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "小类";
            // 
            // TypeAAddBtn
            // 
            this.TypeAAddBtn.Location = new System.Drawing.Point(15, 258);
            this.TypeAAddBtn.Name = "TypeAAddBtn";
            this.TypeAAddBtn.Size = new System.Drawing.Size(75, 23);
            this.TypeAAddBtn.TabIndex = 4;
            this.TypeAAddBtn.Text = "添加大类";
            this.TypeAAddBtn.UseVisualStyleBackColor = true;
            this.TypeAAddBtn.Click += new System.EventHandler(this.TypeAAddBtn_Click);
            // 
            // TypeBAddBtn
            // 
            this.TypeBAddBtn.Location = new System.Drawing.Point(113, 258);
            this.TypeBAddBtn.Name = "TypeBAddBtn";
            this.TypeBAddBtn.Size = new System.Drawing.Size(75, 23);
            this.TypeBAddBtn.TabIndex = 5;
            this.TypeBAddBtn.Text = "添加小类";
            this.TypeBAddBtn.UseVisualStyleBackColor = true;
            this.TypeBAddBtn.Click += new System.EventHandler(this.TypeBAddBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(238, 258);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 6;
            this.delBtn.Text = "删除";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(343, 258);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 7;
            this.quitBtn.Text = "关闭";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(62, 223);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 21);
            this.txtType.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "选择大类添加小类";
            // 
            // comTypeB
            // 
            this.comTypeB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comTypeB.FormattingEnabled = true;
            this.comTypeB.Location = new System.Drawing.Point(315, 223);
            this.comTypeB.Name = "comTypeB";
            this.comTypeB.Size = new System.Drawing.Size(87, 20);
            this.comTypeB.TabIndex = 10;
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
            // TypeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 319);
            this.Controls.Add(this.comTypeB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.TypeBAddBtn);
            this.Controls.Add(this.TypeAAddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTypeB);
            this.Controls.Add(this.dgvTypeA);
            this.Name = "TypeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypeManager";
            this.Load += new System.EventHandler(this.TypeManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTypeA;
        private System.Windows.Forms.DataGridView dgvTypeB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TypeAAddBtn;
        private System.Windows.Forms.Button TypeBAddBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comTypeB;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}