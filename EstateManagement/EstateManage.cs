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

namespace EstateManagement
{
    public partial class EstateManage : Form
    {
        public EstateManage()
        {
            InitializeComponent();
        }

        private void EstateManage_Load(object sender, EventArgs e)
        {
            //初始化列表
            refreshEstate();
        }
        /// <summary>
        /// 刷新列表
        /// </summary>
        private void refreshEstate()
        {
            DataSet ds = EstateOperation.GetAllEstate();
            dgvEstate.DataSource = ds.Tables[0].DefaultView;
        }

        private void refreshUser()
        {
            DataSet ds = UserOperation.GetAllUser();
            dgvUser.DataSource = ds.Tables[0].DefaultView;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
