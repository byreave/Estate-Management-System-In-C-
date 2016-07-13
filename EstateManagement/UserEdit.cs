using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using DAL;

namespace EstateManagement
{
    public partial class UserEdit : Form
    {
        bool isEdit; //判断是否是编辑模式
        string uid;
        public UserEdit(bool isedit)
        {
            isEdit = isedit;
            InitializeComponent();
        }

        public UserEdit(bool isedit, string u)
        {
            isEdit = isedit;
            uid = u;
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            User usr = new User();
            if(txtName.Text == "")
            {
                MessageBox.Show("输入名字!");
                txtName.Focus();
                return;
            }
            usr.Name = txtName.Text;
            if(txtCareer.Text == "")
            {
                MessageBox.Show("输入职业！");
                txtCareer.Focus();
                return;
            }
            usr.Career = txtCareer.Text;

            usr.Comment = txtComm.Text;

            if(isEdit)
            {
                UserOperation.UserEdit(usr, uid);
                MessageBox.Show("修改成功");
            }
            else
            {
                UserOperation.UserAdd(usr);
                MessageBox.Show("添加成功");
            }
            Close();
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
