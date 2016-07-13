using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace EstateManagement
{
    public partial class ChangePassword : Form
    {
        string admin;
        public ChangePassword(string a)
        {
            admin = a;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldP = txtOldPwd.Text;
            if(oldP == "")
            {
                MessageBox.Show("旧密码不能为空白");
                txtOldPwd.Focus();
                return;
            }
            string newP = txtNewPwd.Text;
            if(newP == "")
            {
                MessageBox.Show("新密码不能为空");
                txtNewPwd.Focus();
                return;
            }
            string conP = txtPwdCon.Text;
            if(conP == "")
            {
                MessageBox.Show("确认密码不能为空");
                txtPwdCon.Focus();
                return;
            }

            switch(AdminInfo.checkChangePwd(admin, newP, oldP, conP))
            {
                case 0:
                    MessageBox.Show("旧密码错误！");
                    break;
                case 1:
                    MessageBox.Show("成功！");
                    break;
                case 2:
                    MessageBox.Show("确认密码不匹配");
                    break;
                default:
                    break;
            }
        }
    }
}
