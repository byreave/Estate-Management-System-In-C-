using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Entity;

namespace EstateManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsrn.Text;
            string password = txtPwd.Text;
            if(username == "")
            {
                MessageBox.Show("Please Enter Username!");
                txtUsrn.Focus();
                return;
            }
            if(password == "")
            {
                MessageBox.Show("Enter Your Password!");
                txtPwd.Focus();
                return;
            }
            Admin a = new Admin();
            a.Username = username;
            a.Password = password;
            if(AdminOperation.Login(a))
            {
                EstateManage em = new EstateManage(a.Username);
                em.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("账户名密码不正确");
            }
        }

    }
}
