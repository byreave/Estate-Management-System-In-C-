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
using BLL;

namespace EstateManagement
{
    public partial class EstateOut : Form
    {
        string estateID;//记录要出租的资产
        string admin; //登陆的管理员的用户名
        public EstateOut(string eid, string ad)
        {
            estateID = eid;
            admin = ad;
            InitializeComponent();
        }

        private void EstateOut_Load(object sender, EventArgs e)
        {
            DataSet dsA = AdminOperation.GetAllAdmin();
            DataSet dsU = UserOperation.GetAllUserName();
            comUser.DataSource = dsU.Tables[0];
            comUser.DisplayMember = dsU.Tables[0].Columns["Name"].ToString();
        }

        private void outBtn_Click(object sender, EventArgs e)
        {
            string odate = outDate.Value.ToShortDateString();
            odate = odate.Replace('/', '-'); //转换为 xxxx-xx-xx 格式

            string user = comUser.Text;
            if(user == "")
            {
                MessageBox.Show("选择一个用户！");
                return;
            }
            string usage = txtUsage.Text;
            string comm = txtComm.Text;

            string result = EstateInfo.CheckEstateOutInfo(user, estateID, odate, usage, comm, admin); //通过BLL获取返回数值
            MessageBox.Show(result);
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
